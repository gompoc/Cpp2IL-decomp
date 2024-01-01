using AsmResolver.DotNet;
using AsmResolver.DotNet.Signatures.Types;
using Cpp2IL.Core.Utils;
using LibCpp2IL.BinaryStructures;

namespace Cpp2IL.Core.Model.Contexts;

public class PointerTypeAnalysisContext : WrappedTypeAnalysisContext
{
    public PointerTypeAnalysisContext(TypeAnalysisContext elementType, AssemblyAnalysisContext referencedFrom) : base(elementType, referencedFrom)
    {
    }

    public PointerTypeAnalysisContext(Il2CppType rawType, AssemblyAnalysisContext referencedFrom)
        : this(referencedFrom.ResolveIl2CppType(rawType.GetEncapsulatedType()), referencedFrom)
    {
    }

    public override Il2CppTypeEnum Type => Il2CppTypeEnum.IL2CPP_TYPE_PTR;

    public override string DefaultName => $"{ElementType.Name}*";

    public override TypeSignature ToTypeSignature(ModuleDefinition parentModule)
    {
        return ElementType.ToTypeSignature(parentModule).MakePointerType();
    }
}