namespace SMI.Core.CustomEntities
{
    public class Response <T>
    {
        public bool Exito { get; set; }
        public string Mensaje { get; set; }
        public T Data { get; set; }
    }
}
