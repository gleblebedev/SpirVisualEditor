using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupIAddNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupIAddNodeFactory Instance = new OpGroupIAddNodeFactory();

        public OpGroupIAddNodeFactory():base(new ScriptNode()
        {
            Name = "GroupIAdd",
            Category = NodeCategory.Function,
            Type = "OpGroupIAdd",
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