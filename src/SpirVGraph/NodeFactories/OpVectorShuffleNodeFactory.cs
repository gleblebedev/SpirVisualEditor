using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpVectorShuffleNodeFactory : AbstractNodeFactory
    {
        public static readonly OpVectorShuffleNodeFactory Instance = new OpVectorShuffleNodeFactory();

        public OpVectorShuffleNodeFactory():base(new ScriptNode()
        {
            Name = "VectorShuffle",
            Category = NodeCategory.Function,
            Type = "OpVectorShuffle",
            InputPins =
            {
                new PinWithConnection("Vector1",null),
                new PinWithConnection("Vector2",null),
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