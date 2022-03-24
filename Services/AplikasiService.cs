using Add.ons.Web.Models;

namespace Add.ons.Web.Services
{
    public class AplikasiService : IAplikasiService
    {
        List<Aplikasi> _aplikasi;
        public AplikasiService()
        {
            _aplikasi = new List<Aplikasi>
            {
                new Aplikasi(1, "Add ons", "Add ons for browser"),
                new Aplikasi(2, "Add ons 1", "Add ons for browser"),
                new Aplikasi(3, "Add ons 2", "Add ons for browser"),
                new Aplikasi(4, "Add ons 2", "Add ons for browser"),
            };
        }
        public int Add(AplikasiViewModel request)
        {
            throw new NotImplementedException();
        }

        public List<AplikasiViewModel> GetAplikasis()
        {
            List<AplikasiViewModel> aplikasiViewModels = new List<AplikasiViewModel>();

            foreach (var item in _aplikasi)
            {
                aplikasiViewModels.Add(new AplikasiViewModel(item.Id, item.Title, item.Title));
            }

            return aplikasiViewModels;
        }
    }
}
