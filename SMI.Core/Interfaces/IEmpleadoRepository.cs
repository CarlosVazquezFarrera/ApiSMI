namespace SMI.Core.Interfaces
{
    using SMI.Core.Entites;
    using System.Threading.Tasks;
    public interface IEmpleadoRepository
    {
        Task<Empleado> Login();
    }
}
