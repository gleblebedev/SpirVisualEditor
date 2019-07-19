using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupIAddNonUniformAMDNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupIAddNonUniformAMDNodeFactory Instance = new OpGroupIAddNonUniformAMDNodeFactory();

        public OpGroupIAddNonUniformAMDNodeFactory():base(new ScriptNode()
        {
            Name = "GroupIAddNonUniformAMD",
            Category = NodeCategory.Function,
            Type = "OpGroupIAddNonUniformAMD",
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