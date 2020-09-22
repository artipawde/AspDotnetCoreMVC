using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtiShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie{PieId =1, Name="Cheese Cake", Price=720.50M, ShortDescription="Only Cheese", LongDescription="A cheesecake can be savory (and served with crackers as an appetizer), however, most of us think of the term as describing a luscious, rich and sweet dessert. The texture can vary greatly-from light and airy to dense and rich to smooth and creamy depending on the ingredients and mixing methods used.",Category = _categoryRepository.AllCategory.ToList()[2], ImageUrl="",InStock= true, IsPieOfTheWeek= false, ImageThumbnailUrl=""},
                new Pie{PieId =2, Name="Fruit Cake", Price=520.50M, ShortDescription="Only Fruits", LongDescription="A fruitcake is a cake that contains raisins, currants, and other dried fruit. 2. countable noun. If you refer to someone as a fruitcake, you mean that they are crazy or that their behavior is very strange.", Category = _categoryRepository.AllCategory.ToList()[1], ImageUrl="", InStock=true, IsPieOfTheWeek=true , ImageThumbnailUrl="" },
                new Pie{PieId =3, Name="Chocolate Pie", Price=240.50M, ShortDescription="Only Cheese", LongDescription="Pudding, or in this case, chocolate pie filling, only requires a few ingredients to make. We start with sugar, egg yolks (you can save the whites for an Angel Food cake or Funfetti cake!), cornstarch (to help firm up the chocolate pie and make it sliceable rather than soupy!), salt, milk, and heavy cream.", Category = _categoryRepository.AllCategory.ToList()[3], ImageUrl="", InStock= true, IsPieOfTheWeek= false, ImageThumbnailUrl="" },
                new Pie{PieId =4, Name="Chocolate Cake", Price=850.50M, ShortDescription="Only Chocolate", LongDescription="Chocolate cake is beloved for its deep, rich flavor. As such, be sure to use the highest quality cocoa you can find. The darker the hue of the cocoa, the more satisfying the chocolate flavor will be.", Category = _categoryRepository.AllCategory.ToList()[3], ImageUrl="", InStock = true, IsPieOfTheWeek= false, ImageThumbnailUrl="" }
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
