using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TechInterview_GithubDashboard.Models;

namespace TechInterview_GithubDashboard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //TestModel testModel = new TestModel();
            //testModel.ID = 45345;
            //testModel.Name = "Lauren";

            string url = "https://api.github.com/events";
            HttpWebRequest webRequestURL = (HttpWebRequest)WebRequest.Create(url);
            webRequestURL.UserAgent = "application/vnd.github.v3+json";
            Stream dataStream = webRequestURL.GetResponse().GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            var temp = JsonConvert.DeserializeObject<IEnumerable<TestModel>>(reader.ReadToEnd());


            return View(temp);
        }

        public ActionResult About() 
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}