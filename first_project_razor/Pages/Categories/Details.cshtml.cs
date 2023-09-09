using first_project_razor.Data;
using first_project_razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace first_project_razor.Pages.Categories
{
    [BindProperties]
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category{ get; set; }
        public DetailsModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            Category = _db.Categories.Find(id);
        }
    }
}
