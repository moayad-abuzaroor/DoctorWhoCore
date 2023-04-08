using DoctorWho.Db.Persistence.Services;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using DoctorWho.Resources;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Domain.IServices;

namespace DoctorWho.Controllers
{
    [Route("/api/[controller]")]
    public class AuthorController : Controller
    {
        private readonly IAuthorServices _authorServices;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorServices authorServices, IMapper mapper)
        {
            _authorServices = authorServices;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<AuthorResource> GetAuthors()
        {
            var authors = _authorServices.GetAllAuthors();
            var result = _mapper.Map<IEnumerable<Author>, IEnumerable<AuthorResource>>(authors);
            return result;
        }

        [HttpPost]
        public IActionResult AddAuthor([FromBody] AddAuthorResource resource)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            var author = _mapper.Map<AddAuthorResource, Author>(resource);
            _authorServices.InsertAuthor(author);


            return Ok(author);
        }
    }
}
