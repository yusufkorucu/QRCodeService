using QRCodeService.Core.Abstract;
using QRCodeService.Core.Services;
using QRCodeService.Domain.Request;

namespace QRCodeService.Test
{
    public class UnitTest1
    {
        [Fact]
        public async void QrCode_CreateQRCodeTest_ShouldBeCreated()
        {
            IQrCodeService service = new QrCodeService();

            var request = new CreateQrCodeRequestDto { Description = "Yusuf KORUCU" };

            var response = await service.CreateQRCodeAsync(request);

            Assert.NotNull(response.Data);

            Assert.True(response.IsSuccess);

        }
    }
}