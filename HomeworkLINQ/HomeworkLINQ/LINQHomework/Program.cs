﻿using Domain.Enums;
using Domain.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml;




static void PrintCollectionItems(IEnumerable collection)
{
    foreach (var item in collection)
    {
        Console.WriteLine($"{item} ");
    }
    Console.WriteLine();
}

static void PrintProducts(List<Product> products)
{
    foreach (Product product in products)
    {
        Console.WriteLine($"{product.Title} ");
    }
    Console.WriteLine();
}

List<Product> products = new List<Product>()
{
    new Product(1, "iPhone 9", "An apple mobile which is nothing like apple", 549, 4.69, 94, "Apple", ProductCategory.Smartphones),
    new Product(2, "iPhone X", "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...", 899, 4.44, 34, "Apple", ProductCategory.Smartphones),
    new Product(3, "Samsung Universe 9", "Samsung's new variant which goes beyond Galaxy to the Universe", 1249, 4.09, 36, "Samsung", ProductCategory.Smartphones),
    new Product(4, "OPPOF19", "OPPO F19 is officially announced on April 2021.", 280, 4.3, 123, "OPPO", ProductCategory.Smartphones),
    new Product(5, "Huawei P30", "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.", 499, 4.09, 32, "Huawei", ProductCategory.Smartphones),
    new Product(6, "MacBook Pro", "MacBook Pro 2021 with mini-LED display may launch between September, November", 1749, 4.57, 83, "Apple", ProductCategory.Laptops),
    new Product(7, "Samsung Galaxy Book", "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched", 1499, 4.25, 50, "Samsung", ProductCategory.Laptops),
    new Product(8, "Microsoft Surface Laptop 4", "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.", 1499, 4.43, 68, "Microsoft Surface", ProductCategory.Laptops),
    new Product(9, "Infinix INBOOK", "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty", 1099, 4.54, 96, "Infinix", ProductCategory.Laptops),
    new Product(10, "HP Pavilion 15-DK1056WM", "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10", 1099, 4.43, 89, "HP Pavilion", ProductCategory.Laptops),
    new Product(11, "perfume Oil", "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil", 13, 4.26, 65, "Impression of Acqua Di Gio", ProductCategory.Fragrances),
    new Product(12, "Brown Perfume", "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml", 40, 4, 52, "Royal_Mirage", ProductCategory.Fragrances),
    new Product(13, "Fog Scent Xpressio Perfume", "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men", 13, 4.59, 61, "Fog Scent Xpressio", ProductCategory.Fragrances),
    new Product(14, "Non-Alcoholic Concentrated Perfume Oil", "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil", 120, 4.21, 114, "Al Munakh", ProductCategory.Fragrances),
    new Product(15, "Eau De Perfume Spray", "Genuine  Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality", 30, 4.7, 105, "Lord - Al-Rehab", ProductCategory.Fragrances),
    new Product(16, "Hyaluronic Acid Serum", "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid", 19, 4.83, 110, "L'Oreal Paris", ProductCategory.Skincare),
    new Product(17, "Tree Oil 30ml", "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,", 12, 4.52, 78, "Hemani Tea", ProductCategory.Skincare),
    new Product(18, "Oil Free Moisturizer 100ml", "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.", 40, 4.56, 88, "Dermive", ProductCategory.Skincare),
    new Product(19, "Skin Beauty Serum.", "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m", 46, 4.42, 54, "ROREC White Rice", ProductCategory.Skincare),
    new Product(20, "Freckle Treatment Cream- 15gm", "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.", 70, 4.06, 140, "Fair & Clear", ProductCategory.Skincare),
    new Product(21, "- Daal Masoor 500 grams", "Fine quality Branded Product Keep in a cool and dry place", 20, 4.44, 133, "Saaf & Khaas", ProductCategory.Groceries),
    new Product(22, "Elbow Macaroni - 400 gm", "Product details of Bake Parlor Big Elbow Macaroni - 400 gm", 14, 4.57, 146, "Bake Parlor Big", ProductCategory.Groceries),
    new Product(23, "Orange Essence Food Flavou", "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item", 14, 4.85, 26, "Baking Food Items", ProductCategory.Groceries)
};


//Console.WriteLine("Products which price is greater than 500: ");
List<Product> productWithPriceGreaterThan500 = products.Where(product => product.Price > 500).ToList();
//PrintProducts(productWithPriceGreaterThan500);

