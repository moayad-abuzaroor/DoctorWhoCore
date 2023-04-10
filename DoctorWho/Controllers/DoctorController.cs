using AutoMapper;
using DoctorWho.Db.Domain.IServices;
using DoctorWho.Db.Domain.Models;
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
    }
}
