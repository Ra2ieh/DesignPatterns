
namespace Decorator;

public abstract class Decorator : IVehicle
{
    private IVehicle _vehicle;
    public Decorator(IVehicle vehicle)
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
