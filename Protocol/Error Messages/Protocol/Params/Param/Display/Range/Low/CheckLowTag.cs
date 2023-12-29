namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Display.Range.Low.CheckLowTag
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
        public static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckLowTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "2.32.3",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "Range/Low", "Param", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "If present, the 'Range/Low' tag should be filled in with a numerical value." + Environment.NewLine + "Its value should be smaller than the one in the 'Range/High' tag.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string tagValue, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckLowTag,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "2.32.4",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}'. {2} {4} '{3}'.", tagValue, "Range/Low", "Param", paramId, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "If present, the 'Range/Low' tag should be filled in with a numerical value." + Environment.NewLine + "Its value should be smaller than the one in the 'Range/High' tag.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedValue(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckLowTag,
                ErrorId = ErrorIds.UntrimmedValue,
                FullId = "2.32.5",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "Range/Low", "Param", paramId, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "If present, the 'Range/Low' tag should be filled in with a numerical value." + Environment.NewLine + "Its value should be smaller than the one in the 'Range/High' tag.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult LogarithmicLowerOrEqualToZero(IValidate test, IReadable referenceNode, IReadable positionNode, string rangeLow, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckLowTag,
                ErrorId = ErrorIds.LogarithmicLowerOrEqualToZero,
                FullId = "2.32.6",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Range/Low '{0}' should be bigger than zero due to Trending@logarithmic 'true'. Param ID '{1}'.", rangeLow, paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "When Trending@logarithmic is set to 'true', both 'Range/Low' and 'Range/High' should be bigger than 0.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult WriteDifferentThanRead(IValidate test, IReadable referenceNode, IReadable positionNode, string rangeLowOnWrite, string rangeLowOnRead, string writePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckLowTag,
                ErrorId = ErrorIds.WriteDifferentThanRead,
                FullId = "2.32.7",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Range/Low on write Param '{0}' is different than the one on read Param '{1}'. Write PID '{2}'.", rangeLowOnWrite, rangeLowOnRead, writePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorCompare
    {
        public static IValidationResult UpdatedLowRange(IReadable referenceNode, IReadable positionNode, string previousValue, string paramPid, string newValue)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckLowTag,
                ErrorId = ErrorIds.UpdatedLowRange,
                FullId = "2.32.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Low range '{0}' in Param '{1}' increased to '{2}'.", previousValue, paramPid, newValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult AddedLowRange(IReadable referenceNode, IReadable positionNode, string newValue, string paramPid)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckLowTag,
                ErrorId = ErrorIds.AddedLowRange,
                FullId = "2.32.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Low range '{0}' in Param '{1}' was added.", newValue, paramPid),
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
        public const uint UpdatedLowRange = 1;
        public const uint AddedLowRange = 2;
        public const uint EmptyTag = 3;
        public const uint InvalidValue = 4;
        public const uint UntrimmedValue = 5;
        public const uint LogarithmicLowerOrEqualToZero = 6;
        public const uint WriteDifferentThanRead = 7;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckLowTag = 32;
    }
}