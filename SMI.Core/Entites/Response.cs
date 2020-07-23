using SMI.Core.DTOs;

namespace SMI.Core.Entites
{
    public class Response
    {
        public bool Exito { get; set; }
        public string Mensaje { get; set; }
        public object Data { get; set; }
    }
}
