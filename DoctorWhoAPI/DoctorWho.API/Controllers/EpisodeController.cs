using AutoMapper;
using DoctorWho.API.Models;
using DoctorWhoData.Repos;
using DoctorWhoDomain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpisodeController : ControllerBase
    {
        private readonly IEpisodeRepo _episodeRepo;
        private readonly IMapper _mapper;

        public EpisodeController(IEpisodeRepo episodeRepo, IMapper mapper)
        {
            _episodeRepo = episodeRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<EpisodeDto>> Get() { 
            var episodes = await _episodeRepo.GetAllAsync();
            if(episodes.Count == 0) 
                return Ok("no episodes found");
             
            return Ok(_mapper.Map<EpisodeDto>(episodes));
        }
        [HttpPost]
        public async Task<ActionResult<int>> Create(EpisodeDto episode)
        {
            if (episode == null)
                return BadRequest();
            var episodecreated = await _episodeRepo
                                        .CreateAsync(_mapper.Map<Episode>(episode));
            return Ok(episodecreated);
        }
        public async Task<ActionResult<Episode>> AddEnemyToEpisode(int episodeId, EnemyDto enemy)
        {
            if (episodeId == null)
                return BadRequest("Episode is required");
            if (enemy == null)
                return BadRequest();
            var episode = await _episodeRepo.AddEnemyToEpisodeAsync(episodeId, _mapper.Map <Enemy> (enemy));
            if (episode is not null)
                return NotFound("Episode not found");
            if (episode.Enemies.FirstOrDefault(e => e.EnemyId == enemy.EnemyId) is null)
            {
                return BadRequest();
            }

            return Ok(episode);
        }
        public async Task<ActionResult<Episode>> AddCompanionToEpisode(int episodeId, CompanionDto companion)
        {
            if (episodeId == null)
                return BadRequest("Episode is required");
            if (companion == null)
                return BadRequest("Companion is requires");
            var episode = await _episodeRepo.AddCompanionToEpisodeAsync(episodeId,_mapper.Map<Companion>(companion));
            if (episode == null)
                return NotFound("Episode not found");
            if (episode.Companions.FirstOrDefault(c => c.CompanionId == companion.CompanionId) is null)
                return BadRequest("");
            return Ok(episode);
        }
    }
}
