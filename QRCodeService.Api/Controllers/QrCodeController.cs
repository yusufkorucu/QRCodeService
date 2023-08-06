using Microsoft.AspNetCore.Mvc;
using QRCodeService.Core.Abstract;
using QRCodeService.Domain.Request;

namespace QRCodeService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QrCodeController : ControllerBase
    {
        #region Field

        private readonly IQrCodeService _qrCodeService;

        #endregion

        #region Ctor

        public QrCodeController(IQrCodeService qrCodeService)
        {
            _qrCodeService = qrCodeService;
        }

        #endregion

        #region Methods

        [HttpPost]
        public async Task<IActionResult> CreateQRCodeAsync(CreateQrCodeRequestDto requestDto)
        {

            var result = await _qrCodeService.CreateQRCodeAsync(requestDto);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);

        }

        #endregion
    }
}
