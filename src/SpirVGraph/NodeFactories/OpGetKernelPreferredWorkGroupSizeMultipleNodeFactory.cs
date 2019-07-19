using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpGetKernelPreferredWorkGroupSizeMultipleNodeFactory : AbstractNodeFactory
    {
        public static readonly OpGetKernelPreferredWorkGroupSizeMultipleNodeFactory Instance = new OpGetKernelPreferredWorkGroupSizeMultipleNodeFactory();

        public OpGetKernelPreferredWorkGroupSizeMultipleNodeFactory():base(new ScriptNode()
        {
            Name = "GetKernelPreferredWorkGroupSizeMultiple",
            Category = NodeCategory.Function,
            Type = "OpGetKernelPreferredWorkGroupSizeMultiple",
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