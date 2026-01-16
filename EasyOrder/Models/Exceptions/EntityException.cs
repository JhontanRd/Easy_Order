namespace EasyOrder.Models.Exceptions
{
    class EntityException : ApplicationException
    {
        public EntityException(string msg) : base(msg) { }
    }
}
