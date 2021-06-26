using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Models
{
    
    public class Favorites
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string RecipeId { get; set; }

        public string RecipeName { get; set; }

        public Favorites()
        {

        }
    }
}
