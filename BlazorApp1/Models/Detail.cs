using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Detail : INotifyPropertyChanged
    {
        int _productId;
        decimal _quantity = 0;
        decimal _rate = 0;
        decimal _total = 0;

        public int ProductId { get { return _productId; } set { 
                _productId = value;
                OnPropertyChanged("product");
            } }
        [GreaterThanDecimal(0)]
        public decimal Quantity { get { return _quantity; }
            set
            {
                _quantity = value;
                _total = _quantity * _rate;
                OnPropertyChanged("quantity");
            } }
        public decimal Rate
        {
            get { return _rate; }
            set
            {
                _rate = value;
                _total = _quantity * _rate;
                OnPropertyChanged("rate");
            }
        }
        public decimal Total { get { return _total; } set { _total = value; } }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

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
