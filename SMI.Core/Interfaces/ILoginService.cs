namespace SMI.Core.Interfaces
{
    using SMI.Core.CustomEntities;
    using SMI.Core.Entites;
    using System.Threading.Tasks;
    public interface ILoginService
    {
        Task<Response<Empleado>> Login(Empleado empleado);
    }
}