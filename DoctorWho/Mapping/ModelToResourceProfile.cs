using AutoMapper;
using DoctorWho.Db.Domain.Functions;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Domain.Views;
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
            CreateMap<Enemy, EnemyResource>();
            CreateMap<fnEnemiesClass, EnemyFunctionResource>();
            CreateMap<Episode, EpisodeResource>();
            CreateMap<viewEpisodes, ViewEpisodeResource>();
        }
    }
}
