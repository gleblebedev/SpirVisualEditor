using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFragmentFetchAMDNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFragmentFetchAMDNodeFactory Instance = new OpFragmentFetchAMDNodeFactory();

        public OpFragmentFetchAMDNodeFactory():base(new ScriptNode()
        {
            Name = "FragmentFetchAMD",
            Category = NodeCategory.Function,
            Type = "OpFragmentFetchAMD",
            InputPins =
            {
                new PinWithConnection("Image",null),
                new PinWithConnection("Coordinate",null),
                new PinWithConnection("FragmentIndex",null),
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