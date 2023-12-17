namespace utility.RequestDetails
{
    public class RequestDetails
    {
        public string Message{get; set;}
        public string PropertyName{get; set;}

        public RequestDetails(string message, string propertyName)
        {

            Message = message;
            PropertyName = propertyName;

        }

    }
}