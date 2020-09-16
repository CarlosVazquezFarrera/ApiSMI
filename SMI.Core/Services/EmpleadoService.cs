namespace SMI.Core.Services
{
    using SMI.Core.CustomEntities;
    using SMI.Core.Exceptios;
    using SMI.Core.Interfaces;
    using System.Threading.Tasks;

    public class EmpleadoService : IEmpleadoService
    {
        #region Constructor
        public EmpleadoService(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }
        #endregion

        #region Atributes
        private readonly IEmpleadoRepository _empleadoRepository;
        #endregion

        #region Methods
        public async Task<Response<string>> CambiarPasword(Credenciales credenciales)
        {
            if (credenciales.Password.Equals(credenciales.NewPassword))
            {
                throw new BussinessExecption("La nueva contraseña no debe ser igual a la anterior");
            }
            return await _empleadoRepository.CambiarPasword(credenciales);
        } 
        #endregion
    }
}
