using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALvl_ExamProject.DAL.Models
{
    public class Page
    {
        public int Id { get; set; }
        
        public string Title { get; set; }

        public string Slug { get; set; }

        public string Body { get; set; }

        public int Sorting { get; set; }

        public bool Sidebar { get; set; }
    }
}
