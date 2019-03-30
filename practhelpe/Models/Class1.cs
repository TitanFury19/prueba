using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace practhelpe.Models
{
    public class Class1
    {
        [Required(ErrorMessage = "Campo obligatorio")]
        public string cedula{ get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string apellido { get; set; }

        [Range(15,70,ErrorMessage ="mayor de 15 y menor de 70")]
        public int edad { get; set; }

        public string telefono { get; set; }

        [EmailAddress(ErrorMessage ="formato de correo invalido")]
        public string  correo { get; set; }

        public string  genero { get; set; }

       
        public string estadoc { get; set; }
        public String hobbys { get; set; }
    }
 
}