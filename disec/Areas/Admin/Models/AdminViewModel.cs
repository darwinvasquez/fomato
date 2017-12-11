using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace disec.Areas.Admin.Models
{
    public class ResetPasswordViewModels
    {
        [Required]
        [Display(Name = "Id Usuario")]
        public string idUsuario { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Nueva Contraseña")]
        public string nuevoPassword { get; set; }
    }
}