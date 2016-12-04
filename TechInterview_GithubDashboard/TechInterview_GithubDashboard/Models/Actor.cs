using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechInterview_GithubDashboard.Models
{
    public class Actor
    {
        private int id;
        private string login;
        private string displayLogin;
        private string gravatarID;
        private string url;
        private string avatarURL;

        [JsonProperty("id")]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty("login")]
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        [JsonProperty("display_login")]
        public string DisplayLogin
        {
            get { return displayLogin; }
            set { displayLogin = value; }
        }

        [JsonProperty("gravatar_id")]
        public string GravatarID
        {
            get { return gravatarID; }
            set { gravatarID = value; }
        }

        [JsonProperty("url")]
        public string URL
        {
            get { return url; }
            set { url = value; }
        }

        [JsonProperty("avatar_url")]
        public string AvatarURL
        {
            get { return avatarURL; }
            set { avatarURL = value; }
        }
    }
}