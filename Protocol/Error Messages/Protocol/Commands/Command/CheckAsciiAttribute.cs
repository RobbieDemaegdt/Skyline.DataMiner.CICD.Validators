namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Commands.Command.CheckAsciiAttribute
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
        public static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string commandId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckAsciiAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "10.4.1",
                Category = Category.Command,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "ascii", "Command", commandId),
                HowToFix = "",
                ExampleCode = "",
                Details = "This attribute allows you to specify which parameters should be sent as ASCII. Possible values:" + Environment.NewLine + " - True: all params as ascii" + Environment.NewLine + " - False: no param as ascii" + Environment.NewLine + " - Semicolon separated list of Param IDs" + Environment.NewLine + "Note that this option only makes sense when using unicode feature.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string asciiValue, string commandId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckAsciiAttribute,
                ErrorId = ErrorIds.InvalidAttribute,
                FullId = "10.4.2",
                Category = Category.Command,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'. {2} {4} '{3}'.", "ascii", asciiValue, "Command", commandId, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "This attribute allows you to specify which parameters should be sent as ASCII. Possible values:" + Environment.NewLine + " - True: all params as ascii" + Environment.NewLine + " - False: no param as ascii" + Environment.NewLine + " - Semicolon separated list of Param IDs" + Environment.NewLine + "Note that this option only makes sense when using unicode feature.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string commandId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckAsciiAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "10.4.3",
                Category = Category.Command,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "ascii", "Param", "ID", pid, "Command", "ID", commandId),
                HowToFix = "",
                ExampleCode = "",
                Details = "This attribute allows you to specify which parameters should be sent as ASCII. Possible values:" + Environment.NewLine + " - True: all params as ascii" + Environment.NewLine + " - False: no param as ascii" + Environment.NewLine + " - Semicolon separated list of Param IDs" + Environment.NewLine + "Note that this option only makes sense when using unicode feature.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint EmptyAttribute = 1;
        public const uint InvalidAttribute = 2;
        public const uint NonExistingId = 3;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckAsciiAttribute = 4;
    }
}