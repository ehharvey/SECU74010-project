// Get DbContext from StoreWebApp project

using Microsoft.EntityFrameworkCore;
using StoreWebApp.Components;
using StoreWebApp.Models;
using Newtonsoft.Json;

namespace StoreWebAppDbSeeding
{
    class Program
    {
        static void Main(string[] args)
        {
            var data_split_size = 2000;

            var configuration_builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory().Replace("StoreWebAppDbSeeding", "StoreWebApp"))
                .AddJsonFile("appsettings.json");

            var configuration = configuration_builder.Build();

            var options_builder = new DbContextOptionsBuilder<StoreWebApp.Components.MyDbContext>();
            options_builder.UseSqlite("Data Source=../StoreWebApp/app.db");

            using (var context = new StoreWebApp.Components.MyDbContext(options_builder.Options))
            {
                context.Database.EnsureCreated();

                // Clear all `ories
                context.Categories.RemoveRange(context.Categories);
                context.SaveChanges();
                Console.WriteLine("Cleared all categories");

                // Read ./seed_data/categories.json and seed the database with the data
                var categories = JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText("./seed_data/categories.json"));
                if (categories != null)
                {
                    for (int i = 0; i < categories.Count; i += data_split_size)
                    {
                        var categories_to_add = categories.Skip(i).Take(data_split_size).ToList();
                        context.Categories.AddRange(categories_to_add);
                        context.SaveChanges();

                        Console.WriteLine($"Seeded {categories_to_add.Count} categories");
                    }
                }  
                else
                {
                    throw new Exception("Failed to seed categories");
                }

                // Clear all brands
                context.Brands.RemoveRange(context.Brands);
                context.SaveChanges();
                Console.WriteLine("Cleared all brands");

                // Read ./seed_data/brands.json and seed the database with the data
                var brands = JsonConvert.DeserializeObject<List<Brand>>(File.ReadAllText("./seed_data/brands.json"));
                if (brands != null)
                {
                    for (int i = 0; i < brands.Count; i += data_split_size)
                    {
                        var brands_to_add = brands.Skip(i).Take(data_split_size).ToList();
                        context.Brands.AddRange(brands_to_add);
                        context.SaveChanges();

                        Console.WriteLine($"Seeded {brands_to_add.Count} brands");
                    }
                }
                else
                {
                    throw new Exception("Failed to seed brands");
                }

                // Clear all age groups
                context.AgeGroups.RemoveRange(context.AgeGroups);
                context.SaveChanges();
                Console.WriteLine("Cleared all age groups");

                // Read ./seed_data/age_groups.json and seed the database with the data
                var age_groups = JsonConvert.DeserializeObject<List<AgeGroup>>(File.ReadAllText("./seed_data/age_groups.json"));
                if (age_groups != null)
                {
                    for (int i = 0; i < age_groups.Count; i += data_split_size)
                    {
                        var age_groups_to_add = age_groups.Skip(i).Take(data_split_size).ToList();
                        context.AgeGroups.AddRange(age_groups_to_add);
                        context.SaveChanges();

                        Console.WriteLine($"Seeded {age_groups_to_add.Count} age groups");
                    }
                }
                else
                {
                    throw new Exception("Failed to seed age groups");
                }

                // Clear all colours
                context.Colours.RemoveRange(context.Colours);
                context.SaveChanges();
                Console.WriteLine("Cleared all colours");

                // Read ./seed_data/colours.json and seed the database with the data
                var colours = JsonConvert.DeserializeObject<List<Colour>>(File.ReadAllText("./seed_data/colours.json"));
                if (colours != null)
                {
                    for (int i = 0; i < colours.Count; i += data_split_size)
                    {
                        var colours_to_add = colours.Skip(i).Take(data_split_size).ToList();
                        context.Colours.AddRange(colours_to_add);
                        context.SaveChanges();

                        Console.WriteLine($"Seeded {colours_to_add.Count} colours");
                    }
                }
                else
                {
                    throw new Exception("Failed to seed colours");
                }

                // Clear all genders
                context.Genders.RemoveRange(context.Genders);
                context.SaveChanges();
                Console.WriteLine("Cleared all Genders");

                // Read ./seed_data/genders.json and seed the database with the data
                var genders = JsonConvert.DeserializeObject<List<Gender>>(File.ReadAllText("./seed_data/genders.json"));
                if (genders != null)
                {
                    for (int i = 0; i < genders.Count; i += data_split_size)
                    {
                        var genders_to_add = genders.Skip(i).Take(data_split_size).ToList();

                        context.Genders.AddRange(genders_to_add);

                        context.SaveChanges();
                        Console.WriteLine($"Seeded {genders_to_add.Count} genders");
                    }
                }
                else
                {
                    throw new Exception("Failed to seed genders");
                }

                // Clear all seasons
                context.Seasons.RemoveRange(context.Seasons);
                context.SaveChanges();
                Console.WriteLine("Cleared all seasons");

                // Read ./seed_data/seasons.json and seed the database with the data
                var seasons = JsonConvert.DeserializeObject<List<Season>>(File.ReadAllText("./seed_data/seasons.json"));
                if (seasons != null)
                {
                    for (int i = 0; i < seasons.Count; i += data_split_size)
                    {
                        var seasons_to_add = seasons.Skip(i).Take(data_split_size).ToList();
                        context.Seasons.AddRange(seasons_to_add);
                        context.SaveChanges();

                        Console.WriteLine($"Seeded {seasons_to_add.Count} seasons");
                    }
                }
                else
                {
                    throw new Exception("Failed to seed seasons");
                }

