using AutoMapper;
using DoctorWho.Db.Domain.IServices;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Domain.Views;
using DoctorWho.Extensions;
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

        [HttpGet("ViewEpisodes")]
        public IEnumerable<ViewEpisodeResource> ViewEpisodes()
        {
            var episodes = _episodeServices.viewEpisodes();
            var result = _mapper.Map<IEnumerable<viewEpisodes>, IEnumerable<ViewEpisodeResource>>(episodes);
            return result;
        }

        [HttpPost("AddEpisode")]
        public IActionResult AddEpisode([FromBody] AddEpisodeResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages);

            var episode = _mapper.Map<AddEpisodeResource, Episode>(resource);
            var result = _episodeServices.InsertEpisode(episode);

            if (!result.Success)
                return BadRequest(result.Message);

            var episodeResource = _mapper.Map<Episode, EpisodeResource>(result.Episode);

            return Ok(episodeResource);
        }

        [HttpPost("AddEnemyToEpisode")]
        public IActionResult AddEnemyToEpisode(int enemyId, int episodeId)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages);
            
            var result = _episodeServices.AddEnemyToEpisode(enemyId, episodeId);

            if (!result.Success)
                return BadRequest(result.Message);

            var episodeResource = _mapper.Map<Episode, EpisodeResource>(result.Episode);

            return Ok(episodeResource);
        }

        [HttpPost("AddCompanionToEpisode")]
        public IActionResult AddCompanionToEpisode(int companionId, int episodeId)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages);

            var result = _episodeServices.AddCompanionToEpisode(companionId, episodeId);

            if (!result.Success)
                return BadRequest(result.Message);

            var episodeResource = _mapper.Map<Episode, EpisodeResource>(result.Episode);

            return Ok(episodeResource);
        }

        [HttpPut("UpdateEpisode")]
        public IActionResult UpdateEpisode(int id, [FromBody] AddEpisodeResource resource)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages);

            var episode = _mapper.Map<AddEpisodeResource, Episode>(resource);
            var result = _episodeServices.UpdateEpisode(id, episode);

            if (!result.Success)
                return BadRequest(result.Message);

            var episodeResource = _mapper.Map<Episode, EpisodeResource>(result.Episode);

            return Ok(episodeResource);

        }
    }
}
