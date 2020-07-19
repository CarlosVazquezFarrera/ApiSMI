using System;

namespace SMI.Core.Entites
{
    public class Edificio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int NumeroNiveles { get; set; }
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public DateTime FechaEdificacion { get; set; }
    }
}
