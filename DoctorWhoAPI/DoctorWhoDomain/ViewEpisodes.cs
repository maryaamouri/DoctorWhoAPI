using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain
{
    public class ViewEpisode
    {
        public Episode Episode { get; set; }
        public string? Authors{ get; set; }
        public string? Doctors { get;set; }
        public string? Enemies { get; set; }    
    
    }
}
