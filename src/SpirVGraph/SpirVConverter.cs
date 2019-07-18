using System;
using System.IO;
using System.Security.Cryptography;
using Toe.Scripting;

namespace SpirVGraph
{
    public class SpirVConverter
    {
        public static Script Deserialize(byte[] spirvBytes)
        {
            if (spirvBytes.Length % 4 != 0)
            {
                throw new FormatException("SpirV bytecode length should be divisable by 4");
            }
            using (var reader = new BinaryReader(new MemoryStream(spirvBytes)))
            {
                var parser = new Parser(reader, spirvBytes.Length/4);
                return parser.Parse();

            }
        }

        public static byte[] Serialize(Script script)
        {
            throw new NotImplementedException();
        }
    }
}
