using Microsoft.Extensions.DependencyInjection;
using QRCodeService.Core.Abstract;
using QRCodeService.Core.Services;

namespace QRCodeService.Core
{
    public static class ServicesRegistration
    {
        public static void AddApplicationServices(this IServiceCollection collection)
        {
            collection.AddScoped<IQrCodeService, QrCodeService>();

        }

    }
}
