using Shop_Auto.Data.interfaces;
using Shop_Auto.Data.Models;
using System.Collections.Generic;

namespace Shop_Auto.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {

        private readonly AppDbContent appDbContent;
        public CategoryRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Category> AllCategories => appDbContent.Category;
    }
}
