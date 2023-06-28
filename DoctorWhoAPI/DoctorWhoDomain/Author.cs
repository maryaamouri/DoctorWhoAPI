namespace DoctorWhoDomain
{
    public class Author
    {
        public Author() {
            Episodes = new List<Episode>();
        }
        public int AuthorId { set; get; }
        public string Name { set; get; }
        
        public IList<Episode> Episodes;
    }
}