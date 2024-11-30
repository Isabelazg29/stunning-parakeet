using System.Threading.Tasks;
using Glamping_Addventure2.Models;

namespace Glamping_Addventure.Models.Servicios.Contrato
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuario(string email, string contrasena);

        Task<Usuario> SaveUsuario(Usuario modelo);

        Task<Usuario> GetUsuarioPorEmail(string email);

        Task<Usuario> GetUsuarioPorDocumento(int? numeroDocumento);

        Task<Role> GetRolPorId(int Idrol);

        Task<List<Role>> GetRolesActivos();

    }
}