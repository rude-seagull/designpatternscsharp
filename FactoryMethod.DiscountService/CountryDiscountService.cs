namespace FactoryMethod.DiscountService;

public class CountryDiscountService : DiscountService
{
    private readonly string _countryIdentifier;

    public CountryDiscountService(string countryIdentifier)
    {
        _countryIdentifier = countryIdentifier;
    }

    public override int DiscountPercentage
    {
        get
        {
            return _countryIdentifier switch
            {
                "US" => 20,
                "BE" => 30,
                _ => 10
            };
        }
    }
}