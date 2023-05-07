using DoctorWho.Db.Domain.Models;
using DoctorWho.Resources;
using FluentValidation;

namespace DoctorWho.Validations
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator() 
        {
            RuleFor(author => author.AuthorName).NotEmpty().NotNull().Length(3,70);
        }
    }
}
