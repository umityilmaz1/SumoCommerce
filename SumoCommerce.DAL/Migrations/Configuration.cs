namespace SumoCommerce.DAL.Migrations
{
    using SumoCommerce.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SumoCommerce.DAL.Concrete.EntityFramework.SumoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SumoCommerce.DAL.Concrete.EntityFramework.SumoDbContext context)
        {
            UserRole role = new UserRole();
            role.RoleName = "Admin";
            context.UserRoles.Add(role);

            context.SaveChanges();

            User admin = new User();
            admin.BirthDate = new DateTime(1987, 1, 15);
            admin.Mail = "muh.muratcakir@gmail.com";
            admin.Name = "Murat";
            admin.Surname = "Çakir";
            admin.Password = "bimbik";
            admin.PhoneNumber = "5325983657";
            admin.UserRole = role;
            context.Users.Add(admin);

            role = new UserRole();
            role.RoleName = "User";
            context.UserRoles.Add(role);

            context.SaveChanges();

            User user = new User();
            user.BirthDate = new DateTime(1989, 7, 18);
            user.Mail = "birumittiryasamak@gmail.com";
            user.Name = "Ümit";
            user.Surname = "Yilmaz";
            user.Password = "cilginümit";
            user.UserRole = role;
            user.ID = 2;
            context.Users.Add(user);

            context.SaveChanges();

            user = new User();
            user.BirthDate = new DateTime(1993, 3, 22);
            user.Mail = "bickindelikanli@gmail.com";
            user.Name = "Oguzhan";
            user.Surname = "Whitewater";
            user.Password = "bickinouz";
            user.UserRole = role;
            user.ID = 3;
            context.Users.Add(user);

            context.SaveChanges();


            user = new User();
            user.BirthDate = new DateTime(1996, 9, 1);
            user.Mail = "serensari@gmail.com";
            user.Name = "Seren";
            user.Surname = "Sariayva";
            user.Password = "seren123";
            user.UserRole = role;
            user.ID = 4;
            context.Users.Add(user);

            City city = new City();
            city.CityName = "Rize";
            context.Cities.Add(city);

            context.SaveChanges();

            County county = new County();
            county.CountyName = "Derepazari";
            county.City = city;
            context.Counties.Add(county);
            County county2 = new County();
            county2.CountyName = "Ardesen";
            county.City = city;
            context.Counties.Add(county);

            city = new City();
            city.CityName = "Istanbul";
            context.Cities.Add(city);

            context.SaveChanges();

            county = new County();
            county.CountyName = "Bakirköy";
            county.City = city;
            context.Counties.Add(county);
            county2 = new County();
            county2.CountyName = "Üsküdar";
            county.City = city;
            context.Counties.Add(county);

            city = new City();
            city.CityName = "Izmir";
            context.Cities.Add(city);

            context.SaveChanges();

            county = new County();
            county.CountyName = "Alsancak";
            county.City = city;
            context.Counties.Add(county);
            county2 = new County();
            county2.CountyName = "Konak";
            county.City = city;
            context.Counties.Add(county);

            city = new City();
            city.CityName = "Ankara";
            context.Cities.Add(city);

            context.SaveChanges();

            county = new County();
            county.CountyName = "Kizilay";
            county.City = city;
            context.Counties.Add(county);
            county2 = new County();
            county2.CountyName = "Etimesgut";
            county.City = city;
            context.Counties.Add(county);


            city = new City();
            city.CityName = "Konya";
            context.Cities.Add(city);

            context.SaveChanges();

            county = new County();
            county.CountyName = "Beysehir";
            county.City = city;
            context.Counties.Add(county);
            county2 = new County();
            county2.CountyName = "Seydisehir";
            county.City = city;
            context.Counties.Add(county);


            Category c1 = new Category();
            c1.CategoryName = "Diþ Saðlýðý";
            c1.Description = "Diþ saðlýðý için kullanabilir ürünler";
            context.Categories.Add(c1);
            context.SaveChanges();

            Product Agarta = new Product();
            Agarta.Category = c1;
            Agarta.Price = 10;
            Agarta.ProductName = "%100 Doðal Diþ Macunu Çocuk 75ml";
            Agarta.Stock = 120;
            Agarta.Image = "https://drive.google.com/uc?id=1IXqsaj4_ZrlPDv2ihKYJc59pp1vBWwDu";
            Agarta.Brand = "Agarta";
            Agarta.Description = "agarta!";
            context.Products.Add(Agarta);


            Product mecitEfendi = new Product();
            mecitEfendi.Category = c1;
            mecitEfendi.Price = 16;
            mecitEfendi.ProductName = "ME Misvak Özlü Doðal Diþ Macunu 75ml";
            mecitEfendi.Stock = 53;
            mecitEfendi.Image = "https://drive.google.com/uc?id=1TzNB1y5ngEC33d8wQNaPAvgop217o-bW";
            mecitEfendi.Brand = "Mecit Efendi";
            mecitEfendi.Description = "mecit efendi..!";
            context.Products.Add(mecitEfendi);


            Category c2 = new Category();
            c2.CategoryName = "Sivilce Kremi";
            c2.Description = "Sivilcelere karþý kullanýlacak ürünler";
            context.Categories.Add(c2);
            context.SaveChanges();

            Product SofttoPlus = new Product();
            SofttoPlus.Category = c2;
            SofttoPlus.ProductName = "Akne ve Sivilce Kremi 100gr";
            SofttoPlus.Price = 8;
            SofttoPlus.Stock = 66;
            SofttoPlus.Image = "https://drive.google.com/uc?id=13lkCG5PP53Qgia_wql1h7kntsL4caZP_";
            SofttoPlus.Brand = "Softto Plus";
            SofttoPlus.Description = "softto plus !!";
            context.Products.Add(SofttoPlus);

            Product Dermaderm = new Product();
            Dermaderm.Category = c2;
            Dermaderm.ProductName = "Sivilce Kremi 50g";
            Dermaderm.Price = 15;
            Dermaderm.Stock = 168;
            Dermaderm.Image = "https://drive.google.com/uc?id=1kZCm3gbjonwcVc84wConSN8dmHTIHyBU";
            Dermaderm.Brand = "Dermaderm";
            Dermaderm.Description = "dermaderm";
            context.Products.Add(Dermaderm);

            Product MindivanPhytoFlora = new Product();
            MindivanPhytoFlora.Category = c2;
            MindivanPhytoFlora.ProductName = "Sivilce Karþýtý Krem 50ml";
            MindivanPhytoFlora.Price = 33;
            MindivanPhytoFlora.Stock = 298;
            MindivanPhytoFlora.Image = "https://drive.google.com/uc?id=1XyZFeLLyHJn4DbrUE94egBXlX1av6aMD";
            MindivanPhytoFlora.Brand = "Mindivan Phyto Flora";
            MindivanPhytoFlora.Description = "mindivan";
            context.Products.Add(MindivanPhytoFlora);

            context.SaveChanges();
        }
    }
}
