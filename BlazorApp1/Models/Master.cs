using BlazorApp1.CustomValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Master
    {
        public int BillNo { get; set; }
        public bool Taxable { get; set; }
        public string Remarks { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public decimal Net { get; set; }
        [DecimalMinValueValidator(MinValue = 0)]
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public List<Detail> DetailList { get; set; }
    }
}
