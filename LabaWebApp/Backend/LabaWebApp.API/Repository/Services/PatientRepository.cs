using LabaWebApp.API.dbContext;
using LabaWebApp.API.Models;
using LabaWebApp.API.Repository.Interfaces;
using System;
using Microsoft.EntityFrameworkCore;

namespace LabaWebApp.API.Repository.Services
{
    public class PatientRepository : IPatientRepository
    {
        private readonly PatientsDbContext _dbContext;
        public PatientRepository(PatientsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Patient> AddPatient(Patient patient)
        {
            var result = await _dbContext.Patients.AddAsync(patient);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<bool> DeletePatient(Guid guid)
        {
            var patientToDelete = await _dbContext.Patients.FirstOrDefaultAsync(e => e.Guid == guid);
            if (patientToDelete != null)
            {
                _dbContext.Patients.Remove(patientToDelete);
                await _dbContext.SaveChangesAsync();
                return true; 
            }
            return false; 
        }

        public async  Task<IEnumerable<Patient>> GetAllPatients()
        {
            return await _dbContext.Patients.ToListAsync();
        }

        public async Task<Patient> GetPatient(string fullname)
        {
            return await _dbContext.Patients
                .FirstOrDefaultAsync(e => e.Fullname == fullname);
        }

        public async Task<Patient> GetPatient(Guid guid)
        {
            return await _dbContext.Patients
                .FirstOrDefaultAsync(e => e.Guid == guid);
        }

        public async Task<Patient> UpdatePatient(Guid id, Patient updatedPatient)
        {
            var existingPatient = await _dbContext.Patients.FirstOrDefaultAsync(p => p.Guid == id);
            if (existingPatient == null)
            {
                return null; 
            }
            if (!string.IsNullOrEmpty(updatedPatient.Fullname) && existingPatient.Fullname != updatedPatient.Fullname)
            {
                existingPatient.Fullname = updatedPatient.Fullname;
            }
            if (updatedPatient.Gender.HasValue && existingPatient.Gender != updatedPatient.Gender)
            {
                existingPatient.Gender = updatedPatient.Gender;
            }
            if (updatedPatient.Birthday.HasValue && existingPatient.Birthday != updatedPatient.Birthday.Value)
            {
                existingPatient.Birthday = updatedPatient.Birthday.Value;
            }
            await _dbContext.SaveChangesAsync();
            return existingPatient;
        }
    }
}
