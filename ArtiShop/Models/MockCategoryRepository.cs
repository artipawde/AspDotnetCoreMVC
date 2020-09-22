using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtiShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategory =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit Pies", Descripation="All fruits pie"},
                new Category{CategoryId=2, CategoryName="Fruit Cakes", Descripation="All fruits cake"},
                new Category{CategoryId=3, CategoryName="Cheese pies", Descripation="All Cheese pie"},
                new Category{CategoryId=4, CategoryName="Chocolate Cake", Descripation="All Chocolate pie"}
            };
    }
}
