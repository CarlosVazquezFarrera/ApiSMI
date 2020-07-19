namespace SMI.Infrastructure.Repositories
{
    using SMI.Core.Entites;
    using SMI.Core.Interfaces;
    using System.Threading.Tasks;

    public class EmpleadoReposotory: IEmpleadoRepository
    {
        public async Task<Empleado> Login()
        {
            await Task.Delay(10);
            return new Empleado { Id = 1, Apellidos = "Vazquez", Email = "Aja", Nombre = "Carlos", Password = "1234"};
        }
    }
}
