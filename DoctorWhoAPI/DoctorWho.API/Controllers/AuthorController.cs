using AutoMapper;
using DoctorWho.API.Models;
using DoctorWhoData.Repos;
using DoctorWhoDomain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepo _authorRepo;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorRepo authorRepo, IMapper mapper)
        {
            _authorRepo = authorRepo;
            _mapper = mapper;
        }
        [HttpPut]
        public async Task<ActionResult<AuthorDto>> Update(AuthorDto author)
        {
            var newauthor = await _authorRepo.UpdateAsync(_mapper.Map<Author>(author));
            if(newauthor == null) {
                return NotFound();
            }
            return Ok(newauthor);
        }
    }
}
