namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Actions.Action.On.CheckNrAttribute
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
        public static IValidationResult EmptyAttibute(IValidate test, IReadable referenceNode, IReadable positionNode, string actionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNrAttribute,
                ErrorId = ErrorIds.EmptyAttibute,
                FullId = "6.22.2",
                Category = Category.Action,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "Action/On@nr", "Action", actionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The 'Action/On@nr' attribute only makes sense if 'Action/Type' tag is set to one of the following values:" + Environment.NewLine + "- reverse: Semicolon (;) separated list of 0-based position(s) of the parameter in the command/response.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string untrimmedValue, string actionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNrAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "6.22.3",
                Category = Category.Action,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed value '{0}' in attribute '{1}'. {2} {3} '{4}'.", untrimmedValue, "Action/On@nr", "Action", "ID", actionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The 'Action/On@nr' attribute only makes sense if 'Action/Type' tag is set to one of the following values:" + Environment.NewLine + "- reverse: Semicolon (;) separated list of 0-based position(s) of the parameter in the command/response.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string attributeValue, string actionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckNrAttribute,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "6.22.4",
                Category = Category.Action,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'. {2} {4} '{3}'.", "Action/On@nr", attributeValue, "Action", actionId, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "The 'Action/On@nr' attribute only makes sense if 'Action/Type' tag is set to one of the following values:" + Environment.NewLine + "- reverse: Semicolon (;) separated list of 0-based position(s) of the parameter in the command/response.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint EmptyAttibute = 2;
        public const uint UntrimmedAttribute = 3;
        public const uint InvalidValue = 4;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckNrAttribute = 22;
    }
}