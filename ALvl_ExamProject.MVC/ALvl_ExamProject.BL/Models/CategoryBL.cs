using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALvl_ExamProject.BL.Models
{
    public class CategoryBL
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public int Sorting { get; set; }

        public ICollection<ProductBL> ProductsBL { get; set; }
    }
}
