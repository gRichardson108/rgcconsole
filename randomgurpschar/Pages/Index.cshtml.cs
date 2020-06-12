using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using rgcconsole;

namespace randomgurpschar.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// The point limit set
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int PointLimit { get; set; } = -1;

        /// <summary>
        /// The seed (optional) for generating the character.
        /// Reusing the same seed / pointlimit should result in the
        /// same character being generated.
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int Seed { get; set; } = -1;

        public Character Character { get; set; }

        public void OnGet()
        {
            if (Seed == -1)
            {
                Random random = new Random();
                Seed = random.Next();
            }
            
            if (PointLimit < 1)
            {
                PointLimit = 200;
            }

            Character = FantasyRandomizer.GenerateRandomCharacterWithSeed(PointLimit, Seed);
        }
    }
}
