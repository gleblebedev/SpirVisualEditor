using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageNodeFactory Instance = new OpImageNodeFactory();

        public OpImageNodeFactory():base(new ScriptNode()
        {
            Name = "Image",
            Category = NodeCategory.Function,
            Type = "OpImage",
            InputPins =
            {
                new PinWithConnection("SampledImage",null),
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