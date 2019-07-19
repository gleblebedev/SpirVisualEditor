using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpEmitStreamVertexNodeFactory : AbstractNodeFactory
    {
        public static readonly OpEmitStreamVertexNodeFactory Instance = new OpEmitStreamVertexNodeFactory();

        public OpEmitStreamVertexNodeFactory():base(new ScriptNode()
        {
            Name = "EmitStreamVertex",
            Category = NodeCategory.Function,
            Type = "OpEmitStreamVertex",
            InputPins =
            {
                new PinWithConnection("Stream",null),
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}