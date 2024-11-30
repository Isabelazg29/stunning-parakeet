using Glamping_Addventure2.Models;
using Glamping_Addventure2.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Glamping_Addventure2.Controllers
{
    [AllowAnonymous]
   
    [Route("Recuperacion/[action]")]
    public class RecuperacionController : Controller
    {
        private readonly GlampingAddventureContext _context;
        private readonly IEmailService _emailService;

        public RecuperacionController(GlampingAddventureContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        // Acción para mostrar la vista de solicitar recuperación de contraseña
        [HttpGet("SolicitarRecuperacion")]
        public IActionResult SolicitarRecuperacion()
        {
            return View();
        }

        [HttpPost("enviar-recuperacion")]
        public async Task<IActionResult> EnviarRecuperacion([FromForm] string email)
        {
            // Validación del formato del correo electrónico
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return BadRequest("El correo electrónico no tiene un formato válido.");
            }

            // Buscar al usuario por su correo
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == email);
            if (usuario == null)
            {
                return BadRequest("El correo electrónico no está registrado.");
            }

            // Generar el token de recuperación
            var token = Guid.NewGuid().ToString();
            var tokenRecuperacion = new TokenRecuperacion
            {
                UsuarioId = usuario.Idusuario,
                Token = token,
                FechaExpiracion = DateTime.Now.AddHours(1)
            };

            _context.TokenRecuperacion.Add(tokenRecuperacion);
            await _context.SaveChangesAsync();

            // Crear el enlace de recuperación
            var recoveryLink = Url.Action("Recuperar", "Recuperacion", new { token }, Request.Scheme);

            var subject = "Recuperación de Contraseña";

            // HTML del mensaje
            var message = $@"
    <html>
    <head>
        <style>
            body {{
                font-family: Arial, sans-serif;
                margin: 0;
                padding: 0;
                background-color: #f4f4f4;
            }}
            .container {{
                width: 100%;
                max-width: 600px;
                margin: 0 auto;
                background-color: #ffffff;
                padding: 20px;
                border-radius: 8px;
                box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            }}
            .header {{
                text-align: center;
                font-size: 24px;
                font-weight: bold;
                color: #333;
                margin-bottom: 20px;
            }}
            .content {{
                font-size: 16px;
                color: #333;
                margin-bottom: 20px;
            }}
            .footer {{
                font-size: 12px;
                text-align: center;
                color: #999;
                margin-top: 20px;
            }}
            .btn {{
                display: inline-block;
                padding: 12px 24px;
                background-color: #28a745;
                color: #ffffff;
                text-decoration: none;
                border-radius: 5px;
                text-align: center;
                font-size: 16px;
                margin-top: 20px;
            }}
            .btn:hover {{
                background-color: #218838;
            }}
        </style>
    </head>
    <body>
        <div class='container'>
            <div class='header'>
                Recuperación de Contraseña
            </div>
            <div class='content'>
                <p>Hola,</p>
                <p>Hemos recibido una solicitud para recuperar la contraseña de tu cuenta en <strong>Glamping Addventure</strong>.</p>
                <p>Si no fuiste tú quien solicitó este cambio, puedes ignorar este correo.</p>
                <p>Para restablecer tu contraseña, haz clic en el siguiente enlace:</p>
                <a href='{recoveryLink}' class='btn'>Recuperar Contraseña</a>
                <p>Este enlace expirará en 1 hora.</p>
            </div>
            <div class='footer'>
                <p>&copy; 2024 Glamping Addventure. Todos los derechos reservados.</p>
                <p>Si tienes problemas, por favor contacta con nosotros a <a href='mailto:support@glampingaddventure.com'>support@glampingaddventure.com</a>.</p>
            </div>
        </div>
    </body>
    </html>";

            // Enviar el correo utilizando el servicio de correo
            await _emailService.EnviarCorreoRecuperacion(usuario.Email, subject, message);

            return Ok("Se ha enviado un enlace de recuperación a su correo electrónico.");
        }

        // Cambiar contraseña usando el token
        [HttpPost("cambiar")]
        public async Task<IActionResult> CambiarContrasena([FromForm] CambioContrasenaDto cambioContrasena)
        {
            // Validar que el token sea válido
            var tokenRecuperacion = await _context.TokenRecuperacion
                .FirstOrDefaultAsync(t => t.Token == cambioContrasena.Token && !t.Usado && t.FechaExpiracion > DateTime.Now);

            if (tokenRecuperacion == null)
                return BadRequest("Token inválido o expirado");

            // Obtener al usuario asociado al token
            var usuario = await _context.Usuarios.FindAsync(tokenRecuperacion.UsuarioId);
            if (usuario == null)
                return NotFound("Usuario no encontrado");

            // Validar la nueva contraseña
            if (string.IsNullOrWhiteSpace(cambioContrasena.NuevaContrasena) || cambioContrasena.NuevaContrasena.Length < 6)
            {
                return BadRequest("La contraseña debe tener al menos 6 caracteres.");
            }

            // Actualizar la contraseña y marcar el token como usado
            usuario.Contrasena = cambioContrasena.NuevaContrasena;
            tokenRecuperacion.Usado = true;

            await _context.SaveChangesAsync();
            return Ok("Contraseña actualizada exitosamente");
        }
    }

    // DTO para cambio de contraseña
    public class CambioContrasenaDto
    {
        public string Token { get; set; }
        public string NuevaContrasena { get; set; }
    }
}
