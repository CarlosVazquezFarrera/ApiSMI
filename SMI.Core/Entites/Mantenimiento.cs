using System;
using System.Collections.Generic;

namespace SMI.Core.Entites
{
    public partial class Mantenimiento
    {
        public Mantenimiento()
        {
            Actividad = new HashSet<Actividad>();
        }

        public int Id { get; set; }
        public string Mantenimiento1 { get; set; }

        public virtual ICollection<Actividad> Actividad { get; set; }
    }
}
