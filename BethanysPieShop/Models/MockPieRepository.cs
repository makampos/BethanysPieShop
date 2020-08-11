using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private  readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies => new List<Pie>
        {
            new Pie{ PieId = 1,
                Name = "Strawberry Pie", 
                Price = 15.95M,
                CategoryId = 1,
                ShortDescription = "Lorem ", 
                LongDescription = "Lorem ipsum" },
            
            new Pie{ PieId = 2,
                Name = "Xambras", 
                Price = 15.95M,
                CategoryId = 3,
                ShortDescription = "Lorem ", 
                LongDescription = "Lorem ipsum" }
            
            
        };

        public IEnumerable<Pie> PiesOfWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }

    }
}