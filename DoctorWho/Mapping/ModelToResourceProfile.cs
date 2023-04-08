using AutoMapper;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Resources;

namespace DoctorWho.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile() 
        {
            CreateMap<Author, AuthorResource>();
        }
    }
}
