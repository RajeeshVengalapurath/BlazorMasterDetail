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
            Master.Products = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("Product1", 1),
                new KeyValuePair<string, int>("Product2", 2),
                new KeyValuePair<string, int>("Product3", 3)
            };
            Master.AddNewDetailRow();
        }

        void HandleValidSubmit() { }
        void AddNewRow()
        {
            Master.AddNewDetailRow();
        }
    }
}
