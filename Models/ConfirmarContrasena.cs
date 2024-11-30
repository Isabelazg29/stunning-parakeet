using System.ComponentModel.DataAnnotations;

namespace Glamping_Addventure2.Models
{
    public class CambioContrasenaDto
    {
        [Key]
        [MaxLength(255)] // Define un límite razonable para el token
        public string Token { get; set; }

        [Required]
        public string NuevaContrasena { get; set; }

        [Required]
        [Compare("NuevaContrasena", ErrorMessage = "Las contraseñas no coinciden.")]
        public string ConfirmarContrasena { get; set; }
    }

}
