using QRCodeService.Domain.Request;
using QRCodeService.Domain.Response;
using QRCodeService.Domain.Response.GeneralResponseDto;

namespace QRCodeService.Core.Abstract
{
    public interface IQrCodeService
    {
        Task<ApiResponseDto<QrCodeResponseDto>> CreateQRCodeAsync(CreateQrCodeRequestDto requestDto);
    }
}
