using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupFAddNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupFAddNodeFactory Instance = new OpGroupFAddNodeFactory();

        public OpGroupFAddNodeFactory():base(new ScriptNode()
        {
            Name = "GroupFAdd",
            Category = NodeCategory.Function,
            Type = "OpGroupFAdd",
            InputPins =
            {
                new PinWithConnection("X",null),
            },
            OutputPins =
            {
                new Pin("out",null),
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}