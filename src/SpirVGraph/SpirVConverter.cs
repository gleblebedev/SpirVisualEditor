using System;
using Toe.Scripting;

namespace SpirVGraph
{
    public class SpirVConverter
    {
        public static Script Deserialize(byte[] spirvBytes)
        {
            var shader = Shader.Parse(spirvBytes);
            var script = new Script();
            foreach (var instruction in shader.Instructions)
            {
                uint id;
                if (instruction.TryGetResultId(out id))
                {

                }
            }

            return script;
        }

        public static byte[] Serialize(Script script)
        {
            throw new NotImplementedException();
        }
    }
}