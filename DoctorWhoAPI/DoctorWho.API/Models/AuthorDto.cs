namespace DoctorWho.API.Models
{
    public class AuthorDto
    {
        public AuthorDto()
        {
            Episodes = new List<EpisodeDto>();
        }
        public int AuthorId { set; get; }
        public string Name { set; get; }

        public IList<EpisodeDto> Episodes;
    }
}

