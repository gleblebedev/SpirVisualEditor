using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpPhiNodeFactory : AbstractNodeFactory
    {
        public static readonly OpPhiNodeFactory Instance = new OpPhiNodeFactory();

        public OpPhiNodeFactory():base(new ScriptNode()
        {
            Name = "Phi",
            Category = NodeCategory.Function,
            Type = "OpPhi",
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