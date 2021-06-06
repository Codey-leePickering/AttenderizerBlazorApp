using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttenderizerBlazorApp.Models
{
    public class QRModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("qRCode")]
        public string QrCode { get; set; }
    }
}
