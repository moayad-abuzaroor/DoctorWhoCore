using AutoMapper;
using DoctorWho.Db.Domain.Functions;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Resources;

namespace DoctorWho.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile() 
        {
            CreateMap<Author, AuthorResource>();
            CreateMap<Companion, CompanionResource>();
            CreateMap<fnCompanionClass, CompanionFunctionResource>();
            CreateMap<Doctor, DoctorResource>();
        }
    }
}
