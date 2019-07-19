using System;
using System.Collections.Generic;
using System.Linq;
using SpirVGraph.Instructions;
using SpirVGraph.NodeFactories;
using SpirVGraph.Spv;
using Toe.Scripting;

namespace SpirVGraph
{
    public class Deserializer
    {
        private readonly Shader _shader;
        private readonly SpvNodeRegistry _registry;
        private Dictionary<uint, ScriptNode> _nodeById = new Dictionary<uint, ScriptNode>();

        public Deserializer(Shader shader, SpvNodeRegistry registry)
        {
            _shader = shader;
            _registry = registry;
        }
        public Script Deserialize()
        {
            var script = new Script();
            var nodes = new List<Tuple<Instruction, ScriptNode>>();
            foreach (var instruction in _shader.Instructions)
            {
                var node = _registry.Resolve(instruction.OpCode).Build();
                if (node != null)
                {
                    script.Nodes.Add(node);
                    if (instruction.TryGetResultId(out var id))
                    {
                        _nodeById.Add(id, node);
                    }
                    nodes.Add(Tuple.Create(instruction, node));
                }
            }

            foreach (var tuple in nodes)
            {
                var instruction = tuple.Item1;
                var node = tuple.Item2;
                switch (instruction.OpCode)
                {

                    case Op.OpName:
                        {
                            var i = (OpName)instruction;
                            Connect(i.Target, node, "Target");
                            break;
                        }
                    case Op.OpMemberName:
                        {
                            var i = (OpMemberName)instruction;
                            Connect(i.Type, node, "Type");
                            break;
                        }
                    case Op.OpLine:
                        {
                            var i = (OpLine)instruction;
                            Connect(i.File, node, "File");
                            break;
                        }
                    case Op.OpExtInst:
                        {
                            var i = (OpExtInst)instruction;
                            Connect(i.Set, node, "Set");
                            break;
                        }
                    case Op.OpEntryPoint:
                        {
                            var i = (OpEntryPoint)instruction;
                            Connect(i.EntryPoint, node, "EntryPoint");
                            break;
                        }
                    case Op.OpExecutionMode:
                        {
                            var i = (OpExecutionMode)instruction;
                            Connect(i.EntryPoint, node, "EntryPoint");
                            break;
                        }
                    case Op.OpTypeVector:
                        {
                            var i = (OpTypeVector)instruction;
                            Connect(i.ComponentType, node, "ComponentType");
                            break;
                        }
                    case Op.OpTypeMatrix:
                        {
                            var i = (OpTypeMatrix)instruction;
                            Connect(i.ColumnType, node, "ColumnType");
                            break;
                        }
                    case Op.OpTypeImage:
                        {
                            var i = (OpTypeImage)instruction;
                            Connect(i.SampledType, node, "SampledType");
                            break;
                        }
                    case Op.OpTypeSampledImage:
                        {
                            var i = (OpTypeSampledImage)instruction;
                            Connect(i.ImageType, node, "ImageType");
                            break;
                        }
                    case Op.OpTypeArray:
                        {
                            var i = (OpTypeArray)instruction;
                            Connect(i.ElementType, node, "ElementType");
                            Connect(i.Length, node, "Length");
                            break;
                        }
                    case Op.OpTypeRuntimeArray:
                        {
                            var i = (OpTypeRuntimeArray)instruction;
                            Connect(i.ElementType, node, "ElementType");
                            break;
                        }
                    case Op.OpTypePointer:
                        {
                            var i = (OpTypePointer)instruction;
                            Connect(i.Type, node, "Type");
                            break;
                        }
                    case Op.OpTypeFunction:
                        {
                            var i = (OpTypeFunction)instruction;
                            Connect(i.ReturnType, node, "ReturnType");
                            break;
                        }
                    case Op.OpTypeForwardPointer:
                        {
                            var i = (OpTypeForwardPointer)instruction;
                            Connect(i.PointerType, node, "PointerType");
                            break;
                        }
                    case Op.OpFunction:
                        {
                            var i = (OpFunction)instruction;
                            Connect(i.FunctionType, node, "FunctionType");
                            break;
                        }
                    case Op.OpFunctionCall:
                        {
                            var i = (OpFunctionCall)instruction;
                            Connect(i.Function, node, "Function");
                            break;
                        }
                    case Op.OpImageTexelPointer:
                        {
                            var i = (OpImageTexelPointer)instruction;
                            Connect(i.Image, node, "Image");
                            Connect(i.Coordinate, node, "Coordinate");
                            Connect(i.Sample, node, "Sample");
                            break;
                        }
                    case Op.OpLoad:
                        {
                            var i = (OpLoad)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            break;
                        }
                    case Op.OpStore:
                        {
                            var i = (OpStore)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.Object, node, "Object");
                            break;
                        }
                    case Op.OpCopyMemory:
                        {
                            var i = (OpCopyMemory)instruction;
                            Connect(i.Target, node, "Target");
                            Connect(i.Source, node, "Source");
                            break;
                        }
                    case Op.OpCopyMemorySized:
                        {
                            var i = (OpCopyMemorySized)instruction;
                            Connect(i.Target, node, "Target");
                            Connect(i.Source, node, "Source");
                            Connect(i.Size, node, "Size");
                            break;
                        }
                    case Op.OpAccessChain:
                        {
                            var i = (OpAccessChain)instruction;
                            Connect(i.Base, node, "Base");
                            break;
                        }
                    case Op.OpInBoundsAccessChain:
                        {
                            var i = (OpInBoundsAccessChain)instruction;
                            Connect(i.Base, node, "Base");
                            break;
                        }
                    case Op.OpPtrAccessChain:
                        {
                            var i = (OpPtrAccessChain)instruction;
                            Connect(i.Base, node, "Base");
                            Connect(i.Element, node, "Element");
                            break;
                        }
                    case Op.OpArrayLength:
                        {
                            var i = (OpArrayLength)instruction;
                            Connect(i.Structure, node, "Structure");
                            break;
                        }
                    case Op.OpGenericPtrMemSemantics:
                        {
                            var i = (OpGenericPtrMemSemantics)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            break;
                        }
                    case Op.OpInBoundsPtrAccessChain:
                        {
                            var i = (OpInBoundsPtrAccessChain)instruction;
                            Connect(i.Base, node, "Base");
                            Connect(i.Element, node, "Element");
                            break;
                        }
                    case Op.OpDecorate:
                        {
                            var i = (OpDecorate)instruction;
                            Connect(i.Target, node, "Target");
                            break;
                        }
                    case Op.OpMemberDecorate:
                        {
                            var i = (OpMemberDecorate)instruction;
                            Connect(i.StructureType, node, "StructureType");
                            break;
                        }
                    case Op.OpGroupDecorate:
                        {
                            var i = (OpGroupDecorate)instruction;
                            Connect(i.DecorationGroup, node, "DecorationGroup");
                            break;
                        }
                    case Op.OpGroupMemberDecorate:
                        {
                            var i = (OpGroupMemberDecorate)instruction;
                            Connect(i.DecorationGroup, node, "DecorationGroup");
                            break;
                        }
                    case Op.OpVectorExtractDynamic:
                        {
                            var i = (OpVectorExtractDynamic)instruction;
                            Connect(i.Vector, node, "Vector");
                            Connect(i.Index, node, "Index");
                            break;
                        }
                    case Op.OpVectorInsertDynamic:
                        {
                            var i = (OpVectorInsertDynamic)instruction;
                            Connect(i.Vector, node, "Vector");
                            Connect(i.Component, node, "Component");
                            Connect(i.Index, node, "Index");
                            break;
                        }
                    case Op.OpVectorShuffle:
                        {
                            var i = (OpVectorShuffle)instruction;
                            Connect(i.Vector1, node, "Vector1");
                            Connect(i.Vector2, node, "Vector2");
                            break;
                        }
                    case Op.OpCompositeExtract:
                        {
                            var i = (OpCompositeExtract)instruction;
                            Connect(i.Composite, node, "Composite");
                            break;
                        }
                    case Op.OpCompositeInsert:
                        {
                            var i = (OpCompositeInsert)instruction;
                            Connect(i.Object, node, "Object");
                            Connect(i.Composite, node, "Composite");
                            break;
                        }
                    case Op.OpCopyObject:
                        {
                            var i = (OpCopyObject)instruction;
                            Connect(i.Operand, node, "Operand");
                            break;
                        }
                    case Op.OpTranspose:
                        {
                            var i = (OpTranspose)instruction;
                            Connect(i.Matrix, node, "Matrix");
                            break;
                        }
                    case Op.OpSampledImage:
                        {
                            var i = (OpSampledImage)instruction;
                            Connect(i.Image, node, "Image");
                            Connect(i.Sampler, node, "Sampler");
                            break;
                        }
                    case Op.OpImageSampleImplicitLod:
                        {
                            var i = (OpImageSampleImplicitLod)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            break;
                        }
                    case Op.OpImageSampleExplicitLod:
                        {
                            var i = (OpImageSampleExplicitLod)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            break;
                        }
                    case Op.OpImageSampleDrefImplicitLod:
                        {
                            var i = (OpImageSampleDrefImplicitLod)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            Connect(i.D_ref, node, "D_ref");
                            break;
                        }
                    case Op.OpImageSampleDrefExplicitLod:
                        {
                            var i = (OpImageSampleDrefExplicitLod)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            Connect(i.D_ref, node, "D_ref");
                            break;
                        }
                    case Op.OpImageSampleProjImplicitLod:
                        {
                            var i = (OpImageSampleProjImplicitLod)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            break;
                        }
                    case Op.OpImageSampleProjExplicitLod:
                        {
                            var i = (OpImageSampleProjExplicitLod)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            break;
                        }
                    case Op.OpImageSampleProjDrefImplicitLod:
                        {
                            var i = (OpImageSampleProjDrefImplicitLod)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            Connect(i.D_ref, node, "D_ref");
                            break;
                        }
                    case Op.OpImageSampleProjDrefExplicitLod:
                        {
                            var i = (OpImageSampleProjDrefExplicitLod)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            Connect(i.D_ref, node, "D_ref");
                            break;
                        }
                    case Op.OpImageFetch:
                        {
                            var i = (OpImageFetch)instruction;
                            Connect(i.Image, node, "Image");
                            Connect(i.Coordinate, node, "Coordinate");
                            break;
                        }
                    case Op.OpImageGather:
                        {
                            var i = (OpImageGather)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            Connect(i.Component, node, "Component");
                            break;
                        }
                    case Op.OpImageDrefGather:
                        {
                            var i = (OpImageDrefGather)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            Connect(i.D_ref, node, "D_ref");
                            break;
                        }
                    case Op.OpImageRead:
                        {
                            var i = (OpImageRead)instruction;
                            Connect(i.Image, node, "Image");
                            Connect(i.Coordinate, node, "Coordinate");
                            break;
                        }
                    case Op.OpImageWrite:
                        {
                            var i = (OpImageWrite)instruction;
                            Connect(i.Image, node, "Image");
                            Connect(i.Coordinate, node, "Coordinate");
                            Connect(i.Texel, node, "Texel");
                            break;
                        }
                    case Op.OpImage:
                        {
                            var i = (OpImage)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            break;
                        }
                    case Op.OpImageQueryFormat:
                        {
                            var i = (OpImageQueryFormat)instruction;
                            Connect(i.Image, node, "Image");
                            break;
                        }
                    case Op.OpImageQueryOrder:
                        {
                            var i = (OpImageQueryOrder)instruction;
                            Connect(i.Image, node, "Image");
                            break;
                        }
                    case Op.OpImageQuerySizeLod:
                        {
                            var i = (OpImageQuerySizeLod)instruction;
                            Connect(i.Image, node, "Image");
                            Connect(i.LevelofDetail, node, "LevelofDetail");
                            break;
                        }
                    case Op.OpImageQuerySize:
                        {
                            var i = (OpImageQuerySize)instruction;
                            Connect(i.Image, node, "Image");
                            break;
                        }
                    case Op.OpImageQueryLod:
                        {
                            var i = (OpImageQueryLod)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            break;
                        }
                    case Op.OpImageQueryLevels:
                        {
                            var i = (OpImageQueryLevels)instruction;
                            Connect(i.Image, node, "Image");
                            break;
                        }
                    case Op.OpImageQuerySamples:
                        {
                            var i = (OpImageQuerySamples)instruction;
                            Connect(i.Image, node, "Image");
                            break;
                        }
                    case Op.OpConvertFToU:
                        {
                            var i = (OpConvertFToU)instruction;
                            Connect(i.FloatValue, node, "FloatValue");
                            break;
                        }
                    case Op.OpConvertFToS:
                        {
                            var i = (OpConvertFToS)instruction;
                            Connect(i.FloatValue, node, "FloatValue");
                            break;
                        }
                    case Op.OpConvertSToF:
                        {
                            var i = (OpConvertSToF)instruction;
                            Connect(i.SignedValue, node, "SignedValue");
                            break;
                        }
                    case Op.OpConvertUToF:
                        {
                            var i = (OpConvertUToF)instruction;
                            Connect(i.UnsignedValue, node, "UnsignedValue");
                            break;
                        }
                    case Op.OpUConvert:
                        {
                            var i = (OpUConvert)instruction;
                            Connect(i.UnsignedValue, node, "UnsignedValue");
                            break;
                        }
                    case Op.OpSConvert:
                        {
                            var i = (OpSConvert)instruction;
                            Connect(i.SignedValue, node, "SignedValue");
                            break;
                        }
                    case Op.OpFConvert:
                        {
                            var i = (OpFConvert)instruction;
                            Connect(i.FloatValue, node, "FloatValue");
                            break;
                        }
                    case Op.OpQuantizeToF16:
                        {
                            var i = (OpQuantizeToF16)instruction;
                            Connect(i.Value, node, "Value");
                            break;
                        }
                    case Op.OpConvertPtrToU:
                        {
                            var i = (OpConvertPtrToU)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            break;
                        }
                    case Op.OpSatConvertSToU:
                        {
                            var i = (OpSatConvertSToU)instruction;
                            Connect(i.SignedValue, node, "SignedValue");
                            break;
                        }
                    case Op.OpSatConvertUToS:
                        {
                            var i = (OpSatConvertUToS)instruction;
                            Connect(i.UnsignedValue, node, "UnsignedValue");
                            break;
                        }
                    case Op.OpConvertUToPtr:
                        {
                            var i = (OpConvertUToPtr)instruction;
                            Connect(i.IntegerValue, node, "IntegerValue");
                            break;
                        }
                    case Op.OpPtrCastToGeneric:
                        {
                            var i = (OpPtrCastToGeneric)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            break;
                        }
                    case Op.OpGenericCastToPtr:
                        {
                            var i = (OpGenericCastToPtr)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            break;
                        }
                    case Op.OpGenericCastToPtrExplicit:
                        {
                            var i = (OpGenericCastToPtrExplicit)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            break;
                        }
                    case Op.OpBitcast:
                        {
                            var i = (OpBitcast)instruction;
                            Connect(i.Operand, node, "Operand");
                            break;
                        }
                    case Op.OpSNegate:
                        {
                            var i = (OpSNegate)instruction;
                            Connect(i.Operand, node, "Operand");
                            break;
                        }
                    case Op.OpFNegate:
                        {
                            var i = (OpFNegate)instruction;
                            Connect(i.Operand, node, "Operand");
                            break;
                        }
                    case Op.OpIAdd:
                        {
                            var i = (OpIAdd)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFAdd:
                        {
                            var i = (OpFAdd)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpISub:
                        {
                            var i = (OpISub)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFSub:
                        {
                            var i = (OpFSub)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpIMul:
                        {
                            var i = (OpIMul)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFMul:
                        {
                            var i = (OpFMul)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpUDiv:
                        {
                            var i = (OpUDiv)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpSDiv:
                        {
                            var i = (OpSDiv)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFDiv:
                        {
                            var i = (OpFDiv)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpUMod:
                        {
                            var i = (OpUMod)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpSRem:
                        {
                            var i = (OpSRem)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpSMod:
                        {
                            var i = (OpSMod)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFRem:
                        {
                            var i = (OpFRem)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFMod:
                        {
                            var i = (OpFMod)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpVectorTimesScalar:
                        {
                            var i = (OpVectorTimesScalar)instruction;
                            Connect(i.Vector, node, "Vector");
                            Connect(i.Scalar, node, "Scalar");
                            break;
                        }
                    case Op.OpMatrixTimesScalar:
                        {
                            var i = (OpMatrixTimesScalar)instruction;
                            Connect(i.Matrix, node, "Matrix");
                            Connect(i.Scalar, node, "Scalar");
                            break;
                        }
                    case Op.OpVectorTimesMatrix:
                        {
                            var i = (OpVectorTimesMatrix)instruction;
                            Connect(i.Vector, node, "Vector");
                            Connect(i.Matrix, node, "Matrix");
                            break;
                        }
                    case Op.OpMatrixTimesVector:
                        {
                            var i = (OpMatrixTimesVector)instruction;
                            Connect(i.Matrix, node, "Matrix");
                            Connect(i.Vector, node, "Vector");
                            break;
                        }
                    case Op.OpMatrixTimesMatrix:
                        {
                            var i = (OpMatrixTimesMatrix)instruction;
                            Connect(i.LeftMatrix, node, "LeftMatrix");
                            Connect(i.RightMatrix, node, "RightMatrix");
                            break;
                        }
                    case Op.OpOuterProduct:
                        {
                            var i = (OpOuterProduct)instruction;
                            Connect(i.Vector1, node, "Vector1");
                            Connect(i.Vector2, node, "Vector2");
                            break;
                        }
                    case Op.OpDot:
                        {
                            var i = (OpDot)instruction;
                            Connect(i.Vector1, node, "Vector1");
                            Connect(i.Vector2, node, "Vector2");
                            break;
                        }
                    case Op.OpIAddCarry:
                        {
                            var i = (OpIAddCarry)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpISubBorrow:
                        {
                            var i = (OpISubBorrow)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpUMulExtended:
                        {
                            var i = (OpUMulExtended)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpSMulExtended:
                        {
                            var i = (OpSMulExtended)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpAny:
                        {
                            var i = (OpAny)instruction;
                            Connect(i.Vector, node, "Vector");
                            break;
                        }
                    case Op.OpAll:
                        {
                            var i = (OpAll)instruction;
                            Connect(i.Vector, node, "Vector");
                            break;
                        }
                    case Op.OpIsNan:
                        {
                            var i = (OpIsNan)instruction;
                            Connect(i.x, node, "x");
                            break;
                        }
                    case Op.OpIsInf:
                        {
                            var i = (OpIsInf)instruction;
                            Connect(i.x, node, "x");
                            break;
                        }
                    case Op.OpIsFinite:
                        {
                            var i = (OpIsFinite)instruction;
                            Connect(i.x, node, "x");
                            break;
                        }
                    case Op.OpIsNormal:
                        {
                            var i = (OpIsNormal)instruction;
                            Connect(i.x, node, "x");
                            break;
                        }
                    case Op.OpSignBitSet:
                        {
                            var i = (OpSignBitSet)instruction;
                            Connect(i.x, node, "x");
                            break;
                        }
                    case Op.OpLessOrGreater:
                        {
                            var i = (OpLessOrGreater)instruction;
                            Connect(i.x, node, "x");
                            Connect(i.y, node, "y");
                            break;
                        }
                    case Op.OpOrdered:
                        {
                            var i = (OpOrdered)instruction;
                            Connect(i.x, node, "x");
                            Connect(i.y, node, "y");
                            break;
                        }
                    case Op.OpUnordered:
                        {
                            var i = (OpUnordered)instruction;
                            Connect(i.x, node, "x");
                            Connect(i.y, node, "y");
                            break;
                        }
                    case Op.OpLogicalEqual:
                        {
                            var i = (OpLogicalEqual)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpLogicalNotEqual:
                        {
                            var i = (OpLogicalNotEqual)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpLogicalOr:
                        {
                            var i = (OpLogicalOr)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpLogicalAnd:
                        {
                            var i = (OpLogicalAnd)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpLogicalNot:
                        {
                            var i = (OpLogicalNot)instruction;
                            Connect(i.Operand, node, "Operand");
                            break;
                        }
                    case Op.OpSelect:
                        {
                            var i = (OpSelect)instruction;
                            Connect(i.Condition, node, "Condition");
                            Connect(i.Object1, node, "Object1");
                            Connect(i.Object2, node, "Object2");
                            break;
                        }
                    case Op.OpIEqual:
                        {
                            var i = (OpIEqual)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpINotEqual:
                        {
                            var i = (OpINotEqual)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpUGreaterThan:
                        {
                            var i = (OpUGreaterThan)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpSGreaterThan:
                        {
                            var i = (OpSGreaterThan)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpUGreaterThanEqual:
                        {
                            var i = (OpUGreaterThanEqual)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpSGreaterThanEqual:
                        {
                            var i = (OpSGreaterThanEqual)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpULessThan:
                        {
                            var i = (OpULessThan)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpSLessThan:
                        {
                            var i = (OpSLessThan)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpULessThanEqual:
                        {
                            var i = (OpULessThanEqual)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpSLessThanEqual:
                        {
                            var i = (OpSLessThanEqual)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFOrdEqual:
                        {
                            var i = (OpFOrdEqual)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFUnordEqual:
                        {
                            var i = (OpFUnordEqual)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFOrdNotEqual:
                        {
                            var i = (OpFOrdNotEqual)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFUnordNotEqual:
                        {
                            var i = (OpFUnordNotEqual)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFOrdLessThan:
                        {
                            var i = (OpFOrdLessThan)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFUnordLessThan:
                        {
                            var i = (OpFUnordLessThan)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFOrdGreaterThan:
                        {
                            var i = (OpFOrdGreaterThan)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFUnordGreaterThan:
                        {
                            var i = (OpFUnordGreaterThan)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFOrdLessThanEqual:
                        {
                            var i = (OpFOrdLessThanEqual)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFUnordLessThanEqual:
                        {
                            var i = (OpFUnordLessThanEqual)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFOrdGreaterThanEqual:
                        {
                            var i = (OpFOrdGreaterThanEqual)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpFUnordGreaterThanEqual:
                        {
                            var i = (OpFUnordGreaterThanEqual)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpShiftRightLogical:
                        {
                            var i = (OpShiftRightLogical)instruction;
                            Connect(i.Base, node, "Base");
                            Connect(i.Shift, node, "Shift");
                            break;
                        }
                    case Op.OpShiftRightArithmetic:
                        {
                            var i = (OpShiftRightArithmetic)instruction;
                            Connect(i.Base, node, "Base");
                            Connect(i.Shift, node, "Shift");
                            break;
                        }
                    case Op.OpShiftLeftLogical:
                        {
                            var i = (OpShiftLeftLogical)instruction;
                            Connect(i.Base, node, "Base");
                            Connect(i.Shift, node, "Shift");
                            break;
                        }
                    case Op.OpBitwiseOr:
                        {
                            var i = (OpBitwiseOr)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpBitwiseXor:
                        {
                            var i = (OpBitwiseXor)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpBitwiseAnd:
                        {
                            var i = (OpBitwiseAnd)instruction;
                            Connect(i.Operand1, node, "Operand1");
                            Connect(i.Operand2, node, "Operand2");
                            break;
                        }
                    case Op.OpNot:
                        {
                            var i = (OpNot)instruction;
                            Connect(i.Operand, node, "Operand");
                            break;
                        }
                    case Op.OpBitFieldInsert:
                        {
                            var i = (OpBitFieldInsert)instruction;
                            Connect(i.Base, node, "Base");
                            Connect(i.Insert, node, "Insert");
                            Connect(i.Offset, node, "Offset");
                            Connect(i.Count, node, "Count");
                            break;
                        }
                    case Op.OpBitFieldSExtract:
                        {
                            var i = (OpBitFieldSExtract)instruction;
                            Connect(i.Base, node, "Base");
                            Connect(i.Offset, node, "Offset");
                            Connect(i.Count, node, "Count");
                            break;
                        }
                    case Op.OpBitFieldUExtract:
                        {
                            var i = (OpBitFieldUExtract)instruction;
                            Connect(i.Base, node, "Base");
                            Connect(i.Offset, node, "Offset");
                            Connect(i.Count, node, "Count");
                            break;
                        }
                    case Op.OpBitReverse:
                        {
                            var i = (OpBitReverse)instruction;
                            Connect(i.Base, node, "Base");
                            break;
                        }
                    case Op.OpBitCount:
                        {
                            var i = (OpBitCount)instruction;
                            Connect(i.Base, node, "Base");
                            break;
                        }
                    case Op.OpDPdx:
                        {
                            var i = (OpDPdx)instruction;
                            Connect(i.P, node, "P");
                            break;
                        }
                    case Op.OpDPdy:
                        {
                            var i = (OpDPdy)instruction;
                            Connect(i.P, node, "P");
                            break;
                        }
                    case Op.OpFwidth:
                        {
                            var i = (OpFwidth)instruction;
                            Connect(i.P, node, "P");
                            break;
                        }
                    case Op.OpDPdxFine:
                        {
                            var i = (OpDPdxFine)instruction;
                            Connect(i.P, node, "P");
                            break;
                        }
                    case Op.OpDPdyFine:
                        {
                            var i = (OpDPdyFine)instruction;
                            Connect(i.P, node, "P");
                            break;
                        }
                    case Op.OpFwidthFine:
                        {
                            var i = (OpFwidthFine)instruction;
                            Connect(i.P, node, "P");
                            break;
                        }
                    case Op.OpDPdxCoarse:
                        {
                            var i = (OpDPdxCoarse)instruction;
                            Connect(i.P, node, "P");
                            break;
                        }
                    case Op.OpDPdyCoarse:
                        {
                            var i = (OpDPdyCoarse)instruction;
                            Connect(i.P, node, "P");
                            break;
                        }
                    case Op.OpFwidthCoarse:
                        {
                            var i = (OpFwidthCoarse)instruction;
                            Connect(i.P, node, "P");
                            break;
                        }
                    case Op.OpEmitStreamVertex:
                        {
                            var i = (OpEmitStreamVertex)instruction;
                            Connect(i.Stream, node, "Stream");
                            break;
                        }
                    case Op.OpEndStreamPrimitive:
                        {
                            var i = (OpEndStreamPrimitive)instruction;
                            Connect(i.Stream, node, "Stream");
                            break;
                        }
                    case Op.OpAtomicLoad:
                        {
                            var i = (OpAtomicLoad)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            break;
                        }
                    case Op.OpAtomicStore:
                        {
                            var i = (OpAtomicStore)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.Value, node, "Value");
                            break;
                        }
                    case Op.OpAtomicExchange:
                        {
                            var i = (OpAtomicExchange)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.Value, node, "Value");
                            break;
                        }
                    case Op.OpAtomicCompareExchange:
                        {
                            var i = (OpAtomicCompareExchange)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.Value, node, "Value");
                            Connect(i.Comparator, node, "Comparator");
                            break;
                        }
                    case Op.OpAtomicCompareExchangeWeak:
                        {
                            var i = (OpAtomicCompareExchangeWeak)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.Value, node, "Value");
                            Connect(i.Comparator, node, "Comparator");
                            break;
                        }
                    case Op.OpAtomicIIncrement:
                        {
                            var i = (OpAtomicIIncrement)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            break;
                        }
                    case Op.OpAtomicIDecrement:
                        {
                            var i = (OpAtomicIDecrement)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            break;
                        }
                    case Op.OpAtomicIAdd:
                        {
                            var i = (OpAtomicIAdd)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.Value, node, "Value");
                            break;
                        }
                    case Op.OpAtomicISub:
                        {
                            var i = (OpAtomicISub)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.Value, node, "Value");
                            break;
                        }
                    case Op.OpAtomicSMin:
                        {
                            var i = (OpAtomicSMin)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.Value, node, "Value");
                            break;
                        }
                    case Op.OpAtomicUMin:
                        {
                            var i = (OpAtomicUMin)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.Value, node, "Value");
                            break;
                        }
                    case Op.OpAtomicSMax:
                        {
                            var i = (OpAtomicSMax)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.Value, node, "Value");
                            break;
                        }
                    case Op.OpAtomicUMax:
                        {
                            var i = (OpAtomicUMax)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.Value, node, "Value");
                            break;
                        }
                    case Op.OpAtomicAnd:
                        {
                            var i = (OpAtomicAnd)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.Value, node, "Value");
                            break;
                        }
                    case Op.OpAtomicOr:
                        {
                            var i = (OpAtomicOr)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.Value, node, "Value");
                            break;
                        }
                    case Op.OpAtomicXor:
                        {
                            var i = (OpAtomicXor)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.Value, node, "Value");
                            break;
                        }
                    case Op.OpLoopMerge:
                        {
                            var i = (OpLoopMerge)instruction;
                            Connect(i.MergeBlock, node, "MergeBlock");
                            Connect(i.ContinueTarget, node, "ContinueTarget");
                            break;
                        }
                    case Op.OpSelectionMerge:
                        {
                            var i = (OpSelectionMerge)instruction;
                            Connect(i.MergeBlock, node, "MergeBlock");
                            break;
                        }
                    case Op.OpBranch:
                        {
                            var i = (OpBranch)instruction;
                            Connect(i.TargetLabel, node, "TargetLabel");
                            break;
                        }
                    case Op.OpBranchConditional:
                        {
                            var i = (OpBranchConditional)instruction;
                            Connect(i.Condition, node, "Condition");
                            Connect(i.TrueLabel, node, "TrueLabel");
                            Connect(i.FalseLabel, node, "FalseLabel");
                            break;
                        }
                    case Op.OpSwitch:
                        {
                            var i = (OpSwitch)instruction;
                            Connect(i.Selector, node, "Selector");
                            Connect(i.Default, node, "Default");
                            break;
                        }
                    case Op.OpReturnValue:
                        {
                            var i = (OpReturnValue)instruction;
                            Connect(i.Value, node, "Value");
                            break;
                        }
                    case Op.OpLifetimeStart:
                        {
                            var i = (OpLifetimeStart)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            break;
                        }
                    case Op.OpLifetimeStop:
                        {
                            var i = (OpLifetimeStop)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            break;
                        }
                    case Op.OpGroupAsyncCopy:
                        {
                            var i = (OpGroupAsyncCopy)instruction;
                            Connect(i.Destination, node, "Destination");
                            Connect(i.Source, node, "Source");
                            Connect(i.NumElements, node, "NumElements");
                            Connect(i.Stride, node, "Stride");
                            Connect(i.Event, node, "Event");
                            break;
                        }
                    case Op.OpGroupWaitEvents:
                        {
                            var i = (OpGroupWaitEvents)instruction;
                            Connect(i.NumEvents, node, "NumEvents");
                            Connect(i.EventsList, node, "EventsList");
                            break;
                        }
                    case Op.OpGroupAll:
                        {
                            var i = (OpGroupAll)instruction;
                            Connect(i.Predicate, node, "Predicate");
                            break;
                        }
                    case Op.OpGroupAny:
                        {
                            var i = (OpGroupAny)instruction;
                            Connect(i.Predicate, node, "Predicate");
                            break;
                        }
                    case Op.OpGroupBroadcast:
                        {
                            var i = (OpGroupBroadcast)instruction;
                            Connect(i.Value, node, "Value");
                            Connect(i.LocalId, node, "LocalId");
                            break;
                        }
                    case Op.OpGroupIAdd:
                        {
                            var i = (OpGroupIAdd)instruction;
                            Connect(i.X, node, "X");
                            break;
                        }
                    case Op.OpGroupFAdd:
                        {
                            var i = (OpGroupFAdd)instruction;
                            Connect(i.X, node, "X");
                            break;
                        }
                    case Op.OpGroupFMin:
                        {
                            var i = (OpGroupFMin)instruction;
                            Connect(i.X, node, "X");
                            break;
                        }
                    case Op.OpGroupUMin:
                        {
                            var i = (OpGroupUMin)instruction;
                            Connect(i.X, node, "X");
                            break;
                        }
                    case Op.OpGroupSMin:
                        {
                            var i = (OpGroupSMin)instruction;
                            Connect(i.X, node, "X");
                            break;
                        }
                    case Op.OpGroupFMax:
                        {
                            var i = (OpGroupFMax)instruction;
                            Connect(i.X, node, "X");
                            break;
                        }
                    case Op.OpGroupUMax:
                        {
                            var i = (OpGroupUMax)instruction;
                            Connect(i.X, node, "X");
                            break;
                        }
                    case Op.OpGroupSMax:
                        {
                            var i = (OpGroupSMax)instruction;
                            Connect(i.X, node, "X");
                            break;
                        }
                    case Op.OpReadPipe:
                        {
                            var i = (OpReadPipe)instruction;
                            Connect(i.Pipe, node, "Pipe");
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.PacketSize, node, "PacketSize");
                            Connect(i.PacketAlignment, node, "PacketAlignment");
                            break;
                        }
                    case Op.OpWritePipe:
                        {
                            var i = (OpWritePipe)instruction;
                            Connect(i.Pipe, node, "Pipe");
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.PacketSize, node, "PacketSize");
                            Connect(i.PacketAlignment, node, "PacketAlignment");
                            break;
                        }
                    case Op.OpReservedReadPipe:
                        {
                            var i = (OpReservedReadPipe)instruction;
                            Connect(i.Pipe, node, "Pipe");
                            Connect(i.ReserveId, node, "ReserveId");
                            Connect(i.Index, node, "Index");
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.PacketSize, node, "PacketSize");
                            Connect(i.PacketAlignment, node, "PacketAlignment");
                            break;
                        }
                    case Op.OpReservedWritePipe:
                        {
                            var i = (OpReservedWritePipe)instruction;
                            Connect(i.Pipe, node, "Pipe");
                            Connect(i.ReserveId, node, "ReserveId");
                            Connect(i.Index, node, "Index");
                            Connect(i.Pointer, node, "Pointer");
                            Connect(i.PacketSize, node, "PacketSize");
                            Connect(i.PacketAlignment, node, "PacketAlignment");
                            break;
                        }
                    case Op.OpReserveReadPipePackets:
                        {
                            var i = (OpReserveReadPipePackets)instruction;
                            Connect(i.Pipe, node, "Pipe");
                            Connect(i.NumPackets, node, "NumPackets");
                            Connect(i.PacketSize, node, "PacketSize");
                            Connect(i.PacketAlignment, node, "PacketAlignment");
                            break;
                        }
                    case Op.OpReserveWritePipePackets:
                        {
                            var i = (OpReserveWritePipePackets)instruction;
                            Connect(i.Pipe, node, "Pipe");
                            Connect(i.NumPackets, node, "NumPackets");
                            Connect(i.PacketSize, node, "PacketSize");
                            Connect(i.PacketAlignment, node, "PacketAlignment");
                            break;
                        }
                    case Op.OpCommitReadPipe:
                        {
                            var i = (OpCommitReadPipe)instruction;
                            Connect(i.Pipe, node, "Pipe");
                            Connect(i.ReserveId, node, "ReserveId");
                            Connect(i.PacketSize, node, "PacketSize");
                            Connect(i.PacketAlignment, node, "PacketAlignment");
                            break;
                        }
                    case Op.OpCommitWritePipe:
                        {
                            var i = (OpCommitWritePipe)instruction;
                            Connect(i.Pipe, node, "Pipe");
                            Connect(i.ReserveId, node, "ReserveId");
                            Connect(i.PacketSize, node, "PacketSize");
                            Connect(i.PacketAlignment, node, "PacketAlignment");
                            break;
                        }
                    case Op.OpIsValidReserveId:
                        {
                            var i = (OpIsValidReserveId)instruction;
                            Connect(i.ReserveId, node, "ReserveId");
                            break;
                        }
                    case Op.OpGetNumPipePackets:
                        {
                            var i = (OpGetNumPipePackets)instruction;
                            Connect(i.Pipe, node, "Pipe");
                            Connect(i.PacketSize, node, "PacketSize");
                            Connect(i.PacketAlignment, node, "PacketAlignment");
                            break;
                        }
                    case Op.OpGetMaxPipePackets:
                        {
                            var i = (OpGetMaxPipePackets)instruction;
                            Connect(i.Pipe, node, "Pipe");
                            Connect(i.PacketSize, node, "PacketSize");
                            Connect(i.PacketAlignment, node, "PacketAlignment");
                            break;
                        }
                    case Op.OpGroupReserveReadPipePackets:
                        {
                            var i = (OpGroupReserveReadPipePackets)instruction;
                            Connect(i.Pipe, node, "Pipe");
                            Connect(i.NumPackets, node, "NumPackets");
                            Connect(i.PacketSize, node, "PacketSize");
                            Connect(i.PacketAlignment, node, "PacketAlignment");
                            break;
                        }
                    case Op.OpGroupReserveWritePipePackets:
                        {
                            var i = (OpGroupReserveWritePipePackets)instruction;
                            Connect(i.Pipe, node, "Pipe");
                            Connect(i.NumPackets, node, "NumPackets");
                            Connect(i.PacketSize, node, "PacketSize");
                            Connect(i.PacketAlignment, node, "PacketAlignment");
                            break;
                        }
                    case Op.OpGroupCommitReadPipe:
                        {
                            var i = (OpGroupCommitReadPipe)instruction;
                            Connect(i.Pipe, node, "Pipe");
                            Connect(i.ReserveId, node, "ReserveId");
                            Connect(i.PacketSize, node, "PacketSize");
                            Connect(i.PacketAlignment, node, "PacketAlignment");
                            break;
                        }
                    case Op.OpGroupCommitWritePipe:
                        {
                            var i = (OpGroupCommitWritePipe)instruction;
                            Connect(i.Pipe, node, "Pipe");
                            Connect(i.ReserveId, node, "ReserveId");
                            Connect(i.PacketSize, node, "PacketSize");
                            Connect(i.PacketAlignment, node, "PacketAlignment");
                            break;
                        }
                    case Op.OpEnqueueMarker:
                        {
                            var i = (OpEnqueueMarker)instruction;
                            Connect(i.Queue, node, "Queue");
                            Connect(i.NumEvents, node, "NumEvents");
                            Connect(i.WaitEvents, node, "WaitEvents");
                            Connect(i.RetEvent, node, "RetEvent");
                            break;
                        }
                    case Op.OpEnqueueKernel:
                        {
                            var i = (OpEnqueueKernel)instruction;
                            Connect(i.Queue, node, "Queue");
                            Connect(i.Flags, node, "Flags");
                            Connect(i.NDRange, node, "NDRange");
                            Connect(i.NumEvents, node, "NumEvents");
                            Connect(i.WaitEvents, node, "WaitEvents");
                            Connect(i.RetEvent, node, "RetEvent");
                            Connect(i.Invoke, node, "Invoke");
                            Connect(i.Param, node, "Param");
                            Connect(i.ParamSize, node, "ParamSize");
                            Connect(i.ParamAlign, node, "ParamAlign");
                            break;
                        }
                    case Op.OpGetKernelNDrangeSubGroupCount:
                        {
                            var i = (OpGetKernelNDrangeSubGroupCount)instruction;
                            Connect(i.NDRange, node, "NDRange");
                            Connect(i.Invoke, node, "Invoke");
                            Connect(i.Param, node, "Param");
                            Connect(i.ParamSize, node, "ParamSize");
                            Connect(i.ParamAlign, node, "ParamAlign");
                            break;
                        }
                    case Op.OpGetKernelNDrangeMaxSubGroupSize:
                        {
                            var i = (OpGetKernelNDrangeMaxSubGroupSize)instruction;
                            Connect(i.NDRange, node, "NDRange");
                            Connect(i.Invoke, node, "Invoke");
                            Connect(i.Param, node, "Param");
                            Connect(i.ParamSize, node, "ParamSize");
                            Connect(i.ParamAlign, node, "ParamAlign");
                            break;
                        }
                    case Op.OpGetKernelWorkGroupSize:
                        {
                            var i = (OpGetKernelWorkGroupSize)instruction;
                            Connect(i.Invoke, node, "Invoke");
                            Connect(i.Param, node, "Param");
                            Connect(i.ParamSize, node, "ParamSize");
                            Connect(i.ParamAlign, node, "ParamAlign");
                            break;
                        }
                    case Op.OpGetKernelPreferredWorkGroupSizeMultiple:
                        {
                            var i = (OpGetKernelPreferredWorkGroupSizeMultiple)instruction;
                            Connect(i.Invoke, node, "Invoke");
                            Connect(i.Param, node, "Param");
                            Connect(i.ParamSize, node, "ParamSize");
                            Connect(i.ParamAlign, node, "ParamAlign");
                            break;
                        }
                    case Op.OpRetainEvent:
                        {
                            var i = (OpRetainEvent)instruction;
                            Connect(i.Event, node, "Event");
                            break;
                        }
                    case Op.OpReleaseEvent:
                        {
                            var i = (OpReleaseEvent)instruction;
                            Connect(i.Event, node, "Event");
                            break;
                        }
                    case Op.OpIsValidEvent:
                        {
                            var i = (OpIsValidEvent)instruction;
                            Connect(i.Event, node, "Event");
                            break;
                        }
                    case Op.OpSetUserEventStatus:
                        {
                            var i = (OpSetUserEventStatus)instruction;
                            Connect(i.Event, node, "Event");
                            Connect(i.Status, node, "Status");
                            break;
                        }
                    case Op.OpCaptureEventProfilingInfo:
                        {
                            var i = (OpCaptureEventProfilingInfo)instruction;
                            Connect(i.Event, node, "Event");
                            Connect(i.ProfilingInfo, node, "ProfilingInfo");
                            Connect(i.Value, node, "Value");
                            break;
                        }
                    case Op.OpBuildNDRange:
                        {
                            var i = (OpBuildNDRange)instruction;
                            Connect(i.GlobalWorkSize, node, "GlobalWorkSize");
                            Connect(i.LocalWorkSize, node, "LocalWorkSize");
                            Connect(i.GlobalWorkOffset, node, "GlobalWorkOffset");
                            break;
                        }
                    case Op.OpImageSparseSampleImplicitLod:
                        {
                            var i = (OpImageSparseSampleImplicitLod)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            break;
                        }
                    case Op.OpImageSparseSampleExplicitLod:
                        {
                            var i = (OpImageSparseSampleExplicitLod)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            break;
                        }
                    case Op.OpImageSparseSampleDrefImplicitLod:
                        {
                            var i = (OpImageSparseSampleDrefImplicitLod)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            Connect(i.D_ref, node, "D_ref");
                            break;
                        }
                    case Op.OpImageSparseSampleDrefExplicitLod:
                        {
                            var i = (OpImageSparseSampleDrefExplicitLod)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            Connect(i.D_ref, node, "D_ref");
                            break;
                        }
                    case Op.OpImageSparseSampleProjImplicitLod:
                        {
                            var i = (OpImageSparseSampleProjImplicitLod)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            break;
                        }
                    case Op.OpImageSparseSampleProjExplicitLod:
                        {
                            var i = (OpImageSparseSampleProjExplicitLod)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            break;
                        }
                    case Op.OpImageSparseSampleProjDrefImplicitLod:
                        {
                            var i = (OpImageSparseSampleProjDrefImplicitLod)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            Connect(i.D_ref, node, "D_ref");
                            break;
                        }
                    case Op.OpImageSparseSampleProjDrefExplicitLod:
                        {
                            var i = (OpImageSparseSampleProjDrefExplicitLod)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            Connect(i.D_ref, node, "D_ref");
                            break;
                        }
                    case Op.OpImageSparseFetch:
                        {
                            var i = (OpImageSparseFetch)instruction;
                            Connect(i.Image, node, "Image");
                            Connect(i.Coordinate, node, "Coordinate");
                            break;
                        }
                    case Op.OpImageSparseGather:
                        {
                            var i = (OpImageSparseGather)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            Connect(i.Component, node, "Component");
                            break;
                        }
                    case Op.OpImageSparseDrefGather:
                        {
                            var i = (OpImageSparseDrefGather)instruction;
                            Connect(i.SampledImage, node, "SampledImage");
                            Connect(i.Coordinate, node, "Coordinate");
                            Connect(i.D_ref, node, "D_ref");
                            break;
                        }
                    case Op.OpImageSparseTexelsResident:
                        {
                            var i = (OpImageSparseTexelsResident)instruction;
                            Connect(i.ResidentCode, node, "ResidentCode");
                            break;
                        }
                    case Op.OpAtomicFlagTestAndSet:
                        {
                            var i = (OpAtomicFlagTestAndSet)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            break;
                        }
                    case Op.OpAtomicFlagClear:
                        {
                            var i = (OpAtomicFlagClear)instruction;
                            Connect(i.Pointer, node, "Pointer");
                            break;
                        }
                    case Op.OpImageSparseRead:
                        {
                            var i = (OpImageSparseRead)instruction;
                            Connect(i.Image, node, "Image");
                            Connect(i.Coordinate, node, "Coordinate");
                            break;
                        }
                    case Op.OpDecorateId:
                        {
                            var i = (OpDecorateId)instruction;
                            Connect(i.Target, node, "Target");
                            break;
                        }
                    case Op.OpSubgroupBallotKHR:
                        {
                            var i = (OpSubgroupBallotKHR)instruction;
                            Connect(i.Predicate, node, "Predicate");
                            break;
                        }
                    case Op.OpSubgroupFirstInvocationKHR:
                        {
                            var i = (OpSubgroupFirstInvocationKHR)instruction;
                            Connect(i.Value, node, "Value");
                            break;
                        }
                    case Op.OpSubgroupAllKHR:
                        {
                            var i = (OpSubgroupAllKHR)instruction;
                            Connect(i.Predicate, node, "Predicate");
                            break;
                        }
                    case Op.OpSubgroupAnyKHR:
                        {
                            var i = (OpSubgroupAnyKHR)instruction;
                            Connect(i.Predicate, node, "Predicate");
                            break;
                        }
                    case Op.OpSubgroupAllEqualKHR:
                        {
                            var i = (OpSubgroupAllEqualKHR)instruction;
                            Connect(i.Predicate, node, "Predicate");
                            break;
                        }
                    case Op.OpSubgroupReadInvocationKHR:
                        {
                            var i = (OpSubgroupReadInvocationKHR)instruction;
                            Connect(i.Value, node, "Value");
                            Connect(i.Index, node, "Index");
                            break;
                        }
                    case Op.OpGroupIAddNonUniformAMD:
                        {
                            var i = (OpGroupIAddNonUniformAMD)instruction;
                            Connect(i.X, node, "X");
                            break;
                        }
                    case Op.OpGroupFAddNonUniformAMD:
                        {
                            var i = (OpGroupFAddNonUniformAMD)instruction;
                            Connect(i.X, node, "X");
                            break;
                        }
                    case Op.OpGroupFMinNonUniformAMD:
                        {
                            var i = (OpGroupFMinNonUniformAMD)instruction;
                            Connect(i.X, node, "X");
                            break;
                        }
                    case Op.OpGroupUMinNonUniformAMD:
                        {
                            var i = (OpGroupUMinNonUniformAMD)instruction;
                            Connect(i.X, node, "X");
                            break;
                        }
                    case Op.OpGroupSMinNonUniformAMD:
                        {
                            var i = (OpGroupSMinNonUniformAMD)instruction;
                            Connect(i.X, node, "X");
                            break;
                        }
                    case Op.OpGroupFMaxNonUniformAMD:
                        {
                            var i = (OpGroupFMaxNonUniformAMD)instruction;
                            Connect(i.X, node, "X");
                            break;
                        }
                    case Op.OpGroupUMaxNonUniformAMD:
                        {
                            var i = (OpGroupUMaxNonUniformAMD)instruction;
                            Connect(i.X, node, "X");
                            break;
                        }
                    case Op.OpGroupSMaxNonUniformAMD:
                        {
                            var i = (OpGroupSMaxNonUniformAMD)instruction;
                            Connect(i.X, node, "X");
                            break;
                        }
                    case Op.OpFragmentMaskFetchAMD:
                        {
                            var i = (OpFragmentMaskFetchAMD)instruction;
                            Connect(i.Image, node, "Image");
                            Connect(i.Coordinate, node, "Coordinate");
                            break;
                        }
                    case Op.OpFragmentFetchAMD:
                        {
                            var i = (OpFragmentFetchAMD)instruction;
                            Connect(i.Image, node, "Image");
                            Connect(i.Coordinate, node, "Coordinate");
                            Connect(i.FragmentIndex, node, "FragmentIndex");
                            break;
                        }
                    case Op.OpSubgroupShuffleINTEL:
                        {
                            var i = (OpSubgroupShuffleINTEL)instruction;
                            Connect(i.Data, node, "Data");
                            Connect(i.InvocationId, node, "InvocationId");
                            break;
                        }
                    case Op.OpSubgroupShuffleDownINTEL:
                        {
                            var i = (OpSubgroupShuffleDownINTEL)instruction;
                            Connect(i.Current, node, "Current");
                            Connect(i.Next, node, "Next");
                            Connect(i.Delta, node, "Delta");
                            break;
                        }
                    case Op.OpSubgroupShuffleUpINTEL:
                        {
                            var i = (OpSubgroupShuffleUpINTEL)instruction;
                            Connect(i.Previous, node, "Previous");
                            Connect(i.Current, node, "Current");
                            Connect(i.Delta, node, "Delta");
                            break;
                        }
                    case Op.OpSubgroupShuffleXorINTEL:
                        {
                            var i = (OpSubgroupShuffleXorINTEL)instruction;
                            Connect(i.Data, node, "Data");
                            Connect(i.Value, node, "Value");
                            break;
                        }
                    case Op.OpSubgroupBlockReadINTEL:
                        {
                            var i = (OpSubgroupBlockReadINTEL)instruction;
                            Connect(i.Ptr, node, "Ptr");
                            break;
                        }
                    case Op.OpSubgroupBlockWriteINTEL:
                        {
                            var i = (OpSubgroupBlockWriteINTEL)instruction;
                            Connect(i.Ptr, node, "Ptr");
                            Connect(i.Data, node, "Data");
                            break;
                        }
                    case Op.OpSubgroupImageBlockReadINTEL:
                        {
                            var i = (OpSubgroupImageBlockReadINTEL)instruction;
                            Connect(i.Image, node, "Image");
                            Connect(i.Coordinate, node, "Coordinate");
                            break;
                        }
                    case Op.OpSubgroupImageBlockWriteINTEL:
                        {
                            var i = (OpSubgroupImageBlockWriteINTEL)instruction;
                            Connect(i.Image, node, "Image");
                            Connect(i.Coordinate, node, "Coordinate");
                            Connect(i.Data, node, "Data");
                            break;
                        }
                    case Op.OpDecorateStringGOOGLE:
                        {
                            var i = (OpDecorateStringGOOGLE)instruction;
                            Connect(i.Target, node, "Target");
                            break;
                        }
                    case Op.OpMemberDecorateStringGOOGLE:
                        {
                            var i = (OpMemberDecorateStringGOOGLE)instruction;
                            Connect(i.StructType, node, "StructType");
                            break;
                        }
                }
            }

            return script;
        }

        private void Connect(uint operandId, ScriptNode node, string pin)
        {
            if (!_nodeById.TryGetValue(operandId, out var source))
                return;
            if (source.OutputPins.Count == 0)
                return;
            var input = node.InputPins.FirstOrDefault(_ => _.Id == pin);
            if (input == null)
                return;
            input.Connection = new Connection(source, source.OutputPins[0]);
        }
    }
}