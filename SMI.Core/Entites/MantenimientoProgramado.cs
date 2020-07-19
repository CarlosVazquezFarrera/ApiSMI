using System;
using System.Collections.Generic;

namespace SMI.Core.Entites
{
    public partial class MantenimientoProgramado
    {
        public int Id { get; set; }
        public int IdActividad { get; set; }
        public int IdEspacio { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaEstablecidad { get; set; }
        public DateTime FechaFinProgramada { get; set; }
        public DateTime FechaFinRealizacion { get; set; }
        public int Estatus { get; set; }
        public string Observaciones { get; set; }

        public virtual Actividad IdActividadNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual Espacio IdEspacioNavigation { get; set; }
    }
}
