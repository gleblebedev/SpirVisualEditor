using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class OpTypePipeNodeFactory : AbstractNodeFactory
    {
        public static readonly OpTypePipeNodeFactory Instance = new OpTypePipeNodeFactory();

        public OpTypePipeNodeFactory():base(new ScriptNode()
        {
            Name = "TypePipe",
            Category = NodeCategory.Function,
            Type = "OpTypePipe",
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