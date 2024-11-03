using LabaWebApp.API.Models;

namespace LabaWebApp.API.Repository.Interfaces
{
    public interface IPatientRepository
    {
        Task<Patient> GetPatient(string fullname);
        Task<Patient> GetPatient(Guid guid);
        Task<IEnumerable<Patient>> GetAllPatients();
        Task<Patient> UpdatePatient(Guid id, Patient patient);
        Task<bool> DeletePatient(Guid guid);
        Task<Patient> AddPatient(Patient patient);

    }
}
