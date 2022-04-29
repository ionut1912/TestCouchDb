using TestCouchDb.Models;

namespace TestCouchDb.Repository
{
    public interface ICouchRepository
    {
        Task<HttpClientResponse> PostDocumentAsync(EnrollCourse enrollCourse);
        Task<HttpClientResponse> PutDocumentAsync(UpdateEnroll update);
        Task<HttpClientResponse> GetDocumentAsync(string id);

        Task<HttpClientResponse> DeleteDocumentAsync(string id, string rev);
    }
}
