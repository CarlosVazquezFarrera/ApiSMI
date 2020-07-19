using System;
using System.Collections.Generic;

namespace SMI.Infrastructure.Data
{
    public partial class Actividad
    {
        public Actividad()
        {
            MantenimientoProgramado = new HashSet<MantenimientoProgramado>();
        }

        public int Id { get; set; }
        public int IdMantenimiento { get; set; }
        public string Actividad1 { get; set; }

        public virtual Mantenimiento IdMantenimientoNavigation { get; set; }
        public virtual ICollection<MantenimientoProgramado> MantenimientoProgramado { get; set; }
    }
}
