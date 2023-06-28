using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain
{
    public class Episode
    {
        public Episode() {
        Companions = new List<Companion>();
        Enemies = new List<Enemy>();
        }
        public int EpisodeId { get; set; }
        public int SeriesNumber { get; set; }
        public int Number { get; set; }
        public string Type  { get; set; }
        public string Title { set; get; }
        public DateTime EpisodeDate { set; get; }
        public int AuthorId { set; get; }
        public int DoctorId { set;get; }
        public Doctor doctor { set; get; }
        public Author author { set; get; }  
        public string Notes { set;get; }
        public IList<Companion> Companions;
        public IList<Enemy> Enemies;
        
    }
}
