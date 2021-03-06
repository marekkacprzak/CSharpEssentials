﻿using Microsoft.CodeAnalysis.Diagnostics;
using NUnit.Framework;
using CSharpEssentials.UseExpressionBodiedMember;

namespace CSharpEssentials.Tests
{
    [TestFixture]
    public class UseExpressionBodiedMemberAnalyzerTests : AnalyzerTestFixture
    {
        public override DiagnosticAnalyzer CreateAnalyzer()
        {
            return new UseExpressionBodiedMemberAnalyzer();
        }

        [Test]
        public void NoDiagnosticWhenThereIsAnAttributeOnAnAccessor()
        {
            const string code = @"
class C
{
    int Property
    {
        [A] get { return 42; }
    }
}";

            NoDiagnostic(code, DiagnosticIds.UseExpressionBodiedMember);
        }
    }
}
