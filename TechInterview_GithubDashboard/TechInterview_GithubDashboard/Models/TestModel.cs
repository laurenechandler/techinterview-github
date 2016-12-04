using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechInterview_GithubDashboard.Models
{
    public class TestModel
    {
        private string id;
        private string type;
        private string created;

        [JsonProperty("id")]
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty("type")]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        [JsonProperty("created_at")]
        public string Created
        {
            get { return created; }
            set { created = value; }
        }
    }
}