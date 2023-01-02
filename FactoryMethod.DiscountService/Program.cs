﻿using FactoryMethod.DiscountService;

Console.Title = "Factory Method";

var factories = new List<DiscountFactory>
{
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("BE")
};

foreach (var discountService in factories.Select(factory => factory.CreateDiscountService()))
{
    Console.WriteLine(
        $"Percentage {discountService.DiscountPercentage} " +
        $"coming from {discountService}");
}

Console.ReadKey();