using Add.ons.Web.Models;
using Add.ons.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Add.ons.Web.Controllers
{
    public class AplikasiController : Controller
    {
        List<AplikasiViewModel> _listAplikasi = new List<AplikasiViewModel>();
        private readonly IAplikasiService _aplikasiService;
        public AplikasiController(IAplikasiService aplikasiService)
        {
            _aplikasiService = aplikasiService;
            _listAplikasi = new List<AplikasiViewModel>(){
                new AplikasiViewModel(1, "ZenMate Free VPN – Best VPN for Edge", "ZenMate VPN - The best free Edge VPN extension to hide your IP. Encrypt your connection & Access websites easily.")
                {
                    LinkImage = "https://store-images.s-microsoft.com/image/apps.42476.b497a636-55ce-4970-877c-b9ddf545f71e.4d15c5c8-9583-40ea-87cc-7ae57781d9fa.754c2c99-9113-4770-b654-209fcc94293f?mode=scale&h=100&q=90&w=100",
                },
                new AplikasiViewModel(2, "MetaMask", "MetaMask is a Crypto Wallet and Your Gateway to Web3. Buy, store and send tokens globally. Explore blockchain applications at lightening speed. Choose what to share and what to keep private.")
                {
                    LinkImage = "https://store-images.s-microsoft.com/image/apps.46850.52d760c7-fbda-4912-b609-0a91590a4eb5.5e6b8b3e-2a46-48c9-aae5-ef3724034f66.b5cfbf10-de59-4d85-adf5-ea103ac2ad67?mode=scale&h=100&q=90&w=100",
                },
                new AplikasiViewModel(3, "NordVPN – VPN Proxy for Privacy & Security", "Get yourself an ultra-fast VPN proxy extension for Microsoft Edge and never stop for anything. Download NordVPN to enjoy fast, private, and secure internet in an instant. It’s an easy-to-use VPN, trusted by millions of users worldwide.")
                {
                    LinkImage = "https://store-images.s-microsoft.com/image/apps.57636.71b12a17-6a22-4cc8-a0e8-895f272a8f1b.65545a2a-baac-4eaf-8a2a-cf22ef308fc7.b76adfd5-e6b1-4977-9503-c4a7614700ad?mode=scale&h=100&q=90&w=100",
                },
                new AplikasiViewModel(4, "IDM Integration Module", "Internet Download Manager (IDM) is a popular tool to increase download speeds by up to 5 times, resume and schedule downloads.")
                {
                    LinkImage = "https://store-images.s-microsoft.com/image/apps.59923.0c5ee452-c04d-4152-a6d4-2073117a0427.a781b8c0-8427-4934-8a8d-df2c74da6215.388aec9e-7312-4dcb-84bc-c35dc01a9075?mode=scale&h=100&q=90&w=100",
                },
                new AplikasiViewModel(5, "The Elder Scrolls V: Skyrim 10th Anniversary", "Personalize Microsoft Edge with a new browser theme inspired by The Elder Scrolls V: Skyrim Anniversary Edition celebrating the 10th Anniversary of the game.")
                {
                    LinkImage = "https://store-images.s-microsoft.com/image/apps.11679.b0da2c59-ac0b-4fa2-be60-7bd5087a9aa2.7c62ea9f-3cc7-47c9-b561-95c9ae2a6405.21f7b62f-120b-41da-bfce-9943dfcf7576?mode=scale&h=100&q=90&w=100",
                },
            };
        }
        // GET: AplikasiController
        public ActionResult Index()
        {
            return View(_aplikasiService.GetAplikasis());
        }

        // GET: AplikasiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AplikasiController/Create
        public ActionResult Create()
        {
            return View(new AplikasiViewModel(1, "Aplikasi", "Aplikasi desc"));
        }

        // POST: AplikasiController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AplikasiViewModel collection)
        {
            if(!ModelState.IsValid)
            {
                return View(collection);
            }

            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: AplikasiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AplikasiController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AplikasiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AplikasiController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
