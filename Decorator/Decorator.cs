
namespace Decorator;

public abstract class Decorator : Vehicle
{
    private Vehicle _vehicle;
    public Decorator(Vehicle vehicle)
    {
        _vehicle = vehicle;
    }
    public string Make
    {
        get { return _vehicle.Make; }
    }

    public string Model
    {
        get { return _vehicle.Model; }
    }

    public double Price
    {
        get { return _vehicle.Price; }
    }
}
