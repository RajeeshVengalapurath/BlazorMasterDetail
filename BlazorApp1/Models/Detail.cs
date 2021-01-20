using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Detail
    {
        int _productId;
        string _quantity = "0.00";
        string _rate = "0.00";
        string _total = "0.00";

        public int ProductId { get { return _productId; } set { _productId = value; } }
        [GreaterThanDecimal(0)]
        public string Quantity { get { return _quantity; }
            set
            {
                _quantity = value;
                _total = (Convert.ToDecimal(_quantity) * Convert.ToDecimal(_rate)).ToString("#.00");
            } }
        public string Rate
        {
            get { return _rate; }
            set
            {
                _rate = value;
                _total = (Convert.ToDecimal(_quantity) * Convert.ToDecimal(_rate)).ToString("#.00");
            }
        }
        public string Total { get { return _total; } set { _total = value; } }
        [Required]
        public string Name { get; set; }
    }

    public class GreaterThanDecimalAttribute : ValidationAttribute
    {
        private readonly decimal _val;


        public GreaterThanDecimalAttribute(double val) //double: decimal is not supported by CLR.
        {
            _val = (decimal)val;
        }

        public override bool IsValid(object value)
        {
            if (value == null) return false;
            return Convert.ToDecimal(value) > _val;
        }
    }
}