                // Clear all style options
                context.StyleOptions.RemoveRange(context.StyleOptions);
                context.SaveChanges();
                Console.WriteLine("Cleared all style options");

                // Read ./seed_data/style_options.json and seed the database with the data
                var style_options = JsonConvert.DeserializeObject<List<StyleOption>>(File.ReadAllText("./seed_data/style_options.json"));
                if (style_options != null)
                {
                    for (int i = 0; i < style_options.Count; i += data_split_size)
                    {
                        var style_options_to_add = style_options.Skip(i).Take(data_split_size).ToList();
                        context.StyleOptions.AddRange(style_options_to_add);
                        context.SaveChanges();

                        Console.WriteLine($"Seeded {style_options_to_add.Count} style options");
                    }
                }
                else
                {
                    throw new Exception("Failed to seed style options");
                }

                // CleaMicrosoft.AspNetCore.Routing.RouteEndpointr all usages
                context.Usages.RemoveRange(context.Usages);
                context.SaveChanges();
                Console.WriteLine("Cleared all usages");

                // Read ./seed_data/usages.json and seed the database with the data
                var usages = JsonConvert.DeserializeObject<List<Usage>>(File.ReadAllText("./seed_data/usages.json"));
                if (usages != null)
                {
                    for (int i = 0; i < usages.Count; i += data_split_size)
                    {
                        var usages_to_add = usages.Skip(i).Take(data_split_size).ToList();
                        context.Usages.AddRange(usages_to_add);
                        context.SaveChanges();

                        Console.WriteLine($"Seeded {usages_to_add.Count} usages");
                    }
                }
                else
                {
                    throw new Exception("Failed to seed usages");
                }

                // Clear all products
                context.Products.RemoveRange(context.Products);
                context.SaveChanges();
                Console.WriteLine("Cleared all products");

                // Read ./seed_data/products.json and seed the database with the data
                var products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("./seed_data/products.json"));
                if (products != null)
                {
                    for (int i = 0; i < products.Count; i += data_split_size)
                    {
                        var products_to_add = products.Skip(i).Take(data_split_size).ToList();
                        context.Products.AddRange(products_to_add);
                        context.SaveChanges();

                        Console.WriteLine($"Seeded {products_to_add.Count} products");
                    }
                }
                else
                {
                    throw new Exception("Failed to seed products");
                }

                // Clear all products to style option junctions
                context.ProductToStyleOptionJunctions.RemoveRange(context.ProductToStyleOptionJunctions);
                context.SaveChanges();
                Console.WriteLine("Cleared all product to style options junctions");

                // Read ./seed_data/product_to_style_option_junctions.json and seed the database with the data
                var product_to_style_option_junctions = JsonConvert.DeserializeObject<List<ProductToStyleOptionJunction>>(File.ReadAllText("./seed_data/product_to_style_options_junction.json"));
                if (product_to_style_option_junctions != null)
                {
                    for (int i = 0; i < product_to_style_option_junctions.Count; i += data_split_size)
                    {
                        var product_to_style_option_junctions_to_add = product_to_style_option_junctions.Skip(i).Take(data_split_size).ToList();
                        context.ProductToStyleOptionJunctions.AddRange(product_to_style_option_junctions_to_add);
                        context.SaveChanges();

                        Console.WriteLine($"Seeded {product_to_style_option_junctions_to_add.Count} product to style option junctions");
                    }
                }
                else
                {
                    throw new Exception("Failed to seed product to style option junctions");
                }

                // Clear all zip codes
                context.ZipCodes.RemoveRange(context.ZipCodes);
                context.SaveChanges();
                Console.WriteLine("Cleared all zip codes");

                // Read ./seed_data/zip_codes.json and seed the database with the data
                var zip_codes = JsonConvert.DeserializeObject<List<ZipCodeData>>(File.ReadAllText("./seed_data/zip_codes.json"));
                if (zip_codes != null)
                {
                    for (int i = 0; i < zip_codes.Count; i += data_split_size)
                    {
                        var zip_codes_to_add = zip_codes.Skip(i).Take(data_split_size).ToList();
                        context.ZipCodes.AddRange(zip_codes_to_add);
                        context.SaveChanges();

                        Console.WriteLine($"Seeded {zip_codes_to_add.Count} zip codes");
                    }
                }
                else
                {
                    throw new Exception("Failed to seed zip codes");
                }

                // Clear all addresses
                context.Addresses.RemoveRange(context.Addresses);
                context.SaveChanges();
                Console.WriteLine("Cleared all addresses");

                var zip = context.ZipCodes.Find("001W0");

                var address = new Address
                {
                    Id = -1,
                    Street = "1234 Elm St",
                    ZipCode = "001W0",
                    ZipCodeData = zip,
                    Phone = "123-456-7890",
                    Email = "test@example.com"
                };

                context.Addresses.Add(address);
                context.SaveChanges();
                Console.WriteLine("Seeded an address");


                var puma_shoe = context.Products.Find(9355);
                var lotto_slipper = context.Products.Find(19119);
                var arrow_suspenders = context.Products.Find(3496);
                var wildcraft_backpack = context.Products.Find(5270);

                for (int i = 0; i < 20; i++)
                {
                    var purchase = new Purchase
                    {
                        Address = address,
                        Products = new List<Product> { puma_shoe, lotto_slipper, arrow_suspenders, wildcraft_backpack },
                        ProductIds = new List<int> { puma_shoe.Id, lotto_slipper.Id, arrow_suspenders.Id, wildcraft_backpack.Id },
                        PurchaseDate = DateTime.Now,
                    };
                    context.Purchases.Add(purchase);
                }
                context.SaveChanges();

                Console.WriteLine("Seeded some purchases");
            }
        }
    }
}