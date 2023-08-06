using QRCoder;
using QRCodeService.Core.Abstract;
using QRCodeService.Domain.Request;
using QRCodeService.Domain.Response;
using QRCodeService.Domain.Response.GeneralResponseDto;

namespace QRCodeService.Core.Services
{
    public class QrCodeService : IQrCodeService
    {
        public async Task<ApiResponseDto<QrCodeResponseDto>> CreateQRCodeAsync(CreateQrCodeRequestDto requestDto)
        {
            try
            {
                var qrCode = BitmapByteQRCodeHelper.GetQRCode(requestDto.Description, QRCodeGenerator.ECCLevel.Q, 15);

                var responseData = new QrCodeResponseDto
                {
                    Description = requestDto.Description,
                    QrCode = Convert.ToBase64String(qrCode)
                };

                return new ApiResponseDto<QrCodeResponseDto>(isSuccess: true, data: responseData);
            }
            catch (Exception ex)
            {
                return new ApiResponseDto<QrCodeResponseDto>(isSuccess: false, message: ex.ToString(), exception: ex);
            }

        }
    }
}
