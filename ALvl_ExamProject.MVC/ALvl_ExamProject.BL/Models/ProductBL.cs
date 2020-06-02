using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALvl_ExamProject.BL.Models
{
    public class ProductBL
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public string Slug { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public CategoryBL CategoryBL { get; set; }
    }
}
