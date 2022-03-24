using Add.ons.Web.Models;

namespace Add.ons.Web.Services
{
    public interface IAplikasiService
    {
        List<AplikasiViewModel> GetAplikasis();
        int Add(AplikasiViewModel request);
    }
}
