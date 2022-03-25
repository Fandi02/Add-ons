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
           
        }
        // GET: AplikasiController
        public async Task<ActionResult> Index()
        {
            var data = await _aplikasiService.Read();
            
            

            return View(data);
        }
        // GET: AplikasiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AplikasiController/Create
        public ActionResult Create()
        {
            return View(new Aplikasi(1, "Aplikasi", "Aplikasi desc", 90, "Link Image"));
        }

        // POST: AplikasiController/Create
        [HttpPost]
        public ActionResult Create(int id, string title, string desc, int totalLike, string linkImage)
        {
            Aplikasi dataBaru = new Aplikasi(id, title, desc, totalLike, linkImage);
            _aplikasiService.Write(dataBaru);
                return RedirectToAction("Index");
            
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
