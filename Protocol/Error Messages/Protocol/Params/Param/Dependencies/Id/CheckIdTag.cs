namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Dependencies.Id.CheckIdTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        internal static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "2.67.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing tag '{0}' in {1} '{2}'.", "Dependencies/Id", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "A 'Dependencies/Id' tag should contain the ID of an existing Param. Both the referencing and the referenced Param should have their RTDisplay tag set to 'true'.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "2.67.2",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "Dependencies/Id", "Param", pid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "A 'Dependencies/Id' tag should contain the ID of an existing Param. Both the referencing and the referenced Param should have their RTDisplay tag set to 'true'.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string referencedPid, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdTag,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "2.67.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "Dependencies/Id", "Param", "ID", referencedPid, "Param", "ID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "A 'Dependencies/Id' tag should contain the ID of an existing Param. Both the referencing and the referenced Param should have their RTDisplay tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult RTDisplayExpected(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdTag,
                ErrorId = ErrorIds.RTDisplayExpected,
                FullId = "2.67.4",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on Param '{0}' containing 'Dependencies/Id' tag(s).", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "A 'Dependencies/Id' tag should contain the ID of an existing Param. Both the referencing and the referenced Param should have their RTDisplay tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult RTDisplayExpectedOnReferencedParam(IValidate test, IReadable referenceNode, IReadable positionNode, string referencedPid, string referencingPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdTag,
                ErrorId = ErrorIds.RTDisplayExpectedOnReferencedParam,
                FullId = "2.67.5",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on Param '{0}' referenced by a 'Dependencies/Id' tag. Param ID '{1}'.", referencedPid, referencingPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "A 'Dependencies/Id' tag should contain the ID of an existing Param. Both the referencing and the referenced Param should have their RTDisplay tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint EmptyTag = 1;
        public const uint UntrimmedTag = 2;
        public const uint NonExistingId = 3;
        public const uint RTDisplayExpected = 4;
        public const uint RTDisplayExpectedOnReferencedParam = 5;
    }

    public static class CheckId
    {
        public const uint CheckIdTag = 67;
    }
}