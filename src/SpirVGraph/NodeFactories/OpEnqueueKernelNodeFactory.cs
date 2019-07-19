using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpEnqueueKernelNodeFactory : AbstractNodeFactory
    {
        public static readonly OpEnqueueKernelNodeFactory Instance = new OpEnqueueKernelNodeFactory();

        public OpEnqueueKernelNodeFactory():base(new ScriptNode()
        {
            Name = "EnqueueKernel",
            Category = NodeCategory.Function,
            Type = "OpEnqueueKernel",
            InputPins =
            {
                new PinWithConnection("Queue",null),
                new PinWithConnection("Flags",null),
                new PinWithConnection("NDRange",null),
                new PinWithConnection("NumEvents",null),
                new PinWithConnection("WaitEvents",null),
                new PinWithConnection("RetEvent",null),
                new PinWithConnection("Invoke",null),
                new PinWithConnection("Param",null),
                new PinWithConnection("ParamSize",null),
                new PinWithConnection("ParamAlign",null),
                new PinWithConnection("LocalSize",null),
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