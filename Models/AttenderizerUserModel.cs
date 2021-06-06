using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttenderizerBlazorApp.Models
{
    public class Rootobject
    {
        public AttenderizerUserModel[] Property1 { get; set; }
    }

    public class AttenderizerUserModel
    {
        public string id { get; set; }
        public int username { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool isAbsent { get; set; }
    }

}
