using BestStore.Data;
using BestStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BestStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;   //1. get the data from constructor to local variable so can use in action
        public CategoryController(ApplicationDbContext db)  // 2. constructor  parameter is from DI service in program.cs
        {
            _db = db;   
        }
        public IActionResult Index() //action method
        {
            List<Category> objCategoryList = _db.Categories.ToList();    //3. retrive category  assign to the var
            return View(objCategoryList);
        }
    }
}
