using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpVectorTimesScalarNodeFactory : AbstractNodeFactory
    {
        public static readonly OpVectorTimesScalarNodeFactory Instance = new OpVectorTimesScalarNodeFactory();

        public OpVectorTimesScalarNodeFactory():base(new ScriptNode()
        {
            Name = "VectorTimesScalar",
            Category = NodeCategory.Function,
            Type = "OpVectorTimesScalar",
            InputPins =
            {
                new PinWithConnection("Vector",null),
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