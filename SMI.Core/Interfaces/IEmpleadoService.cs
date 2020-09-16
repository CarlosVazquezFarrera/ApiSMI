using SMI.Core.Custom_Entites;
using SMI.Core.CustomEntities;
using SMI.Core.Entites;
using System.Threading.Tasks;

namespace SMI.Core.Interfaces
{
    public interface IEmpleadoService
    {
        /// <summary>
        /// Cambia la contraseña del usuario
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Password"></param>
        /// <param name="NewPassowrd"></param>
        /// <returns></returns>
        Task<Response<string>> CambiarPasword(CambiarPassword credenciales);
    }
}
