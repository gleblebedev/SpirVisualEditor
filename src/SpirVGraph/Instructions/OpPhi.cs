using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpPhi: Instruction
    {
        public OpPhi()
        {
        }

        public override Op OpCode { get { return Op.OpPhi; } }
    }
}