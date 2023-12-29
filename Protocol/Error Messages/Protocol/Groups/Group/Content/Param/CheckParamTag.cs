namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Groups.Group.Content.Param.CheckParamTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        internal static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string groupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParamTag,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "4.2.1",
                Category = Category.Group,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Tag '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "Content/Param", "Param", "ID", pid, "Group", "ID", groupId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Group/Content tag should contain a list of 'Param', 'Pair', 'Session', 'Trigger' or 'Action' tags. Note that only one type of them is allowed for a specific Group." + Environment.NewLine + " - 'Param' tags should refer to the id of an existing Param." + Environment.NewLine + " - 'Pair' tags should refer to the id of an existing Pair." + Environment.NewLine + " - 'Session' tags should refer to the id of an existing HTTP/Session." + Environment.NewLine + " - 'Trigger' tags should refer to the id of an existing Trigger." + Environment.NewLine + " - 'Action' tags should refer to the id of an existing Action.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyParamTag(IValidate test, IReadable referenceNode, IReadable positionNode, string groupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParamTag,
                ErrorId = ErrorIds.EmptyParamTag,
                FullId = "4.2.2",
                Category = Category.Group,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "Content/Param", "Group", groupId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Group/Content tag should contain a list of 'Param', 'Pair', 'Session', 'Trigger' or 'Action' tags. Note that only one type of them is allowed for a specific Group." + Environment.NewLine + " - 'Param' tags should refer to the id of an existing Param." + Environment.NewLine + " - 'Pair' tags should refer to the id of an existing Pair." + Environment.NewLine + " - 'Session' tags should refer to the id of an existing HTTP/Session." + Environment.NewLine + " - 'Trigger' tags should refer to the id of an existing Trigger." + Environment.NewLine + " - 'Action' tags should refer to the id of an existing Action.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidParamTag(IValidate test, IReadable referenceNode, IReadable positionNode, string value, string groupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParamTag,
                ErrorId = ErrorIds.InvalidParamTag,
                FullId = "4.2.3",
                Category = Category.Group,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}'. {2} {4} '{3}'.", value, "Content/Param", "Group", groupId, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "Group/Content tag should contain a list of 'Param', 'Pair', 'Session', 'Trigger' or 'Action' tags. Note that only one type of them is allowed for a specific Group." + Environment.NewLine + " - 'Param' tags should refer to the id of an existing Param." + Environment.NewLine + " - 'Pair' tags should refer to the id of an existing Pair." + Environment.NewLine + " - 'Session' tags should refer to the id of an existing HTTP/Session." + Environment.NewLine + " - 'Trigger' tags should refer to the id of an existing Trigger." + Environment.NewLine + " - 'Action' tags should refer to the id of an existing Action.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidParamSuffix(IValidate test, IReadable referenceNode, IReadable positionNode, string suffix, string groupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParamTag,
                ErrorId = ErrorIds.InvalidParamSuffix,
                FullId = "4.2.4",
                Category = Category.Group,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid suffix '{0}' in 'Group/Content/Param' element. Group ID '{1}'.", suffix, groupId),
                HowToFix = "",
                ExampleCode = "<Param>100:tablev2</Param>",
                Details = "Within 'Group/Content/Param' element, following suffixes are allowed:" + Environment.NewLine + " - Single: If \":single\" is appended after the parameter ID, this parameter will be retrieved via a separate SNMP Get request." + Environment.NewLine + " - Instance: Indicates that this parameter holds the instance value. The following parameters in the group will use the value retrieved by this parameter as the instance." + Environment.NewLine + " - table: (Deprecated) Indicates that the requested parameter represents a table. Use tablev2 instead." + Environment.NewLine + " - tablev2: Indicates that the requested parameter represents a table." + Environment.NewLine + " - getnext: Performs a GetNext request." + Environment.NewLine + "" + Environment.NewLine + "Note that all those are meant to poll data via a multi-threaded timer so a group containing such suffixes can only be called from multi-threaded timers.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult ObsoleteSuffixTable(IValidate test, IReadable referenceNode, IReadable positionNode, string groupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParamTag,
                ErrorId = ErrorIds.ObsoleteSuffixTable,
                FullId = "4.2.5",
                Category = Category.Group,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Suffix 'table' in 'Group/Content/Param' element is considered obsolete. Group ID '{0}'.", groupId),
                HowToFix = "",
                ExampleCode = "<Param>100:tablev2</Param>",
                Details = "Suffix 'table' is used in 'Group/Content/Param' element to indicate the provided parameter represents a table to be polled." + Environment.NewLine + "This results in a number of GetNext request operations to retrieve the instances followed by a number of Get request operations to retrieve the table data column by column. This way of polling is inefficient and can some times lead to corrupted data." + Environment.NewLine + "" + Environment.NewLine + "To improve on this, the new suffix 'tablev2' should be used and will result in a number of getBulk request operations to retrieve the table data row by row." + Environment.NewLine + "" + Environment.NewLine + "Note that these suffixes can only be used if the group is called by a multi-threaded timer.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult SuffixRequiresMultiThreadedTimer(IValidate test, IReadable referenceNode, IReadable positionNode, string suffix, string groupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckParamTag,
                ErrorId = ErrorIds.SuffixRequiresMultiThreadedTimer,
                FullId = "4.2.6",
                Category = Category.Group,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Suffix '{0}' in'Group/Content/Param' element requires the group to be called from a multi-threaded timer. Group ID '{1}'.", suffix, groupId),
                HowToFix = "",
                ExampleCode = "<Param>100:tablev2</Param>",
                Details = "Within 'Group/Content/Param' element, following suffixes are allowed:" + Environment.NewLine + " - Single: If \":single\" is appended after the parameter ID, this parameter will be retrieved via a separate SNMP Get request." + Environment.NewLine + " - Instance: Indicates that this parameter holds the instance value. The following parameters in the group will use the value retrieved by this parameter as the instance." + Environment.NewLine + " - table: (Deprecated) Indicates that the requested parameter represents a table. Use tablev2 instead." + Environment.NewLine + " - tablev2: Indicates that the requested parameter represents a table." + Environment.NewLine + " - getnext: Performs a GetNext request." + Environment.NewLine + "" + Environment.NewLine + "However, all those are meant to poll data via a multi-threaded timer so a group containing such suffixes can only be called from multi-threaded timers.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint NonExistingId = 1;
        public const uint EmptyParamTag = 2;
        public const uint InvalidParamTag = 3;
        public const uint InvalidParamSuffix = 4;
        public const uint ObsoleteSuffixTable = 5;
        public const uint SuffixRequiresMultiThreadedTimer = 6;
    }

    public static class CheckId
    {
        public const uint CheckParamTag = 2;
    }
}