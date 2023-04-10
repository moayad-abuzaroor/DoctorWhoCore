using AutoMapper;
using DoctorWho.Db.Domain.IServices;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Persistence.Services.Communication;
using DoctorWho.Extensions;
using DoctorWho.Resources;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Controllers
{
    [Route("/api/[controller]")]
    public class DoctorController : Controller
    {
        private readonly IDoctorServices _doctorServices;
        private readonly IMapper _mapper;
        public DoctorController(IDoctorServices doctorServices, IMapper mapper)
        {
            _doctorServices = doctorServices;
            _mapper = mapper;
        }

        [HttpGet("GetAllDoctors")]
        public IEnumerable<DoctorResource> GetDoctors()
        {
            var doctors = _doctorServices.GetAllDoctors();
            var result = _mapper.Map<IEnumerable<Doctor>, IEnumerable<DoctorResource>>(doctors);
            return result;
        }

        [HttpGet("GetDoctorById")]
        public DoctorResource GetDoctorById(int id)
        {
            var doctor = _doctorServices.GetDoctorById(id);
            var result = _mapper.Map<Doctor, DoctorResource>(doctor);
            return result;
        }

        [HttpPost("AddDoctor")]
        public IActionResult AddDoctor([FromBody] AddDoctorResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages);

            var doctor = _mapper.Map<AddDoctorResource, Doctor>(resource);
            var result = _doctorServices.InsertDoctor(doctor);

            if (!result.Success)
                return BadRequest(result.Message);

            var doctorResource = _mapper.Map<Doctor, DoctorResource>(result.Doctor);

            return Ok(doctorResource);
        }
    }
}
