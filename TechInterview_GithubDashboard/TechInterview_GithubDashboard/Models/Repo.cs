using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechInterview_GithubDashboard.Models
{
    public class Repo
    {
        private int id;
        private string name;
        private string url;

        [JsonProperty("id")]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty("name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [JsonProperty("url")]
        public string URL
        {
            get { return url; }
            set { url = value; }
        }
    }
}