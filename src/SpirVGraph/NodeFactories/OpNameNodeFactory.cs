using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpNameNodeFactory : AbstractNodeFactory
    {
        public static readonly OpNameNodeFactory Instance = new OpNameNodeFactory();

        public OpNameNodeFactory():base(new ScriptNode()
        {
            Name = "Name",
            Category = NodeCategory.Function,
            Type = "OpName",
            InputPins =
            {
                new PinWithConnection("Target",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}