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

            Master = new Master {  
                DetailList = new List<Detail>
                {
                    new Detail{ },
                }
            };
        }

        void HandleValidSubmit() { }
        void AddNewRow()
        {
            Master.DetailList.Add(new Detail());
        }
    }
}
