﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALvl_ExamProject.MVC.Models
{
    public class SidebarPL
    {
        public int Id { get; set; }

        [Required]
        public string Body { get; set; }
    }
}