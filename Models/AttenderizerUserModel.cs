using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttenderizerBlazorApp.Models
{
    public class AttenderizerUserModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public int Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("isAbsent")]
        public bool IsAbsent { get; set; }
    }

}
