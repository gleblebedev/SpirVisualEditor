using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpCompositeExtractNodeFactory : AbstractNodeFactory
    {
        public static readonly OpCompositeExtractNodeFactory Instance = new OpCompositeExtractNodeFactory();

        public OpCompositeExtractNodeFactory():base(new ScriptNode()
        {
            Name = "CompositeExtract",
            Category = NodeCategory.Function,
            Type = "OpCompositeExtract",
            InputPins =
            {
                new PinWithConnection("Composite",null),
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