using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpMatrixTimesMatrixNodeFactory : AbstractNodeFactory
    {
        public static readonly OpMatrixTimesMatrixNodeFactory Instance = new OpMatrixTimesMatrixNodeFactory();

        public OpMatrixTimesMatrixNodeFactory():base(new ScriptNode()
        {
            Name = "MatrixTimesMatrix",
            Category = NodeCategory.Function,
            Type = "OpMatrixTimesMatrix",
            InputPins =
            {
                new PinWithConnection("LeftMatrix",null),
                new PinWithConnection("RightMatrix",null),
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