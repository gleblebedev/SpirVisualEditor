using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpImageSparseTexelsResidentNodeFactory : AbstractNodeFactory
    {
        public static readonly OpImageSparseTexelsResidentNodeFactory Instance = new OpImageSparseTexelsResidentNodeFactory();

        public OpImageSparseTexelsResidentNodeFactory():base(new ScriptNode()
        {
            Name = "ImageSparseTexelsResident",
            Category = NodeCategory.Function,
            Type = "OpImageSparseTexelsResident",
            InputPins =
            {
                new PinWithConnection("ResidentCode",null),
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