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
                new Aplikasi(1, "Title", "Bootcamp alkademi"),
                new Aplikasi(2, "Title 1", "Bootcamp alkademi"),
                new Aplikasi(3, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
                new Aplikasi(4, "Title 2", "Bootcamp alkademi"),
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
