using EdenWorks.Domain.Entites;
using EdenWorks.Domain.Enums;
using EdenWorks.Infrastructure.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Infrastructure.SeedData
{
    public class ProductSeeding : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
               // Product Seeding with proper food menu. 


                // SALATALAR / SALADS Id=1
                new Product { Id = 1, Name = "Akdeniz Salatası / Mediterranean Salad", Description = "Kırmızı lahana, havuç, yeşil zeytin, mısır, cherry domates ve taze mevsim yeşillikleri ile servis edilir. / Contains red cabbage, carrot, green olive, corn, tomato and seasonal fresh ingredients.", Price = 35 ,ImagePath= "/image/products/8c600f0b-ea06-4880-9f05-f419c32c3b94.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 1 },

                new Product { Id = 2, Name = "Izg. Tavuk Salata / Grilled Chicken Salad ", Description = "Izg. tavuk, domates, salatalık, kornişon turşu ve karışık taze yeşillik ile servis edilir. / Contains grilled chicken, tomato, cucumber, pickle and seasonal fresh ingredients.", Price = 35 ,ImagePath= "/image/products/fe52f4fa-966f-4fb3-a206-025aa2ab1802.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 1 },

                new Product { Id = 3, Name = "Ton Balıkh Salata / Tuna Salad ", Description = "Ton balığı, dilim siyah zeytin, dilim yeşil zeytin, mısır, domates, salatalık, soğan, kornişon turşu ve karışk taze yeşillikler ile servis edilir / Contains tuna, black and green olive, corn, tomato, cucumber, onion, pickle and seasonal fresh ingredients.", Price = 40 ,ImagePath= "/image/products/fe73ccae-b72d-48e3-a988-34603c2f05f1.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 1 },

                new Product { Id = 4, Name = "Izg. Hellim Salata / Grilled Halloumi Salad ", Description = "Izgarada kızartılmış hellim peyniri, domates, salatalık, yeşil biber ve karışık taze yeşillikler ile servis edilir / Contains grilled halomi cheese, tomato, cucumber, green pepper and seasonal fresh ingredients.", Price = 40 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 1 },

                
                // APERATİFLER / SNACKS Id=2
                new Product { Id = 5, Name = "Yoğurtlu Kızartma / Fried food with yoghurt ", Description = "Patates, Patlıcan, papya Biber, Kavrulmuş kuru acı biber ve Şanmsaklı süzme yoğurt ile servis edilir / Contains Fried potato, eggplant, capia pepper, hot dry pepper and yoghurt with garlic.", Price = 30 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 2 },

                new Product { Id = 6, Name = "Bira Tabağı / Beer Plate ", Description = "Parmak dilim patates, sosis, soğan halkaları kizartılarak servis edilir / Roasting Of potato, sausage and onion rings.", Price = 35 ,ImagePath= "/image/products/4c2050a8-a31f-4a4e-b4fd-796903a5c0aa.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 2 },

                new Product { Id = 7, Name = "Cordon Bleu", Description = "200 Gr tavuk göğsü içinde, jambon içerisine sarılmış tel peynir ile galeta ununda kızartılarak, patates kızartması ile servis edilir / Contains 200Gr chickhen breast and beef jam rolled up with cheese inside of it, fried in oil with french fries.", Price = 40,ImagePath= "/image/products/dba35200-a1eb-4cfd-8a37-f7ed4739fb17.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 2 },

                new Product { Id = 8, Name = "Balık Köftesi / Fish Balls", Description = "Balık fileto, karides, mantar, kaşar peyniri, sarımsak, maydanoz, galeta unu ve baharatlar ile servis edilir / Contains fillet fish, shrimp, mushroom, cheese, garlic, parsley, bread crumbs with spices.", Price = 40 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 2 },

                new Product { Id = 9, Name = "Fish and Chips", Description = "Galeta ununda kızartılmış Mezgit fileto, ev yapımı kızartılmış patates ile servis edilir / Contains fried North Atlantic whiting with french fries.", Price = 45 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 2 },

               
                //TOSTLAR / TOASTS Id=3
                new Product { Id = 10, Name = "Kepek Ekmeğinde Tost / Bran Bread Toast", Description = "Kepek ekmeğinde kaşar pey. ve köz. domates yanında yeşil ve siyah zeytin ile servis edilir / Contains cheese and tomato inside of bran bread with green and black olive.", Price = 25 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 3 },

                new Product { Id = 11, Name = "Kasap Sucuklu Kaşarlı Tost / Toast with sausage and cheese", Description = "Bazlama ekmeğinde kasap syucuğu ve Kaşar peyniri yanında patates kızartması ile servis edilir / Contains sausage with cheese with french fries.", Price = 35 ,ImagePath= "/image/products/b67b0113-550f-4223-8c0f-038558e80b93.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 3 },

                new Product { Id = 12, Name = "4 Peynirli Tost / Mix of  Cheese Toast", Description = "Bazlama ekmeğinde Ezine Peyniri, Kaşar peyniri, İzmir tulum ve Tel peyniri yanında patates kızartması ile servis edilir / Contains mixture of 4 different type of cheese with french fries.", Price = 35,ImagePath= "/image/products/6f601cc6-7b59-4f21-a3e5-fd20d8cbb77d.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 3 },

                new Product { Id = 13, Name = "Karışık Tost / Mixed Toast", Description = "Bazlama ekmeğinde kaşar peyniri, tel peyniri, kasap sucuğu, közlenmiş domates, biber ve turşu yanında patates kızartması ile servis edilir / Contains sausage, cheese, roasted tomato, pepper and pickle with french fries.", Price = 40 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 3 },


               
                //BURGERLER / BURGERS Id=4
                new Product { Id = 14, Name = "Kasap Burger / Hamburger", Description = "180 gr ev yapımı köfte, karamelize soğan, közlenmiş domates, barbekü sos, turşu ve patates kızartması ile servis edilir / Contains 180 gr handmate meatball, caramelized onion, roasted tomato, barbeque sauce and pickle with french fries.", Price = 40 ,ImagePath= "/image/products/f2e14afe-5c91-4ec5-a9a5-a718c26b4552.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 4 },

                new Product { Id = 15, Name = "Cheese Burger", Description = "180 gr ev yapımı köfte, karamelize soğan, közlenmiş domates, turşu, barbekü sos, cheddar peynir ve patates kızartması ile servis edilir / Contains 180 gr handmade meatball, caramelized onion, roasted tomato, barbeque sauce, chedddar and pickle with french fries.", Price = 45 , ImagePath= "/image/products/cf32dddf-5237-40df-9978-abda40b777b1.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 4 },

              
                //PİDELER / PIDES Id=5
                new Product { Id = 16, Name = "Lahmacun", Description = "İnce hamur, dana kıyma, mevsim yeşillikleri eklenerek servis edilir / Contains thin pide dough, mince, with seasonal fresh ingredients.", Price = 20 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 5 },

                new Product { Id = 17, Name = "4 Peynirli Pide / Mix of 4 Cheese Pide", Description = "İnce pide hamuru, İzmir tulum, Kaşar, Ezine ve Tel peyniri ile servis edilir / Contains thin pide dough, 4 different type of cheese.", Price = 33 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 5 },

                new Product { Id = 18, Name = "Kıymalı Pide / Minced Pide", Description = "İnce pide hamuru, dana kıyma, mevsim yeşillikleri eklenerek servis edilir / Contains thin pide dough, mince with seasonal fresh ingredients.", Price = 35 ,ImagePath="/image/products/b7fab8d0-aed8-4826-9eff-19548f0fc524.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 5 },

                new Product { Id = 19, Name = "Kasap Sucuklu Kaşarlı Pide / Sausage Pide with Cheese", Description = "İnce pide hamuru, kasap sucuk ve kaşar peyniri ile servis edilir / Contains thin pide dough, fermented sausage with cheese.", Price = 37 ,ImagePath= "/image/products/9eeca60a-918a-4195-ac9c-f9b8fd4080ee.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 5 },

                new Product { Id = 20, Name = "Kuşbaşılı Kaşarlı Pide / Pide with meat and cheese", Description = "Pide Hamuru, Dana kuşbaşı ve Kaşar peyniri ile servis edilir / Contains thin pide dough, meat with cheese.", Price = 40,ImagePath= "/image/products/22aca5b5-2c90-491b-a3fb-c1cf023ced97.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 5 },

               
                // PİZZALAR / PIZZAS Id=6
                new Product { Id = 21, Name = "Vejeteryan Pizza / Vegetarian Pizza", Description = "Pizza hamuru, Mozzarella peyniri, domates, siyah zeytin, mantar, mısır ile servis edilir / Pizza dough contains Mozzarella , tomato, black olive, mushroom and corn.", Price = 30 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 6 },

                new Product { Id = 22, Name = "Ton Balıklı Pizza / Tuna Fish Pizza", Description = "Pizza hamuru, Mozzarella peyniri, ton balığı, siyah zeytin, yeşil zeytin, mısır ve kekik ile servis edilir / Pizza dough contains Mozzarella, tuna, black and green olive, corn with thyme.", Price = 40 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 6 },

                new Product { Id = 23, Name = "Eden Special Pizza", Description = "Pizza hamuru, Mozzarella peyniri, kasap sucuk, sosis, domates,mısır, siyah zeytin, yeşil zeytin ve mantar ile servis edilir / Pizza dough contains Mozzarella, corn, tomato, black olive, green olive and mushroom.", Price = 45 , ImagePath= "/image/products/bb0f9322-e90e-4e47-b5bf-4dc759904031.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 6 },


                
                // QUESADILLAS & WRAPS Id=7
                new Product { Id = 24, Name = "Tavuklu / Chicken Quesadilla & Wrap", Description = "Tortilla ekmeği, tavuk eti, yeşil biber, kırmızı biber, domates, soğan, peynir, baharatlar ve cips ile servis edilir / Contains tortilla bread, beef, green pepper, red pepper, tomato, onion, cheese, species and french fries.", Price = 30 ,ImagePath= "/image/products/ae81fa43-5564-461f-aa04-367eca9759c8.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 7 },

                new Product { Id = 25, Name = "Etli / Beef Quesadilla & Wrap", Description = "Tortilla ekmeği, dana eti, yeşil biber, kırmızı biber, domates, soğan, peynir, baharatlar ve cips ile servis edilir / Contains tortilla bread, beef, green pepper, red pepper, tomato, onion, cheese, species and french fries.", Price = 35 ,ImagePath= "/image/products/0c6cc40a-749c-464c-b5e5-1c17f6ded018.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 7 },

                new Product { Id = 26, Name = "Balıklı / Fish Quesadilla", Description = "Tortilla ekmeği, balık, yeşil biber, kırmızı biber, domates, soğan, peynir, baharatlar, limon ve cips ile servis edilir / Contains tortilla bread, beef, green pepper, red pepper, tomato, onion, cheese, spices, lemoın and french fries", Price = 40 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 7 },

               
                //Mezeler / Mezzes Id=8
                 new Product { Id = 27, Name = "Girit Ezmesi / Crete Paste ", Description = "Ezine peyniri, ceviz içi, sarımsak, sızma zeytinyağı, maydanoz, kekik ve pul biber ile servis edilir / Contains Ezine cheese, walnut, garlic, olive oil, parsley, thyme and chili pepper.", Price = 20 ,ImagePath= "/image/products/d266ef17-93b4-4d23-92c4-60c7ddec3758.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 8 },

                 new Product { Id = 28, Name = "Atom", Description = "Tereyağında kavrulmuş acı kuru biber, pul biber, süzme yoğurt ile servis edilir / contains roasted hot dry pepper in butter, chili pepper and yoghurt.", Price = 20 , ImagePath= "/image/products/5346297c-d9c2-45ed-8bd7-d85d01e6a4d7.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 8 },

                 new Product { Id = 29, Name = "Yoğurtlu Közlenmiş Patlıcan (Köpoğlu) / Eggplant Salad", Description = "Közlenmiş patlıcan, süzme yoğurt, sarımsak ve zeytinyağı ile servis edilir / Contains roasted eggplant, yoghurt, garlic and olive oil.", Price = 30 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 8 },

                 new Product { Id = 30, Name = "Peynir Tabağı / Cheese Plate", Description = "Ezine peyniri, tel peyniri, közlenmiş hellim peyniri, tulum peyniri, domates ve roka ile servis edilir / Contains mixture of 4 different type of cheese served with rocket.", Price = 30 ,ImagePath= "/image/products/7d091183-18e4-4951-9a2e-25e6ba56193d.jpg", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 8 },

                 new Product { Id = 31, Name = "Karides Güveç / Shrimp Stew", Description = "Karides, sivri biber, tereyağ, sarımsak, domates, mantar, kaşar peyniri, tuz ve kekik ile servis edilir / Contains shrimp, pointed pepper, butter, garlic, tomato, mushroom, cheese, salt and thyme", Price = 40 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 8 },

                 new Product { Id = 32, Name = "Kalamar Tava / Fried Calamari", Description = "Özel ununda kızartılmış Kalamar, sos, limon ve roka ile servis edilir / Contains Fried Calamari, served with special sauce, lemon and arugula.", Price = 40 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 8 },

                
                 //Izgaralar / Grills Id=9
                 new Product { Id = 33, Name = "Barbekü Soslu Tavuk Izgara / Grilled Chicken with Barbecue Souce", Description = "Marine edilmiş kemiksiz tavuk but, közlenmiş domates, barbekü sosu ve patates kızartması ile servis edilir / Contains marinated chicked, roasted tomato with barbeque sauce and french fries.", Price = 35 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 9 },

                 new Product { Id = 34, Name = "Izgara Kasap Köfte / Grilled Meatballs", Description = "200 gr. ev yapımı köfte, közlenmiş domates, biber, karamelize soğan ve patates kızartması ile servis edilir / Contains 200 gr handmade meatballs, roasted tomato, pepper, caramelized onion with french fries.", Price = 40 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 9 },

                 new Product { Id = 35, Name = "Yoğurtlu Tire Köftesi / Tire Kebab with yoghurt", Description = "200 gr. özel yapım köfte, yoğurt, yeşil biber, kuru kırmızı biber, domates, tereyağ ve tuz ile servis edilir / Contains 200 gr special meatballs, yoghurt, green pepper, dry red pepper, tomato, butter and salt. ", Price = 40 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 9 },

                 new Product { Id = 36, Name = "Izgara Mezgit Marin / Grilled Whiting Marin", Description = "200 gr. marine edilmiş Kuzey Atlantik mezgiti, soğan, cherry domates, roka ve kızarmış limon ile servis edilir / Contains 200 gr marin North Atlantic whiting, onion, cherry tomato, arugula and grilled lemon", Price = 45 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 9 },

                 new Product { Id = 37, Name = "Külbastı / Grilled Cotlet", Description = "200 gr Kuzu eti, karamelize soğan, közlenmiş biber, domates ve cips ile servis edilir / Contains 200 gr slim sliced lamb, caramelized onion, roasted pepper, tomato with french fries.", Price = 60 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 9 },

                
                 // Makarnalar / Pastas Id=10
                 new Product { Id = 38, Name = "Spagetti Bolognese", Description = "Bolonez sos, kıyma, doamtes ve sarımsak ile servis edilir / Contains bolognese sauce, mince, tomato and garlic", Price = 35 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 10 },

                 new Product { Id = 39, Name = "Köri Soslu Penne / Penne with Curry Sauce", Description = "Krema, köri sos, peynir ve mantar ile servis edilir / Contains curry sauce, cheese, mushroom and cream.", Price = 35 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 10 },
                 new Product { Id = 40, Name = "Fettucini Alfredo", Description = "Fettucini makarna, krema, tereyağ, mantar, tavuk göğsü, sarımsak, fesleğen, peynir, karabiber ve tuz ile servis edilir / Fettucine, heavy cream, butter, mushroom, chicken breast, garlic, basil, cheese, salt and pepper.", Price = 40 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 10 },

                 
                 //Kahveler / Coffees Id=11
                  new Product { Id = 41, Name = "Türk Kahvesi / Turkish Coffee", Description = "", Price = 12 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 11 },

                  new Product { Id = 42, Name = "Espresso", Description = "", Price = 15 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 11 },

                  new Product { Id = 43, Name = "French Press Filter Coffee", Description = "", Price = 20 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 11 },

                  new Product { Id = 44, Name = "Americano", Description = "", Price = 20 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 11 },

                  new Product { Id = 45, Name = "Cafe Latte / Café Con Leche", Description = "", Price = 20 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 11 },


                  // Soft Drink Id = 12
                   new Product { Id = 46, Name = "Taze Sıkılmış Portakal / Orange Juice", Description = "", Price = 15 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 12 },

                   new Product { Id = 47, Name = "Nar Suyu / Pomegranate Juice", Description = "", Price = 17 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 12 },

                   new Product { Id = 48, Name = "Coca Cola / Light / Zero", Description = "", Price = 8 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 12 },

                   new Product { Id = 49, Name = "Sprite / Fanta", Description = "", Price = 8 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 12 },

                   new Product { Id = 50, Name = "Meyve Suyu Vişne / Şeftali / Karışık (Cherry Juice / Peach / Mixed Juice)", Description = "", Price = 8 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 12},

                   new Product { Id = 51, Name = "Ayran", Description = "", Price = 6 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 12 },

                   new Product { Id = 52, Name = "Soda", Description = "", Price = 6 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 12 },

                   new Product { Id = 53, Name = "Su", Description = "", Price = 4 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 12 },

                  
                   // Biralar / Beers Id=13
                   new Product { Id = 54, Name = "Efes / Efes Malt 50 cl", Description = "", Price = 23 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 13 },
                  
                   new Product { Id = 55, Name = "Bomonti", Description = "", Price = 23 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 13 },
                  
                   new Product { Id = 56, Name = "Bomonti Filtresiz", Description = "", Price = 25 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 13 },
                  
                   new Product { Id = 57, Name = "Tuborg Gold", Description = "", Price = 23 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 13 },
                
                   new Product { Id = 58, Name = "Tuborg Amber / Bud", Description = "", Price = 25 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 13 },
                 
                   new Product { Id = 59, Name = "Carlsberg / Miller / Beck's", Description = "", Price = 27 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 13},
                 
                   new Product { Id = 60, Name = "Corona Extra / Sol", Description = "", Price = 30 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 13 },
                  
                   new Product { Id = 61, Name = "Desperado / Amsterdam", Description = "", Price = 35 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 13 },
                  
                   new Product { Id = 62, Name = "Guinness", Description = "", Price = 37 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 13 },


                   // Rakılar / Raki Id=14
                   new Product { Id = 63, Name = "Tekirdağ (Tek)", Description = "", Price = 25 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 14 },

                   new Product { Id = 64, Name = "Tekirdağ (Duble)", Description = "", Price = 35 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 14 },
                  
                   new Product { Id = 65, Name = "Tekirdağ 35 cl", Description = "", Price = 125 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 14 },
                  
                   new Product { Id = 66, Name = "Tekirdağ 70 cl", Description = "", Price = 205 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 14 },

                   new Product { Id = 67, Name = "Tekirdağ T.Serisi 35 cl", Description = "", Price = 145 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 14 },

                   new Product { Id = 68, Name = "Tekirdağ T.Serisi 70 cl", Description = "", Price = 240 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 14 },

                  
                   // Şaraplar / Vines Id=15
                   new Product { Id = 69, Name = "White Wine", Description = "Şişe 130 TL / Bottle 130 TL", Price = 35 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 15 },

                   new Product { Id = 70, Name = "Red Wine", Description = "Şişe 35 TL / Bottle 130 TL", Price = 35 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 15 },
                  
                   new Product { Id = 71, Name = "Blush", Description = "Şişe 35 TL / Bottle 130 TL", Price = 35 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 15 },

                 
                   //Diğer İçkiler / Hard Liquours Id=16
                   new Product { Id = 72, Name = "Gordon Gin", Description = "", Price = 45 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 16 },

                   new Product { Id = 73, Name = "Beefeather Gin", Description = "", Price = 50 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 16 },

                   new Product { Id = 74, Name = "Absolut / Smirnoff Vodka", Description = "", Price = 45 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 16 },

                   new Product { Id = 75, Name = "Jim Beam Bourbon", Description = "", Price = 50 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 16 },

                   new Product { Id = 76, Name = "Jack Daniels Tennesee Whiskey", Description = "", Price = 50 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 16 },

                   new Product { Id = 77, Name = "Chivas Regal (12 years)", Description = "", Price = 55 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 16 },

                   new Product { Id = 78, Name = "Black Label", Description = "", Price = 55 , CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active, CategoryId = 15 }

            );
        }
    }
}
