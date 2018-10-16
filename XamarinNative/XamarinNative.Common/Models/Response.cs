    namespace XamarinNative.Common.Models
{
    public class Response
    {
        public bool IsSuccess { get; set; }

        public string  Message { get; set; } //si no es exitoso

        public object Result { get; set; } //Porque es generico [Obj*]
    }
}
