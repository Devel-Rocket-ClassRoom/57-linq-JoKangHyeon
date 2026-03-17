using System;
using System.Collections.Generic;
using System.Linq;


List<Product> products = new List<Product>
{
    new Product("Laptop",   "Electronics", 1200),
    new Product("Mouse",    "Electronics", 25),
    new Product("Keyboard", "Electronics", 75),
    new Product("Shirt",    "Clothing",    50),
    new Product("Pants",    "Clothing",    100),
    new Product("Desk",     "Furniture",   250),
    new Product("Chair",    "Furniture",   150),
    new Product("Monitor",  "Electronics", 300),
};

Console.WriteLine("=== 문제 1: 가격 100 이상 ===");
foreach (var product in products.Where(x => x.Price >= 100)
                               .Select(x => x.Name))
{
    Console.WriteLine(product);
}


Console.WriteLine();
Console.WriteLine("=== 문제 2: Electronics 카테고리 ===");
foreach (var product in products
    .Where(x => x.Category == "Electronics")
    .Select(x => $"{x.Name} - {x.Category} - {x.Price}원"))
{
    Console.WriteLine(product);
}


Console.WriteLine();
Console.WriteLine("=== 문제 3: 이름순 정렬 ===");
foreach (var product in products
    .OrderBy(x => x.Name)
    .Select(x => x.Name))
{
    Console.WriteLine(product);
}


Console.WriteLine();
Console.WriteLine("=== 문제 4: 평균 가격 ===");
Console.WriteLine($"{products.Average(x => x.Price)}원");


Console.WriteLine();
Console.WriteLine("=== 문제 5: 가장 저렴한 상품 ===");
var cheapestProduct = products.OrderBy(x => x.Price).First();
Console.WriteLine($"{cheapestProduct.Name} - {cheapestProduct.Category} - {cheapestProduct.Price}원");


Console.WriteLine();
Console.WriteLine("=== 문제 6: 가장 비싼 상품 ===");
var expensiveProduct = products.OrderByDescending(x => x.Price).First();
Console.WriteLine($"{expensiveProduct.Name} - {expensiveProduct.Category} - {expensiveProduct.Price}원");


Console.WriteLine();
Console.WriteLine("=== 문제 7: Electronics 평균 가격 ==");
double electronicsAvg = products.Where(x => x.Category == "Electronics")
                                .Average(x => x.Price);
Console.WriteLine($"{electronicsAvg}원");


Console.WriteLine();
Console.WriteLine("=== 문제 8: 'o' 포함 상품 (대문자) ===");
foreach (var product in products
    .Select(x => x.Name.ToUpper())
    .Where(x => x.Contains('O')))
{
    Console.WriteLine(product);
}


Console.WriteLine();
Console.WriteLine("=== 문제 9: Clothing 역순 ===");
foreach (var product in products
    .Where(x => x.Category == "Clothing")
    .Select(x => x.Name)
    .OrderDescending())
{
    Console.WriteLine(product);
}


Console.WriteLine();
Console.WriteLine("=== 문제 10: 가격 50~300, 복합 정렬 ===");
foreach (var product in products
    .Where(x => x.Price >= 50 && x.Price <= 300)
    .OrderBy(x => x.Price)
    .ThenBy(x => x.Name)
    .Select(x => $"{x.Name} - {x.Price}원"))
{
    Console.WriteLine(product);
}
