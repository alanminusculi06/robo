using RoboClient.Models.Robos;
using RoboClient.Services;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RoboClient.Controllers
{
    public class RobosController : Controller
    {
        private readonly RoboApiService _api = new RoboApiService();
        private static IList<Robo> _robos;

        public RobosController()
        {
            if (_robos == null)
                _robos = new List<Robo>();
        }

        public ActionResult Index()
        {
            return View(_robos);
        }

        public async Task<ActionResult> Details(string id)
        {
            if (string.IsNullOrEmpty(id))
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var robo = await _api.GetAsync<Robo>(id);
            if (robo == null)
                return HttpNotFound();

            return View(robo);
        }

        public async Task<ActionResult> Create()
        {
            var robo = await _api.GetAsync<Robo>();
            _robos.Add(robo);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var robo = await _api.GetAsync<Robo>(id);
            if (robo == null)
                return HttpNotFound();

            return View(robo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Cabeca,BracoDireito,BracoEsquerdo")] Robo robo)
        {
            if (ModelState.IsValid)
            {
                await _api.PutAsync<Robo>(robo);
                return RedirectToAction("Index");
            }
            return View(robo);
        }
    }
}
