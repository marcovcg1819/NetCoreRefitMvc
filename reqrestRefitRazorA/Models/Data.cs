using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace reqrestRefitRazorA.Models
{
    public class Data
    {

        [Display(Name = "id")]
        public int id { get; set; }
        [Display(Name = "Correo")]
        public string email { get; set; }
        [Display(Name = "Nombre")]
        public string first_name { get; set; }
        [Display(Name = "Apellido")]
        public string last_name { get; set; }
        [Display(Name = "Avatar")]
        public string avatar { get; set; }

    }
}

