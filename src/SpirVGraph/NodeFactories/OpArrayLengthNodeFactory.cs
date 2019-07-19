using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpArrayLengthNodeFactory : AbstractNodeFactory
    {
        public static readonly OpArrayLengthNodeFactory Instance = new OpArrayLengthNodeFactory();

        public OpArrayLengthNodeFactory():base(new ScriptNode()
        {
            Name = "ArrayLength",
            Category = NodeCategory.Function,
            Type = "OpArrayLength",
            InputPins =
            {
                new PinWithConnection("Structure",null),
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