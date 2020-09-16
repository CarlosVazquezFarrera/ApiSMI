namespace SMI.Core.Interfaces
{
    using SMI.Core.Entites;
    using System.Threading.Tasks;
    public interface ILoginService
    {
        /// <summary>
        /// Hace el logeo del usuario
        /// </summary>
        /// <param name="empleado"></param>
        /// <returns></returns>
        Task<Response> Login(Empleado empleado);
    }
}