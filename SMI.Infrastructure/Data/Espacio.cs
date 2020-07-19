using System;
using System.Collections.Generic;

namespace SMI.Infrastructure.Data
{
    public partial class Espacio
    {
        public Espacio()
        {
            MantenimientoProgramado = new HashSet<MantenimientoProgramado>();
        }

        public int Id { get; set; }
        public int IdEdificio { get; set; }
        public string Nombre { get; set; }
        public decimal? Largo { get; set; }
        public decimal? Ancho { get; set; }

        public virtual Edificio IdEdificioNavigation { get; set; }
        public virtual ICollection<MantenimientoProgramado> MantenimientoProgramado { get; set; }
    }
}
