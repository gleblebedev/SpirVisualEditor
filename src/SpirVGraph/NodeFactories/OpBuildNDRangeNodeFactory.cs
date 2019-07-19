using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpBuildNDRangeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpBuildNDRangeNodeFactory Instance = new OpBuildNDRangeNodeFactory();

        public OpBuildNDRangeNodeFactory():base(new ScriptNode()
        {
            Name = "BuildNDRange",
            Category = NodeCategory.Function,
            Type = "OpBuildNDRange",
            InputPins =
            {
                new PinWithConnection("GlobalWorkSize",null),
                new PinWithConnection("LocalWorkSize",null),
                new PinWithConnection("GlobalWorkOffset",null),
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