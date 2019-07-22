using System;
using SpirVGraph.NodeFactories;
using Toe.Scripting;

namespace SpirVGraph
{
    public class SpirVConverter
    {
        public static Script Deserialize(byte[] spirvBytes)
        {
            return new Deserializer(Shader.Parse(spirvBytes)).Deserialize();
        }

        public static byte[] Serialize(Script script)
        {
            throw new NotImplementedException();
        }
    }
}