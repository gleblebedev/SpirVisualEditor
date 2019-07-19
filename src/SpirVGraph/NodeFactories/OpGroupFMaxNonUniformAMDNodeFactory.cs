using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupFMaxNonUniformAMDNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupFMaxNonUniformAMDNodeFactory Instance = new OpGroupFMaxNonUniformAMDNodeFactory();

        public OpGroupFMaxNonUniformAMDNodeFactory():base(new ScriptNode()
        {
            Name = "GroupFMaxNonUniformAMD",
            Category = NodeCategory.Function,
            Type = "OpGroupFMaxNonUniformAMD",
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