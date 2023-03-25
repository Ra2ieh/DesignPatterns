
namespace Bridge;

public class ExtendedAbstraction : Abstraction
{
    public ExtendedAbstraction(Bridge implementation) : base(implementation)
    {
    }

    public override string Operation()
    {
        return "ExtendedAbstraction: Extended operation with:\n" +
            base._implementation.OperationImplementation();
    }
}
