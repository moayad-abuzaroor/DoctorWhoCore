using DoctorWho.Db.Persistence.Services;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using DoctorWho.Resources;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Domain.IServices;
using DoctorWho.Extensions;

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
        
        [HttpGet("{id}")]
        public AuthorResource GetAuthorById(int id)
        {
            var author = _authorServices.GetAuthorById(id);
            var result = _mapper.Map<Author, AuthorResource>(author);
            return result;
        }

        [HttpPost]
        public IActionResult AddAuthor([FromBody] AddAuthorResource resource)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages);
            }

            var author = _mapper.Map<AddAuthorResource, Author>(resource);
            var result = _authorServices.InsertAuthor(author);

            if(!result.Success)
                return BadRequest(result.Message);

            var authorResource = _mapper.Map<Author, AuthorResource>(result.Author);

            return Ok(authorResource);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAuthor(int id, [FromBody] AddAuthorResource resource)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages);
            }
            var author = _mapper.Map<AddAuthorResource, Author>(resource);
            var result = _authorServices.UpdateAuthor(id, author);

            if (!result.Success)
                return BadRequest(result.Message);

            var authorResource = _mapper.Map<Author, AuthorResource>(result.Author);

            return Ok(authorResource);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(int id)
        {
            var result = _authorServices.DeleteAuthor(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var authorResource = _mapper.Map<Author, AuthorResource>(result.Author);

            return Ok(authorResource);
        }
    }
}
