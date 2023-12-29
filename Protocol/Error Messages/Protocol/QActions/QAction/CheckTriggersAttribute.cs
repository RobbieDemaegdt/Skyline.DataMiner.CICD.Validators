namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.QActions.QAction.CheckTriggersAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        internal static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTriggersAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "3.2.1",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}' in {1} '{2}'.", "triggers", "QAction", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "QActions should always have the QAction@triggers defined. It should contain a 'semi-colon' separated list of parameter IDs." + Environment.NewLine + "Exceptions are to be made in following cases:" + Environment.NewLine + " - Precompiled QActions: no triggers attribute required." + Environment.NewLine + " - QActions triggered by multi-threaded timers: no triggers attribute required." + Environment.NewLine + " - QAction using the options=\"group\": triggers required but refers to Groups instead of Params.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTriggersAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "3.2.2",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "triggers", "QAction", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "QActions should always have the QAction@triggers defined. It should contain a 'semi-colon' separated list of parameter IDs." + Environment.NewLine + "Exceptions are to be made in following cases:" + Environment.NewLine + " - Precompiled QActions: no triggers attribute required." + Environment.NewLine + " - QActions triggered by multi-threaded timers: no triggers attribute required." + Environment.NewLine + " - QAction using the options=\"group\": triggers required but refers to Groups instead of Params.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string triggersValue, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTriggersAttribute,
                ErrorId = ErrorIds.InvalidAttribute,
                FullId = "3.2.3",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'. {2} {4} '{3}'.", "triggers", triggersValue, "QAction", qactionId, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "QActions should always have the QAction@triggers defined. It should contain a 'semi-colon' separated list of parameter IDs." + Environment.NewLine + "Exceptions are to be made in following cases:" + Environment.NewLine + " - Precompiled QActions: no triggers attribute required." + Environment.NewLine + " - QActions triggered by multi-threaded timers: no triggers attribute required." + Environment.NewLine + " - QAction using the options=\"group\": triggers required but refers to Groups instead of Params.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingParam(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTriggersAttribute,
                ErrorId = ErrorIds.NonExistingParam,
                FullId = "3.2.4",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "triggers", "Param", "ID", pid, "QAction", "ID", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "QActions should always have the QAction@triggers defined. It should contain a 'semi-colon' separated list of parameter IDs." + Environment.NewLine + "Exceptions are to be made in following cases:" + Environment.NewLine + " - Precompiled QActions: no triggers attribute required." + Environment.NewLine + " - QActions triggered by multi-threaded timers: no triggers attribute required." + Environment.NewLine + " - QAction using the options=\"group\": triggers required but refers to Groups instead of Params.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingGroup(IValidate test, IReadable referenceNode, IReadable positionNode, string triggerId, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTriggersAttribute,
                ErrorId = ErrorIds.NonExistingGroup,
                FullId = "3.2.5",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "triggers", "Group", "ID", triggerId, "QAction", "ID", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "QActions should always have the QAction@triggers defined. It should contain a 'semi-colon' separated list of parameter IDs." + Environment.NewLine + "Exceptions are to be made in following cases:" + Environment.NewLine + " - Precompiled QActions: no triggers attribute required." + Environment.NewLine + " - QActions triggered by multi-threaded timers: no triggers attribute required." + Environment.NewLine + " - QAction using the options=\"group\": triggers required but refers to Groups instead of Params.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult DuplicateId(IValidate test, IReadable referenceNode, IReadable positionNode, string duplicateId, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTriggersAttribute,
                ErrorId = ErrorIds.DuplicateId,
                FullId = "3.2.6",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicate value '{0}' in attribute '{1}'. {2} {3} '{4}'.", duplicateId, "QAction@triggers", "QAction", "ID", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "QActions should always have the QAction@triggers defined. It should contain a 'semi-colon' separated list of parameter IDs." + Environment.NewLine + "Exceptions are to be made in following cases:" + Environment.NewLine + " - Precompiled QActions: no triggers attribute required." + Environment.NewLine + " - QActions triggered by multi-threaded timers: no triggers attribute required." + Environment.NewLine + " - QAction using the options=\"group\": triggers required but refers to Groups instead of Params.",
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
        public const uint InvalidAttribute = 3;
        public const uint NonExistingParam = 4;
        public const uint NonExistingGroup = 5;
        public const uint DuplicateId = 6;
    }

    public static class CheckId
    {
        public const uint CheckTriggersAttribute = 2;
    }
}