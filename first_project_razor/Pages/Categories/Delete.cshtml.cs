using first_project_razor.Data;
using first_project_razor.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace first_project_razor.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
                Category = _db.Categories.Find(id);
            }   
        }
        public IActionResult OnPost() {
            Category? obj = _db.Categories.Find(Category.Id);
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            return RedirectToPage("/categories/index");
        }
    }
}
