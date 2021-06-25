using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Models
{
    public class Recipes
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Recipe Name")]
        public string Name { get; set; }

        [Display(Name = "Details About the Recipe")]
        public string Details { get; set; }

        [Display(Name = "Link to the Recipe")]
        public string Url { get; set; }

        //The Ingredients Start Here

        [Display(Name = "bacon")]
        public bool Ing001 { get; set; } = false;

        [Display(Name = "basil, dried")]
        public bool Ing002 { get; set; } = false;

        [Display(Name = "beef, ground")]
        public bool Ing003 { get; set; } = false;

        [Display(Name = "bell pepper, green")]
        public bool Ing004 { get; set; } = false;

        [Display(Name = "bell pepper, red")]
        public bool Ing005 { get; set; } = false;

        [Display(Name = "bread, french")]
        public bool Ing006 { get; set; } = false;

        [Display(Name = "bread, italian")]
        public bool Ing007 { get; set; } = false;

        [Display(Name = "bread, white")]
        public bool Ing008 { get; set; } = false;

        [Display(Name = "broth, beef")]
        public bool Ing009 { get; set; } = false;

        [Display(Name = "broth, chicken")]
        public bool Ing010 { get; set; } = false;

        //First 10 Over

        [Display(Name = "buns, hot-dog")]
        public bool Ing011 { get; set; } = false;

        [Display(Name = "butter")]
        public bool Ing012 { get; set; } = false;

        [Display(Name = "capers")]
        public bool Ing013 { get; set; } = false;

        [Display(Name = "cheese, cheddar")]
        public bool Ing014 { get; set; } = false;

        [Display(Name = "Cheese, Mexican blend")]
        public bool Ing015 { get; set; } = false;

        [Display(Name = "cheese, mozarella")]
        public bool Ing016 { get; set; } = false;

        [Display(Name = "cheese, parmesan")]
        public bool Ing017 { get; set; } = false;

        [Display(Name = "cheese, pecorino romano")]
        public bool Ing018 { get; set; } = false;

        [Display(Name = "cheese, red leicester")]
        public bool Ing019 { get; set; } = false;

        [Display(Name = "cheese, ricotta")]
        public bool Ing020 { get; set; } = false;

        //First 20 Over

        [Display(Name = "chicken breasts")]
        public bool Ing021 { get; set; } = false;

        [Display(Name = "chicken thighs")]
        public bool Ing022 { get; set; } = false;

        [Display(Name = "chicken, whole")]
        public bool Ing023 { get; set; } = false;

        [Display(Name = "cilantro")]
        public bool Ing024 { get; set; } = false;

        [Display(Name = "cod loin")]
        public bool Ing025 { get; set; } = false;

        [Display(Name = "cooking sherry")]
        public bool Ing026 { get; set; } = false;

        [Display(Name = "cooking spray")]
        public bool Ing027 { get; set; } = false;

        [Display(Name = "coriander")]
        public bool Ing028 { get; set; } = false;

        [Display(Name = "cornstarch")]
        public bool Ing029 { get; set; } = false;

        [Display(Name = "crackers, buttery")]
        public bool Ing030 { get; set; } = false;

        //First 30 Over

        [Display(Name = "crackers, cheese")]
        public bool Ing031 { get; set; } = false;

        [Display(Name = "cream, coconut")]
        public bool Ing032 { get; set; } = false;

        [Display(Name = "egg")]
        public bool Ing033 { get; set; } = false;

        [Display(Name = "flatbreads")]
        public bool Ing034 { get; set; } = false;

        [Display(Name = "flour")]
        public bool Ing035 { get; set; } = false;

        [Display(Name = "garlic")]
        public bool Ing036 { get; set; } = false;

        [Display(Name = "honey")]
        public bool Ing037 { get; set; } = false;

        [Display(Name = "ketchup")]
        public bool Ing038 { get; set; } = false;

        [Display(Name = "lemon")]
        public bool Ing039 { get; set; } = false;

        [Display(Name = "lentils")]
        public bool Ing040 { get; set; } = false;

        //First 40 Over

        [Display(Name = "lettuce")]
        public bool Ing041 { get; set; } = false;

        [Display(Name = "margarine")]
        public bool Ing042 { get; set; } = false;

        [Display(Name = "mayonnaise")]
        public bool Ing043 { get; set; } = false;

        [Display(Name = "milk, whole")]
        public bool Ing044 { get; set; } = false;

        [Display(Name = "mustard powder")]
        public bool Ing045 { get; set; } = false;

        [Display(Name = "noodles, lasagna")]
        public bool Ing046 { get; set; } = false;

        [Display(Name = "noodles, rice")]
        public bool Ing047 { get; set; } = false;

        [Display(Name = "noodles, rice vermicelli")]
        public bool Ing048 { get; set; } = false;

        [Display(Name = "oil, coconut")]
        public bool Ing049 { get; set; } = false;

        [Display(Name = "oil, olive")]
        public bool Ing050 { get; set; } = false;

        //First 50 Over

        [Display(Name = "oil, sesame")]
        public bool Ing051 { get; set; } = false;

        [Display(Name = "oil, vegetable")]
        public bool Ing052 { get; set; } = false;

        [Display(Name = "olives, black")]
        public bool Ing053 { get; set; } = false;

        [Display(Name = "onion")]
        public bool Ing054 { get; set; } = false;

        [Display(Name = "onion, green")]
        public bool Ing055 { get; set; } = false;

        [Display(Name = "onion, red")]
        public bool Ing056 { get; set; } = false;

        [Display(Name = "oregano, dried ")]
        public bool Ing057 { get; set; } = false;

        [Display(Name = "paprika")]
        public bool Ing058 { get; set; } = false;

        [Display(Name = "parsley, fresh")]
        public bool Ing059 { get; set; } = false;

        [Display(Name = "pasta, elbow macaroni")]
        public bool Ing060 { get; set; } = false;

        //First 60 Over

        [Display(Name = "pasta, rigatoni")]
        public bool Ing061 { get; set; } = false;

        [Display(Name = "pasta, spaghetti")]
        public bool Ing062 { get; set; } = false;

        [Display(Name = "peanuts")]
        public bool Ing063 { get; set; } = false;

        [Display(Name = "pepper")]
        public bool Ing064 { get; set; } = false;

        [Display(Name = "pepper, cayenne")]
        public bool Ing065 { get; set; } = false;

        [Display(Name = "pepper, lemon")]
        public bool Ing066 { get; set; } = false;

        [Display(Name = "peppercorns, whole")]
        public bool Ing067 { get; set; } = false;

        [Display(Name = "powder, baking")]
        public bool Ing068 { get; set; } = false;

        [Display(Name = "powder, garlic")]
        public bool Ing069 { get; set; } = false;

        [Display(Name = "powder, onion")]
        public bool Ing070 { get; set; } = false;

        //First 70 Over

        [Display(Name = "rice, converted")]
        public bool Ing071 { get; set; } = false;

        [Display(Name = "salmon, canned")]
        public bool Ing072 { get; set; } = false;

        [Display(Name = "salt")]
        public bool Ing073 { get; set; } = false;

        [Display(Name = "sauce, bbq (barbeque)")]
        public bool Ing074 { get; set; } = false;

        [Display(Name = "sauce, fish")]
        public bool Ing075 { get; set; } = false;

        [Display(Name = "sauce, green chile enchilada")]
        public bool Ing076 { get; set; } = false;

        [Display(Name = "sauce, marinara ")]
        public bool Ing077 { get; set; } = false;

        [Display(Name = "sauce, soy")]
        public bool Ing078 { get; set; } = false;

        [Display(Name = "sauce, sriracha")]
        public bool Ing079 { get; set; } = false;

        [Display(Name = "sauce, thai curry")]
        public bool Ing080 { get; set; } = false;

        //First 80 Over

        [Display(Name = "sauce, worcestershire")]
        public bool Ing081 { get; set; } = false;

        [Display(Name = "sausage")]
        public bool Ing082 { get; set; } = false;

        [Display(Name = "seasoning, italian")]
        public bool Ing083 { get; set; } = false;

        [Display(Name = "seasoning, taco")]
        public bool Ing084 { get; set; } = false;

        [Display(Name = "seeds, sesame")]
        public bool Ing085 { get; set; } = false;

        [Display(Name = "spinach")]
        public bool Ing086 { get; set; } = false;

        [Display(Name = "sugar, brown")]
        public bool Ing087 { get; set; } = false;

        [Display(Name = "sugar, white")]
        public bool Ing088 { get; set; } = false;

        [Display(Name = "tarragon, dried")]
        public bool Ing089 { get; set; } = false;

        [Display(Name = "thyme, dried")]
        public bool Ing090 { get; set; } = false;

        //First 90 Over

        [Display(Name = "tomato, paste")]
        public bool Ing091 { get; set; } = false;

        [Display(Name = "tomatoes, crushed")]
        public bool Ing092 { get; set; } = false;

        [Display(Name = "tomatoes, diced")]
        public bool Ing093 { get; set; } = false;

        [Display(Name = "tortillas, corn")]
        public bool Ing094 { get; set; } = false;

        [Display(Name = "trout, speckled")]
        public bool Ing095 { get; set; } = false;

        [Display(Name = "tuna, ahi steaks")]
        public bool Ing096 { get; set; } = false;

        [Display(Name = "vinegar, rice")]
        public bool Ing097 { get; set; } = false;

        [Display(Name = "water")]
        public bool Ing098 { get; set; } = false;

        [Display(Name = "wine, white")]
        public bool Ing099 { get; set; } = false;

        [Display(Name = "zucchini")]
        public bool Ing100 { get; set; } = false;

        //First 100 Over
        public Recipes()
        {

        }
    }
}
