using HealthyFoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyFoods.DAL
{
    public class HealthInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<HealthContext>
    {
        protected override void Seed(HealthContext context)
        {
            //var foods = new List<Food>
            //{
            //new Food{Group="Vegetables"},
            //new Food{Group="Fruits"},
            //new Food{Group="Nuts"},
            //new Food{Group="Beans"},
            //new Food{Group="Meet Fish Eggs"}
            //};
            //foods.ForEach(f => context.Foods.Add(f));
            //context.SaveChanges();

            //var vegetables = new List<Vegetable>
            //{
            //new Vegetable{Name="Broccoli",Protein=2.82 ,Carbohydrates=6.64, Fat=0.37, Energy=34.00},
            //new Vegetable{Name="Tomatos",Protein=0.88 ,Carbohydrates=3.89, Fat=0.20, Energy=18.00},
            //new Vegetable{Name="Carrot",Protein=0.93 ,Carbohydrates=9.58, Fat=0.24, Energy=41.00},
            //new Vegetable{Name="Beetroot",Protein=1.61 ,Carbohydrates=9.56, Fat=0.17, Energy=43.00},
            //new Vegetable{Name="Cabbage",Protein=1.28 ,Carbohydrates=5.80, Fat=0.10, Energy=25.00}
            //};
            //vegetables.ForEach(f => context.Vegetables.Add(f));
            //context.SaveChanges();

            //var fruits = new List<Fruit>
            //{
            //new Fruit{Name="Bananas",Protein=1.09 ,Carbohydrates=22.84, Fat=0.33, Energy=89.00},
            //new Fruit{Name="Grapefruit",Protein=0.63 ,Carbohydrates=8.08, Fat=0.10, Energy=32.00},
            //new Fruit{Name="Kiwi",Protein=1.14 ,Carbohydrates=14.66, Fat=0.52, Energy=61.00},
            //new Fruit{Name="Lemons",Protein=1.10 ,Carbohydrates=9.32, Fat=0.30, Energy=29.00},
            //new Fruit{Name="Watermelon",Protein=0.61 ,Carbohydrates=7.55, Fat=0.15, Energy=30.00},
            //new Fruit{Name="Mango",Protein=0.82 ,Carbohydrates=14.98, Fat=0.38, Energy=60.00}
            //};
            //fruits.ForEach(f => context.Fruits.Add(f));
            //context.SaveChanges();

            //var nuts = new List<Nut>
            //{
            //new Nut{Name="Almonds",Protein=21.15 ,Carbohydrates=21.55, Fat=49.93, Energy=579.00},
            //new Nut{Name="Cashew",Protein=18.22 ,Carbohydrates=30.19, Fat=43.85, Energy=553.00},
            //new Nut{Name="Hazelnut",Protein=14.95 ,Carbohydrates=16.70, Fat=60.75, Energy=628.00},
            //new Nut{Name="Walnut",Protein=15.23 ,Carbohydrates=13.71, Fat=65.21, Energy=654.00},
            //new Nut{Name="Pistachios",Protein=20.27 ,Carbohydrates=27.51, Fat=45.39, Energy=562.00},
            //new Nut{Name="Peanuts",Protein=25.80 ,Carbohydrates=16.13, Fat=49.24, Energy=567.00}
            //};
            //nuts.ForEach(f => context.Nuts.Add(f));
            //context.SaveChanges();

            //var beans = new List<Bean>
            //{
            //new Bean{Image="http://www.puls.bg/cache/news/21625_big.jpg", Name="Peas",Protein=23.82 ,Carbohydrates=63.74, Fat=1.16, Energy=352.00},
            //new Bean{Name="Lentils",Protein=23.91 ,Carbohydrates=63.10, Fat=2.17, Energy=358.00},
            //new Bean{Name="Beans",Protein=23.58 ,Carbohydrates=60.01, Fat=0.83, Energy=333.00}
            //};
            //beans.ForEach(f => context.Beans.Add(f));
            //context.SaveChanges();

            //var meatFishEggs = new List<MeatFishEgg>
            //{
            //new MeatFishEgg{Name="Chicken Fillet",Protein=18.77 ,Carbohydrates=0.00, Fat=17.07, Energy=234.00},
            //new MeatFishEgg{Name="Salmon",Protein=19.84 ,Carbohydrates=0.00, Fat=6.34, Energy=142.00},
            //new MeatFishEgg{Name="Eggs",Protein=12.56 ,Carbohydrates=0.72, Fat=9.51, Energy=143.00},
            //new MeatFishEgg{Name="Beef",Protein=21.85 ,Carbohydrates=0.00, Fat=2.90, Energy=114.00},
            //new MeatFishEgg{Name="Whitefish",Protein=19.09 ,Carbohydrates=0.00, Fat=5.86, Energy=134.00},
            //new MeatFishEgg{Name="Turkey Fillet",Protein=23.66 ,Carbohydrates=0.14, Fat=1.48, Energy=114.00}
            //};
            //meatFishEggs.ForEach(f => context.MeatFishEggs.Add(f));
            //context.SaveChanges();
        }
    }
}