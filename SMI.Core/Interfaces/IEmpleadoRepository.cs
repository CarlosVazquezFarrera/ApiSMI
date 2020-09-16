﻿namespace SMI.Core.Interfaces
{
    using SMI.Core.Custom_Entites;
    using SMI.Core.Entites;
    using System.Threading.Tasks;
    public interface IEmpleadoRepository
    {
        /// <summary>
        /// Hace el logeo
        /// </summary>
        /// <param name="empleado"></param>
        /// <returns></returns>
        Task<Response> Login(Empleado empleado);

        /// <summary>
        /// Cambia la contraseña del usuario
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Password"></param>
        /// <param name="NewPassowrd"></param>
        /// <returns></returns>
        Task<Response> CambiarPasword(CambiarPassword credenciales);
    }
}
