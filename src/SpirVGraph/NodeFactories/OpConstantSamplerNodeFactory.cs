using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpConstantSamplerNodeFactory : AbstractNodeFactory
    {
        public static readonly OpConstantSamplerNodeFactory Instance = new OpConstantSamplerNodeFactory();

        public OpConstantSamplerNodeFactory():base(new ScriptNode()
        {
            Name = "ConstantSampler",
            Category = NodeCategory.Function,
            Type = "OpConstantSampler",
            InputPins =
            {
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