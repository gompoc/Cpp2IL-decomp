﻿using System.IO;
using Cpp2IL.Core.Model.Contexts;

namespace Cpp2IL.Core.Model.CustomAttributes;

public sealed class CustomAttributeNullParameter : BaseCustomAttributeParameter
{
    public CustomAttributeNullParameter(AnalyzedCustomAttribute owner, CustomAttributeParameterKind kind, int index) : base(owner, kind, index)
    {
    }

    public override void ReadFromV29Blob(BinaryReader reader, ApplicationAnalysisContext context) => throw new System.NotSupportedException();
}