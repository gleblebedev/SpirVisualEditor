using System;
using SpirVGraph.Spv;

namespace SpirVGraph.Instructions
{
    public enum InstructionCategory
    {
        Unknown,
        Type,
    }
    public static class InstructionFactory
    {

	    public static Instruction Parse(WordReader reader)
        {
            var pos = reader.Position;
            var opCode = reader.ReadWord();
            var op = (Op)(opCode & 0x0FFFF);
            var wordCount = (opCode >> 16) & 0x0FFFF;
            var end = pos + wordCount;
            var instruction = Create(op);
            instruction.Parse(reader, wordCount);
            if (reader.Position != end)
            {
                throw new FormatException();
            }

            return instruction;
        }

        public static Instruction Create(Op op)
		{
			switch (op)
			{
				case Op.OpNop: return new OpNop();
				case Op.OpUndef: return new OpUndef();
				case Op.OpSourceContinued: return new OpSourceContinued();
				case Op.OpSource: return new OpSource();
				case Op.OpSourceExtension: return new OpSourceExtension();
				case Op.OpName: return new OpName();
				case Op.OpMemberName: return new OpMemberName();
				case Op.OpString: return new OpString();
				case Op.OpLine: return new OpLine();
				case Op.OpExtension: return new OpExtension();
				case Op.OpExtInstImport: return new OpExtInstImport();
				case Op.OpExtInst: return new OpExtInst();
				case Op.OpMemoryModel: return new OpMemoryModel();
				case Op.OpEntryPoint: return new OpEntryPoint();
				case Op.OpExecutionMode: return new OpExecutionMode();
				case Op.OpCapability: return new OpCapability();
				case Op.OpTypeVoid: return new OpTypeVoid();
				case Op.OpTypeBool: return new OpTypeBool();
				case Op.OpTypeInt: return new OpTypeInt();
				case Op.OpTypeFloat: return new OpTypeFloat();
				case Op.OpTypeVector: return new OpTypeVector();
				case Op.OpTypeMatrix: return new OpTypeMatrix();
				case Op.OpTypeImage: return new OpTypeImage();
				case Op.OpTypeSampler: return new OpTypeSampler();
				case Op.OpTypeSampledImage: return new OpTypeSampledImage();
				case Op.OpTypeArray: return new OpTypeArray();
				case Op.OpTypeRuntimeArray: return new OpTypeRuntimeArray();
				case Op.OpTypeStruct: return new OpTypeStruct();
				case Op.OpTypeOpaque: return new OpTypeOpaque();
				case Op.OpTypePointer: return new OpTypePointer();
				case Op.OpTypeFunction: return new OpTypeFunction();
				case Op.OpTypeEvent: return new OpTypeEvent();
				case Op.OpTypeDeviceEvent: return new OpTypeDeviceEvent();
				case Op.OpTypeReserveId: return new OpTypeReserveId();
				case Op.OpTypeQueue: return new OpTypeQueue();
				case Op.OpTypePipe: return new OpTypePipe();
				case Op.OpTypeForwardPointer: return new OpTypeForwardPointer();
				case Op.OpConstantTrue: return new OpConstantTrue();
				case Op.OpConstantFalse: return new OpConstantFalse();
				case Op.OpConstant: return new OpConstant();
				case Op.OpConstantComposite: return new OpConstantComposite();
				case Op.OpConstantSampler: return new OpConstantSampler();
				case Op.OpConstantNull: return new OpConstantNull();
				case Op.OpSpecConstantTrue: return new OpSpecConstantTrue();
				case Op.OpSpecConstantFalse: return new OpSpecConstantFalse();
				case Op.OpSpecConstant: return new OpSpecConstant();
				case Op.OpSpecConstantComposite: return new OpSpecConstantComposite();
				case Op.OpSpecConstantOp: return new OpSpecConstantOp();
				case Op.OpFunction: return new OpFunction();
				case Op.OpFunctionParameter: return new OpFunctionParameter();
				case Op.OpFunctionEnd: return new OpFunctionEnd();
				case Op.OpFunctionCall: return new OpFunctionCall();
				case Op.OpVariable: return new OpVariable();
				case Op.OpImageTexelPointer: return new OpImageTexelPointer();
				case Op.OpLoad: return new OpLoad();
				case Op.OpStore: return new OpStore();
				case Op.OpCopyMemory: return new OpCopyMemory();
				case Op.OpCopyMemorySized: return new OpCopyMemorySized();
				case Op.OpAccessChain: return new OpAccessChain();
				case Op.OpInBoundsAccessChain: return new OpInBoundsAccessChain();
				case Op.OpPtrAccessChain: return new OpPtrAccessChain();
				case Op.OpArrayLength: return new OpArrayLength();
				case Op.OpGenericPtrMemSemantics: return new OpGenericPtrMemSemantics();
				case Op.OpInBoundsPtrAccessChain: return new OpInBoundsPtrAccessChain();
				case Op.OpDecorate: return new OpDecorate();
				case Op.OpMemberDecorate: return new OpMemberDecorate();
				case Op.OpDecorationGroup: return new OpDecorationGroup();
				case Op.OpGroupDecorate: return new OpGroupDecorate();
				case Op.OpGroupMemberDecorate: return new OpGroupMemberDecorate();
				case Op.OpVectorExtractDynamic: return new OpVectorExtractDynamic();
				case Op.OpVectorInsertDynamic: return new OpVectorInsertDynamic();
				case Op.OpVectorShuffle: return new OpVectorShuffle();
				case Op.OpCompositeConstruct: return new OpCompositeConstruct();
				case Op.OpCompositeExtract: return new OpCompositeExtract();
				case Op.OpCompositeInsert: return new OpCompositeInsert();
				case Op.OpCopyObject: return new OpCopyObject();
				case Op.OpTranspose: return new OpTranspose();
				case Op.OpSampledImage: return new OpSampledImage();
				case Op.OpImageSampleImplicitLod: return new OpImageSampleImplicitLod();
				case Op.OpImageSampleExplicitLod: return new OpImageSampleExplicitLod();
				case Op.OpImageSampleDrefImplicitLod: return new OpImageSampleDrefImplicitLod();
				case Op.OpImageSampleDrefExplicitLod: return new OpImageSampleDrefExplicitLod();
				case Op.OpImageSampleProjImplicitLod: return new OpImageSampleProjImplicitLod();
				case Op.OpImageSampleProjExplicitLod: return new OpImageSampleProjExplicitLod();
				case Op.OpImageSampleProjDrefImplicitLod: return new OpImageSampleProjDrefImplicitLod();
				case Op.OpImageSampleProjDrefExplicitLod: return new OpImageSampleProjDrefExplicitLod();
				case Op.OpImageFetch: return new OpImageFetch();
				case Op.OpImageGather: return new OpImageGather();
				case Op.OpImageDrefGather: return new OpImageDrefGather();
				case Op.OpImageRead: return new OpImageRead();
				case Op.OpImageWrite: return new OpImageWrite();
				case Op.OpImage: return new OpImage();
				case Op.OpImageQueryFormat: return new OpImageQueryFormat();
				case Op.OpImageQueryOrder: return new OpImageQueryOrder();
				case Op.OpImageQuerySizeLod: return new OpImageQuerySizeLod();
				case Op.OpImageQuerySize: return new OpImageQuerySize();
				case Op.OpImageQueryLod: return new OpImageQueryLod();
				case Op.OpImageQueryLevels: return new OpImageQueryLevels();
				case Op.OpImageQuerySamples: return new OpImageQuerySamples();
				case Op.OpConvertFToU: return new OpConvertFToU();
				case Op.OpConvertFToS: return new OpConvertFToS();
				case Op.OpConvertSToF: return new OpConvertSToF();
				case Op.OpConvertUToF: return new OpConvertUToF();
				case Op.OpUConvert: return new OpUConvert();
				case Op.OpSConvert: return new OpSConvert();
				case Op.OpFConvert: return new OpFConvert();
				case Op.OpQuantizeToF16: return new OpQuantizeToF16();
				case Op.OpConvertPtrToU: return new OpConvertPtrToU();
				case Op.OpSatConvertSToU: return new OpSatConvertSToU();
				case Op.OpSatConvertUToS: return new OpSatConvertUToS();
				case Op.OpConvertUToPtr: return new OpConvertUToPtr();
				case Op.OpPtrCastToGeneric: return new OpPtrCastToGeneric();
				case Op.OpGenericCastToPtr: return new OpGenericCastToPtr();
				case Op.OpGenericCastToPtrExplicit: return new OpGenericCastToPtrExplicit();
				case Op.OpBitcast: return new OpBitcast();
				case Op.OpSNegate: return new OpSNegate();
				case Op.OpFNegate: return new OpFNegate();
				case Op.OpIAdd: return new OpIAdd();
				case Op.OpFAdd: return new OpFAdd();
				case Op.OpISub: return new OpISub();
				case Op.OpFSub: return new OpFSub();
				case Op.OpIMul: return new OpIMul();
				case Op.OpFMul: return new OpFMul();
				case Op.OpUDiv: return new OpUDiv();
				case Op.OpSDiv: return new OpSDiv();
				case Op.OpFDiv: return new OpFDiv();
				case Op.OpUMod: return new OpUMod();
				case Op.OpSRem: return new OpSRem();
				case Op.OpSMod: return new OpSMod();
				case Op.OpFRem: return new OpFRem();
				case Op.OpFMod: return new OpFMod();
				case Op.OpVectorTimesScalar: return new OpVectorTimesScalar();
				case Op.OpMatrixTimesScalar: return new OpMatrixTimesScalar();
				case Op.OpVectorTimesMatrix: return new OpVectorTimesMatrix();
				case Op.OpMatrixTimesVector: return new OpMatrixTimesVector();
				case Op.OpMatrixTimesMatrix: return new OpMatrixTimesMatrix();
				case Op.OpOuterProduct: return new OpOuterProduct();
				case Op.OpDot: return new OpDot();
				case Op.OpIAddCarry: return new OpIAddCarry();
				case Op.OpISubBorrow: return new OpISubBorrow();
				case Op.OpUMulExtended: return new OpUMulExtended();
				case Op.OpSMulExtended: return new OpSMulExtended();
				case Op.OpAny: return new OpAny();
				case Op.OpAll: return new OpAll();
				case Op.OpIsNan: return new OpIsNan();
				case Op.OpIsInf: return new OpIsInf();
				case Op.OpIsFinite: return new OpIsFinite();
				case Op.OpIsNormal: return new OpIsNormal();
				case Op.OpSignBitSet: return new OpSignBitSet();
				case Op.OpLessOrGreater: return new OpLessOrGreater();
				case Op.OpOrdered: return new OpOrdered();
				case Op.OpUnordered: return new OpUnordered();
				case Op.OpLogicalEqual: return new OpLogicalEqual();
				case Op.OpLogicalNotEqual: return new OpLogicalNotEqual();
				case Op.OpLogicalOr: return new OpLogicalOr();
				case Op.OpLogicalAnd: return new OpLogicalAnd();
				case Op.OpLogicalNot: return new OpLogicalNot();
				case Op.OpSelect: return new OpSelect();
				case Op.OpIEqual: return new OpIEqual();
				case Op.OpINotEqual: return new OpINotEqual();
				case Op.OpUGreaterThan: return new OpUGreaterThan();
				case Op.OpSGreaterThan: return new OpSGreaterThan();
				case Op.OpUGreaterThanEqual: return new OpUGreaterThanEqual();
				case Op.OpSGreaterThanEqual: return new OpSGreaterThanEqual();
				case Op.OpULessThan: return new OpULessThan();
				case Op.OpSLessThan: return new OpSLessThan();
				case Op.OpULessThanEqual: return new OpULessThanEqual();
				case Op.OpSLessThanEqual: return new OpSLessThanEqual();
				case Op.OpFOrdEqual: return new OpFOrdEqual();
				case Op.OpFUnordEqual: return new OpFUnordEqual();
				case Op.OpFOrdNotEqual: return new OpFOrdNotEqual();
				case Op.OpFUnordNotEqual: return new OpFUnordNotEqual();
				case Op.OpFOrdLessThan: return new OpFOrdLessThan();
				case Op.OpFUnordLessThan: return new OpFUnordLessThan();
				case Op.OpFOrdGreaterThan: return new OpFOrdGreaterThan();
				case Op.OpFUnordGreaterThan: return new OpFUnordGreaterThan();
				case Op.OpFOrdLessThanEqual: return new OpFOrdLessThanEqual();
				case Op.OpFUnordLessThanEqual: return new OpFUnordLessThanEqual();
				case Op.OpFOrdGreaterThanEqual: return new OpFOrdGreaterThanEqual();
				case Op.OpFUnordGreaterThanEqual: return new OpFUnordGreaterThanEqual();
				case Op.OpShiftRightLogical: return new OpShiftRightLogical();
				case Op.OpShiftRightArithmetic: return new OpShiftRightArithmetic();
				case Op.OpShiftLeftLogical: return new OpShiftLeftLogical();
				case Op.OpBitwiseOr: return new OpBitwiseOr();
				case Op.OpBitwiseXor: return new OpBitwiseXor();
				case Op.OpBitwiseAnd: return new OpBitwiseAnd();
				case Op.OpNot: return new OpNot();
				case Op.OpBitFieldInsert: return new OpBitFieldInsert();
				case Op.OpBitFieldSExtract: return new OpBitFieldSExtract();
				case Op.OpBitFieldUExtract: return new OpBitFieldUExtract();
				case Op.OpBitReverse: return new OpBitReverse();
				case Op.OpBitCount: return new OpBitCount();
				case Op.OpDPdx: return new OpDPdx();
				case Op.OpDPdy: return new OpDPdy();
				case Op.OpFwidth: return new OpFwidth();
				case Op.OpDPdxFine: return new OpDPdxFine();
				case Op.OpDPdyFine: return new OpDPdyFine();
				case Op.OpFwidthFine: return new OpFwidthFine();
				case Op.OpDPdxCoarse: return new OpDPdxCoarse();
				case Op.OpDPdyCoarse: return new OpDPdyCoarse();
				case Op.OpFwidthCoarse: return new OpFwidthCoarse();
				case Op.OpEmitVertex: return new OpEmitVertex();
				case Op.OpEndPrimitive: return new OpEndPrimitive();
				case Op.OpEmitStreamVertex: return new OpEmitStreamVertex();
				case Op.OpEndStreamPrimitive: return new OpEndStreamPrimitive();
				case Op.OpControlBarrier: return new OpControlBarrier();
				case Op.OpMemoryBarrier: return new OpMemoryBarrier();
				case Op.OpAtomicLoad: return new OpAtomicLoad();
				case Op.OpAtomicStore: return new OpAtomicStore();
				case Op.OpAtomicExchange: return new OpAtomicExchange();
				case Op.OpAtomicCompareExchange: return new OpAtomicCompareExchange();
				case Op.OpAtomicCompareExchangeWeak: return new OpAtomicCompareExchangeWeak();
				case Op.OpAtomicIIncrement: return new OpAtomicIIncrement();
				case Op.OpAtomicIDecrement: return new OpAtomicIDecrement();
				case Op.OpAtomicIAdd: return new OpAtomicIAdd();
				case Op.OpAtomicISub: return new OpAtomicISub();
				case Op.OpAtomicSMin: return new OpAtomicSMin();
				case Op.OpAtomicUMin: return new OpAtomicUMin();
				case Op.OpAtomicSMax: return new OpAtomicSMax();
				case Op.OpAtomicUMax: return new OpAtomicUMax();
				case Op.OpAtomicAnd: return new OpAtomicAnd();
				case Op.OpAtomicOr: return new OpAtomicOr();
				case Op.OpAtomicXor: return new OpAtomicXor();
				case Op.OpPhi: return new OpPhi();
				case Op.OpLoopMerge: return new OpLoopMerge();
				case Op.OpSelectionMerge: return new OpSelectionMerge();
				case Op.OpLabel: return new OpLabel();
				case Op.OpBranch: return new OpBranch();
				case Op.OpBranchConditional: return new OpBranchConditional();
				case Op.OpSwitch: return new OpSwitch();
				case Op.OpKill: return new OpKill();
				case Op.OpReturn: return new OpReturn();
				case Op.OpReturnValue: return new OpReturnValue();
				case Op.OpUnreachable: return new OpUnreachable();
				case Op.OpLifetimeStart: return new OpLifetimeStart();
				case Op.OpLifetimeStop: return new OpLifetimeStop();
				case Op.OpGroupAsyncCopy: return new OpGroupAsyncCopy();
				case Op.OpGroupWaitEvents: return new OpGroupWaitEvents();
				case Op.OpGroupAll: return new OpGroupAll();
				case Op.OpGroupAny: return new OpGroupAny();
				case Op.OpGroupBroadcast: return new OpGroupBroadcast();
				case Op.OpGroupIAdd: return new OpGroupIAdd();
				case Op.OpGroupFAdd: return new OpGroupFAdd();
				case Op.OpGroupFMin: return new OpGroupFMin();
				case Op.OpGroupUMin: return new OpGroupUMin();
				case Op.OpGroupSMin: return new OpGroupSMin();
				case Op.OpGroupFMax: return new OpGroupFMax();
				case Op.OpGroupUMax: return new OpGroupUMax();
				case Op.OpGroupSMax: return new OpGroupSMax();
				case Op.OpReadPipe: return new OpReadPipe();
				case Op.OpWritePipe: return new OpWritePipe();
				case Op.OpReservedReadPipe: return new OpReservedReadPipe();
				case Op.OpReservedWritePipe: return new OpReservedWritePipe();
				case Op.OpReserveReadPipePackets: return new OpReserveReadPipePackets();
				case Op.OpReserveWritePipePackets: return new OpReserveWritePipePackets();
				case Op.OpCommitReadPipe: return new OpCommitReadPipe();
				case Op.OpCommitWritePipe: return new OpCommitWritePipe();
				case Op.OpIsValidReserveId: return new OpIsValidReserveId();
				case Op.OpGetNumPipePackets: return new OpGetNumPipePackets();
				case Op.OpGetMaxPipePackets: return new OpGetMaxPipePackets();
				case Op.OpGroupReserveReadPipePackets: return new OpGroupReserveReadPipePackets();
				case Op.OpGroupReserveWritePipePackets: return new OpGroupReserveWritePipePackets();
				case Op.OpGroupCommitReadPipe: return new OpGroupCommitReadPipe();
				case Op.OpGroupCommitWritePipe: return new OpGroupCommitWritePipe();
				case Op.OpEnqueueMarker: return new OpEnqueueMarker();
				case Op.OpEnqueueKernel: return new OpEnqueueKernel();
				case Op.OpGetKernelNDrangeSubGroupCount: return new OpGetKernelNDrangeSubGroupCount();
				case Op.OpGetKernelNDrangeMaxSubGroupSize: return new OpGetKernelNDrangeMaxSubGroupSize();
				case Op.OpGetKernelWorkGroupSize: return new OpGetKernelWorkGroupSize();
				case Op.OpGetKernelPreferredWorkGroupSizeMultiple: return new OpGetKernelPreferredWorkGroupSizeMultiple();
				case Op.OpRetainEvent: return new OpRetainEvent();
				case Op.OpReleaseEvent: return new OpReleaseEvent();
				case Op.OpCreateUserEvent: return new OpCreateUserEvent();
				case Op.OpIsValidEvent: return new OpIsValidEvent();
				case Op.OpSetUserEventStatus: return new OpSetUserEventStatus();
				case Op.OpCaptureEventProfilingInfo: return new OpCaptureEventProfilingInfo();
				case Op.OpGetDefaultQueue: return new OpGetDefaultQueue();
				case Op.OpBuildNDRange: return new OpBuildNDRange();
				case Op.OpImageSparseSampleImplicitLod: return new OpImageSparseSampleImplicitLod();
				case Op.OpImageSparseSampleExplicitLod: return new OpImageSparseSampleExplicitLod();
				case Op.OpImageSparseSampleDrefImplicitLod: return new OpImageSparseSampleDrefImplicitLod();
				case Op.OpImageSparseSampleDrefExplicitLod: return new OpImageSparseSampleDrefExplicitLod();
				case Op.OpImageSparseSampleProjImplicitLod: return new OpImageSparseSampleProjImplicitLod();
				case Op.OpImageSparseSampleProjExplicitLod: return new OpImageSparseSampleProjExplicitLod();
				case Op.OpImageSparseSampleProjDrefImplicitLod: return new OpImageSparseSampleProjDrefImplicitLod();
				case Op.OpImageSparseSampleProjDrefExplicitLod: return new OpImageSparseSampleProjDrefExplicitLod();
				case Op.OpImageSparseFetch: return new OpImageSparseFetch();
				case Op.OpImageSparseGather: return new OpImageSparseGather();
				case Op.OpImageSparseDrefGather: return new OpImageSparseDrefGather();
				case Op.OpImageSparseTexelsResident: return new OpImageSparseTexelsResident();
				case Op.OpNoLine: return new OpNoLine();
				case Op.OpAtomicFlagTestAndSet: return new OpAtomicFlagTestAndSet();
				case Op.OpAtomicFlagClear: return new OpAtomicFlagClear();
				case Op.OpImageSparseRead: return new OpImageSparseRead();
				case Op.OpDecorateId: return new OpDecorateId();
				case Op.OpSubgroupBallotKHR: return new OpSubgroupBallotKHR();
				case Op.OpSubgroupFirstInvocationKHR: return new OpSubgroupFirstInvocationKHR();
				case Op.OpSubgroupAllKHR: return new OpSubgroupAllKHR();
				case Op.OpSubgroupAnyKHR: return new OpSubgroupAnyKHR();
				case Op.OpSubgroupAllEqualKHR: return new OpSubgroupAllEqualKHR();
				case Op.OpSubgroupReadInvocationKHR: return new OpSubgroupReadInvocationKHR();
				case Op.OpGroupIAddNonUniformAMD: return new OpGroupIAddNonUniformAMD();
				case Op.OpGroupFAddNonUniformAMD: return new OpGroupFAddNonUniformAMD();
				case Op.OpGroupFMinNonUniformAMD: return new OpGroupFMinNonUniformAMD();
				case Op.OpGroupUMinNonUniformAMD: return new OpGroupUMinNonUniformAMD();
				case Op.OpGroupSMinNonUniformAMD: return new OpGroupSMinNonUniformAMD();
				case Op.OpGroupFMaxNonUniformAMD: return new OpGroupFMaxNonUniformAMD();
				case Op.OpGroupUMaxNonUniformAMD: return new OpGroupUMaxNonUniformAMD();
				case Op.OpGroupSMaxNonUniformAMD: return new OpGroupSMaxNonUniformAMD();
				case Op.OpFragmentMaskFetchAMD: return new OpFragmentMaskFetchAMD();
				case Op.OpFragmentFetchAMD: return new OpFragmentFetchAMD();
				case Op.OpSubgroupShuffleINTEL: return new OpSubgroupShuffleINTEL();
				case Op.OpSubgroupShuffleDownINTEL: return new OpSubgroupShuffleDownINTEL();
				case Op.OpSubgroupShuffleUpINTEL: return new OpSubgroupShuffleUpINTEL();
				case Op.OpSubgroupShuffleXorINTEL: return new OpSubgroupShuffleXorINTEL();
				case Op.OpSubgroupBlockReadINTEL: return new OpSubgroupBlockReadINTEL();
				case Op.OpSubgroupBlockWriteINTEL: return new OpSubgroupBlockWriteINTEL();
				case Op.OpSubgroupImageBlockReadINTEL: return new OpSubgroupImageBlockReadINTEL();
				case Op.OpSubgroupImageBlockWriteINTEL: return new OpSubgroupImageBlockWriteINTEL();
				case Op.OpDecorateStringGOOGLE: return new OpDecorateStringGOOGLE();
				case Op.OpMemberDecorateStringGOOGLE: return new OpMemberDecorateStringGOOGLE();
			}
			throw new NotImplementedException();
		}

