using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Models;

namespace BlazorApp1.Pages
{
    public partial class Index : ComponentBase
    {
        public Master Master { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            Master = new Master { MyProperty = "Master Property" , 
                DetailList = new List<Detail>
                {
                    new Detail{MyProperty="Detail Property 1"},
                    new Detail{MyProperty="Detail Property 2"},
                    new Detail{MyProperty="Detail Property 3"}
                }
            };
        }

        void HandleValidSubmit() { }
    }
}
