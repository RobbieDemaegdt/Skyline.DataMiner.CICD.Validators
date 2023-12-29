namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Compliancies.MinimumRequiredVersion.CheckMinimumRequiredVersionTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        internal static IValidationResult MinVersionTooLow(IValidate test, IReadable referenceNode, IReadable positionNode, string currentMinDmVersion, string expectedMinDmVersion)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckMinimumRequiredVersionTag,
                ErrorId = ErrorIds.MinVersionTooLow,
                FullId = "1.25.1",
                Category = Category.Protocol,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Minimum required version '{0}' too low. Expected value '{1}'.", currentMinDmVersion, expectedMinDmVersion),
                HowToFix = "",
                ExampleCode = "",
                Details = "Indicates the minimum DataMiner ver­sion that the driver is compatible with. " + Environment.NewLine + "If the DMS software version is less recent than the indicated version, the protocol will not be useable.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MinVersionTooLow_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string requiredDmVersion, string usedFeature)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckMinimumRequiredVersionTag,
                ErrorId = ErrorIds.MinVersionTooLow_Sub,
                FullId = "1.25.2",
                Category = Category.Protocol,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("'{0}' : '{1}'", requiredDmVersion, usedFeature),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MinVersionFeatureUsedInItemWithId_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string itemKind, string identifierType, string itemId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckMinimumRequiredVersionTag,
                ErrorId = ErrorIds.MinVersionFeatureUsedInItemWithId_Sub,
                FullId = "1.25.3",
                Category = Category.Protocol,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Feature used in '{0}' with '{1}' '{2}'.", itemKind, identifierType, itemId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MinVersionFeatureUsedInItem_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string itemKind)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckMinimumRequiredVersionTag,
                ErrorId = ErrorIds.MinVersionFeatureUsedInItem_Sub,
                FullId = "1.25.4",
                Category = Category.Protocol,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Feature used in '{0}'.", itemKind),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string tagValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckMinimumRequiredVersionTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "1.25.5",
                Category = Category.Protocol,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}'. Current value '{1}'.", "MinimumRequiredVersion", tagValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorCompare
    {
        internal static IValidationResult MinVersionIncreased(IReadable referenceNode, IReadable positionNode, string oldMinDmVersion, string newMinDmVersion)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckMinimumRequiredVersionTag,
                ErrorId = ErrorIds.MinVersionIncreased,
                FullId = "1.25.6",
                Category = Category.Protocol,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Minimum DataMiner required version increased from '{0}' to '{1}'.", oldMinDmVersion, newMinDmVersion),
                HowToFix = "",
                ExampleCode = "",
                Details = "When increasing the minimum supported DataMiner version, a new protocol range should be made by incrementing the system version (2nd part of the protocol version)",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint MinVersionTooLow = 1;
        public const uint MinVersionTooLow_Sub = 2;
        public const uint MinVersionFeatureUsedInItemWithId_Sub = 3;
        public const uint MinVersionFeatureUsedInItem_Sub = 4;
        public const uint UntrimmedTag = 5;
        public const uint MinVersionIncreased = 6;
    }

    public static class CheckId
    {
        public const uint CheckMinimumRequiredVersionTag = 25;
    }
}