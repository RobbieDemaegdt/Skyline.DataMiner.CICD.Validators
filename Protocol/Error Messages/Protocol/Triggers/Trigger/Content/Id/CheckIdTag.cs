namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Triggers.Trigger.Content.Id.CheckIdTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        internal static IValidationResult MissingTag(IValidate test, IReadable referenceNode, IReadable positionNode, string triggerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdTag,
                ErrorId = ErrorIds.MissingTag,
                FullId = "5.10.1",
                Category = Category.Trigger,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing tag '{0}' in {1} '{2}'.", "Content/Id", "Trigger", triggerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Content tag of every Trigger should contain at least one Id tag." + Environment.NewLine + "Such Id tag should contain an unsigned number and refer to the id of an existing Trigger or Action depending on the 'Trigger/Type' tag value." + Environment.NewLine + "" + Environment.NewLine + "Note that only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string triggerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "5.10.2",
                Category = Category.Trigger,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "Content/Id", "Trigger", triggerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Content tag of every Trigger should contain at least one Id tag." + Environment.NewLine + "Such Id tag should contain an unsigned number and refer to the id of an existing Trigger or Action depending on the 'Trigger/Type' tag value." + Environment.NewLine + "" + Environment.NewLine + "Note that only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string triggerId, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "5.10.3",
                Category = Category.Trigger,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "Content/Id", "Trigger", triggerId, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Content tag of every Trigger should contain at least one Id tag." + Environment.NewLine + "Such Id tag should contain an unsigned number and refer to the id of an existing Trigger or Action depending on the 'Trigger/Type' tag value." + Environment.NewLine + "" + Environment.NewLine + "Note that only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string tagValue, string triggerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdTag,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "5.10.4",
                Category = Category.Trigger,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}'. {2} {4} '{3}'.", tagValue, "Content/Id", "Trigger", triggerId, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Content tag of every Trigger should contain at least one Id tag." + Environment.NewLine + "Such Id tag should contain an unsigned number and refer to the id of an existing Trigger or Action depending on the 'Trigger/Type' tag value." + Environment.NewLine + "" + Environment.NewLine + "Note that only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string targetKind, string targetId, string triggerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdTag,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "5.10.5",
                Category = Category.Trigger,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Tag '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "Content/Id", targetKind, "ID", targetId, "Trigger", "ID", triggerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Content tag of every Trigger should contain at least one Id tag." + Environment.NewLine + "Such Id tag should contain an unsigned number and refer to the id of an existing Trigger or Action depending on the 'Trigger/Type' tag value." + Environment.NewLine + "" + Environment.NewLine + "Note that only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint MissingTag = 1;
        public const uint EmptyTag = 2;
        public const uint UntrimmedTag = 3;
        public const uint InvalidValue = 4;
        public const uint NonExistingId = 5;
    }

    public static class CheckId
    {
        public const uint CheckIdTag = 10;
    }
}