using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.Entity.Concrete
{
    public class Category
    {

        //internal bulundugu katmandan erişim saglanıyor.
        //protected -->miras alınan sınıflardan erişim saglanıyor.
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }

    }
}
