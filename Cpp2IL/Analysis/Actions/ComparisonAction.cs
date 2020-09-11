﻿using Cpp2IL.Analysis.ResultModels;
using Iced.Intel;

namespace Cpp2IL.Analysis.Actions
{
    public class ComparisonAction : BaseAction
    {
        public IAnalysedOperand ArgumentOne;
        public IAnalysedOperand ArgumentTwo;
        
        public ComparisonAction(MethodAnalysis context, Instruction instruction) : base(context, instruction)
        {
            var r0 = Utils.GetRegisterNameNew(instruction.Op0Register);
            var r1 = Utils.GetRegisterNameNew(instruction.Op1Register);

            if (r0 != "rsp")
                ArgumentOne = context.GetOperandInRegister(r0);
            if (r1 != "rsp")
                ArgumentTwo = context.GetOperandInRegister(r1);
        }

        public override Mono.Cecil.Cil.Instruction[] ToILInstructions()
        {
            throw new System.NotImplementedException();
        }

        public override string ToPsuedoCode()
        {
            throw new System.NotImplementedException();
        }

        public override string ToTextSummary()
        {
            return $"[!] Compares {ArgumentOne} and {ArgumentTwo}";
        }
    }
}