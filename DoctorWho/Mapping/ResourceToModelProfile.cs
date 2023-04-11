using AutoMapper;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Resources;

namespace DoctorWho.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<AddAuthorResource, Author>();
            CreateMap<AddCompanionResource, Companion>();
            CreateMap<AddDoctorResource, Doctor>();
            CreateMap<AddEnemyResource, Enemy>();
            CreateMap<AddEpisodeResource, Episode>();
        }
    }
}
