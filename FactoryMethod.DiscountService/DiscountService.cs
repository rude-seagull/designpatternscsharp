﻿namespace FactoryMethod.DiscountService;

public abstract class DiscountService
{
    public abstract int DiscountPercentage { get; }
    public override string ToString()
    {
        return GetType().Name;
    }
}