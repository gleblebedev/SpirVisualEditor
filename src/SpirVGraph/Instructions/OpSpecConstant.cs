using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpSpecConstant: Instruction
    {
        public OpSpecConstant()
        {
        }

        public override Op OpCode { get { return Op.OpSpecConstant; } }
    }
}