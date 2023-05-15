namespace DaLatFood.Domain.Core.Response;

public class ApiResponse<TResult> where TResult : class
{
    public  TResult Result { get; }
    public  bool Success { get; }
    public  object? Error { get; }
    public  int StatusCode { get; }
    public  string Message { get; }
    public  ApiResponse(bool success,
        string message,
        TResult result,
        object? error = null,
        int statusCode = 200)
    {
        this.Result = result;
        this.Success = success;
        this.StatusCode = statusCode;
        this.Message = message;
        this.Error = error;
    }

    public static ApiResponse<TResult> Ok(TResult result = null, string message = null)
    {
        return new ApiResponse<TResult>(true, message, result);
    }

    public static ApiResponse<TResult> Fail(string message, object error = null, int statusCode = 500,
        TResult? result = null)
    {
        return new ApiResponse<TResult>(false, message, result, statusCode);
    }
}