// See https://aka.ms/new-console-template for more information
/// <summary>
/// Klasa dla punktu połączeniowego
/// </summary>
public class Port
{
    public BramkaAbstract? Owner { get; set; }
    public bool Value { get; set; }

    /// <summary>
    /// połązenie do następnej bramki lub wynik końcowy
    /// </summary>
    public Port? NextPort { get; set; }
    /// <summary>
    /// połączenie do wcześniejszej bramki lub wartość początkowa
    /// </summary>
    public Port? PreviousPort { get; set; }
}
