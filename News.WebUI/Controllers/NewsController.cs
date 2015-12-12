using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using News.Entity;
using News.Repositories;
using System.Configuration;
using System.Data.SqlClient;

namespace News.WebUI.Controllers
{   [NoCache]
    public class NewsController : Controller
    {

        private SqlNewsRepository _newsRepository;
        // GET: News

        public NewsController()
        {
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["_cnString"].ConnectionString);
            this._newsRepository = new SqlNewsRepository(Conn.ConnectionString);
        }
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Tasks = _newsRepository.GetAll();
            return View();
        }

    }
}
