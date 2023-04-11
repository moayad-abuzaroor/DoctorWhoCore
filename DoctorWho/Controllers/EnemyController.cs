using AutoMapper;
using DoctorWho.Db.Domain.Functions;
using DoctorWho.Db.Domain.IServices;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Extensions;
using DoctorWho.Resources;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Controllers
{
    [Route("/api/[controller]")]
    public class EnemyController : Controller
    {
        private readonly IEnemyServices _enemyServices;
        private readonly IMapper _mapper;

        public EnemyController(IEnemyServices enemyServices, IMapper mapper)
        {
            _enemyServices = enemyServices;
            _mapper = mapper;
        }

        [HttpGet("GetAllEnemies")]
        public IEnumerable<EnemyResource> GetEnemies()
        {
            var enemies = _enemyServices.GetAllEnemies();
            var result = _mapper.Map<IEnumerable<Enemy>, IEnumerable<EnemyResource>>(enemies);
            return result;
        }

        [HttpGet("GetEnemyById")]
        public EnemyResource GetEnemyById(int id)
        {
            var enemy = _enemyServices.GetEnemyById(id);
            var result = _mapper.Map<Enemy, EnemyResource>(enemy);
            return result;
        }

        [HttpGet("GetEnemiesByEpisodeId")]
        public List<EnemyFunctionResource> GetEnemiesByEpisodeId(int episodeId)
        {
            var enemies = _enemyServices.GetEnemiesByEpisodeId(episodeId);
            var result = _mapper.Map<List<fnEnemiesClass>, List<EnemyFunctionResource>>(enemies);
            return result;
        }

        [HttpPost("AddEnemy")]
        public IActionResult AddEnemy([FromBody] AddEnemyResource resource)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages);

            var enemy = _mapper.Map<AddEnemyResource, Enemy>(resource);
            var result = _enemyServices.InsertEnemy(enemy);

            if (!result.Success)
                return BadRequest(result.Message);

            var enemyResource = _mapper.Map<Enemy, EnemyResource>(result.Enemy);

            return Ok(enemyResource);
        }
    }
}
