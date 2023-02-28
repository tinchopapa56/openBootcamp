using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace openBootcamp.Models
{
    public class Curso : BaseEntity
    {
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(18, MinimumLength = 3,
        ErrorMessage = "Last Name should be minimum 3 characters and a maximum of 50 characters")]
        public string Name { get; set; } //maximo
        [Required, StringLength(280)]
        public string DescriptionS { get; set; } //maximo 280
        public string DescriptionL { get; set; } //maximo
        public string Publico { get; set; } //maximo
        public string Requisitos { get; set; } //maximo
        public string Nivel { get; set; } //TUPLE
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Telefono { get; set; }
    }
}
