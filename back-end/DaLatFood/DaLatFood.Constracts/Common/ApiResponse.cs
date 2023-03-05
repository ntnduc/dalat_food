namespace DaLatFood.WebApi.Common;

public class ApiResponse<TResult> where TResult : class
{
    public TResult Result { get; }

    private ApiResponse(
        bool success,
        string message,
        TResult result,
        object error = null,
        int statusCode = 200)
    {
        this.Result = result;
    }

    public static ApiResponse<TResult> Ok(TResult result = null, string message = null) =>
        new ApiResponse<TResult>(true, message, result);

    public static ApiResponse<TResult> Fail(
        string message,
        object errors = null,
        int statusCode = 500,
        TResult result = null)
    {
        return new ApiResponse<TResult>(false, message, result, errors, statusCode);
    }
}