using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGroupUMinNonUniformAMDNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGroupUMinNonUniformAMDNodeFactory Instance = new OpGroupUMinNonUniformAMDNodeFactory();

        public OpGroupUMinNonUniformAMDNodeFactory():base(new ScriptNode()
        {
            Name = "GroupUMinNonUniformAMD",
            Category = NodeCategory.Function,
            Type = "OpGroupUMinNonUniformAMD",
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