using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace reqrestRefitRazorA.Models
{
    public class UserUpdate
	{
        public int id { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Nombre es requerido")]
        public string name { get; set; }
        [Display(Name = "Empleo")]
        [Required(ErrorMessage = "Empleo es requerido")]
        public string job { get; set; }
    }
}

