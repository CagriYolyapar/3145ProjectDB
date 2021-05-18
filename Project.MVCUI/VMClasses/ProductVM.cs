using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.VMClasses
{
    public class ProductVM //PAVM ile aynı şekilde acılmıstır. Aslında aynı görevleri yapıyor gibi gözükmektedirler. Fakat PAVM ek olarak alışveriş tarafında Pagination işlemlerini de yapacak bir Pagination tipi tutacaktır...Admin icin böyle bir tipe ihtiyaç yoktur. Çünkü zaten Admin'in kullandığı Template'te bu işlemler hazır yapılmıştır...
    {
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }

    }
}