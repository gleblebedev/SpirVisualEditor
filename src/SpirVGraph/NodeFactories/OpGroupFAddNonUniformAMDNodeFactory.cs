using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupFAddNonUniformAMDNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupFAddNonUniformAMDNodeFactory Instance = new OpGroupFAddNonUniformAMDNodeFactory();

        public OpGroupFAddNonUniformAMDNodeFactory():base(new ScriptNode()
        {
            Name = "GroupFAddNonUniformAMD",
            Category = NodeCategory.Function,
            Type = "OpGroupFAddNonUniformAMD",
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