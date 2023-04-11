using AutoMapper;
using DoctorWho.Db.Domain.IServices;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Resources;
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

        [HttpGet("GetAllEpisodes")]
        public IEnumerable<EpisodeResource> GetEpisodes()
        {
            var episodes = _episodeServices.GetAllEpisodes();
            var result = _mapper.Map<IEnumerable<Episode>, IEnumerable<EpisodeResource>>(episodes);
            return result;
        }

        [HttpGet("GetEpisodeById")]
        public EpisodeResource GetEpisodeById(int id)
        {
            var episode = _episodeServices.GetEpisodeById(id);
            var result = _mapper.Map<Episode, EpisodeResource>(episode);
            return result;
        }
    }
}
