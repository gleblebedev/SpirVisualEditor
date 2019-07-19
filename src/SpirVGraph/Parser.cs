using System.Collections.Generic;
using System.IO;
using SpirVGraph.Instructions;
using SpirVGraph.Spv;
using Toe.Scripting;

namespace SpirVGraph
{
    //internal class Parser
    //{
    //    public Parser(BinaryReader reader, int spirvwords)
    //    {
    //        _reader = new WordReader(reader);
    //        _spirvwords = spirvwords;
    //        _script = new Script();
    //    }

    //    public Script Parse()
    //    {
     

    //        var instructions = new List<Instruction>();
    //        var lookupById = new Dictionary<uint, Instruction>();
    //        var names = new Dictionary<uint, string>();
    //        var nodes = new Dictionary<uint, ScriptNode>();
    //        while (_reader.Position < _spirvwords)
    //        {
    //            var instruction = InstructionFactory.Parse(_reader);
    //            switch (instruction.OpCode)
    //            {
    //                case Op.OpName:
    //                {
    //                    var name = (OpName)instruction;
    //                    names[name.Target] = name.Name;
    //                    break;
    //                }
    //                case Op.OpVariable:
    //                {
    //                    var variable = (OpVariable)instruction;
    //                    names.TryGetValue(variable.IdResult, out var name);
    //                    var node = new ScriptNode() {Category = NodeCategory.Parameter, Name = name, OutputPins = { new Pin() }, InputPins = { new PinWithConnection() }};
    //                    _script.Nodes.Add(node);
    //                    nodes[variable.IdResult] = node;
    //                    break;
    //                }
    //                case Op.OpLoad:
    //                {
    //                    var load = (OpLoad)instruction;
    //                    nodes.TryGetValue(load.Pointer, out var source);
    //                    var pointerPin = new PinWithConnection("Pointer", null);
    //                    var node = new ScriptNode() { Category = NodeCategory.Function, Name = "Load", InputPins = { pointerPin }};
    //                    Connect(source, pointerPin);
    //                    _script.Nodes.Add(node);
    //                    nodes[load.IdResult] = node;
    //                    break;
    //                }
    //                case Op.OpSampledImage:
    //                {
    //                    var sampledImage = (OpSampledImage)instruction;
    //                    nodes.TryGetValue(sampledImage.Image, out var image);
    //                    nodes.TryGetValue(sampledImage.Sampler, out var sampler);
    //                    var imagePin = new PinWithConnection("Image", null);
    //                    var samplerPin = new PinWithConnection("Sampler", null);
    //                    var node = new ScriptNode() { Category = NodeCategory.Function, Name = "SampledImage", InputPins = { imagePin, samplerPin } };
    //                    Connect(image, imagePin);
    //                    Connect(sampler, samplerPin);
    //                    _script.Nodes.Add(node);
    //                    nodes[sampledImage.IdResult] = node;
    //                    break;
    //                }
    //                case Op.OpImageSampleImplicitLod:
    //                {
    //                    var sampledImage = (OpImageSampleImplicitLod)instruction;
    //                    nodes.TryGetValue(sampledImage.SampledImage, out var SampledImage);
    //                    nodes.TryGetValue(sampledImage.Coordinate, out var Coordinate);
    //                    var SampledImagePin = new PinWithConnection("SampledImage", null);
    //                    var CoordinatePin = new PinWithConnection("Coordinate", null);
    //                    var node = new ScriptNode() { Category = NodeCategory.Function, Name = "ImageSampleImplicitLod", InputPins = { SampledImagePin, CoordinatePin } };
    //                    Connect(SampledImage, SampledImagePin);
    //                    Connect(Coordinate, CoordinatePin);
    //                    _script.Nodes.Add(node);
    //                    nodes[sampledImage.IdResult] = node;
    //                    break;
    //                }
    //                case Op.OpStore:
    //                {
    //                    var store = (OpStore)instruction;
    //                    nodes.TryGetValue(store.Pointer, out var Pointer);
    //                    nodes.TryGetValue(store.Object, out var Object);
    //                    if (Pointer != null && Pointer.InputPins.Count > 0)
    //                        Connect(Object, Pointer.InputPins[0]);
    //                    break;
    //                }
    //            }
    //            if (instruction.TryGetResultId(out var id))
    //            {
    //                lookupById.Add(id, instruction);
    //            }
    //            instructions.Add(instruction);
    //        }

    //        return _script;
    //    }

    //    private void Connect(ScriptNode source, PinWithConnection pin)
    //    {
    //        if (source != null)
    //        {
    //            if (source.OutputPins.Count == 0)
    //                source.OutputPins.Add(new Pin());
    //            pin.Connection = new Connection(source, source.OutputPins[0]);
    //        }

    //    }


     
    //}
}