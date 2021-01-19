using E_CommerceMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_CommerceMVC.web.Areas.Dashboard.ViewModels
{
    public class CategoryActionViewModels
    {
        public Category Category { get; set; }
        public int? ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}