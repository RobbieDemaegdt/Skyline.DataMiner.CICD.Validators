namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Alarm.CheckOptionsAttribute
{
    using System;
    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    internal static class Error
    {
        internal static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "2.34.4",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "Alarm@option", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "2.34.5",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}' in {1} '{2}'. Current value '{3}'.", "Alarm@option", "Param", pid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
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
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "2.34.6",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "Alarm@option", "Param", "ID", referencedPid, "Param", "ID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ReferencedParamRTDisplayExpected(IValidate test, IReadable referenceNode, IReadable positionNode, string referencedPid, string referencingPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.ReferencedParamRTDisplayExpected,
                FullId = "2.34.7",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on Param '{0}' referenced by a 'Alarm@option' attribute. Param ID '{1}'.", referencedPid, referencingPid),
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
        internal static IValidationResult UpdatedThresholdAlarmType(IReadable referenceNode, IReadable positionNode, string oldValue, string paramPid, string newValue)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.UpdatedThresholdAlarmType,
                FullId = "2.34.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Threshold with value '{0}' on Param '{1}' was changed into '{2}'.", oldValue, paramPid, newValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult AddedThresholdAlarmType(IReadable referenceNode, IReadable positionNode, string newValue, string paramPid)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.AddedThresholdAlarmType,
                FullId = "2.34.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Threshold with value '{0}' was added to Param '{1}'.", newValue, paramPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult RemovedThresholdAlarmType(IReadable referenceNode, IReadable positionNode, string oldValue, string paramPid)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.RemovedThresholdAlarmType,
                FullId = "2.34.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Threshold with value '{0}' was removed from Param '{1}'.", oldValue, paramPid),
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
        public const uint UpdatedThresholdAlarmType = 1;
        public const uint AddedThresholdAlarmType = 2;
        public const uint RemovedThresholdAlarmType = 3;
        public const uint EmptyAttribute = 4;
        public const uint UntrimmedAttribute = 5;
        public const uint NonExistingId = 6;
        public const uint ReferencedParamRTDisplayExpected = 7;
    }

    public static class CheckId
    {
        public const uint CheckOptionsAttribute = 34;
    }
}