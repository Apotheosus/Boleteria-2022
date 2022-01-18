using BoleteriaOnline.Web.Extensions.Response;

namespace BoleteriaOnline.Web.Utils;
public class WebResult<T> where T : class
{
    public T? Data { get; set; }
    public bool Success { get; set; } = true;
    public string? Message { get; set; } = null;
    public IDictionary<string, string[]>? ErrorMessages { get; set; } = null;
    public ErrorMessage ErrorCode { get; set; }
    public string? Error { get; set; } 
}
