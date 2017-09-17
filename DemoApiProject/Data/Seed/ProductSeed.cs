using System.Collections.Generic;
using DemoApiProject.Model;
using Newtonsoft.Json;

namespace DemoApiProject.Data.Seed
{
  public static class ProductSeed
  {
    public static List<Product> Product =>
      JsonConvert.DeserializeObject<List<Product>>(
        @"[{
                                      ""Name"": ""Rolled Oats"",
                                      ""Price"": ""0.52""
                                    }, {
                                      ""Name"": ""Dried Figs"",
                                      ""Price"": ""3.79""
                                    }, {
                                      ""Name"": ""Chevere Logs"",
                                      ""Price"": ""7.99""
                                    }, {
                                      ""Name"": ""Wine - Cotes Du Rhone"",
                                      ""Price"": ""6.00""
                                    }, {
                                      ""Name"": ""Tuna - Fresh"",
                                      ""Price"": ""4.00""
                                    }, {
                                      ""Name"": ""Muskox - French Rack"",
                                      ""Price"": ""4.94""
                                    }, {
                                      ""Name"": ""Lobak"",
                                      ""Price"": ""0.38""
                                    }, {
                                      ""Name"": ""Lettuce - Boston Bib"",
                                      ""Price"": ""6.98""
                                    }, {
                                      ""Name"": ""Jack Daniels"",
                                      ""Price"": ""2.05""
                                    }, {
                                      ""Name"": ""Hinge W Undercut"",
                                      ""Price"": ""4.24""
                                    }, {
                                      ""Name"": ""Pasta - Cappellini, Dry"",
                                      ""Price"": ""2.17""
                                    }, {
                                      ""Name"": ""Veal - Leg"",
                                      ""Price"": ""8.65""
                                    }, {
                                      ""Name"": ""Mushroom Morel Fresh"",
                                      ""Price"": ""2.09""
                                    }, {
                                      ""Name"": ""Chicken - White Meat With Tender"",
                                      ""Price"": ""7.99""
                                    }, {
                                      ""Name"": ""Plastic Arrow Stir Stick"",
                                      ""Price"": ""8.20""
                                    }, {
                                      ""Name"": ""Placemat - Scallop, White"",
                                      ""Price"": ""0.17""
                                    }, {
                                      ""Name"": ""Sauce - Salsa"",
                                      ""Price"": ""1.92""
                                    }, {
                                      ""Name"": ""Pork - Back Ribs"",
                                      ""Price"": ""9.39""
                                    }, {
                                      ""Name"": ""Fish - Bones"",
                                      ""Price"": ""3.44""
                                    }, {
                                      ""Name"": ""Shrimp - 100 / 200 Cold Water"",
                                      ""Price"": ""3.60""
                                    }, {
                                      ""Name"": ""Durian Fruit"",
                                      ""Price"": ""7.42""
                                    }, {
                                      ""Name"": ""Bread - Assorted Rolls"",
                                      ""Price"": ""5.07""
                                    }, {
                                      ""Name"": ""Soup - Campbells, Beef Barley"",
                                      ""Price"": ""2.98""
                                    }, {
                                      ""Name"": ""Tahini Paste"",
                                      ""Price"": ""4.56""
                                    }, {
                                      ""Name"": ""Vacuum Bags 12x16"",
                                      ""Price"": ""1.72""
                                    }, {
                                      ""Name"": ""Tomatoes - Cherry"",
                                      ""Price"": ""6.15""
                                    }, {
                                      ""Name"": ""Pasta - Agnolotti - Butternut"",
                                      ""Price"": ""6.52""
                                    }, {
                                      ""Name"": ""Thermometer Digital"",
                                      ""Price"": ""3.24""
                                    }, {
                                      ""Name"": ""Bag - Bread, White, Plain"",
                                      ""Price"": ""1.83""
                                    }, {
                                      ""Name"": ""Paper Cocktail Umberlla 80 - 180"",
                                      ""Price"": ""7.20""
                                    }, {
                                      ""Name"": ""Chicken - Base"",
                                      ""Price"": ""7.10""
                                    }, {
                                      ""Name"": ""Doilies - 5, Paper"",
                                      ""Price"": ""5.94""
                                    }, {
                                      ""Name"": ""Pepper - Paprika, Spanish"",
                                      ""Price"": ""1.98""
                                    }, {
                                      ""Name"": ""Ice Cream Bar - Oreo Sandwich"",
                                      ""Price"": ""2.81""
                                    }, {
                                      ""Name"": ""Ham - Black Forest"",
                                      ""Price"": ""3.59""
                                    }, {
                                      ""Name"": ""Crackers - Soda / Saltins"",
                                      ""Price"": ""0.33""
                                    }, {
                                      ""Name"": ""Stainless Steel Cleaner Vision"",
                                      ""Price"": ""0.31""
                                    }, {
                                      ""Name"": ""Bonito Flakes - Toku Katsuo"",
                                      ""Price"": ""8.06""
                                    }, {
                                      ""Name"": ""Onions - Red Pearl"",
                                      ""Price"": ""0.46""
                                    }, {
                                      ""Name"": ""Cheese - Perron Cheddar"",
                                      ""Price"": ""4.67""
                                    }, {
                                      ""Name"": ""Mushroom - Enoki, Dry"",
                                      ""Price"": ""4.71""
                                    }, {
                                      ""Name"": ""Beer - Steamwhistle"",
                                      ""Price"": ""5.62""
                                    }, {
                                      ""Name"": ""Potatoes - Mini Red"",
                                      ""Price"": ""4.83""
                                    }, {
                                      ""Name"": ""Beef - Salted"",
                                      ""Price"": ""7.71""
                                    }, {
                                      ""Name"": ""Wine - White, Pinot Grigio"",
                                      ""Price"": ""2.74""
                                    }, {
                                      ""Name"": ""Long Island Ice Tea"",
                                      ""Price"": ""4.09""
                                    }, {
                                      ""Name"": ""Squid - Breaded"",
                                      ""Price"": ""7.41""
                                    }, {
                                      ""Name"": ""Turkey - Whole, Fresh"",
                                      ""Price"": ""9.12""
                                    }, {
                                      ""Name"": ""Soup - French Onion"",
                                      ""Price"": ""9.93""
                                    }, {
                                      ""Name"": ""Wine - Savigny - Les - Beaune"",
                                      ""Price"": ""2.21""
                                    }, {
                                      ""Name"": ""Glass - Juice Clear 5oz 55005"",
                                      ""Price"": ""2.99""
                                    }, {
                                      ""Name"": ""Lettuce - California Mix"",
                                      ""Price"": ""7.24""
                                    }, {
                                      ""Name"": ""External Supplier"",
                                      ""Price"": ""9.06""
                                    }, {
                                      ""Name"": ""External Supplier"",
                                      ""Price"": ""8.29""
                                    }, {
                                      ""Name"": ""Sauce - Black Current, Dry Mix"",
                                      ""Price"": ""2.50""
                                    }, {
                                      ""Name"": ""Beef - Tenderlion, Center Cut"",
                                      ""Price"": ""2.55""
                                    }, {
                                      ""Name"": ""Oil - Hazelnut"",
                                      ""Price"": ""7.95""
                                    }, {
                                      ""Name"": ""Tea - Herbal - 6 Asst"",
                                      ""Price"": ""7.40""
                                    }, {
                                      ""Name"": ""Pie Shell - 5"",
                                      ""Price"": ""3.90""
                                    }, {
                                      ""Name"": ""Parasol Pick Stir Stick"",
                                      ""Price"": ""0.75""
                                    }, {
                                      ""Name"": ""Beef - Diced"",
                                      ""Price"": ""2.10""
                                    }, {
                                      ""Name"": ""Beans - French"",
                                      ""Price"": ""2.74""
                                    }, {
                                      ""Name"": ""Wine - White, Concha Y Toro"",
                                      ""Price"": ""5.46""
                                    }, {
                                      ""Name"": ""Juice - Tomato, 10 Oz"",
                                      ""Price"": ""9.18""
                                    }, {
                                      ""Name"": ""Mousse - Banana Chocolate"",
                                      ""Price"": ""5.46""
                                    }, {
                                      ""Name"": ""Extract - Almond"",
                                      ""Price"": ""4.67""
                                    }, {
                                      ""Name"": ""Urban Zen Drinks"",
                                      ""Price"": ""8.88""
                                    }, {
                                      ""Name"": ""Artichokes - Jerusalem"",
                                      ""Price"": ""0.06""
                                    }, {
                                      ""Name"": ""Beef Wellington"",
                                      ""Price"": ""0.78""
                                    }, {
                                      ""Name"": ""Mayonnaise - Individual Pkg"",
                                      ""Price"": ""2.15""
                                    }, {
                                      ""Name"": ""Salmon - Whole, 4 - 6 Pounds"",
                                      ""Price"": ""5.75""
                                    }, {
                                      ""Name"": ""Juice - Orangina"",
                                      ""Price"": ""8.41""
                                    }, {
                                      ""Name"": ""Tea - Lemon Green Tea"",
                                      ""Price"": ""2.85""
                                    }, {
                                      ""Name"": ""Tea - Jasmin Green"",
                                      ""Price"": ""5.27""
                                    }, {
                                      ""Name"": ""Wine - Dubouef Macon - Villages"",
                                      ""Price"": ""1.74""
                                    }, {
                                      ""Name"": ""Mousse - Mango"",
                                      ""Price"": ""7.28""
                                    }, {
                                      ""Name"": ""Pear - Halves"",
                                      ""Price"": ""3.38""
                                    }, {
                                      ""Name"": ""Vinegar - Tarragon"",
                                      ""Price"": ""6.14""
                                    }, {
                                      ""Name"": ""Compound - Passion Fruit"",
                                      ""Price"": ""4.88""
                                    }, {
                                      ""Name"": ""Chick Peas - Canned"",
                                      ""Price"": ""8.98""
                                    }, {
                                      ""Name"": ""Basil - Dry, Rubbed"",
                                      ""Price"": ""9.31""
                                    }, {
                                      ""Name"": ""Asparagus - Mexican"",
                                      ""Price"": ""5.08""
                                    }, {
                                      ""Name"": ""Evaporated Milk - Skim"",
                                      ""Price"": ""8.87""
                                    }, {
                                      ""Name"": ""Juice - Apple, 341 Ml"",
                                      ""Price"": ""7.92""
                                    }, {
                                      ""Name"": ""Lamb - Loin, Trimmed, Boneless"",
                                      ""Price"": ""8.56""
                                    }, {
                                      ""Name"": ""Tomatoes - Roma"",
                                      ""Price"": ""6.13""
                                    }, {
                                      ""Name"": ""7up Diet, 355 Ml"",
                                      ""Price"": ""3.53""
                                    }, {
                                      ""Name"": ""Bar Special K"",
                                      ""Price"": ""9.31""
                                    }, {
                                      ""Name"": ""Syrup - Golden, Lyles"",
                                      ""Price"": ""3.07""
                                    }, {
                                      ""Name"": ""Flour - Bread"",
                                      ""Price"": ""8.79""
                                    }, {
                                      ""Name"": ""Shrimp - Black Tiger 16/20"",
                                      ""Price"": ""5.37""
                                    }, {
                                      ""Name"": ""Tea - English Breakfast"",
                                      ""Price"": ""4.64""
                                    }, {
                                      ""Name"": ""Langers - Mango Nectar"",
                                      ""Price"": ""0.59""
                                    }, {
                                      ""Name"": ""Shrimp - Prawn"",
                                      ""Price"": ""1.31""
                                    }, {
                                      ""Name"": ""Rum - White, Gg White"",
                                      ""Price"": ""4.23""
                                    }, {
                                      ""Name"": ""Sugar - Splenda Sweetener"",
                                      ""Price"": ""8.71""
                                    }, {
                                      ""Name"": ""Appetizer - Lobster Phyllo Roll"",
                                      ""Price"": ""0.25""
                                    }, {
                                      ""Name"": ""Rum - White, Gg White"",
                                      ""Price"": ""5.96""
                                    }, {
                                      ""Name"": ""Beef Ground Medium"",
                                      ""Price"": ""2.60""
                                    }, {
                                      ""Name"": ""Cranberries - Fresh"",
                                      ""Price"": ""4.87""
                                    }]");
  }
}
