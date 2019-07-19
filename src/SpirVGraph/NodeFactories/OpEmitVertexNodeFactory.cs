using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpEmitVertexNodeFactory : AbstractNodeFactory
    {
        public static readonly OpEmitVertexNodeFactory Instance = new OpEmitVertexNodeFactory();

        public OpEmitVertexNodeFactory():base(new ScriptNode()
        {
            Name = "EmitVertex",
            Category = NodeCategory.Function,
            Type = "OpEmitVertex",
            InputPins =
            {
            },
            OutputPins =
            {
            }
        }, NodeFactoryVisibility.Visible)
        {
        }
    }
}