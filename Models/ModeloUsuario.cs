using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HackProElite.Models
{
    public class ModeloUsuario
    {
        [Required(ErrorMessage = "Usuario Requerido")]
        public string userName { get; set; }
        
        [Required(ErrorMessage = "Correo Requerido")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "No Es un correo Valido")]
        public string correoElec { get; set; }

        [Required(ErrorMessage = "Nombre Requerido")]
        public string priNombre { get; set; }

        [Required(ErrorMessage = "Nombre Requerido")]
        public string segNombre { get; set; }

        [Required(ErrorMessage = "Apellido Requerido")]
        public string priApellido { get; set; }

        [Required(ErrorMessage = "Apellido Requerido")]
        public string segApellido { get; set; }

        [Required(ErrorMessage = "Contraseña Requerida")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = "Contraseña Requerida")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string confirmarPass { get; set; }

        [Required(ErrorMessage = "Fecha Requerida")]
        public DateTime fechaNac { get; set; }

        [Required(ErrorMessage = "Celular Requerido")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Solo se puede ingresar numeros")]
        public string numCelular { get; set; }

        [StringLength(1)]
        [Required(ErrorMessage = "Genero Requerido")]
        public string genero { get; set; }

        [Required(ErrorMessage = "Ocupacion Requerida")]
        public string ocupacion { get; set; }
    }
}