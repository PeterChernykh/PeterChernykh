using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALvl_ExamProject.MVC.Models
{
    public class OrderPL
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}