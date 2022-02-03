// See https://aka.ms/new-console-template for more information
public class BramkaOR : BramkaAbstract
{
    public BramkaOR() : base("OR")
    {
        Inputs.Add(new Port { Value = false, Owner = this });
        Inputs.Add(new Port { Value = false, Owner = this });
        Output = new Port { Value = false, Owner = this };
    }

    public List<Port> Inputs { get; set; } = new List<Port>();
    public Port Output { get; set; }
    public override bool Calculate()
    {

        Output.Value = Inputs.Any(x => x.Value == true);
        return Output.Value;
    }
}