using AutoMapper;
using DoctorWho.Db.Domain.IServices;
using DoctorWho.Db.Domain.Models;
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
    }
}
