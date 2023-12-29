namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Actions.Action.On.CheckIdAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        internal static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string actionType, string actionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "6.3.1",
                Category = Category.Action,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}' due to '{1}' '{2}'. {3} {4} '{5}'.", "Action/On@id", "Action/Type", actionType, "Action", "ID", actionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The 'Action/On@id' attribute is mandatory if 'Action/Type' is set to one of the following values:" + Environment.NewLine + "add to execute, aggregate, append, append data, change length, clear, clear length info, clear on display, copy, copy reverse, crc, execute, execute next, execute one, execute one now, execute one top, force execute, go, increment, length, make, multiply, normalize, pow, read, read file, read stuffing, replace, replace data, reschedule, restart timer, reverse, run actions, save, set and get with wait, set next, set with wait, start, stop, stuffing, timeout.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyAttibute(IValidate test, IReadable referenceNode, IReadable positionNode, string actionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.EmptyAttibute,
                FullId = "6.3.2",
                Category = Category.Action,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "On@id", "Action", actionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The 'Action/On@id' attribute can contain a semicolon list of unsigned number which refer to the id of an existing protocol item. The type of item is specified by the inner value of the 'Action/On' tag." + Environment.NewLine + "If the 'Action/On@id' attribute is not present, the action will apply to all item of the type given by the value of the 'Action/On' tag." + Environment.NewLine + "" + Environment.NewLine + "Note that only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedValueInAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string untrimmedValue, string actionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.UntrimmedValueInAttribute,
                FullId = "6.3.3",
                Category = Category.Action,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed value '{0}' in attribute '{1}'. {2} {3} '{4}'.", untrimmedValue, "On@id", "Action", "ID", actionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The 'Action/On@id' attribute can contain a semicolon list of unsigned number which refer to the id of an existing protocol item. The type of item is specified by the inner value of the 'Action/On' tag." + Environment.NewLine + "If the 'Action/On@id' attribute is not present, the action will apply to all item of the type given by the value of the 'Action/On' tag." + Environment.NewLine + "" + Environment.NewLine + "Note that only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string attributeValue, string actionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "6.3.4",
                Category = Category.Action,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'. {2} {4} '{3}'.", "On@id", attributeValue, "Action", actionId, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "The 'Action/On@id' attribute can contain a semicolon list of unsigned number which refer to the id of an existing protocol item. The type of item is specified by the inner value of the 'Action/On' tag." + Environment.NewLine + "If the 'Action/On@id' attribute is not present, the action will apply to all item of the type given by the value of the 'Action/On' tag." + Environment.NewLine + "" + Environment.NewLine + "Note that only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string referenceKind, string referenceId, string actionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "6.3.5",
                Category = Category.Action,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "On@id", referenceKind, "ID", referenceId, "Action", "ID", actionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The 'Action/On@id' attribute can contain a semicolon list of unsigned number which refer to the id of an existing protocol item. The type of item is specified by the inner value of the 'Action/On' tag." + Environment.NewLine + "If the 'Action/On@id' attribute is not present, the action will apply to all item of the type given by the value of the 'Action/On' tag." + Environment.NewLine + "" + Environment.NewLine + "Note that only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint MissingAttribute = 1;
        public const uint EmptyAttibute = 2;
        public const uint UntrimmedValueInAttribute = 3;
        public const uint InvalidValue = 4;
        public const uint NonExistingId = 5;
    }

    public static class CheckId
    {
        public const uint CheckIdAttribute = 3;
    }
}