        public static InstructionCategory GetCategory(Op op)
        {
            switch (op)
            {
                case Op.OpTypeVoid:
                case Op.OpTypeBool:
                case Op.OpTypeInt:
                case Op.OpTypeFloat:
                case Op.OpTypeVector:
                case Op.OpTypeMatrix:
                case Op.OpTypeImage:
                case Op.OpTypeSampler:
                case Op.OpTypeSampledImage:
                case Op.OpTypeArray:
                case Op.OpTypeRuntimeArray:
                case Op.OpTypeStruct:
                case Op.OpTypeOpaque:
                case Op.OpTypePointer:
                case Op.OpTypeFunction:
                case Op.OpTypeEvent:
                case Op.OpTypeDeviceEvent:
                case Op.OpTypeReserveId:
                case Op.OpTypeQueue:
                case Op.OpTypePipe:
                    return InstructionCategory.Type;
                case Op.OpTypeForwardPointer:

                case Op.OpNop:
                case Op.OpUndef:
                case Op.OpSourceContinued:
                case Op.OpSource:
                case Op.OpSourceExtension:
                case Op.OpName:
                case Op.OpMemberName:
                case Op.OpString:
                case Op.OpLine:
                case Op.OpExtension:
                case Op.OpExtInstImport:
                case Op.OpExtInst:
                case Op.OpMemoryModel:
                case Op.OpEntryPoint:
                case Op.OpExecutionMode:
                case Op.OpCapability:
                case Op.OpConstantTrue:
                case Op.OpConstantFalse:
                case Op.OpConstant:
                case Op.OpConstantComposite:
                case Op.OpConstantSampler:
                case Op.OpConstantNull:
                case Op.OpSpecConstantTrue:
                case Op.OpSpecConstantFalse:
                case Op.OpSpecConstant:
                case Op.OpSpecConstantComposite:
                case Op.OpSpecConstantOp:
                case Op.OpFunction:
                case Op.OpFunctionParameter:
                case Op.OpFunctionEnd:
                case Op.OpFunctionCall:
                case Op.OpVariable:
                case Op.OpImageTexelPointer:
                case Op.OpLoad:
                case Op.OpStore:
                case Op.OpCopyMemory:
                case Op.OpCopyMemorySized:
                case Op.OpAccessChain:
                case Op.OpInBoundsAccessChain:
                case Op.OpPtrAccessChain:
                case Op.OpArrayLength:
                case Op.OpGenericPtrMemSemantics:
                case Op.OpInBoundsPtrAccessChain:
                case Op.OpDecorate:
                case Op.OpMemberDecorate:
                case Op.OpDecorationGroup:
                case Op.OpGroupDecorate:
                case Op.OpGroupMemberDecorate:
                case Op.OpVectorExtractDynamic:
                case Op.OpVectorInsertDynamic:
                case Op.OpVectorShuffle:
                case Op.OpCompositeConstruct:
                case Op.OpCompositeExtract:
                case Op.OpCompositeInsert:
                case Op.OpCopyObject:
                case Op.OpTranspose:
                case Op.OpSampledImage:
                case Op.OpImageSampleImplicitLod:
                case Op.OpImageSampleExplicitLod:
                case Op.OpImageSampleDrefImplicitLod:
                case Op.OpImageSampleDrefExplicitLod:
                case Op.OpImageSampleProjImplicitLod:
                case Op.OpImageSampleProjExplicitLod:
                case Op.OpImageSampleProjDrefImplicitLod:
                case Op.OpImageSampleProjDrefExplicitLod:
                case Op.OpImageFetch:
                case Op.OpImageGather:
                case Op.OpImageDrefGather:
                case Op.OpImageRead:
                case Op.OpImageWrite:
                case Op.OpImage:
                case Op.OpImageQueryFormat:
                case Op.OpImageQueryOrder:
                case Op.OpImageQuerySizeLod:
                case Op.OpImageQuerySize:
                case Op.OpImageQueryLod:
                case Op.OpImageQueryLevels:
                case Op.OpImageQuerySamples:
                case Op.OpConvertFToU:
                case Op.OpConvertFToS:
                case Op.OpConvertSToF:
                case Op.OpConvertUToF:
                case Op.OpUConvert:
                case Op.OpSConvert:
                case Op.OpFConvert:
                case Op.OpQuantizeToF16:
                case Op.OpConvertPtrToU:
                case Op.OpSatConvertSToU:
                case Op.OpSatConvertUToS:
                case Op.OpConvertUToPtr:
                case Op.OpPtrCastToGeneric:
                case Op.OpGenericCastToPtr:
                case Op.OpGenericCastToPtrExplicit:
                case Op.OpBitcast:
                case Op.OpSNegate:
                case Op.OpFNegate:
                case Op.OpIAdd:
                case Op.OpFAdd:
                case Op.OpISub:
                case Op.OpFSub:
                case Op.OpIMul:
                case Op.OpFMul:
                case Op.OpUDiv:
                case Op.OpSDiv:
                case Op.OpFDiv:
                case Op.OpUMod:
                case Op.OpSRem:
                case Op.OpSMod:
                case Op.OpFRem:
                case Op.OpFMod:
                case Op.OpVectorTimesScalar:
                case Op.OpMatrixTimesScalar:
                case Op.OpVectorTimesMatrix:
                case Op.OpMatrixTimesVector:
                case Op.OpMatrixTimesMatrix:
                case Op.OpOuterProduct:
                case Op.OpDot:
                case Op.OpIAddCarry:
                case Op.OpISubBorrow:
                case Op.OpUMulExtended:
                case Op.OpSMulExtended:
                case Op.OpAny:
                case Op.OpAll:
                case Op.OpIsNan:
                case Op.OpIsInf:
                case Op.OpIsFinite:
                case Op.OpIsNormal:
                case Op.OpSignBitSet:
                case Op.OpLessOrGreater:
                case Op.OpOrdered:
                case Op.OpUnordered:
                case Op.OpLogicalEqual:
                case Op.OpLogicalNotEqual:
                case Op.OpLogicalOr:
                case Op.OpLogicalAnd:
                case Op.OpLogicalNot:
                case Op.OpSelect:
                case Op.OpIEqual:
                case Op.OpINotEqual:
                case Op.OpUGreaterThan:
                case Op.OpSGreaterThan:
                case Op.OpUGreaterThanEqual:
                case Op.OpSGreaterThanEqual:
                case Op.OpULessThan:
                case Op.OpSLessThan:
                case Op.OpULessThanEqual:
                case Op.OpSLessThanEqual:
                case Op.OpFOrdEqual:
                case Op.OpFUnordEqual:
                case Op.OpFOrdNotEqual:
                case Op.OpFUnordNotEqual:
                case Op.OpFOrdLessThan:
                case Op.OpFUnordLessThan:
                case Op.OpFOrdGreaterThan:
                case Op.OpFUnordGreaterThan:
                case Op.OpFOrdLessThanEqual:
                case Op.OpFUnordLessThanEqual:
                case Op.OpFOrdGreaterThanEqual:
                case Op.OpFUnordGreaterThanEqual:
                case Op.OpShiftRightLogical:
                case Op.OpShiftRightArithmetic:
                case Op.OpShiftLeftLogical:
                case Op.OpBitwiseOr:
                case Op.OpBitwiseXor:
                case Op.OpBitwiseAnd:
                case Op.OpNot:
                case Op.OpBitFieldInsert:
                case Op.OpBitFieldSExtract:
                case Op.OpBitFieldUExtract:
                case Op.OpBitReverse:
                case Op.OpBitCount:
                case Op.OpDPdx:
                case Op.OpDPdy:
                case Op.OpFwidth:
                case Op.OpDPdxFine:
                case Op.OpDPdyFine:
                case Op.OpFwidthFine:
                case Op.OpDPdxCoarse:
                case Op.OpDPdyCoarse:
                case Op.OpFwidthCoarse:
                case Op.OpEmitVertex:
                case Op.OpEndPrimitive:
                case Op.OpEmitStreamVertex:
                case Op.OpEndStreamPrimitive:
                case Op.OpControlBarrier:
                case Op.OpMemoryBarrier:
                case Op.OpAtomicLoad:
                case Op.OpAtomicStore:
                case Op.OpAtomicExchange:
                case Op.OpAtomicCompareExchange:
                case Op.OpAtomicCompareExchangeWeak:
                case Op.OpAtomicIIncrement:
                case Op.OpAtomicIDecrement:
                case Op.OpAtomicIAdd:
                case Op.OpAtomicISub:
                case Op.OpAtomicSMin:
                case Op.OpAtomicUMin:
                case Op.OpAtomicSMax:
                case Op.OpAtomicUMax:
                case Op.OpAtomicAnd:
                case Op.OpAtomicOr:
                case Op.OpAtomicXor:
                case Op.OpPhi:
                case Op.OpLoopMerge:
                case Op.OpSelectionMerge:
                case Op.OpLabel:
                case Op.OpBranch:
                case Op.OpBranchConditional:
                case Op.OpSwitch:
                case Op.OpKill:
                case Op.OpReturn:
                case Op.OpReturnValue:
                case Op.OpUnreachable:
                case Op.OpLifetimeStart:
                case Op.OpLifetimeStop:
                case Op.OpGroupAsyncCopy:
                case Op.OpGroupWaitEvents:
                case Op.OpGroupAll:
                case Op.OpGroupAny:
                case Op.OpGroupBroadcast:
                case Op.OpGroupIAdd:
                case Op.OpGroupFAdd:
                case Op.OpGroupFMin:
                case Op.OpGroupUMin:
                case Op.OpGroupSMin:
                case Op.OpGroupFMax:
                case Op.OpGroupUMax:
                case Op.OpGroupSMax:
                case Op.OpReadPipe:
                case Op.OpWritePipe:
                case Op.OpReservedReadPipe:
                case Op.OpReservedWritePipe:
                case Op.OpReserveReadPipePackets:
                case Op.OpReserveWritePipePackets:
                case Op.OpCommitReadPipe:
                case Op.OpCommitWritePipe:
                case Op.OpIsValidReserveId:
                case Op.OpGetNumPipePackets:
                case Op.OpGetMaxPipePackets:
                case Op.OpGroupReserveReadPipePackets:
                case Op.OpGroupReserveWritePipePackets:
                case Op.OpGroupCommitReadPipe:
                case Op.OpGroupCommitWritePipe:
                case Op.OpEnqueueMarker:
                case Op.OpEnqueueKernel:
                case Op.OpGetKernelNDrangeSubGroupCount:
                case Op.OpGetKernelNDrangeMaxSubGroupSize:
                case Op.OpGetKernelWorkGroupSize:
                case Op.OpGetKernelPreferredWorkGroupSizeMultiple:
                case Op.OpRetainEvent:
                case Op.OpReleaseEvent:
                case Op.OpCreateUserEvent:
                case Op.OpIsValidEvent:
                case Op.OpSetUserEventStatus:
                case Op.OpCaptureEventProfilingInfo:
                case Op.OpGetDefaultQueue:
                case Op.OpBuildNDRange:
                case Op.OpImageSparseSampleImplicitLod:
                case Op.OpImageSparseSampleExplicitLod:
                case Op.OpImageSparseSampleDrefImplicitLod:
                case Op.OpImageSparseSampleDrefExplicitLod:
                case Op.OpImageSparseSampleProjImplicitLod:
                case Op.OpImageSparseSampleProjExplicitLod:
                case Op.OpImageSparseSampleProjDrefImplicitLod:
                case Op.OpImageSparseSampleProjDrefExplicitLod:
                case Op.OpImageSparseFetch:
                case Op.OpImageSparseGather:
                case Op.OpImageSparseDrefGather:
                case Op.OpImageSparseTexelsResident:
                case Op.OpNoLine:
                case Op.OpAtomicFlagTestAndSet:
                case Op.OpAtomicFlagClear:
                case Op.OpImageSparseRead:
                case Op.OpDecorateId:
                case Op.OpSubgroupBallotKHR:
                case Op.OpSubgroupFirstInvocationKHR:
                case Op.OpSubgroupAllKHR:
                case Op.OpSubgroupAnyKHR:
                case Op.OpSubgroupAllEqualKHR:
                case Op.OpSubgroupReadInvocationKHR:
                case Op.OpGroupIAddNonUniformAMD:
                case Op.OpGroupFAddNonUniformAMD:
                case Op.OpGroupFMinNonUniformAMD:
                case Op.OpGroupUMinNonUniformAMD:
                case Op.OpGroupSMinNonUniformAMD:
                case Op.OpGroupFMaxNonUniformAMD:
                case Op.OpGroupUMaxNonUniformAMD:
                case Op.OpGroupSMaxNonUniformAMD:
                case Op.OpFragmentMaskFetchAMD:
                case Op.OpFragmentFetchAMD:
                case Op.OpSubgroupShuffleINTEL:
                case Op.OpSubgroupShuffleDownINTEL:
                case Op.OpSubgroupShuffleUpINTEL:
                case Op.OpSubgroupShuffleXorINTEL:
                case Op.OpSubgroupBlockReadINTEL:
                case Op.OpSubgroupBlockWriteINTEL:
                case Op.OpSubgroupImageBlockReadINTEL:
                case Op.OpSubgroupImageBlockWriteINTEL:
                case Op.OpDecorateStringGOOGLE:
                case Op.OpMemberDecorateStringGOOGLE:
                    return InstructionCategory.Unknown;
            }
            return InstructionCategory.Unknown;
        }
    }
}