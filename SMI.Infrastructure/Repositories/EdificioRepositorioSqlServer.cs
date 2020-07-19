using SMI.Core.Entites;
using SMI.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMI.Infrastructure.Repositories
{
    public class EdificioRepositorioSqlServer : IEdificiosRepository
    {
        public async Task<IEnumerable<Edificio>> GetEdificios()
        {
            var edificios = Enumerable.Range(1, 10).Select(x=> new Edificio{
                Id = x,
                Nombre = $"Edificio {x}",
                NumeroNiveles = x,
                FechaEdificacion = DateTime.Now,
                Largo = 12.23,
                Ancho = 12.23
            });
            await Task.Delay(10);

            return edificios;
        }
    }
}
