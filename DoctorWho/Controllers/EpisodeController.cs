using AutoMapper;
using DoctorWho.Db.Domain.IServices;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Controllers
{
    [Route("/api/[controller]")]
    public class EpisodeController : Controller
    {
        private readonly IEpisodeServices _episodeServices;
        private readonly IMapper _mapper;
        public EpisodeController(IEpisodeServices episodeServices, IMapper mapper)
        {
            _episodeServices = episodeServices;
            _mapper = mapper;
        }
    }
}
