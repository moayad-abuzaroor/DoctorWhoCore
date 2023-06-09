﻿using AutoMapper;
using DoctorWho.Db.Domain.Functions;
using DoctorWho.Db.Domain.IServices;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Extensions;
using DoctorWho.Resources;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Controllers
{
    [Route("/api/[controller]")]
    public class CompanionController : Controller
    {
        private readonly ICompanionServices _companionServices;
        private readonly IMapper _mapper;

        public CompanionController(ICompanionServices companionServices, IMapper mapper)
        {
            _companionServices = companionServices;
            _mapper = mapper;
        }

        [HttpGet("GetAllCompanions")]
        public IEnumerable<CompanionResource> GetCompanions()
        {
            var companions = _companionServices.GetAllCompanions();
            var result = _mapper.Map<IEnumerable<Companion>, IEnumerable<CompanionResource>>(companions);
            return result;
        }

        [HttpGet("GetCompanionById")]
        public CompanionResource GetCompanionById(int id)
        {
            var companion = _companionServices.GetCompanionById(id);
            var result = _mapper.Map<Companion, CompanionResource>(companion);
            return result;
        }

        [HttpGet("GetCompanionByEpisodeId")]
        public List<CompanionFunctionResource> GetCompanionByEpisodeId(int episodeId)
        {
            var companion = _companionServices.GetCompanionsByEpisodeId(episodeId);
            var result = _mapper.Map<List<fnCompanionClass>, List<CompanionFunctionResource>>(companion);
            return result;
        }

        [HttpPost("AddCompanion")]
        public IActionResult AddCompanion([FromBody] AddCompanionResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages);

            var companion = _mapper.Map<AddCompanionResource, Companion>(resource);
            var result = _companionServices.InsertCompanion(companion);

            if(!result.Success)
                return BadRequest(result.Message);

            var companionResource = _mapper.Map<Companion, CompanionResource>(result.Companion);

            return Ok(companionResource);
        }

        [HttpPut("UpdateCompanion")]
        public IActionResult UpdateCompanion(int id, [FromBody] AddCompanionResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages);

            var companion = _mapper.Map<AddCompanionResource, Companion>(resource);
            var result = _companionServices.UpdateCompanion(id, companion);

            if (!result.Success)
                return BadRequest(result.Message);

            var companionResource = _mapper.Map<Companion, CompanionResource>(result.Companion);

            return Ok(companionResource);
        }

        [HttpDelete("DeleteCompanion")]
        public IActionResult DeleteCompanion(int id)
        {
            var result = _companionServices.DeleteCompanion(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var companionResource = _mapper.Map<Companion, CompanionResource>(result.Companion);

            return Ok(companionResource);
        }
    }
}
