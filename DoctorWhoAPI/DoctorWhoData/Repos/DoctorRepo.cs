using DoctorWhoDomain;
using DoctorWhoDomain.Repos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoData.Repos
{
    public class DoctorRepo : IRepo<Doctor>
    {
        private readonly DoctorWhoDBContext _context;

        public DoctorRepo(DoctorWhoDBContext context)
        {
            this._context = context;
        }

        public async Task CreateAsync(Doctor doctor)
        {
            var doctors =  _context.Doctors;
            doctors.Add(doctor);
            await SaveChangesAsync();
        }

        public async Task DeleteAsync(int doctorId)
        {
            var doctor = _context.Doctors.Where(e=>e.DoctorId.Equals(doctorId)).FirstOrDefault();
            var doctors = _context.Doctors;
            if(doctor!=null) 
                doctors.Remove(doctor);
            await SaveChangesAsync();
        }

        public async Task<IList<Doctor>> GetAllAsync()
        {
            var doctors = _context.Doctors.ToList();
            await SaveChangesAsync();
            return doctors;
            
        }

        public async  Task<Doctor> GetByIdAsync(int doctorId)
        {
            var doctor = _context.Doctors.
                Where(e => e.DoctorId.Equals(doctorId))
                .FirstOrDefault();

            await SaveChangesAsync();
            return doctor;
        }

        public async Task UpdateAsync(int doctorId, Doctor? doctor= null)
        {
            var oldVal = _context.Doctors.Where(
              e => e.DoctorId.Equals(doctorId)).FirstOrDefault();
            if(oldVal!=null)
                doctor = oldVal;
            await SaveChangesAsync();
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()>=0);  
        }
    }
}
