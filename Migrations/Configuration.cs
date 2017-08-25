namespace HealthyFoods.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using HealthyFoods.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<HealthyFoods.DAL.HealthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "HealthyFoods.DAL.HealthContext";
        }

        protected override void Seed(HealthyFoods.DAL.HealthContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Beans.AddOrUpdate(
                  b => b.Name,
                  new Bean { Image = "http://dea.bg/ImagesDB/Product_4/1470142348-grah.png", Name = "Peas", Protein = 23.82, Carbohydrates = 63.74, Fat = 1.16, Energy = 352.00 },
                  new Bean { Image = "http://befit.bg/mag/wp-content/uploads/2011/11/red-lentils_2-480x480.jpg", Name = "Lentils", Protein = 23.91, Carbohydrates = 63.10, Fat = 2.17, Energy = 358.00 },
                  new Bean { Image = "https://bg.all.biz/img/bg/catalog/39871.jpeg", Name = "Beans", Protein = 23.58, Carbohydrates = 60.01, Fat = 0.83, Energy = 333.00 }
                );

            context.Vegetables.AddOrUpdate(
                  v => v.Name,
                  new Vegetable { Image = "http://www.napoyavane.com/pictures/thumbs/Application/600_400_1253286692_brokoli.jpg", Name = "Broccoli", Protein = 2.82, Carbohydrates = 6.64, Fat = 0.37, Energy = 34.00 },
                  new Vegetable { Image = "https://bg.all.biz/img/bg/catalog/62092.jpeg", Name = "Tomatos", Protein = 0.88, Carbohydrates = 3.89, Fat = 0.20, Energy = 18.00 },
                  new Vegetable { Image = "http://kostilka.com/image/cache/data/fresh-froot/morkov-450x450_0.jpg", Name = "Carrot", Protein = 0.93, Carbohydrates = 9.58, Fat = 0.24, Energy = 41.00 },
                  new Vegetable { Image = "http://www.aquamat2000.com/pictures/thumbs/Application/600_400_1253693018_cveklo.jpg", Name = "Beetroot", Protein = 1.61, Carbohydrates = 9.56, Fat = 0.17, Energy = 43.00 },
                  new Vegetable { Image = "http://gradcontent.com/lib/300x300/cabbage3.jpg", Name = "Cabbage", Protein = 1.28, Carbohydrates = 5.80, Fat = 0.10, Energy = 25.00 }
                );

            context.Fruits.AddOrUpdate(
                  f => f.Name,
                  new Fruit { Image = "http://spirala.bg/wp-content/uploads/2015/02/banana.jpg", Name = "Bananas", Protein = 1.09, Carbohydrates = 22.84, Fat = 0.33, Energy = 89.00 },
                  new Fruit { Image = "http://www.zajenata.bg/f/uploads/images/8029346_084805717221_2.jpg", Name = "Grapefruit", Protein = 0.63, Carbohydrates = 8.08, Fat = 0.10, Energy = 32.00 },
                  new Fruit { Image = "http://www.1001recepti.com/images/photos/articles/kiwi_smoothie_[182].jpg", Name = "Kiwi", Protein = 1.14, Carbohydrates = 14.66, Fat = 0.52, Energy = 61.00 },
                  new Fruit { Image = "http://lekuvai.bg/wp-content/uploads/2016/07/limoni.jpg", Name = "Lemons", Protein = 1.10, Carbohydrates = 9.32, Fat = 0.30, Energy = 29.00 },
                  new Fruit { Image = "http://www.puls.bg/cache/news/16922_big.jpg", Name = "Watermelon", Protein = 0.61, Carbohydrates = 7.55, Fat = 0.15, Energy = 30.00 },
                  new Fruit { Image = "http://revita.bg/wp-content/uploads/2013/02/african-mango.jpg", Name = "Mango", Protein = 0.82, Carbohydrates = 14.98, Fat = 0.38, Energy = 60.00 }
                );

            context.Nuts.AddOrUpdate(
                  f => f.Name,
                  new Nut { Image = "https://static.framar.bg/thumbs/6/food/badem.jpg", Name = "Almonds", Protein = 21.15, Carbohydrates = 21.55, Fat = 49.93, Energy = 579.00 },
                  new Nut { Image = "https://img01.zdravnitza.com/411-large_default/kashu-surovo.jpg", Name = "Cashew", Protein = 18.22, Carbohydrates = 30.19, Fat = 43.85, Energy = 553.00 },
                  new Nut { Image = "http://www.aquamat2000.com/pictures/thumbs/Application/600_400_1253695124_leshnik.jpg", Name = "Hazelnut", Protein = 14.95, Carbohydrates = 16.70, Fat = 60.75, Energy = 628.00 },
                  new Nut { Image = "https://bg.all.biz/img/bg/catalog/154349.jpeg", Name = "Walnut", Protein = 15.23, Carbohydrates = 13.71, Fat = 65.21, Energy = 654.00 },
                  new Nut { Image = "http://cdn.fashion.bg/img14/pistachios.jpg", Name = "Pistachios", Protein = 20.27, Carbohydrates = 27.51, Fat = 45.39, Energy = 562.00 },
                  new Nut { Image = "https://cache2.24chasa.bg/Images/Cache/700/Image_6095700_126.jpg", Name = "Peanuts", Protein = 25.80, Carbohydrates = 16.13, Fat = 49.24, Energy = 567.00 }
                  );

            context.MeatFishEggs.AddOrUpdate(
                  f => f.Name,
                  new MeatFishEgg { Image = "http://gradcontent.com/lib/250x250/grilled-chicken-fillet5.jpg", Name = "Chicken Fillet", Protein = 18.77, Carbohydrates = 0.00, Fat = 17.07, Energy = 234.00 },
                  new MeatFishEgg { Image = "http://gradcontent.com/lib/250x250/marinated-salmon-trout.jpg", Name = "Salmon", Protein = 19.84, Carbohydrates = 0.00, Fat = 6.34, Energy = 142.00 },
                  new MeatFishEgg { Image = "http://www.poblizodoprirodata.bg/im_pages/1585/1.jpg", Name = "Eggs", Protein = 12.56, Carbohydrates = 0.72, Fat = 9.51, Energy = 143.00 },
                  new MeatFishEgg { Image = "http://i.zajenata.bg/images/2/big_e2d6c4cd644d74f68d722fc0a1c6b3f9.jpg", Name = "Beef", Protein = 21.85, Carbohydrates = 0.00, Fat = 2.90, Energy = 114.00 },
                  new MeatFishEgg { Image = "http://www.az-jenata.bg/media/az-jenata/files/articles/640x480/78527a2dc53b5a9e2f3548693bf18c4c.jpg", Name = "Whitefish", Protein = 19.09, Carbohydrates = 0.00, Fat = 5.86, Energy = 134.00 },
                  new MeatFishEgg { Image = "http://www.vivenda.bg/uploads/productgalleryfile/images/450x450/maxresdefault.jpg", Name = "Turkey Fillet", Protein = 23.66, Carbohydrates = 0.14, Fat = 1.48, Energy = 114.00 }
                  );
        }
    }
}
