// See https://aka.ms/new-console-template for more information
public class BramkaNOT : BramkaAbstract 
{
    public BramkaNOT() : base("NOT")
    {
        Input = new Port { Value = false, Owner = this };
        Output = new Port { Value = false, Owner = this };
    }
    public Port Input { get; set; }
    public Port Output { get; set; }

    public override bool Calculate()
    {
        Output.Value = !Input.Value;
        return Output.Value;
    }
}
