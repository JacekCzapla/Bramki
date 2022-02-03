// See https://aka.ms/new-console-template for more information
/// <summary>
/// Klasa bazowa bramki
/// </summary>
public class BramkaAbstract
{
    protected BramkaAbstract()
    {

    }

    public BramkaAbstract(string name)
    {
        Name = name;
    }
    public String Name { get; protected set; } = String.Empty;
    public virtual bool Calculate()
    {
        return false;
    }
}
