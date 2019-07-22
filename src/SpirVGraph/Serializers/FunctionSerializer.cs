using SpirVGraph.Instructions;
using Toe.Scripting;

namespace SpirVGraph.Serializers
{
    public class FunctionSerializer<T> : FunctionSerializer where T:Instruction
    {
        private ReflectionDeserializer<T> _deserializer;

        public virtual void Deserialize(T instruction, ScriptNode node, Deserializer context)
        {
            _deserializer = _deserializer ?? new ReflectionDeserializer<T>(false);
            _deserializer.Deserialize(instruction, node, context);
        }

        public sealed override void Deserialize(Instruction instruction, ScriptNode node, Deserializer context)
        {
            node.Name = typeof(T).Name;
            node.Type = typeof(T).Name;
            node.Category = NodeCategory.Function;
            Deserialize((T)instruction, node, context);
        }
    }

    public abstract class FunctionSerializer: InstructionSerializer
    {
        public static Pin CreateOutputPin(ScriptNode node, TypeInstruction instruction)
        {
            string outputTypeName;
            if (!instruction.TryGetFriendlyName(out outputTypeName))
            {
                outputTypeName = null;
            }

            var item = new Pin("", outputTypeName);
            node.OutputPins.Add(item);
            return item;
        }
    }
}