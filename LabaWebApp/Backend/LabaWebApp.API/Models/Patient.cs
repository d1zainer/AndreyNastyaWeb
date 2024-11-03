using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace LabaWebApp.API.Models
{
    public class Patient
    {
        [SwaggerSchema(ReadOnly = true)]
        [Key]
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string Fullname { get; set; } = string.Empty;
        public int? Gender { get; set; }
        public DateTime? Birthday { get; set; }

    }
}
