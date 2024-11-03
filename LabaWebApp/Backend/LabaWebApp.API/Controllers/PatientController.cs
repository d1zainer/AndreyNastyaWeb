using LabaWebApp.API.Models;
using LabaWebApp.API.Repository.Interfaces;
using LabaWebApp.API.Repository.Services;
using Microsoft.AspNetCore.Mvc;


namespace WebApp.Contrloller
{

    [Route("api/MyApp")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepository _patientRepository;

        public PatientController(IPatientRepository patientService)
        {
            _patientRepository = patientService;

        }

        #region GET
        [HttpGet("GetAllPatient")]
        public async Task<ActionResult> GetPatients()
        {
            try
            {
                return Ok(await _patientRepository.GetAllPatients());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<Patient>> GetPatient(Guid id)
        {
            try
            {
                var result = await _patientRepository.GetPatient(id);
                if (result == null) return NotFound();
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{fullname}")]
        public async Task<ActionResult<Patient>> GetPatient(string fullname)
        {
            try
            {
                var result = await _patientRepository.GetPatient(fullname);
                if (result == null) return NotFound();
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        #endregion

        #region POST
        [HttpPost("CreatePatient")] 
        public async Task<ActionResult<Patient>> GetPatientByName([FromBody] Patient patient)
        {
            try
            {
                var result = await _patientRepository.AddPatient(patient);
                if (result == null) return NotFound();
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        #endregion
        #region PUT

        [HttpPut("UpdatePatient")] 
        public async Task<ActionResult<Patient>> UpdatePatientById(Guid id, [FromBody]Patient patient)
        {
            try
            {
                var patientToUpdate = await _patientRepository.GetPatient(id);
                if (patientToUpdate == null)
                    return NotFound($"Patient with Id = {id} not found");
                
                // Обновляем данные пациента
                var updatedPatient = await _patientRepository.UpdatePatient(id, patient);
                return updatedPatient;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }

        #endregion

        #region DELETE
        [HttpDelete("DeletePatient")] //api/MyApp/GetByName
        public async Task<ActionResult<bool>> DeletePatientByGUID(Guid id)
        {
            try
            {
                var result = await _patientRepository.DeletePatient(id);
                if (result == null) return NotFound();
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        #endregion

    }
}
