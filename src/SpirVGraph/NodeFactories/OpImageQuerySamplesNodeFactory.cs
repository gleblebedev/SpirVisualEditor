using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageQuerySamplesNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageQuerySamplesNodeFactory Instance = new OpImageQuerySamplesNodeFactory();

        public OpImageQuerySamplesNodeFactory():base(new ScriptNode()
        {
            Name = "ImageQuerySamples",
            Category = NodeCategory.Function,
            Type = "OpImageQuerySamples",
            InputPins =
            {
                new PinWithConnection("Image",null),
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