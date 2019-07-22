using System;
using SpirVGraph.Instructions;
using SpirVGraph.Spv;
using Toe.Scripting;

namespace SpirVGraph.NodeFactories
{
    public class SpvNodeRegistry: AbstractNodeRegistry
    {
        public SpvNodeRegistry()
        {
            var mainFunction = new NodeFactory("main", nameof(OpFunction))
                .WithExitPin();
            Add(mainFunction);
            var functionEnd = new NodeFactory(nameof(OpFunctionEnd))
                .WithEnterPin();
            Add(functionEnd);
            var label = new NodeFactory(nameof(OpLabel))
                .WithEnterPin()
                .WithExitPin();
            Add(label);
        }
    }
}