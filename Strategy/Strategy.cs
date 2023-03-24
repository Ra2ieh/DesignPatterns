

namespace Strategy;

public class Strategy
{
    private readonly ICategory _category;
    public Strategy(ICategory category)
    {
       _category = category;
    }
    public void CallName(string name )
    {
        Console.WriteLine(_category.GetName());
    }
}
