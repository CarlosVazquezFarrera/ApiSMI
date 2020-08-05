namespace SMI.Core.Services
{
    using SMI.Core.Entites;
    using SMI.Core.Interfaces;
    using System;
    using System.Threading.Tasks;

    public class LoginService : ILoginService
    {
        private readonly IEmpleadoRepository _empleadoRepository;

        public LoginService(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }

        public async Task<Response> Login(Empleado empleado)
        {
            if(string.IsNullOrEmpty(empleado.Email) || string.IsNullOrEmpty(empleado.Password))
            {
                throw new Exception("Debe llenar los datos completos");
            }
            return await _empleadoRepository.Login(empleado);
        }
    }
}
