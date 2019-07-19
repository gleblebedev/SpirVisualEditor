using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpCompositeInsertNodeFactory : AbstractNodeFactory
    {
        public static readonly OpCompositeInsertNodeFactory Instance = new OpCompositeInsertNodeFactory();

        public OpCompositeInsertNodeFactory():base(new ScriptNode()
        {
            Name = "CompositeInsert",
            Category = NodeCategory.Function,
            Type = "OpCompositeInsert",
            InputPins =
            {
                new PinWithConnection("Object",null),
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