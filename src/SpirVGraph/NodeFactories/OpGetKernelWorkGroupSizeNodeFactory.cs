using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGetKernelWorkGroupSizeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGetKernelWorkGroupSizeNodeFactory Instance = new OpGetKernelWorkGroupSizeNodeFactory();

        public OpGetKernelWorkGroupSizeNodeFactory():base(new ScriptNode()
        {
            Name = "GetKernelWorkGroupSize",
            Category = NodeCategory.Function,
            Type = "OpGetKernelWorkGroupSize",
            InputPins =
            {
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