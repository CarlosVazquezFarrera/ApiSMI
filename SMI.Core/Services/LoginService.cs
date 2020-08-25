namespace SMI.Core.Services
{
    using SMI.Core.CustomEntities;
    using SMI.Core.Entites;
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
        public async Task<Response<Empleado>> Login(Empleado empleado)
        {
            return await _empleadoRepository.Login(empleado);
        } 
        #endregion
    }
}
