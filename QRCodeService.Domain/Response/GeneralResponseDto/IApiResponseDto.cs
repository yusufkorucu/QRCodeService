namespace QRCodeService.Domain.Response.GeneralResponseDto
{
    public interface IApiResponseDto
    {
        bool IsSuccess { get; }
        string Message { get; }
        Exception Exception { get; }
    }
}
