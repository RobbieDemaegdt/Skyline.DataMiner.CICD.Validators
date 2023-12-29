namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.CheckEndlessLoop
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
        public static IValidationResult EndlessLoop(IValidate test, IReadable referenceNode, IReadable positionNode, string involvedItems)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckEndlessLoop,
                ErrorId = ErrorIds.EndlessLoop,
                FullId = "1.24.1",
                Category = Category.Protocol,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Endless loop detected. Involved items '{0}'", involvedItems),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult PotentialEndlessLoop(IValidate test, IReadable referenceNode, IReadable positionNode, string involvedItems)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckEndlessLoop,
                ErrorId = ErrorIds.PotentialEndlessLoop,
                FullId = "1.24.2",
                Category = Category.Protocol,
                Severity = Severity.Critical,
                Certainty = Certainty.Uncertain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Potential endless loop detected. Involved items '{0}'", involvedItems),
                HowToFix = "",
                ExampleCode = "",
                Details = "Uncertain because not all paths could be completed due to conditions in the flow of the loop.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint EndlessLoop = 1;
        public const uint PotentialEndlessLoop = 2;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckEndlessLoop = 24;
    }
}