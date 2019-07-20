using System;
using SpirVGraph.Instructions;

namespace SpirVGraph.Spv
{
    public class Value
    {
        private readonly byte[] _bytes;
        private readonly TypeInstruction _type;

        public Value(byte[] bytes, TypeInstruction type)
        {
            _bytes = bytes;
            _type = type;
        }

        public byte[] Bytes
        {
            get { return _bytes; }
        }

        public TypeInstruction Type
        {
            get { return _type; }
        }

        public float ToFloat(uint offset = 0)
        {
            return BitConverter.ToSingle(_bytes, (int)offset);
        }
        public double ToDouble(uint offset = 0)
        {
            return BitConverter.ToDouble(_bytes, (int)offset);
        }
        public long ToInt64(uint offset = 0)
        {
            return BitConverter.ToInt64(_bytes, (int)offset);
        }
        public int ToInt32(uint offset = 0)
        {
            return BitConverter.ToInt32(_bytes, (int)offset);
        }
        public short ToInt16(uint offset = 0)
        {
            return BitConverter.ToInt16(_bytes, (int)offset);
        }
        public sbyte ToInt8(uint offset = 0)
        {
            return (sbyte)_bytes[(int)offset];
        }
        public ulong ToUInt64(uint offset = 0)
        {
            return BitConverter.ToUInt64(_bytes, (int)offset);
        }
        public uint ToUInt32(uint offset = 0)
        {
            return BitConverter.ToUInt32(_bytes, (int)offset);
        }
        public ushort ToUInt16(uint offset = 0)
        {
            return BitConverter.ToUInt16(_bytes, (int)offset);
        }
        public byte ToUInt8(uint offset = 0)
        {
            return (byte)_bytes[(int)offset];
        }
        public override string ToString()
        {
            if (Type.OpCode == Op.OpTypeFloat)
            {
                if (Type.SizeInWords == 1)
                {
                    return ToFloat().ToString();
                }
                if (Type.SizeInWords == 2)
                {
                    return ToDouble().ToString();
                }
            }
            else if (Type.OpCode == Op.OpTypeInt)
            {
                var op = (OpTypeInt) Type;
                if (op.Signedness== 0)
                {
                    if (op.Width == 8)
                    {
                        return ToInt8().ToString();
                    }
                    if (op.Width == 16)
                    {
                        return ToInt16().ToString();
                    }
                    if (op.Width == 32)
                    {
                        return ToInt32().ToString();
                    }
                    if (op.Width == 64)
                    {
                        return ToInt64().ToString();
                    }
                }
                else
                {
                    if (op.Width == 8)
                    {
                        return ToUInt8().ToString();
                    }
                    if (op.Width == 16)
                    {
                        return ToUInt16().ToString();
                    }
                    if (op.Width == 32)
                    {
                        return ToUInt32().ToString();
                    }
                    if (op.Width == 64)
                    {
                        return ToUInt64().ToString();
                    }
                }
            }
            else if (Type.OpCode == Op.OpTypeVector)
            {
                var op = (OpTypeVector) Type;
            }

            return Type.OpCode+"("+BitConverter.ToString(_bytes)+")";
        }
    }
}