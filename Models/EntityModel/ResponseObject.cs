using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebConfigurationApi.Models.EntityModel
{
    public class ResponseObject<T>
    {
        public int code { get; set; }
        public bool result { get; set; }
        public string msg { get; set; }
        public int count { get; set; }
        public List<T> data { get; set; }
    }
}
