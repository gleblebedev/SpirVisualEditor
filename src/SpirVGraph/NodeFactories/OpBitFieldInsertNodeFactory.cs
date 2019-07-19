using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpBitFieldInsertNodeFactory : AbstractNodeFactory
    {
        public static readonly OpBitFieldInsertNodeFactory Instance = new OpBitFieldInsertNodeFactory();

        public OpBitFieldInsertNodeFactory():base(new ScriptNode()
        {
            Name = "BitFieldInsert",
            Category = NodeCategory.Function,
            Type = "OpBitFieldInsert",
            InputPins =
            {
                new PinWithConnection("Base",null),
                new PinWithConnection("Insert",null),
                new PinWithConnection("Offset",null),
                new PinWithConnection("Count",null),
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