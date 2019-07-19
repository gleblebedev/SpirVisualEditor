﻿using System;
using System.Collections.Generic;
using System.IO;
using SpirVGraph.Instructions;
using SpirVGraph.Spv;
using Toe.Scripting;

namespace SpirVGraph
{
    internal class Parser
    {
        private readonly WordReader _reader;
        private readonly int _spirvwords;
        private uint _bound;
        private readonly Script _script;

        public Parser(BinaryReader reader, int spirvwords)
        {
            _reader = new WordReader(reader);
            _spirvwords = spirvwords;
            _script = new Script();
        }

        public Script Parse()
        {
            ParseMagic();
            ParseVersion();
            ParseGeneratorName();
            ParseBound();
            ParseZero();

            var instructions = new List<Instruction>();
            while (_reader.Position < _spirvwords)
            {
                instructions.Add(InstructionFactory.Parse(_reader));
            }

            return _script;
        }

      
    
        private void ParseGeneratorName()
        {
            _reader.ReadWord(); //Skip generator name
        }

        private void ParseBound()
        {
            _bound = _reader.ReadWord();
        }

        private void ParseZero()
        {
            if (_reader.ReadWord() != 0) throw new FormatException("SpirV reserved word isn't 0");
        }

        private void ParseVersion()
        {
            if (_reader.ReadWord() != 0x00010000) throw new FormatException("Unsupported SpirV version");
        }

        private void ParseMagic()
        {
            if (_reader.ReadWord() != 0x07230203) throw new FormatException("SpirV magic number doesn't match");
        }

        #region Helpers



        public static ImageOperands ParseImageOperands(WordReader reader, uint wordCount)
        {
            return ImageOperands.Parse(reader, wordCount);
        }

        public static FPFastMathMode ParseFPFastMathMode(WordReader reader, uint wordCount)
        {
            return FPFastMathMode.Parse(reader, wordCount);
        }

        public static SelectionControl ParseSelectionControl(WordReader reader, uint wordCount)
        {
            return SelectionControl.Parse(reader, wordCount);
        }

        public static LoopControl ParseLoopControl(WordReader reader, uint wordCount)
        {
            return LoopControl.Parse(reader, wordCount);
        }

        public static FunctionControl ParseFunctionControl(WordReader reader, uint wordCount)
        {
            return FunctionControl.Parse(reader, wordCount);
        }

        public static MemorySemantics ParseMemorySemantics(WordReader reader, uint wordCount)
        {
            return MemorySemantics.Parse(reader, wordCount);
        }

        public static MemoryAccess ParseMemoryAccess(WordReader reader, uint wordCount)
        {
            return MemoryAccess.Parse(reader, wordCount);
        }

        public static KernelProfilingInfo ParseKernelProfilingInfo(WordReader reader, uint wordCount)
        {
            return KernelProfilingInfo.Parse(reader, wordCount);
        }

        public static SourceLanguage ParseSourceLanguage(WordReader reader, uint wordCount)
        {
            return SourceLanguage.Parse(reader, wordCount);
        }

        public static ExecutionModel ParseExecutionModel(WordReader reader, uint wordCount)
        {
            return ExecutionModel.Parse(reader, wordCount);
        }

        public static AddressingModel ParseAddressingModel(WordReader reader, uint wordCount)
        {
            return AddressingModel.Parse(reader, wordCount);
        }

        public static MemoryModel ParseMemoryModel(WordReader reader, uint wordCount)
        {
            return MemoryModel.Parse(reader, wordCount);
        }

        public static ExecutionMode ParseExecutionMode(WordReader reader, uint wordCount)
        {
            return ExecutionMode.Parse(reader, wordCount);
        }

        public static StorageClass ParseStorageClass(WordReader reader, uint wordCount)
        {
            return StorageClass.Parse(reader, wordCount);
        }

        public static Dim ParseDim(WordReader reader, uint wordCount)
        {
            return Dim.Parse(reader, wordCount);
        }

        public static SamplerAddressingMode ParseSamplerAddressingMode(WordReader reader, uint wordCount)
        {
            return SamplerAddressingMode.Parse(reader, wordCount);
        }

