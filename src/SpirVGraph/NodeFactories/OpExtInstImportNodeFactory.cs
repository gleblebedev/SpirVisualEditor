using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpExtInstImportNodeFactory : AbstractNodeFactory
    {
        public static readonly OpExtInstImportNodeFactory Instance = new OpExtInstImportNodeFactory();

        public OpExtInstImportNodeFactory():base(new ScriptNode()
        {
            Name = "ExtInstImport",
            Category = NodeCategory.Function,
            Type = "OpExtInstImport",
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