using System.Collections.Generic;
using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class NodeFactory : INodeFactory
    {
        private static readonly string[] _emptyCategory = new string[0];
        private IReadOnlyCollection<string> _inputTypes;
        private IReadOnlyCollection<string> _outputTypes;
        private readonly ScriptNode _prototype;

        public NodeFactory(string name, string type = null)
        {
            _prototype = new ScriptNode {Name = name, Type = type ?? name};
        }

        public NodeFactory(NodeFactory prototype, string name, string type = null)
        {
            _prototype = prototype._prototype.CloneNew();
            _prototype.Name = name;
            _prototype.Type = type ?? name;
            Category = prototype.Category;
            Visibility = prototype.Visibility;
        }

        public NodeFactory(ScriptNode prototype)
        {
            _prototype = prototype.CloneNew();
        }

        public NodeCategory NodeCategory => _prototype.Category;

        public NodeFactoryVisibility Visibility { get; set; } = NodeFactoryVisibility.Visible;

        public IEnumerable<string> InputTypes => _inputTypes ?? (_inputTypes = CollectTypes(_prototype.InputPins));

        public IEnumerable<string> OutputTypes => _outputTypes ?? (_outputTypes = CollectTypes(_prototype.OutputPins));

        public string Type => _prototype.Type;
        public string Name => _prototype.Name;
        public string[] Category { get; set; } = _emptyCategory;

        public bool HasEnterPins => _prototype.EnterPins.Count > 0;

        public bool HasExitPins => _prototype.ExitPins.Count > 0;

        public ScriptNode Build()
        {
            return _prototype.CloneNew();
        }

        private IReadOnlyCollection<string> CollectTypes(IEnumerable<Pin> prototypeInputPins)
        {
            var set = new HashSet<string>();
            foreach (var pin in prototypeInputPins) set.Add(pin.Type);
            return set;
        }


        public NodeFactory WithEnterPin(string id = null)
        {
            return ReplaceOrAdd(_prototype.EnterPins, new Pin(id, null));
        }

        public NodeFactory WithExitPin(string id = null)
        {
            return ReplaceOrAdd(_prototype.ExitPins, new PinWithConnection(id, null));
        }

        public NodeFactory WithOutputPin(string id, string type)
        {
            return ReplaceOrAdd(_prototype.OutputPins, new Pin(id, type));
        }

        public NodeFactory WithInputPin(string id, string type)
        {
            return ReplaceOrAdd(_prototype.InputPins, new PinWithConnection(id, type));
        }

        public NodeFactory WithValue(string value)
        {
            _prototype.Value = value;
            return this;
        }
        public NodeFactory WithCategory(params string[] category)
        {
            Category = category;
            return this;
        }
        public NodeFactory Hidden()
        {
            Visibility = NodeFactoryVisibility.Hidden;
            return this;
        }

        private NodeFactory ReplaceOrAdd<T>(IList<T> enterPins, T pin) where T : Pin
        {
            for (var index = 0; index < enterPins.Count; index++)
                if (enterPins[index].Id == pin.Id)
                    enterPins[index] = pin;
            enterPins.Add(pin);
            return this;
        }
    }
}