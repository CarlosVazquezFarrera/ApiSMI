using System;
using System.Collections.Generic;

namespace SMI.Core.Entites
{
    public partial class Empleado
    {
        public Empleado()
        {
            MantenimientoProgramado = new HashSet<MantenimientoProgramado>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<MantenimientoProgramado> MantenimientoProgramado { get; set; }
    }
}
