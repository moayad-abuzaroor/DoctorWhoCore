using DoctorWho.Db.Domain.IRepositories;
using DoctorWho.Db.Domain.IServices;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Persistence.Repositories;
using DoctorWho.Db.Persistence.Services.Communication;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Persistence.Services
{
    public class AuthorServices : IAuthorServices
    {
        IGenericRepository<Author> repoAuthor = new Repositories.GenericRepository<Author>();
        private readonly IValidator<Author> _validator;
        public AuthorServices(IValidator<Author> validator)
        {
            _validator = validator;
        }
        public IEnumerable<Author> GetAllAuthors()
        {
            return repoAuthor.GetAll();
        }

        public Author GetAuthorById(int id)
        {
            return repoAuthor.GetById(id);
        }

        public AuthorResponse InsertAuthor(Author author)
        {
            var validationResult = _validator.Validate(author);
            
            try
            {
                repoAuthor.Insert(author);
                repoAuthor.Save();

                return new AuthorResponse(author);
            }
            catch(Exception ex)
            {
                return new AuthorResponse($"An error occurred when adding new author: {ex.Message}");
            }
            
        }

        public AuthorResponse UpdateAuthor(int id, Author author)
        {
            var existingAuthor = repoAuthor.GetById(id);
            if (existingAuthor == null)
                return new AuthorResponse("Author not found");

            existingAuthor.AuthorName = author.AuthorName;

            try
            {
                repoAuthor.Update(existingAuthor);
                repoAuthor.Save();

                return new AuthorResponse(author);
            }
            catch( Exception ex )
            {
                return new AuthorResponse($"An error occurred when updating Author: {ex.Message}");
            }
            
        }

        public AuthorResponse DeleteAuthor(int id)
        {
            var existingAuthor = repoAuthor.GetById(id);
            if (existingAuthor == null)
                return new AuthorResponse("Author not found");

            try
            {
                repoAuthor.Delete(id);
                repoAuthor.Save();

                return new AuthorResponse(existingAuthor);
            }
            catch(Exception ex)
            {
                return new AuthorResponse($"An error occurred when deleting Author: {ex.Message}");
            }
            
        }
    }
}
