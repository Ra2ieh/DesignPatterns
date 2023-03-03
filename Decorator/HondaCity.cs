
namespace Decorator
{
    public class HondaCity : Vehicle
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
