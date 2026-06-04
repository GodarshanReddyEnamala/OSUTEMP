namespace OSU.Common;

public class ApiResponse
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public Object? Data { get; set; }
    public List<string>? Errors { get; set; }

}
