using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain
{
    public class Doctor
    {
        public Doctor() {
         Episodes = new List<Episode>();
        }
        public int DoctorId { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime FirstEpisodeDate { get; set; }
        public DateTime LastEpisodeDate { get; set; }
        public IList<Episode> Episodes;
    }
}