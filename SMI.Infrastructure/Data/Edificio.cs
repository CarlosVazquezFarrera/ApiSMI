using System;
using System.Collections.Generic;

namespace SMI.Infrastructure.Data
{
    public partial class Edificio
    {
        public Edificio()
        {
            Espacio = new HashSet<Espacio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public byte? NumeroNiveles { get; set; }
        public decimal? Largo { get; set; }
        public decimal? Ancho { get; set; }
        public DateTime? FechaEdificacion { get; set; }

        public virtual ICollection<Espacio> Espacio { get; set; }
    }
}
