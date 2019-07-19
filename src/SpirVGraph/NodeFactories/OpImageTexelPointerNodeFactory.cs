using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageTexelPointerNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageTexelPointerNodeFactory Instance = new OpImageTexelPointerNodeFactory();

        public OpImageTexelPointerNodeFactory():base(new ScriptNode()
        {
            Name = "ImageTexelPointer",
            Category = NodeCategory.Function,
            Type = "OpImageTexelPointer",
            InputPins =
            {
                new PinWithConnection("Image",null),
                new PinWithConnection("Coordinate",null),
                new PinWithConnection("Sample",null),
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