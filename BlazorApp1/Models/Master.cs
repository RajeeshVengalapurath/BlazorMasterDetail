using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Master
    {
        public string MyProperty { get; set; }
        public List<Detail> DetailList { get; set; }
    }
}
