using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data;
using RecipeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RecipeApp.Controllers
{
    [Authorize]
    public class FavoritesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FavoritesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(await _db.Favorites.Where(n => n.UserId.Equals(userId)).ToListAsync());
        }

        public string GetUser()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = User.FindFirstValue(ClaimTypes.Name);

            return userId + " " + userName ;
        }

        public async Task<IActionResult> AddFavorite(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (_db.Favorites.Any(f => f.RecipeId == id.ToString()))
            {
                ViewBag.resulttext = "Error: Already Favorited";
                return View();
            }
            else
            {
                Favorites favorite = new Favorites();
                Recipes recipe = _db.Recipes.Find(id);
                
                favorite.UserId = userId;
                favorite.RecipeId = id.ToString();              
                favorite.RecipeName = recipe.Name;
                

                _db.Add(favorite);
                await _db.SaveChangesAsync();

                ViewBag.resulttext = "Successfully Favorited";
                return View();
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            var favorite = await _db.Favorites.FindAsync(id);
            _db.Favorites.Remove(favorite);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }

    
}
