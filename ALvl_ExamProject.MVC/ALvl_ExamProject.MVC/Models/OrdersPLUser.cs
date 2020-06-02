using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ALvl_ExamProject.MVC.Models
{
    public class OrdersPLUser
    {
        [DisplayName("Order Number ")]
        public int OrderNumber { get; set; }

        public decimal Total { get; set; }

        public Dictionary<string, int> UserOrderHistory { get; set; }

        [DisplayName("Order date")]
        public DateTime OrderDate { get; set; }
    }
}