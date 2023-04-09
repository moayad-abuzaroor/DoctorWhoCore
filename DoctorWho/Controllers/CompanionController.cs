using AutoMapper;
using DoctorWho.Db.Domain.IServices;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Resources;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Controllers
{
    [Route("/api/[controller]")]
    public class CompanionController : Controller
    {
        private readonly ICompanionServices _companionServices;
        private readonly IMapper _mapper;

        public CompanionController(ICompanionServices companionServices, IMapper mapper)
        {
            _companionServices = companionServices;
            _mapper = mapper;
        }

        [HttpGet("GetAllCompanions")]
        public IEnumerable<CompanionResource> GetCompanions()
        {
            var companions = _companionServices.GetAllCompanions();
            var result = _mapper.Map<IEnumerable<Companion>, IEnumerable<CompanionResource>>(companions);
            return result;
        }
    }
}
