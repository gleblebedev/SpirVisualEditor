using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpExtInst: Instruction
    {
        public OpExtInst()
        {
        }

        public override Op OpCode { get { return Op.OpExtInst; } }
    }
}