using first_project_razor.Data;
using first_project_razor.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace first_project_razor.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Category> CategoryList { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
