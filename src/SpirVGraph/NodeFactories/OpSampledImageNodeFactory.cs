using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpSampledImageNodeFactory : AbstractNodeFactory
    {
        public static readonly OpSampledImageNodeFactory Instance = new OpSampledImageNodeFactory();

        public OpSampledImageNodeFactory():base(new ScriptNode()
        {
            Name = "SampledImage",
            Category = NodeCategory.Function,
            Type = "OpSampledImage",
            InputPins =
            {
                new PinWithConnection("Image",null),
                new PinWithConnection("Sampler",null),
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