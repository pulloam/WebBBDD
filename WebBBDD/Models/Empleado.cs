using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBBDD.Models {
    public class Empleado {
  
        [Display(Name = "ID")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Debe ingresar id")]
        public int NumeroEmpleado { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe ingresar nombre")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Al  menos 3 caracteres")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido Paterno")]
        public string Apellido { get; set; }

        [Display(Name = "Edad")]
        [Range(18, 100, ErrorMessage = "Debe ser  mayor de edad")]
        public int Edad { get; set; }

        [Display(Name = "¿Contratado?")]
        public bool Contratado { get; set; }

        [Display(Name = "Clave")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        public Empleado(int id, string nombre, string apellido) {
            NumeroEmpleado = id;
            Nombre = nombre;
            Apellido = apellido;
        }

    }
}