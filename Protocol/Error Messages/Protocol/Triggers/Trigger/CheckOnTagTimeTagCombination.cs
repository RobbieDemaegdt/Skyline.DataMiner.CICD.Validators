namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Triggers.Trigger.CheckOnTagTimeTagCombination
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
        public static IValidationResult InvalidOnTagTimeTagCombination(IValidate test, IReadable referenceNode, IReadable positionNode, string onTagValue, string timeTagValue, string triggerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOnTagTimeTagCombination,
                ErrorId = ErrorIds.InvalidOnTagTimeTagCombination,
                FullId = "5.6.1",
                Category = Category.Trigger,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("The On tag value '{0}' can't be used in combination with the Time tag value '{1}'. Trigger ID '{2}'.", onTagValue, timeTagValue, triggerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DuplicateTrigger(IValidate test, IReadable referenceNode, IReadable positionNode, Certainty certainty, string triggerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOnTagTimeTagCombination,
                ErrorId = ErrorIds.DuplicateTrigger,
                FullId = "5.6.2",
                Category = Category.Trigger,
                Severity = Severity.Minor,
                Certainty = certainty,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Multiple triggers with same Time/On combination. Trigger IDs '{0}'.", triggerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint InvalidOnTagTimeTagCombination = 1;
        public const uint DuplicateTrigger = 2;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckOnTagTimeTagCombination = 6;
    }
}