using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data;
using RecipeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Controllers
{
    public class RecipeOperationsController : Controller
    {
        readonly ApplicationDbContext _db;
        public RecipeOperationsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListAll()
        {
            IEnumerable<Recipes> recipes = _db.Recipes;
            return View(recipes);
        }

        public IActionResult Details(int id)
        {
            var recipe = _db.Recipes.Find(id);
            return View(recipe);
        }

        public IActionResult Search()
        {

            return View();
        }

        public IActionResult SearchByName(string searchPharse)
        {

            return View();
        }
        public async Task<IActionResult> SearchResults(string SearchPhrase)
        {

            return View(await _db.Recipes.Where(n => n.Name.Contains(SearchPhrase)).ToListAsync());
        }

        public IActionResult SearchByIng()
        {

            return View();
        }

        public async Task<IActionResult> SearchResultsIng(
            bool I1 , bool I2 , bool I3 , bool I4 , bool I5 , bool I6 , bool I7 , bool I8 , bool I9 , bool I10,
            bool I11, bool I12, bool I13, bool I14, bool I15, bool I16, bool I17, bool I18, bool I19, bool I20,
            bool I21, bool I22, bool I23, bool I24, bool I25, bool I26, bool I27, bool I28, bool I29, bool I30,
            bool I31, bool I32, bool I33, bool I34, bool I35, bool I36, bool I37, bool I38, bool I39, bool I40,
            bool I41, bool I42, bool I43, bool I44, bool I45, bool I46, bool I47, bool I48, bool I49, bool I50,
            bool I51, bool I52, bool I53, bool I54, bool I55, bool I56, bool I57, bool I58, bool I59, bool I60,
            bool I61, bool I62, bool I63, bool I64, bool I65, bool I66, bool I67, bool I68, bool I69, bool I70,
            bool I71, bool I72, bool I73, bool I74, bool I75, bool I76, bool I77, bool I78, bool I79, bool I80,
            bool I81, bool I82, bool I83, bool I84, bool I85, bool I86, bool I87, bool I88, bool I89, bool I90,
            bool I91, bool I92, bool I93, bool I94, bool I95, bool I96, bool I97, bool I98, bool I99, bool I100
            )
        {
            
            return View(await _db.Recipes.Where(n =>
            n.Ing001.Equals(I1 ) && n.Ing002.Equals(I2 ) && n.Ing003.Equals(I3 ) && n.Ing004.Equals(I4 ) && n.Ing005.Equals(I5 ) &&
            n.Ing006.Equals(I6 ) && n.Ing007.Equals(I7 ) && n.Ing008.Equals(I8 ) && n.Ing009.Equals(I9 ) && n.Ing010.Equals(I10) &&
            n.Ing011.Equals(I11) && n.Ing012.Equals(I12) && n.Ing013.Equals(I13) && n.Ing014.Equals(I14) && n.Ing015.Equals(I15) &&
            n.Ing016.Equals(I16) && n.Ing017.Equals(I17) && n.Ing018.Equals(I18) && n.Ing019.Equals(I19) && n.Ing020.Equals(I20) &&

            n.Ing021.Equals(I21) && n.Ing022.Equals(I22) && n.Ing023.Equals(I23) && n.Ing024.Equals(I24) && n.Ing025.Equals(I25) &&
            n.Ing026.Equals(I26) && n.Ing027.Equals(I27) && n.Ing028.Equals(I28) && n.Ing029.Equals(I29) && n.Ing030.Equals(I30) &&
            n.Ing031.Equals(I31) && n.Ing032.Equals(I32) && n.Ing033.Equals(I33) && n.Ing034.Equals(I34) && n.Ing035.Equals(I35) &&
            n.Ing036.Equals(I36) && n.Ing037.Equals(I37) && n.Ing038.Equals(I38) && n.Ing039.Equals(I39) && n.Ing040.Equals(I40) &&

            n.Ing041.Equals(I41) && n.Ing042.Equals(I42) && n.Ing043.Equals(I43) && n.Ing044.Equals(I44) && n.Ing045.Equals(I45) &&
            n.Ing046.Equals(I46) && n.Ing047.Equals(I47) && n.Ing048.Equals(I48) && n.Ing049.Equals(I49) && n.Ing050.Equals(I50) &&
            n.Ing051.Equals(I51) && n.Ing052.Equals(I52) && n.Ing053.Equals(I53) && n.Ing054.Equals(I54) && n.Ing055.Equals(I55) &&
            n.Ing056.Equals(I56) && n.Ing057.Equals(I57) && n.Ing058.Equals(I58) && n.Ing059.Equals(I59) && n.Ing060.Equals(I60) &&

            n.Ing061.Equals(I61) && n.Ing062.Equals(I62) && n.Ing063.Equals(I63) && n.Ing064.Equals(I64) && n.Ing065.Equals(I65) &&
            n.Ing066.Equals(I66) && n.Ing067.Equals(I67) && n.Ing068.Equals(I68) && n.Ing069.Equals(I69) && n.Ing070.Equals(I70) &&
            n.Ing071.Equals(I71) && n.Ing072.Equals(I72) && n.Ing073.Equals(I73) && n.Ing074.Equals(I74) && n.Ing075.Equals(I75) &&
            n.Ing076.Equals(I76) && n.Ing077.Equals(I77) && n.Ing078.Equals(I78) && n.Ing079.Equals(I79) && n.Ing080.Equals(I40) &&

            n.Ing081.Equals(I81) && n.Ing082.Equals(I82) && n.Ing083.Equals(I83) && n.Ing084.Equals(I84) && n.Ing085.Equals(I85) &&
            n.Ing086.Equals(I86) && n.Ing087.Equals(I87) && n.Ing088.Equals(I88) && n.Ing089.Equals(I89) && n.Ing090.Equals(I90) &&
            n.Ing091.Equals(I91) && n.Ing092.Equals(I92) && n.Ing093.Equals(I93) && n.Ing094.Equals(I94) && n.Ing095.Equals(I95) &&
            n.Ing096.Equals(I96) && n.Ing097.Equals(I97) && n.Ing098.Equals(I98) && n.Ing099.Equals(I99) && n.Ing100.Equals(I100)


            ).ToListAsync());
        }
        public IActionResult SearchByIngIncludes()
        {

            return View();

        }
        public async Task<IActionResult> SearchResultsIngIncludes(
            bool I1, bool I2, bool I3, bool I4, bool I5, bool I6, bool I7, bool I8, bool I9, bool I10,
            bool I11, bool I12, bool I13, bool I14, bool I15, bool I16, bool I17, bool I18, bool I19, bool I20,
            bool I21, bool I22, bool I23, bool I24, bool I25, bool I26, bool I27, bool I28, bool I29, bool I30,
            bool I31, bool I32, bool I33, bool I34, bool I35, bool I36, bool I37, bool I38, bool I39, bool I40,
            bool I41, bool I42, bool I43, bool I44, bool I45, bool I46, bool I47, bool I48, bool I49, bool I50,
            bool I51, bool I52, bool I53, bool I54, bool I55, bool I56, bool I57, bool I58, bool I59, bool I60,
            bool I61, bool I62, bool I63, bool I64, bool I65, bool I66, bool I67, bool I68, bool I69, bool I70,
            bool I71, bool I72, bool I73, bool I74, bool I75, bool I76, bool I77, bool I78, bool I79, bool I80,
            bool I81, bool I82, bool I83, bool I84, bool I85, bool I86, bool I87, bool I88, bool I89, bool I90,
            bool I91, bool I92, bool I93, bool I94, bool I95, bool I96, bool I97, bool I98, bool I99, bool I100
            )
        {
            return View(await _db.Recipes.Where(n =>
            (n.Ing001 & I1 ) || ( n.Ing002 & I2 ) || ( n.Ing003 & I3 ) || ( n.Ing004 & I4 ) || ( n.Ing005 & I5 ) || 
            (n.Ing006 & I6 ) || ( n.Ing007 & I7 ) || ( n.Ing008 & I8 ) || ( n.Ing009 & I9 ) || ( n.Ing010 & I10) || 
            (n.Ing011 & I11) || ( n.Ing012 & I12) || ( n.Ing013 & I13) || ( n.Ing014 & I14) || ( n.Ing015 & I15) || 
            (n.Ing016 & I16) || ( n.Ing017 & I17) || ( n.Ing018 & I18) || ( n.Ing019 & I19) || ( n.Ing020 & I20) || 

            (n.Ing021 & I21) || ( n.Ing022 & I22) || ( n.Ing023 & I23) || ( n.Ing024 & I24) || ( n.Ing025 & I25) || 
            (n.Ing026 & I26) || ( n.Ing027 & I27) || ( n.Ing028 & I28) || ( n.Ing029 & I29) || ( n.Ing030 & I30) || 
            (n.Ing031 & I31) || ( n.Ing032 & I32) || ( n.Ing033 & I33) || ( n.Ing034 & I34) || ( n.Ing035 & I35) || 
            (n.Ing036 & I36) || ( n.Ing037 & I37) || ( n.Ing038 & I38) || ( n.Ing039 & I39) || ( n.Ing040 & I40) || 

            (n.Ing041 & I41) || ( n.Ing042 & I42) || ( n.Ing043 & I43) || ( n.Ing044 & I44) || ( n.Ing045 & I45) || 
            (n.Ing046 & I46) || ( n.Ing047 & I47) || ( n.Ing048 & I48) || ( n.Ing049 & I49) || ( n.Ing050 & I50) || 
            (n.Ing051 & I51) || ( n.Ing052 & I52) || ( n.Ing053 & I53) || ( n.Ing054 & I54) || ( n.Ing055 & I55) || 
            (n.Ing056 & I56) || ( n.Ing057 & I57) || ( n.Ing058 & I58) || ( n.Ing059 & I59) || ( n.Ing060 & I60) || 

            (n.Ing061 & I61) || ( n.Ing062 & I62) || ( n.Ing063 & I63) || ( n.Ing064 & I64) || ( n.Ing065 & I65) || 
            (n.Ing066 & I66) || ( n.Ing067 & I67) || ( n.Ing068 & I68) || ( n.Ing069 & I69) || ( n.Ing070 & I70) || 
            (n.Ing071 & I71) || ( n.Ing072 & I72) || ( n.Ing073 & I73) || ( n.Ing074 & I74) || ( n.Ing075 & I75) || 
            (n.Ing076 & I76) || ( n.Ing077 & I77) || ( n.Ing078 & I78) || ( n.Ing079 & I79) || ( n.Ing080 & I40) || 

            (n.Ing081 & I81) || ( n.Ing082 & I82) || ( n.Ing083 & I83) || ( n.Ing084 & I84) || ( n.Ing085 & I85) || 
            (n.Ing086 & I86) || ( n.Ing087 & I87) || ( n.Ing088 & I88) || ( n.Ing089 & I89) || ( n.Ing090 & I90) || 
            (n.Ing091 & I91) || ( n.Ing092 & I92) || ( n.Ing093 & I93) || ( n.Ing094 & I94) || ( n.Ing095 & I95) || 
            (n.Ing096 & I96) || ( n.Ing097 & I97) || ( n.Ing098 & I98) || ( n.Ing099 & I99) || ( n.Ing100 & I100)


            ).ToListAsync());
        }

    }   
}
