namespace Flight.Entity
{
    public class MessageResult
    {
        public bool IsSucceeded { get; set; }
        public string Message { get; set; }

        public MessageResult Succeeded(string message = "بلیط صادر شد!")
        {
            IsSucceeded = true;
            Message = message ;
            return this;
        }
        public MessageResult Failed(string message = "خطا در عملیات!")
        {
            IsSucceeded = false;
            Message = message;
            return this;
        }
    }
}
