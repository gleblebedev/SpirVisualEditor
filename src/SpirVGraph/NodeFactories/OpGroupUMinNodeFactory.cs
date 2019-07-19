using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupUMinNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupUMinNodeFactory Instance = new OpGroupUMinNodeFactory();

        public OpGroupUMinNodeFactory():base(new ScriptNode()
        {
            Name = "GroupUMin",
            Category = NodeCategory.Function,
            Type = "OpGroupUMin",
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