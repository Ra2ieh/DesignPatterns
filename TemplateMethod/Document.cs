namespace TemplateMethod;
public abstract class Document
{
    public void Print()
    {
        Console.WriteLine("Printing is started ....");
        PrintHeader();
        PrintBody();
        PrintFooter();
        Console.WriteLine("Printing is ended!");
    }
    public abstract void PrintHeader();
    public abstract void PrintBody();
    public abstract void PrintFooter();
}
