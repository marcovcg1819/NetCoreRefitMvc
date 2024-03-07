using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace reqrestRefitRazorA.Models
{
	public class Usera
	{
        [Display(Name = "Correo")]
        [Required(ErrorMessage = "Correo es requerido")]
        public string email { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password es requerido")]
        public string password { get; set; }
    }
}

