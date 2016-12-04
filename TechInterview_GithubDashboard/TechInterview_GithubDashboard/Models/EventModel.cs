using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechInterview_GithubDashboard.Models
{
    public class EventModel
    {
        private string id;
        private string eventType;
        private Actor actor;
        private Repo repo;
        private bool isPublic;
        private string created;

        [JsonProperty("id")]
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty("type")]
        public string EventType
        {
            get { return eventType; }
            set { eventType = value; }
        }

        [JsonProperty("actor")]
        public Actor Actor
        {
            get { return actor; }
            set { actor = value; }
        }

        [JsonProperty("repo")]
        public Repo Repo
        {
            get { return repo; }
            set { repo = value; }
        }

        [JsonProperty("public")]
        public bool Public
        {
            get { return isPublic; }
            set { isPublic = value; }
        }

        [JsonProperty("created_at")]
        public string Created
        {
            get { return created; }
            set { created = value; }
        }
    }
}