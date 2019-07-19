using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpMatrixTimesScalarNodeFactory : AbstractNodeFactory
    {
        public static readonly OpMatrixTimesScalarNodeFactory Instance = new OpMatrixTimesScalarNodeFactory();

        public OpMatrixTimesScalarNodeFactory():base(new ScriptNode()
        {
            Name = "MatrixTimesScalar",
            Category = NodeCategory.Function,
            Type = "OpMatrixTimesScalar",
            InputPins =
            {
                new PinWithConnection("Matrix",null),
                new PinWithConnection("Scalar",null),
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