        public static SamplerFilterMode ParseSamplerFilterMode(WordReader reader, uint wordCount)
        {
            return SamplerFilterMode.Parse(reader, wordCount);
        }

        public static ImageFormat ParseImageFormat(WordReader reader, uint wordCount)
        {
            return ImageFormat.Parse(reader, wordCount);
        }

        public static ImageChannelOrder ParseImageChannelOrder(WordReader reader, uint wordCount)
        {
            return ImageChannelOrder.Parse(reader, wordCount);
        }

        public static ImageChannelDataType ParseImageChannelDataType(WordReader reader, uint wordCount)
        {
            return ImageChannelDataType.Parse(reader, wordCount);
        }

        public static FPRoundingMode ParseFPRoundingMode(WordReader reader, uint wordCount)
        {
            return FPRoundingMode.Parse(reader, wordCount);
        }

        public static LinkageType ParseLinkageType(WordReader reader, uint wordCount)
        {
            return LinkageType.Parse(reader, wordCount);
        }

        public static AccessQualifier ParseAccessQualifier(WordReader reader, uint wordCount)
        {
            return AccessQualifier.Parse(reader, wordCount);
        }

        public static FunctionParameterAttribute ParseFunctionParameterAttribute(WordReader reader, uint wordCount)
        {
            return FunctionParameterAttribute.Parse(reader, wordCount);
        }

        public static Decoration ParseDecoration(WordReader reader, uint wordCount)
        {
            return Decoration.Parse(reader, wordCount);
        }

        public static BuiltIn ParseBuiltIn(WordReader reader, uint wordCount)
        {
            return BuiltIn.Parse(reader, wordCount);
        }

        public static Scope ParseScope(WordReader reader, uint wordCount)
        {
            return Scope.Parse(reader, wordCount);
        }

        public static GroupOperation ParseGroupOperation(WordReader reader, uint wordCount)
        {
            return GroupOperation.Parse(reader, wordCount);
        }

        public static KernelEnqueueFlags ParseKernelEnqueueFlags(WordReader reader, uint wordCount)
        {
            return KernelEnqueueFlags.Parse(reader, wordCount);
        }

        public static Capability ParseCapability(WordReader reader, uint wordCount)
        {
            return Capability.Parse(reader, wordCount);
        }

        public static uint ParseIdResultType(WordReader reader, uint wordCount)
        {
            return reader.ReadWord();
        }

        public static uint ParseIdResult(WordReader reader, uint wordCount)
        {
            return reader.ReadWord();
        }

        public static uint ParseIdMemorySemantics(WordReader reader, uint wordCount)
        {
            return reader.ReadWord();
        }

        public static uint ParseIdScope(WordReader reader, uint wordCount)
        {
            return reader.ReadWord();
        }

        public static uint ParseIdRef(WordReader reader, uint wordCount)
        {
            return reader.ReadWord();
        }

        public static uint ParseLiteralInteger(WordReader reader, uint wordCount)
        {
            return reader.ReadWord();
        }

        public static string ParseLiteralString(WordReader reader, uint wordCount)
        {
            return reader.ReadString();
        }

        public static uint ParseLiteralContextDependentNumber(WordReader reader, uint wordCount)
        {
            return reader.ReadWord();
        }

        public static uint ParseLiteralExtInstInteger(WordReader reader, uint wordCount)
        {
            return reader.ReadWord();
        }

        public static uint ParseLiteralSpecConstantOpInteger(WordReader reader, uint wordCount)
        {
            return reader.ReadWord();
        }

        public static uint ParsePairLiteralIntegerIdRef(WordReader reader, uint wordCount)
        {
            return reader.ReadWord();
        }

        public static uint ParsePairIdRefLiteralInteger(WordReader reader, uint wordCount)
        {
            return reader.ReadWord();
        }

        public static uint ParsePairIdRefIdRef(WordReader reader, uint wordCount)
        {
            return reader.ReadWord();
        }


        #endregion
    }
}