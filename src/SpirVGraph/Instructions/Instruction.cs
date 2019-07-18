using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class Instruction
    {
        private readonly SpvOp _opCode;

        public Instruction(SpvOp opCode)
        {
            _opCode = opCode;
        }
        public string Name { get; set; }

        public SpvOp OpCode
        {
            get { return _opCode; }
        }
    }
}
