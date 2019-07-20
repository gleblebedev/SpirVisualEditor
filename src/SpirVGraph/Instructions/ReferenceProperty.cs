using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public class ReferenceProperty
    {
        private readonly string _name;
        private readonly IdRef _reference;

        public ReferenceProperty(string name, IdRef reference)
        {
            _name = name;
            _reference = reference;
        }

        public string Name
        {
            get { return _name; }
        }

        public IdRef Reference
        {
            get { return _reference; }
        }
    }
}