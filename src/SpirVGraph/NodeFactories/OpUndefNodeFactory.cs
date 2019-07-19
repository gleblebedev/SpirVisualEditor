using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpUndefNodeFactory : AbstractNodeFactory
    {
        public static readonly OpUndefNodeFactory Instance = new OpUndefNodeFactory();

        public OpUndefNodeFactory():base(new ScriptNode()
        {
            Name = "Undef",
            Category = NodeCategory.Function,
            Type = "OpUndef",
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