using DoctorWho.Db.Persistence.Services;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using DoctorWho.Resources;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Domain.IServices;
using DoctorWho.Extensions;
using FluentValidation;

namespace DoctorWho.Controllers
{
    [Route("/api/[controller]")]
    public class AuthorController : Controller
    {
        private readonly IAuthorServices _authorServices;
        private readonly IMapper _mapper;
        private readonly ILogger<AuthorController> _logger;
        private readonly IValidator<Author> _validator;

        public AuthorController(IAuthorServices authorServices, IMapper mapper, ILogger<AuthorController> logger, IValidator<Author> validator)
        {
            _authorServices = authorServices;
            _mapper = mapper;
            _logger = logger;
            _validator = validator;
        }

        [HttpGet("GetAllAuthors")]
        public IEnumerable<AuthorResource> GetAuthors()
        {
            _logger.LogInformation("This is GetAuthors Controller");
            var authors = _authorServices.GetAllAuthors();
            var result = _mapper.Map<IEnumerable<Author>, IEnumerable<AuthorResource>>(authors);
            return result;
        }
        
        [HttpGet("GetAuthorById")]
        public AuthorResource GetAuthorById(int id)
        {
            var author = _authorServices.GetAuthorById(id);
            var result = _mapper.Map<Author, AuthorResource>(author);
            return result;
        }

        [HttpPost("AddAuthor")]
        public IActionResult AddAuthor([FromBody] AddAuthorResource resource)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var author = _mapper.Map<AddAuthorResource, Author>(resource);
            var resultt = _validator.Validate(author);
            if (!resultt.IsValid)
            {
                return BadRequest(resultt.Errors);
            }
            var result = _authorServices.InsertAuthor(author);

            /*if(!result.Success)
                return BadRequest(result.Message);*/

            var authorResource = _mapper.Map<Author, AuthorResource>(result.Author);

            return Ok(authorResource);
        }

        [HttpPut("UpdateAuthor")]
        public IActionResult UpdateAuthor(int id, [FromBody] AddAuthorResource resource)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var author = _mapper.Map<AddAuthorResource, Author>(resource);
            var result = _authorServices.UpdateAuthor(id, author);

            if (!result.Success)
                return BadRequest(result.Message);

            var authorResource = _mapper.Map<Author, AuthorResource>(result.Author);

            return Ok(authorResource);
        }

        [HttpDelete("DeleteAuthor")]
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
