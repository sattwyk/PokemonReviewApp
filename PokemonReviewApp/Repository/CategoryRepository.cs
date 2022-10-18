using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    //repository just another word for where to hold data calls
    //best to keep separate files because numerous users could be working on 
    //context is just the code that sits on top of the database and gives access to the db
    public class CategoryRepository : ICategoryRepository
    {
        private DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context; 
        }
        public bool CategoryExists(int id)
        {
            //Any is a bool condition, runs a conditional on each iteration
            //and checks if at any point does the condition match
            return _context.Categories.Any(c => c.Id == id); 
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            //if only returning 1 element need first or default to return only the 1
            return _context.Categories.Where(e => e.Id == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
            return _context.PokemonCategories.Where(e => e.CategoryId == categoryId).Select(c => c.Pokemon).ToList();
        }
    }
}
