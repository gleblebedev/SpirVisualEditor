using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypeImageNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypeImageNodeFactory Instance = new OpTypeImageNodeFactory();

        public OpTypeImageNodeFactory():base(new ScriptNode()
        {
            Name = "TypeImage",
            Category = NodeCategory.Function,
            Type = "OpTypeImage",
            InputPins =
            {
                new PinWithConnection("SampledType",null),
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