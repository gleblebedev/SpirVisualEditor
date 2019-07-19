using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSparseReadNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSparseReadNodeFactory Instance = new OpImageSparseReadNodeFactory();

        public OpImageSparseReadNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSparseRead",
            Category = NodeCategory.Function,
            Type = "OpImageSparseRead",
            InputPins =
            {
                new PinWithConnection("Image",null),
                new PinWithConnection("Coordinate",null),
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