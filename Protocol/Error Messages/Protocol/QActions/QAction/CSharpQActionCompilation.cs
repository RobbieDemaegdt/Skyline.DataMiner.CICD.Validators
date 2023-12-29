namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.QActions.QAction.CSharpQActionCompilation
{
    using System;
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        public static IValidationResult CompilationFailure(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpQActionCompilation,
                ErrorId = ErrorIds.CompilationFailure,
                FullId = "3.4.1",
                Category = Category.QAction,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("C# compilation errors. QAction ID '{0}'.", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult CompilationFailure_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string errorMessage)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpQActionCompilation,
                ErrorId = ErrorIds.CompilationFailure_Sub,
                FullId = "3.4.2",
                Category = Category.QAction,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("{0}", errorMessage),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NoCSharpCodeAnalysisPerformed(IValidate test, IReadable referenceNode, IReadable positionNode, string cSharpVersion, string visualStudioVersion)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpQActionCompilation,
                ErrorId = ErrorIds.NoCSharpCodeAnalysisPerformed,
                FullId = "3.4.3",
                Category = Category.QAction,
                Severity = Severity.Warning,
                Certainty = Certainty.Uncertain,
                Source = Source.Validator,
                FixImpact = FixImpact.Undefined,
                GroupDescription = "",
                Description = String.Format("No C# QAction code analysis was performed due to unsupported C# version '{0}' in Visual Studio version '{1}'.", cSharpVersion, visualStudioVersion),
                HowToFix = "",
                ExampleCode = "",
                Details = "No C# QAction code analysis could be performed due to following mismatch in supported C# syntax versions:" + Environment.NewLine + "- C# syntax up to and including version 7.3 is supported by the protocol (see 'Compliancies/MinimumRequiredVersion' tag)." + Environment.NewLine + "- C# 7.3 syntax is not supported by this Visual Studio (See Visual Studio version).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint CompilationFailure = 1;
        public const uint CompilationFailure_Sub = 2;
        public const uint NoCSharpCodeAnalysisPerformed = 3;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CSharpQActionCompilation = 4;
    }
}