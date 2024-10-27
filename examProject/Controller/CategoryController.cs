using examProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examProject.Controller
{
    internal class CategoryController
    {

        private List<Category> CategoryList = new List<Category>();

        public void AddCategory(Category category)
        {
            CategoryList.Add(category);
            Console.WriteLine("Category added successfully!");
        }

        public void DeleteCategory(Category category)
        {
            CategoryList.Remove(category);
            Console.WriteLine("Category deleted successfully!");
        }

        public void ShowAllCategories()
        {
            foreach (var category in CategoryList)
            {
                Console.WriteLine(category.Name);
            }
        }

        public List<Questions>? GetQuestionsByCategory(string categoryName)
        {
            var category = CategoryList.FirstOrDefault(c => c.Name == categoryName);
            return category?.Questions;
        }

    }
}
