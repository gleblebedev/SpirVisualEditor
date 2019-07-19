using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpMatrixTimesVectorNodeFactory : AbstractNodeFactory
    {
        public static readonly OpMatrixTimesVectorNodeFactory Instance = new OpMatrixTimesVectorNodeFactory();

        public OpMatrixTimesVectorNodeFactory():base(new ScriptNode()
        {
            Name = "MatrixTimesVector",
            Category = NodeCategory.Function,
            Type = "OpMatrixTimesVector",
            InputPins =
            {
                new PinWithConnection("Matrix",null),
                new PinWithConnection("Vector",null),
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