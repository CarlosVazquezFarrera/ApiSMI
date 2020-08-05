namespace SMI.Core.Services
{
    using SMI.Core.Entites;
    using SMI.Core.Exceptios;
    using SMI.Core.Interfaces;
    using System.Threading.Tasks;

    public class LoginService : ILoginService
    {
        #region Constructor
        public LoginService(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }
        #endregion

        #region Atributes
        private readonly IEmpleadoRepository _empleadoRepository; 
        #endregion

        #region Methods
        public async Task<Response> Login(Empleado empleado)
        {
            if (string.IsNullOrEmpty(empleado.Email) || string.IsNullOrEmpty(empleado.Password))
            {
                throw new BussinessExecption("Debe llenar los datos completos");
            }
            return await _empleadoRepository.Login(empleado);
        } 
        #endregion
    }
}
