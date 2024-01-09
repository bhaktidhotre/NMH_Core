namespace NHM_API.Responses
{
    public class RequestResponse
    {
        public int Code { get; set; }
        public string? Message { get; set; }
        public string? Url { get; set; }
        public Boolean Status { get; set; }
        public object? Data { get; set; }
        public RequestResponse()
        {
        }
        public RequestResponse(int code, Boolean status, string message, string url, object data)
        {
            Code = code;
            Status = status;
            Message = message;
            Url = url;
            Data = data;
        }
    }
}
