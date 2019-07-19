using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpFragmentMaskFetchAMDNodeFactory : AbstractNodeFactory
    {
        public static readonly OpFragmentMaskFetchAMDNodeFactory Instance = new OpFragmentMaskFetchAMDNodeFactory();

        public OpFragmentMaskFetchAMDNodeFactory():base(new ScriptNode()
        {
            Name = "FragmentMaskFetchAMD",
            Category = NodeCategory.Function,
            Type = "OpFragmentMaskFetchAMD",
            InputPins =
            {
                new PinWithConnection("Image",null),
                new PinWithConnection("Coordinate",null),
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