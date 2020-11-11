using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodPortalMVCProject.Models
{
    public class Foods
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string OrderName { get; set; }

        public float Price { get; set; }
    }
}