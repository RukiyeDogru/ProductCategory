using System;
using System.Collections.Generic;
using System.Text;

namespace P.C.Inftra.Entities.Concrete
{
   public class Product:SubCategory
    {
        public string ProductName { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public double fiyat { get; set; }
        public int adet { get; set; }
         public SubCategory SubCategory { get; set; }
    }
}
