using System;

namespace SpirVGraph.Instructions
{
    public abstract class TypeInstruction : InstructionWithId
    {
        public virtual uint SizeInWords { get {throw new NotImplementedException("Can't evaluate value size of type "+this.OpCode);} }
    }
}