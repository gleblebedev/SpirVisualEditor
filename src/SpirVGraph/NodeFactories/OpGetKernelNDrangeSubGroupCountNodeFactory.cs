using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGetKernelNDrangeSubGroupCountNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGetKernelNDrangeSubGroupCountNodeFactory Instance = new OpGetKernelNDrangeSubGroupCountNodeFactory();

        public OpGetKernelNDrangeSubGroupCountNodeFactory():base(new ScriptNode()
        {
            Name = "GetKernelNDrangeSubGroupCount",
            Category = NodeCategory.Function,
            Type = "OpGetKernelNDrangeSubGroupCount",
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