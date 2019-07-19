using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupUMaxNonUniformAMDNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupUMaxNonUniformAMDNodeFactory Instance = new OpGroupUMaxNonUniformAMDNodeFactory();

        public OpGroupUMaxNonUniformAMDNodeFactory():base(new ScriptNode()
        {
            Name = "GroupUMaxNonUniformAMD",
            Category = NodeCategory.Function,
            Type = "OpGroupUMaxNonUniformAMD",
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