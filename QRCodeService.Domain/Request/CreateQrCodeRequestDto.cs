using System.ComponentModel.DataAnnotations;

namespace QRCodeService.Domain.Request
{
    public class CreateQrCodeRequestDto
    {
        [Required]
        public string Description { get; set; }
    }
}
