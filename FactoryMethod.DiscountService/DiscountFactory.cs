namespace FactoryMethod.DiscountService;

public abstract class DiscountFactory
{
    public abstract DiscountService CreateDiscountService();
}