using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentRegistration.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="El nombre es un campo obligatorio")]
        [Display(Name ="Nombre")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El apellido es un campo obligatorio")]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "El estatus es un campo obligatorio")]
        [Display(Name = "Estatus")]
        public bool Status { get; set; }
        [Required(ErrorMessage = "La carrera es un campo obligatorio")]
        [Display(Name = "Carrera")]
        public string Career { get; set; }
    }
}
