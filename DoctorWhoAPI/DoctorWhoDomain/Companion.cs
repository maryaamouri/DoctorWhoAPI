using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain
{
    public class Companion
    {
        public Companion() {
            Episodes = new List<Episode>();
        }
        public int CompanionId { set; get; }
        public string Name { set; get;}
        public string WhoPlayed { set; get;}
        public IList<Episode> Episodes;
    }
}
