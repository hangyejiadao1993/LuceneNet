using Microsoft.AspNetCore.Mvc;
using NCL.Entity;
using NCL.LuceneService;

namespace NCL.WebApp.Controllers
{
    public class CategoryController:Controller
    {
        public IActionResult Add(Category category)
        {
            
            
            
            CategoryLucenService service=new CategoryLucenService();
            
            return Ok("");
        }
    }
}