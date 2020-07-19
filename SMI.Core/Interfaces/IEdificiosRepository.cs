using SMI.Core.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SMI.Core.Interfaces
{
    public interface IEdificiosRepository
    {
        /// <summary>
        /// Obtiene en listado de edificios disponibles
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Edificio>> GetEdificios();
    }
}
