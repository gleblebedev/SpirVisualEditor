using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpSpecConstantOp: Instruction
    {
        public OpSpecConstantOp()
        {
        }

        public override Op OpCode { get { return Op.OpSpecConstantOp; } }
    }
}