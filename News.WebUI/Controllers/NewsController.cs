using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using News.Entity;
using News.Repositories;
namespace News.WebUI.Controllers
{
    public class NewsController : Controller
    {

        private FakeNewsRepository _newsRepository;
        // GET: News

        public NewsController()
        {
            this._newsRepository = new FakeNewsRepository();
        }
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Tasks = _newsRepository.GetAll();
            return View();
        }

    }
}
