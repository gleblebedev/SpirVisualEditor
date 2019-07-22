using SpirVGraph.Instructions;
using Toe.Scripting;

namespace SpirVGraph.Serializers
{
    public class ProcedureSerializer<T> : ProcedureSerializer where T:Instruction
    {
        private ReflectionDeserializer<T> _deserializer;

        public virtual void Deserialize(T instruction, ScriptNode node, Deserializer context)
        {
            _deserializer = _deserializer ?? new ReflectionDeserializer<T>(true);
            _deserializer.Deserialize(instruction, node, context);
        }

        public sealed override void Deserialize(Instruction instruction, ScriptNode node, Deserializer context)
        {
            node.Name = typeof(T).Name;
            node.Type = typeof(T).Name;
            node.Category = NodeCategory.Procedure;
            Deserialize((T)instruction, node, context);
        }
    }

    public abstract class ProcedureSerializer: InstructionSerializer
    {

    }
}