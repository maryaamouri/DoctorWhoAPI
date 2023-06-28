namespace DoctorWho.API.Models
{
    public class EnemyDto
    {
        public EnemyDto()
        {
            Episodes = new List<EpisodeDto>();
        }
        public int EnemyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<EpisodeDto> Episodes;
    }
}
}
