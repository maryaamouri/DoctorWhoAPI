using AutoMapper;
using DoctorWho.API.Models;
using DoctorWhoData.Repos;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepo _doctorRepo;
        private readonly IMapper _mapper;

        public DoctorController(IDoctorRepo doctorRepo, IMapper mapper)
        {
            _doctorRepo = doctorRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<DoctorDto>> Get()
        {
           var doctors = await _doctorRepo.GetAllAsync();
            if (doctors == null)
                return NotFound();
            return Ok(_mapper.Map<IList<DoctorDto>>(doctors));
        }
        [HttpDelete("delete/{doctorId}")]
        public async Task<ActionResult> Delete(int doctorId)
        {
            if (doctorId == 0) 
                return NotFound();
            var doctor = await _doctorRepo.GetByIdAsync(doctorId);
            if(doctor == null)
                return NotFound();
            await _doctorRepo.DeleteAsync(doctorId);
            return Ok($"doctor {doctor.Name} with id {doctorId} is deleted.");
        }

    }
}
