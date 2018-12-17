using System.Collections.Generic;
using System.Linq;

namespace Krd1.Models
{
    public class BeerRecipeRepository
    {
        public static BeerRecipeRepository Current = new BeerRecipeRepository();
        
        private static List<Yeast> _yeasts = new List<Yeast>()
        {
            new Yeast(){Id=1, Name = "Mangrove Jackss M44 West Coast"},
            new Yeast(){Id=2, Name = "Fermentis US05"}
        };

        private static List<Malt> _malts = new List<Malt>()
        {
            new Malt() {Id = 1, Name = "Pale Ale"},
            new Malt() {Id = 2, Name = "Monachijski"},
            new Malt() {Id = 3, Name = "Coffee"},
            new Malt() {Id = 4, Name = "Karmelowy"},
            new Malt() {Id = 5, Name = "Chocolate"},
            new Malt() {Id = 6, Name = "Cara Light"}
        };

        private static List<Hop> _hops = new List<Hop>()
        {
            new Hop() {Id = 1, Name = "Simcoe"},
            new Hop() {Id = 2, Name = "Phoenix"},
            new Hop() {Id = 3, Name = "Progress"}
        };

        private static List<BeerRecipe> _beerRecipes = new List<BeerRecipe>()
        {
            new BeerRecipe()
            {
                Id = 1,
                AmountOfWater = 25,
                Name = "American Stout",
                Yeast = _yeasts.Single(x => x.Id == 1),
                HopAmounts = new List<HopAmount>()
                {
                    new HopAmount() {Amount = 50, BeerId = 1, Hop = _hops.Single(x => x.Id == 1)}
                },
                MaltAmounts = new List<MaltAmount>()
                {
                    new MaltAmount() {BeerId = 1, Amount = 2.7M, Malt = _malts.Single(x => x.Id == 1)},
                    new MaltAmount() {BeerId = 1, Amount = 1M, Malt = _malts.Single(x => x.Id == 2)},
                    new MaltAmount() {BeerId = 1, Amount = 0.5M, Malt = _malts.Single(x => x.Id == 3)},
                    new MaltAmount() {BeerId = 1, Amount = 0.3M, Malt = _malts.Single(x => x.Id == 4)},
                    new MaltAmount() {BeerId = 1, Amount = 0.25M, Malt = _malts.Single(x => x.Id == 5)}                    
                },
                Recipe = "68st 45min, 72st 10min, gotowanie 1h, wysładzać 20 litrami wody 80 stopni."
            },
            new BeerRecipe()
            {
                Id = 2,
                AmountOfWater = 20,
                Name = "Pale Ale",
                Yeast = _yeasts.Single(x => x.Id == 2),
                HopAmounts = new List<HopAmount>()
                {
                    new HopAmount() {Amount = 30, BeerId = 2, Hop = _hops.Single(x => x.Id == 2)},
                    new HopAmount() {Amount = 40, BeerId = 2, Hop = _hops.Single(x => x.Id == 3)}
                },
                MaltAmounts = new List<MaltAmount>()
                {
                    new MaltAmount() {BeerId = 2, Amount = 3.2M, Malt = _malts.Single(x => x.Id == 1)},
                    new MaltAmount() {BeerId = 2, Amount = 0.6M, Malt = _malts.Single(x => x.Id == 2)},                    
                    new MaltAmount() {BeerId = 2, Amount = 0.20M, Malt = _malts.Single(x => x.Id == 6)}
                },
                Recipe = "68st 50min, 78st 10min, gotowanie 50min, wysładzać 12 litrami wody 60 stopni, chmiele dodawać po burzliwej fermentacji."
            },
        };

        public IEnumerable<BeerRecipe> GetAllRecipes()
        {
            return _beerRecipes;
        }

        public IEnumerable<Yeast> GetAllYeasts()
        {
            return _yeasts;
        }

        public IEnumerable<Malt> GetAllMalts()
        {
            return _malts;
        }


        public IEnumerable<Hop> GetAllHops()
        {
            return _hops;
        }

        public BeerRecipe GetBeerRecipe(int id)
        {
            return _beerRecipes.Single(x => x.Id == id);
        }

        public Yeast GetYeast(int id)
        {
            return _yeasts.Single(x => x.Id == id);
        }

        public Malt GetMalt(int id)
        {
            return _malts.Single(x => x.Id == id);
        }

        public Hop GetHop(int id)
        {
            return _hops.Single(x => x.Id == id);
        }

        public void AddBeerRecipe(BeerRecipe recipe)
        {
            recipe.Id = _beerRecipes.Max(x => x.Id) + 1;
            _beerRecipes.Add(recipe);
        }

        public void AddYeast(Yeast yeast)
        {
            yeast.Id = _yeasts.Max(x => x.Id) + 1;
            _yeasts.Add(yeast);
        }

        public void AddMalt(Malt malt)
        {
            malt.Id = _malts.Max(x => x.Id) + 1;
            _malts.Add(malt);
        }

        public void AddHop(Hop hop)
        {
            hop.Id = _hops.Max(x => x.Id) + 1;
            _hops.Add(hop);
        }
        
    }
}