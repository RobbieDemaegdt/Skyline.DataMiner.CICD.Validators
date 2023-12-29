namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Type.CheckOptionsAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        internal static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "1.9.8",
                Category = Category.Protocol,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}'.", "Protocol/Type@options"),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string currentValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "1.9.9",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}'. Current value '{1}'.", "Protocol/Type@options", currentValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "1.9.11",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}@{1}' references a non-existing '{2}' with {3} '{4}'.", "Protocol/Type", "options", "Param", "ID", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Within the 'Protocol/Type@options' attribute, the 'exportProtocol' option allows to define which DVE protocols should be made and based on what parameter DVE elements should be created." + Environment.NewLine + "" + Environment.NewLine + "The exportProtocol option is expected to have the following format: \"exportProtocol:[protocolName]:[DveTablePid]\" optionally followed by \":noElementPrefix\" where:" + Environment.NewLine + "- [protocolName] should be the name of the DVE protocol to be created." + Environment.NewLine + "    - Note that we recommend the DVE protocol name to start with: \"[DveParentProtocolName] - \"" + Environment.NewLine + "- [DveTablePid] should be the PID of the table responsible for creating DVE elements. The referred Param is expected to:" + Environment.NewLine + "    - Be of type 'array'." + Environment.NewLine + "    - Have its RTDisplay tag set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ReferencedParamWrongType(IValidate test, IReadable referenceNode, IReadable positionNode, string paramType, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.ReferencedParamWrongType,
                FullId = "1.9.12",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid DVE Param Type '{0}'. Expected Type 'array'. Param ID '{1}'.", paramType, paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Within the 'Protocol/Type@options' attribute, the 'exportProtocol' option allows to define which DVE protocols should be made and based on what parameter DVE elements should be created." + Environment.NewLine + "" + Environment.NewLine + "The exportProtocol option is expected to have the following format: \"exportProtocol:[protocolName]:[DveTablePid]\" optionally followed by \":noElementPrefix\" where:" + Environment.NewLine + "- [protocolName] should be the name of the DVE protocol to be created." + Environment.NewLine + "    - Note that we recommend the DVE protocol name to start with: \"[DveParentProtocolName] - \"" + Environment.NewLine + "- [DveTablePid] should be the PID of the table responsible for creating DVE elements. The referred Param is expected to:" + Environment.NewLine + "    - Be of type 'array'." + Environment.NewLine + "    - Have its RTDisplay tag set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ReferencedParamExpectingRTDisplay(IValidate test, IReadable referenceNode, IReadable positionNode, string dveTablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.ReferencedParamExpectingRTDisplay,
                FullId = "1.9.13",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on DVE Table. Table PID '{0}'.", dveTablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Within the 'Protocol/Type@options' attribute, the 'exportProtocol' option allows to define which DVE protocols should be made and based on what parameter DVE elements should be created." + Environment.NewLine + "" + Environment.NewLine + "The exportProtocol option is expected to have the following format: \"exportProtocol:[protocolName]:[DveTablePid]\" optionally followed by \":noElementPrefix\" where:" + Environment.NewLine + "- [protocolName] should be the name of the DVE protocol to be created." + Environment.NewLine + "    - Note that we recommend the DVE protocol name to start with: \"[DveParentProtocolName] - \"" + Environment.NewLine + "- [DveTablePid] should be the PID of the table responsible for creating DVE elements. The referred Param is expected to:" + Environment.NewLine + "    - Be of type 'array'." + Environment.NewLine + "    - Have its RTDisplay tag set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorCompare
    {
        internal static IValidationResult UpdatedDveExportProtocolName(IReadable referenceNode, IReadable positionNode, string dveProtocolName, string tableId, string newDveProtocolName)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.UpdatedDveExportProtocolName,
                FullId = "1.9.2",
                Category = Category.Protocol,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("DVE Protocol with Name '{0}' for Table '{1}' was changed into '{2}'.", dveProtocolName, tableId, newDveProtocolName),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult RemovedDveExportProtocolName(IReadable referenceNode, IReadable positionNode, string dveProtocolName, string tableId)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.RemovedDveExportProtocolName,
                FullId = "1.9.3",
                Category = Category.Protocol,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("DVE Protocol with Name '{0}' for Table '{1}' was removed.", dveProtocolName, tableId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult AddedNoElementPrefix(IReadable referenceNode, IReadable positionNode, string dveProtocolName, string tableId)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.AddedNoElementPrefix,
                FullId = "1.9.4",
                Category = Category.Protocol,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("NoElementPrefix option was added to DVE Protocol with Name '{0}' for Table '{1}'.", dveProtocolName, tableId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult RemovedNoElementPrefix(IReadable referenceNode, IReadable positionNode, string dveProtocolName, string tableId)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.RemovedNoElementPrefix,
                FullId = "1.9.5",
                Category = Category.Protocol,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("NoElementPrefix option was removed from DVE Protocol with Name '{0}' for Table '{1}'.", dveProtocolName, tableId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult AddedUnicode(IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.AddedUnicode,
                FullId = "1.9.6",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = "Unicode option on protocol was added.",
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult RemovedUnicode(IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.RemovedUnicode,
                FullId = "1.9.7",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = "Unicode option on protocol was removed.",
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
        public const uint UpdatedDveExportProtocolName = 2;
        public const uint RemovedDveExportProtocolName = 3;
        public const uint AddedNoElementPrefix = 4;
        public const uint RemovedNoElementPrefix = 5;
        public const uint AddedUnicode = 6;
        public const uint RemovedUnicode = 7;
        public const uint EmptyAttribute = 8;
        public const uint UntrimmedAttribute = 9;
        public const uint NonExistingId = 11;
        public const uint ReferencedParamWrongType = 12;
        public const uint ReferencedParamExpectingRTDisplay = 13;
    }

    public static class CheckId
    {
        public const uint CheckOptionsAttribute = 9;
    }
}