using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupFMinNonUniformAMDNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupFMinNonUniformAMDNodeFactory Instance = new OpGroupFMinNonUniformAMDNodeFactory();

        public OpGroupFMinNonUniformAMDNodeFactory():base(new ScriptNode()
        {
            Name = "GroupFMinNonUniformAMD",
            Category = NodeCategory.Function,
            Type = "OpGroupFMinNonUniformAMD",
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