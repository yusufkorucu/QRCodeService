namespace QRCodeService.Domain.Response.GeneralResponseDto
{
    public class ApiResponseDto<T> : IApiResponseDto
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public Exception Exception { get; set; }

        public T Data { get; set; }
        public ApiResponseDto() { }

        public ApiResponseDto(bool isSuccess, string message, T data)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
        }

        public ApiResponseDto(bool isSuccess, string message, Exception exception)
        {
            IsSuccess = isSuccess;
            Message = message;
            Exception = exception;
        }

        public ApiResponseDto(bool isSuccess, T data)
        {
            IsSuccess = isSuccess;
            Data = data;
        }

        public ApiResponseDto(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }

    }
}
