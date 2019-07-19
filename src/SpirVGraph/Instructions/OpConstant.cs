using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class OpConstant: Instruction
    {
        public OpConstant()
        {
        }

        public override Op OpCode { get { return Op.OpConstant; } }
    }
}