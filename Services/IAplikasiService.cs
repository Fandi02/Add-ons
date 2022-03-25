using Add.ons.Web.Models;

namespace Add.ons.Web.Services
{
    public interface IAplikasiService
    {
        Task<List<AplikasiViewModel>> Read();
        Task Write(Aplikasi request);
    }
}
