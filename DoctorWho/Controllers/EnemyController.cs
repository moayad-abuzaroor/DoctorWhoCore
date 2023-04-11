using AutoMapper;
using DoctorWho.Db.Domain.IServices;
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
    }
}
