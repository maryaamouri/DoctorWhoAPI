namespace DoctorWho.API.Models
{
    public class EpisodeDto
    {
        public EpisodeDto()
        {
            Companions = new List<CompanionDto>();
            Enemies = new List<EnemyDto>();
        }
        public int EpisodeId { get; set; }
        public int SeriesNumber { get; set; }
        public int Number { get; set; }
        public string Type { get; set; }
        public string Title { set; get; }
        public DateTime EpisodeDate { set; get; }
        public int AuthorId { set; get; }
        public int DoctorId { set; get; }
        public DoctorDto doctor { set; get; }
        public AuthorDto author { set; get; }
        public string Notes { set; get; }
        public IList<CompanionDto> Companions;
        public IList<EnemyDto> Enemies;

    }
}
