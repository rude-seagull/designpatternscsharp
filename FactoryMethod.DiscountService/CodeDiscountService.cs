namespace FactoryMethod.DiscountService;

public class CodeDiscountService : DiscountService
{
    private readonly Guid _code;

    public CodeDiscountService(Guid code)
    {
        _code = code;
    }

    public override int DiscountPercentage
    {
        // each code returns the same fixed percentage, but a code is only 
        // valid once - include a check to so whether the code's been used before
        // ... 
        get => 15;
    }
}