using DataLibrary.Data;
using Microsoft.AspNetCore.Mvc;

namespace MvcDemoApp.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodData _foodData;

        public FoodController(IFoodData foodData)
        {
            _foodData = foodData;
        }
        // GET: FoodController
        public async Task<ActionResult> Index()
        {
            var food = await _foodData.GetFood();
            return View(food);
        }

    }
}
