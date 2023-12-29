namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Measurement.Discreets.Discreet.CheckDependencyValuesAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        internal static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDependencyValuesAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "2.59.1",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "Discreet@dependencyValues", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Discreet@dependencyValues attribute can be used in 2 scenarios:" + Environment.NewLine + "- In combination with Discreets@dependencyId attribute." + Environment.NewLine + "- On a table contextMenu Param." + Environment.NewLine + "    - All referenced Params then require their RTDisplay tag to be set to true." + Environment.NewLine + "" + Environment.NewLine + "See the guides for more info.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDependencyValuesAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "2.59.2",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}' in {1} '{2}'. Current value '{3}'.", "Discreet@dependencyValues", "Param", pid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Discreet@dependencyValues attribute can be used in 2 scenarios:" + Environment.NewLine + "- In combination with Discreets@dependencyId attribute." + Environment.NewLine + "- On a table contextMenu Param." + Environment.NewLine + "    - All referenced Params then require their RTDisplay tag to be set to true." + Environment.NewLine + "" + Environment.NewLine + "See the guides for more info.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string referencePid, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDependencyValuesAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "2.59.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "Discreet@dependencyValues", "Param", "ID", referencePid, "Param", "ID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Discreet@dependencyValues attribute can be used in 2 scenarios:" + Environment.NewLine + "- In combination with Discreets@dependencyId attribute." + Environment.NewLine + "- On a table contextMenu Param." + Environment.NewLine + "    - All referenced Params then require their RTDisplay tag to be set to true." + Environment.NewLine + "" + Environment.NewLine + "See the guides for more info.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ReferencedParamExpectingRTDisplay(IValidate test, IReadable referenceNode, IReadable positionNode, string referencePid, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDependencyValuesAttribute,
                ErrorId = ErrorIds.ReferencedParamExpectingRTDisplay,
                FullId = "2.59.4",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on Param '{0}' referenced in 'Discreet@dependencyValues' attribute. Param ID '{1}'.", referencePid, pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Discreet@dependencyValues attribute can be used in 2 scenarios:" + Environment.NewLine + "- In combination with Discreets@dependencyId attribute." + Environment.NewLine + "- On a table contextMenu Param." + Environment.NewLine + "    - All referenced Params then require their RTDisplay tag to be set to true." + Environment.NewLine + "" + Environment.NewLine + "See the guides for more info.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint EmptyAttribute = 1;
        public const uint UntrimmedAttribute = 2;
        public const uint NonExistingId = 3;
        public const uint ReferencedParamExpectingRTDisplay = 4;
    }

    public static class CheckId
    {
        public const uint CheckDependencyValuesAttribute = 59;
    }
}