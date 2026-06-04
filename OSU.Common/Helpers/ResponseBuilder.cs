namespace OSU.Common.Helpers;

public static class ResponseBuilder
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="data"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public static ApiResponse Success(Object data, string message = "Request successful")
    {
        return new ApiResponse
        {
            Success = true,
            Message = message,
            Data = data,
            Errors = null
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <param name="errors"></param>
    /// <returns></returns>
    public static ApiResponse Failure(
        string message,
        List<string>? errors = null)
    {
        return new ApiResponse
        {
            Success = false,
            Message = message,
            Data = default,
            Errors = errors
        };
    }
}
