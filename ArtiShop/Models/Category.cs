using System.Collections.Generic;

namespace ArtiShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Descripation { get; set; }
        public List<Pie> Pies { get; set; }
    }
}