using AutoMapper;
using DoctorWho.API.Models;
using DoctorWhoData.Repos;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorRepo _doctorRepo;
        private readonly IMapper _mapper;

        public DoctorsController(IDoctorRepo doctorRepo, IMapper mapper)
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

    }
}
