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
            string url = "https://api.github.com/events";
            HttpWebRequest webRequestURL = (HttpWebRequest)WebRequest.Create(url);
            webRequestURL.UserAgent = "laurenechandler";
            webRequestURL.Accept = "application/vnd.github.v3+json";
            Stream dataStream = webRequestURL.GetResponse().GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            var eventModelList = JsonConvert.DeserializeObject<IEnumerable<EventModel>>(reader.ReadToEnd());


            return View(eventModelList);
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