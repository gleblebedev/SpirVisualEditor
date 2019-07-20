using System.Collections.Generic;
using System.Linq;
using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class AbstractNodeFactory: INodeFactory
    {
        private readonly ScriptNode _prototype;
        private string[] _category = new string[0];
        private NodeFactoryVisibility _visibility;
        private IEnumerable<string> _inputTypes;
        private IEnumerable<string> _outputTypes;

        public AbstractNodeFactory(ScriptNode prototype, NodeFactoryVisibility visibility)
        {
            _prototype = prototype;
            _visibility = visibility;
            _inputTypes = prototype.InputPins.Select(_ => _.Type).Distinct().ToList();
            _outputTypes = prototype.OutputPins.Select(_ => _.Type).Distinct().ToList();
        }

        public string Type => _prototype.Type;

        public string Name => _prototype.Name;

        public string[] Category => _category;

        public NodeFactoryVisibility Visibility => _visibility;

        public IEnumerable<string> InputTypes => _inputTypes;

        public IEnumerable<string> OutputTypes => _outputTypes;

        public bool HasEnterPins => _prototype.EnterPins.Count > 0;

        public bool HasExitPins => _prototype.ExitPins.Count > 0;

        public ScriptNode Build()
        {
            return _prototype.CloneNew();
        }
    }
}
