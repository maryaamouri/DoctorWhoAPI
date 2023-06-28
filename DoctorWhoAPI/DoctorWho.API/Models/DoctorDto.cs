namespace DoctorWho.API.Models
{
    public class DoctorDto
    {
        public int DoctorId { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime FirstEpisodeDate { get; set; }
        public DateTime LastEpisodeDate { get; set; }

    }
}
