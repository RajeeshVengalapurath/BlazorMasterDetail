using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorApp1.Pages
{
    public partial class IndexBase : ComponentBase
    {
        public string Test { get; set; }
        public Master Master { get; set; }
        public InputText nameControl { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            Master = new Master();
            Master.Customers = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("Customer1" , 1),
                new KeyValuePair<string, int>("Customer2" , 2),
                new KeyValuePair<string, int>("Customer3" , 3)
            };
            Master.Products = BlazorApp1.Data.Product.GetAllProducts().Select(e => new KeyValuePair<string, int>(e.Name, e.Id)).ToList();
            Master.AddNewDetailRow();
            Master.DetailPropertyChanged += Master_DetailPropertyChanged;
        }

        private void Master_DetailPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            /*Get detail model on value change: Method2
            Can be used for on productId change on a particular row with detail.rowno = x
            Can avoid splitting the inputselect binding to free up OnChange event*/

            Detail detail = (Detail)sender;
            if (e.PropertyName == "product")
                detail.Rate = Data.Product.GetRate(detail.ProductId);
        }

        void HandleValidSubmit() { }
        void AddNewRow()
        {
            Master.AddNewDetailRow();
        }
        /*Get detail model on value change: Method1
        public void OnProductChange(int value, Detail detail)
        {
            detail.ProductId = value;
            Test = detail.ProductId.ToString() + " " + detail.Total.ToString();
        }*/
    }
}
