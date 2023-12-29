namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Pairs.Pair.Content.Response.CheckResponseTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        internal static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pairId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckResponseTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "9.5.2",
                Category = Category.Pair,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "Content/Response", "Pair", pairId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Content tag of pairs can contain any number of Response tags." + Environment.NewLine + "Those should have as value an unsigned number and refer to the id of an existing Response." + Environment.NewLine + "A given pair can't refer to the same Response more than once (including both Response and ResponseOnBadCommand tags)." + Environment.NewLine + "" + Environment.NewLine + "Also note that only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pairId, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckResponseTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "9.5.3",
                Category = Category.Pair,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "Content/Response", "Pair", pairId, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Content tag of pairs can contain any number of Response tags." + Environment.NewLine + "Those should have as value an unsigned number and refer to the id of an existing Response." + Environment.NewLine + "A given pair can't refer to the same Response more than once (including both Response and ResponseOnBadCommand tags)." + Environment.NewLine + "" + Environment.NewLine + "Also note that only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string tagValue, string pairId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckResponseTag,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "9.5.4",
                Category = Category.Pair,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}'. {2} {4} '{3}'.", tagValue, "Content/Response", "Pair", pairId, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Content tag of pairs can contain any number of Response tags." + Environment.NewLine + "Those should have as value an unsigned number and refer to the id of an existing Response." + Environment.NewLine + "A given pair can't refer to the same Response more than once (including both Response and ResponseOnBadCommand tags)." + Environment.NewLine + "" + Environment.NewLine + "Also note that only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string responseId, string pairId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckResponseTag,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "9.5.5",
                Category = Category.Pair,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Tag '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "Content/Response", "Response", "ID", responseId, "Pair", "ID", pairId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Content tag of pairs can contain any number of Response tags." + Environment.NewLine + "Those should have as value an unsigned number and refer to the id of an existing Response." + Environment.NewLine + "A given pair can't refer to the same Response more than once (including both Response and ResponseOnBadCommand tags)." + Environment.NewLine + "" + Environment.NewLine + "Also note that only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint EmptyTag = 2;
        public const uint UntrimmedTag = 3;
        public const uint InvalidValue = 4;
        public const uint NonExistingId = 5;
    }

    public static class CheckId
    {
        public const uint CheckResponseTag = 5;
    }
}