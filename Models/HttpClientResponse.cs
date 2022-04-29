namespace TestCouchDb.Models
{
    public class HttpClientResponse
    {
    
            public bool IsSuccess { get; set; }
            public dynamic SuccessContentObject { get; set; }
            public string FailedReason { get; set; }
     }
    
}
