using System.Net;

namespace FinanceMan.Server;

public class ApiResponse<T>
{
    public HttpStatusCode StatusCode { get; set; }
    public string Title { get; set; }
    public string Detail { get; set; }
    public T? Data { get; set; }
    public List<string> Errors { get; set; } = [];
}