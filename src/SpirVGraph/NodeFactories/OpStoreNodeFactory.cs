using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpStoreNodeFactory : AbstractNodeFactory
    {
        public static readonly OpStoreNodeFactory Instance = new OpStoreNodeFactory();

        public OpStoreNodeFactory():base(new ScriptNode()
        {
            Name = "Store",
            Category = NodeCategory.Function,
            Type = "OpStore",
            InputPins =
            {
                new PinWithConnection("Pointer",null),
                new PinWithConnection("Object",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}