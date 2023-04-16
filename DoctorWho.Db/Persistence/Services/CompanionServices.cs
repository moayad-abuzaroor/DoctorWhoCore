using DoctorWho.Db.Domain.Functions;
using DoctorWho.Db.Domain.IRepositories;
using DoctorWho.Db.Domain.IServices;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Persistence.Repositories;
using DoctorWho.Db.Persistence.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Persistence.Services
{
    public class CompanionServices : ICompanionServices
    {
        //IGenericRepository<Companion> repoCompanion = new GenericRepository<Companion>();
        //ICompanionRepository repoCompanion2 = new CompanionRepository();
        private readonly IUnitOfWork _unitOfWork;

        public CompanionServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<fnCompanionClass> GetCompanionsByEpisodeId(int episodeId)
        {            
            return _unitOfWork.CompanionRepository2.companionFunctionClass(episodeId);
        }

        public CompanionResponse DeleteCompanion(int id)
        {
            var existingCompanion = _unitOfWork.CompanionRepository.GetById(id);
            if (existingCompanion == null)
                return new CompanionResponse("Companion not found");

            try
            {
                _unitOfWork.CompanionRepository.Delete(id);
                _unitOfWork.Complete();

                return new CompanionResponse(existingCompanion);
            }
            catch(Exception ex) 
            {
                return new CompanionResponse($"An error occurred when deleting companion: {ex.Message}");
            }
            
        }

        public IEnumerable<Companion> GetAllCompanions()
        {
            return _unitOfWork.CompanionRepository.GetAll();
        }

        public Companion GetCompanionById(int id)
        {
            return _unitOfWork.CompanionRepository.GetById(id);
        }

        public CompanionResponse InsertCompanion(Companion companion)
        {
            try
            {
                _unitOfWork.CompanionRepository.Insert(companion);
                _unitOfWork.Complete();

                return new CompanionResponse(companion);
            }
            catch(Exception ex)
            {
                return new CompanionResponse($"An error occurred when adding companion: {ex.Message}");
            }
        }

        public CompanionResponse UpdateCompanion(int id, Companion companion)
        {
            var existingCompanion = _unitOfWork.CompanionRepository.GetById(id);
            if (existingCompanion == null)
                return new CompanionResponse("Companion not found");

            existingCompanion.CompanionName = companion.CompanionName;
            existingCompanion.WhoPlayed = companion.WhoPlayed;

            try
            {
                _unitOfWork.CompanionRepository.Update(existingCompanion);
                _unitOfWork.Complete();

                return new CompanionResponse(companion);
            }
            catch (Exception ex)
            {
                return new CompanionResponse($"An error occurred when updating companion: {ex.Message}");
            }
        }
    }
}
