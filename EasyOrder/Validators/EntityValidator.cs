namespace EasyOrder.Validators
{
    public static class EntityValidator<T> where T : class
    {
        public static bool IsValidName(string name)
        {
            return string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name) ? true : false;
        }
        
        public static bool IsValidEmail(string email)
        {
            return string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email) ? true : false;
        }
        
        public static bool IsValidDate(DateTime registrationDate)
        {
            return registrationDate < DateTime.Now ? true : false;
        }
        
        public static bool IsValidPrice(decimal price)
        {
            return price < 0.0m ? true : false;
        }
        
        public static bool IsValidStockQuantity(int stock)
        {
            return stock < 0 ? true : false;
        }
    }
}
