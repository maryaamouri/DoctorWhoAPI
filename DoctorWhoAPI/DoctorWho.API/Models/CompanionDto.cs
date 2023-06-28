namespace DoctorWho.API.Models
{

        public class CompanionDto
        {
            public CompanionDto()
            {
                Episodes = new List<EpisodeDto>();
            }
            public int CompanionId { set; get; }
            public string Name { set; get; }
            public string WhoPlayed { set; get; }
            public IList<EpisodeDto> Episodes;
        }
    }

