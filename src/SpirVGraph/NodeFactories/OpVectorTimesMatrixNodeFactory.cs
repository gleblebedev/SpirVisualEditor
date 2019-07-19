using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpVectorTimesMatrixNodeFactory : AbstractNodeFactory
    {
        public static readonly OpVectorTimesMatrixNodeFactory Instance = new OpVectorTimesMatrixNodeFactory();

        public OpVectorTimesMatrixNodeFactory():base(new ScriptNode()
        {
            Name = "VectorTimesMatrix",
            Category = NodeCategory.Function,
            Type = "OpVectorTimesMatrix",
            InputPins =
            {
                new PinWithConnection("Vector",null),
                new PinWithConnection("Matrix",null),
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