namespace utility.RequestDetails
{
    public class RequestDetails
    {
        public string Message{get; set;}
        public string PropertyName{get; set;}
        public bool Result{get; set;}

        public RequestDetails(string message, string propertyName, bool result)
        {

            Message = message;
            PropertyName = propertyName;
            result=Result;

        }

    }
}