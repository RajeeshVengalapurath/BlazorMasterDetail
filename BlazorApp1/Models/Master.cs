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
        decimal _net = 0;
        public int BillNo { get; set; }
        public bool Taxable { get; set; }
        public string Remarks { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        [DecimalMinValueValidator(MinValue = 0)]
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public List<Detail> DetailList { get; set; } = new List<Detail>();
        public decimal Net { get => _net; set => _net = value; }

        public void AddNewDetailRow()
        {
            var detail = new Detail();
            detail.PropertyChanged += Detail_PropertyChanged;
            DetailList.Add(detail);
        }

        private void Detail_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            _net = DetailList.Sum(e => e.Total);
        }
    }
}
