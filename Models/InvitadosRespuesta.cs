using System.ComponentModel.DataAnnotations;

namespace FiestaInvitados.Models
{
    public class InvitadosRespuesta
    {
        [Required(ErrorMessage = "Por favor, ingresa tu nombre.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Por favor, ingresa tu email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Por favor, ingresa tu teléfono.")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "¿Asistirás?")]
        public bool? Asistira { get; set; }

    }

}