using System.Collections.Generic;
using System.Reflection;
using SpirVGraph.Instructions;
using SpirVGraph.Spv;
using Toe.Scripting;

namespace SpirVGraph.Serializers
{
    public class ReflectionDeserializer<T> where T:Instruction
    {
        private readonly bool _hasExecutionPins;
        public List<PropertyInfo> _idRefs = new List<PropertyInfo>();
        private PropertyInfo _type;
        public ReflectionDeserializer(bool hasExecutionPins)
        {
            _hasExecutionPins = hasExecutionPins;
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                if (typeof(IdRef).IsAssignableFrom(property.PropertyType))
                {
                    if (property.Name == "IdResultType")
                    {
                        if (!hasExecutionPins)
                        {
                            _type = property;
                        }
                    }
                    else if (property.Name == "IdResult")
                    {
                    }
                    else if (property.Name == "FunctionType")
                    {
                    }
                    else
                    {
                        _idRefs.Add(property);
                    }
                }
            }
        }

        public void Deserialize(T instruction, ScriptNode node, Deserializer context)
        {
            if (!_hasExecutionPins && _type != null)
            {
                IdRef<TypeInstruction> value = (IdRef<TypeInstruction>) _type.GetValue(instruction);
                FunctionSerializer.CreateOutputPin(node, value.Instruction);
            }

            if (_hasExecutionPins)
            {
                node.EnterPins.Add(new Pin("", null));
                node.ExitPins.Add(new PinWithConnection("",null));
            }

            foreach (var idRef in _idRefs)
            {
                var sourceRef = (IdRef)idRef.GetValue(instruction);
                if (sourceRef != null)
                {
                    var source = context.Deserialize(sourceRef.Instruction);
                    if (source.OutputPins.Count > 0)
                    {
                        node.InputPins.Add(new PinWithConnection(idRef.Name, source.OutputPins[0].Type)
                            { Connection = new Connection(source, source.OutputPins[0]) });
                    }
                    else
                    {
                        node.InputPins.Add(new PinWithConnection(idRef.Name, null));
                    }
                }
                else
                {
                    node.InputPins.Add(new PinWithConnection(idRef.Name, null));
                }
            }
        }
    }
}