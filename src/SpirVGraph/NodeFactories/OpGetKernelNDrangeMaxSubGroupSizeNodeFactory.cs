using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGetKernelNDrangeMaxSubGroupSizeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGetKernelNDrangeMaxSubGroupSizeNodeFactory Instance = new OpGetKernelNDrangeMaxSubGroupSizeNodeFactory();

        public OpGetKernelNDrangeMaxSubGroupSizeNodeFactory():base(new ScriptNode()
        {
            Name = "GetKernelNDrangeMaxSubGroupSize",
            Category = NodeCategory.Function,
            Type = "OpGetKernelNDrangeMaxSubGroupSize",
            InputPins =
            {
                new PinWithConnection("NDRange",null),
                new PinWithConnection("Invoke",null),
                new PinWithConnection("Param",null),
                new PinWithConnection("ParamSize",null),
                new PinWithConnection("ParamAlign",null),
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