//Console.WriteLine("SkinCare Products: ");
List<Product> skincareCategory = products.Where(product => product.Category == ProductCategory.Skincare).ToList();
//PrintProducts(skincareCategory);

//Console.WriteLine("All product titles: ");
List<string> productTitles = products.Select(product => product.Title).ToList();
//PrintCollectionItems(productTitles);

//Console.WriteLine("Titles of all products in the \"Laptops\" category: ");
List<string> productTitlesInLaptopCategory = products.Where(product => product.Category == ProductCategory.Laptops).Select(product => product.Title).ToList();
//PrintCollectionItems(productTitlesInLaptopCategory);

//Console.WriteLine("Description of products with a stock of less than 50: ");
List<string> stockLessThan50 = products.Where(product => product.Stock < 50).Select(products => products.Description).ToList();
//PrintCollectionItems(stockLessThan50);

//Console.WriteLine("Products with a rating above 4.5: ");
List<string> ratingAbove4 = products.Where(product => product.Rating > 4.5).Select(products => products.Title).ToList();
//PrintCollectionItems(ratingAbove4);

//Console.WriteLine("Product which price is between 100$ and 200$: ");
List<string> productWithPriceBetween100and200 = products.Where(product => product.Price >= 100 && product.Price <= 200).Select(products => products.Title).ToList();
//PrintCollectionItems(productWithPriceBetween100and200);

//Console.WriteLine(@"All product from ""Fragnance"" Category with rating above 4.6: ");
List<string> fragnanceCategory = products.Where(product => product.Category == ProductCategory.Fragrances && product.Rating > 4.6)
    .Select(products => products.Title).ToList();
//PrintCollectionItems(fragnanceCategory);

//Console.WriteLine("Brand of products with a price above 1000$");
//List<string> priceAbove1000 = products.Where(product => product.Price > 1000).Select(products => products.Brand).ToList();
//PrintCollectionItems(priceAbove1000);
//??????????????????????????????????????????????????????????????????????????????????????????????????????????????????????

//Console.WriteLine("Titles of all products with the word \"perfume\" in the title: ");
List<string> wordInTitle = products.Where(product => product.Title.Contains("perfume", StringComparison.OrdinalIgnoreCase)).Select(products => products.Title).ToList();
//PrintCollectionItems(wordInTitle);  // StringComparison.OrdinalIgnoreCase ne mi bese poznato go najdov na internet 

//Console.WriteLine("The last Grocery product: ");
Product lastProduct = products.LastOrDefault(products => products.Category == ProductCategory.Groceries);
//Console.WriteLine(lastProduct.Title);

//Console.WriteLine("First product with a price above $1000");
Product firstProduct = products.FirstOrDefault(products => products.Price > 1000);
//Console.WriteLine(firstProduct.Title);

//Console.WriteLine("Products of Groceries Category with a stock above a 150: ");
List<string> productOfGroceries = products.Where(products => products.Category == ProductCategory.Groceries && products.Stock > 150).Select(products => products.Title).ToList();

if (productOfGroceries.Any())
{
    PrintCollectionItems(productOfGroceries);
}
else
{
    //Console.WriteLine("No products from the 'Groceries' category with a stock above 150 found.");
}

Product firstItemOfBrand = products.FirstOrDefault(products => products.Brand == "Hemani Tea");
//Console.WriteLine(firstItemOfBrand.Title);

//Console.WriteLine("Ratings of all products with a stock between 30 and 50: ");
List<double> ratings = products.Where(products => products.Stock > 30 && products.Stock < 50).Select(products => products.Rating).ToList();
//PrintCollectionItems(ratings);


//bonus

double average = Math.Round(products.Average(products => products.Price));
//Console.WriteLine("Average price of all product is: ");
//Console.WriteLine(average);

int stockInTotal = products.Sum(products => products.Stock);
//Console.WriteLine("Stock in total: ");
//Console.WriteLine(stockInTotal);


Product mostExpensive = products.Where(products=> products.Category == ProductCategory.Laptops).OrderByDescending(products => products.Price).FirstOrDefault();
//Console.WriteLine($"The most expensive laptop is {mostExpensive.Title}");

List<string> allProductFromSkinCare = products.Where(products=> products.Category == ProductCategory.Skincare ).Select(products => $"Title: {products.Title}, Description: {products.Description}").ToList();
//PrintCollectionItems(allProductFromSkinCare);