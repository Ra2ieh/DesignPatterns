namespace Decorator;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        HondaCity car =new HondaCity();
        Console.WriteLine($"The real price is :{car.Price}");

        SpecialOffer offer=new SpecialOffer(car);
        offer.DiscountPercentage = 25;
        offer.Offer = "25 % discount";
        Console.WriteLine($"{offer.Offer} @ Diwali Special Offer and price are : {offer.Price} " );

        Console.ReadKey();
    }
}