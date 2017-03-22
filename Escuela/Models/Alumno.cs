using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Escuela.Models
{
    [Table("Alumnos")]
    public class Alumno
    {
        [Key]
        public int pkAlumno { get; set; }
        [Required(ErrorMessage ="Campo requerido")]
        public string sNombre { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string sApellido { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string sGrupo { get; set; }
        public string sImagen { get; set; }
        public Boolean bStauts { get; set; }
    }
}