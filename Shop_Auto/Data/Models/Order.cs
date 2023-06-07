using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop_Auto.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
