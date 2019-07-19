namespace SpirVGraph.Spv
{
    public struct IdAndLiteral
    {
        private readonly uint _id;
        private readonly uint _literal;

        public IdAndLiteral(uint id, uint literal)
        {
            _id = id;
            _literal = literal;
        }
    }
}