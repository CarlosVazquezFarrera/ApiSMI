namespace SMI.Core.Interfaces
{
    using SMI.Core.CustomEntities;
    using SMI.Core.Entites;
    using System.Threading.Tasks;
    public interface IEmpleadoRepository
    {
        /// <summary>
        /// Hace el logeo
        /// </summary>
        /// <param name="empleado"></param>
        /// <returns></returns>
        Task<Response<Empleado>> Login(Empleado empleado);

        /// <summary>
        /// Cambia la contraseña del usuario
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Password"></param>
        /// <param name="NewPassowrd"></param>
        /// <returns></returns>
        Task<Response<string>> CambiarPasword(Credenciales credenciales);
    }
}
