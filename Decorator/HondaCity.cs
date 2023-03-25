
namespace Decorator
{
    public class HondaCity : IVehicle
    {
        public string Make {
            get
            {
                return "HondaCity";
            }
        }

        public string Model
        {
            get
            {
                return "Cng";
            }

        }

        public double Price
        {
            get
            {
                return 1000000;
            }

        }
    }
}
