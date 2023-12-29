namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Display.Pages.Page.Visibility.CheckOverridePidAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        internal static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string pageName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOverridePidAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "1.27.1",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}' in {1} '{2}'.", "Page.Visibility@overridePID", "Page", pageName),
                HowToFix = "",
                ExampleCode = "",
                Details = "The attribute 'Visibility@overridePID' is mandatory within a Page/Visibility tag. It should refer to the ID of an existing Param. The referenced Param should have its RTDisplay tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string pageName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOverridePidAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "1.27.2",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "Page.Visibility@overridePID", "Page", pageName),
                HowToFix = "",
                ExampleCode = "",
                Details = "The attribute 'Visibility@overridePID' is mandatory within a Page/Visibility tag. It should refer to the ID of an existing Param. The referenced Param should have its RTDisplay tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string pageName, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOverridePidAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "1.27.3",
                Category = Category.Protocol,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}' in {1} '{2}'. Current value '{3}'.", "Page.Visibility@overridePID", "Page", pageName, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "The attribute 'Visibility@overridePID' is mandatory within a Page/Visibility tag. It should refer to the ID of an existing Param. The referenced Param should have its RTDisplay tag set to 'true'.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingParam(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string pageName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOverridePidAttribute,
                ErrorId = ErrorIds.NonExistingParam,
                FullId = "1.27.4",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "Page.Visibility@overridePID", "Param", "ID", pid, "Page", "Name", pageName),
                HowToFix = "",
                ExampleCode = "",
                Details = "The attribute 'Visibility@overridePID' is mandatory within a Page/Visibility tag. It should refer to the ID of an existing Param. The referenced Param should have its RTDisplay tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ReferencedParamExpectingRTDisplay(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string pageName)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOverridePidAttribute,
                ErrorId = ErrorIds.ReferencedParamExpectingRTDisplay,
                FullId = "1.27.5",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on Param '{0}' used as page visibility condition. Page name '{1}'.", pid, pageName),
                HowToFix = "",
                ExampleCode = "",
                Details = "The attribute 'Visibility@overridePID' is mandatory within a Page/Visibility tag. It should refer to the ID of an existing Param. The referenced Param should have its RTDisplay tag set to 'true'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint MissingAttribute = 1;
        public const uint EmptyAttribute = 2;
        public const uint UntrimmedAttribute = 3;
        public const uint NonExistingParam = 4;
        public const uint ReferencedParamExpectingRTDisplay = 5;
    }

    public static class CheckId
    {
        public const uint CheckOverridePidAttribute = 27;
    }
}