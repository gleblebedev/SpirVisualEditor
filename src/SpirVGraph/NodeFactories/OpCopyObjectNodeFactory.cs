using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpCopyObjectNodeFactory : AbstractNodeFactory
    {
        public static readonly OpCopyObjectNodeFactory Instance = new OpCopyObjectNodeFactory();

        public OpCopyObjectNodeFactory():base(new ScriptNode()
        {
            Name = "CopyObject",
            Category = NodeCategory.Function,
            Type = "OpCopyObject",
            InputPins =
            {
                new PinWithConnection("Operand",null),
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