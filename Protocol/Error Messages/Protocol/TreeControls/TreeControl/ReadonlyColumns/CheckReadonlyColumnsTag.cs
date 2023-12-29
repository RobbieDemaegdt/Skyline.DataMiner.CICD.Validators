namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.TreeControls.TreeControl.ReadonlyColumns.CheckReadonlyColumnsTag
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
        public static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckReadonlyColumnsTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "18.13.1",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "ReadonlyColumns", "TreeControl", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/ReadonlyColumns' tag should contain a comma separated list of column PIDs for which the value edition via the TreeControl should be disabled." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckReadonlyColumnsTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "18.13.2",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "ReadonlyColumns", "TreeControl", treeControlPid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/ReadonlyColumns' tag should contain a comma separated list of column PIDs for which the value edition via the TreeControl should be disabled." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string readonlyColumnsValue, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckReadonlyColumnsTag,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "18.13.3",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}'. {2} {4} '{3}'.", readonlyColumnsValue, "ReadonlyColumns", "TreeControl", treeControlPid, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/ReadonlyColumns' tag should contain a comma separated list of column PIDs for which the value edition via the TreeControl should be disabled." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NonExistingIds(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckReadonlyColumnsTag,
                ErrorId = ErrorIds.NonExistingIds,
                FullId = "18.13.4",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Tag '{0}' references non-existing IDs. {1} {3} '{2}'.", "ReadonlyColumns", "TreeControl", treeControlPid, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/ReadonlyColumns' tag should contain a comma separated list of column PIDs for which the value edition via the TreeControl should be disabled." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NonExistingIds_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckReadonlyColumnsTag,
                ErrorId = ErrorIds.NonExistingIds_Sub,
                FullId = "18.13.5",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Tag '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "ReadonlyColumns", "Column", "PID", columnPid, "TreeControl", "ID", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/ReadonlyColumns' tag should contain a comma separated list of column PIDs for which the value edition via the TreeControl should be disabled." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DuplicateId(IValidate test, IReadable referenceNode, IReadable positionNode, string duplicateId, string treeControlId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckReadonlyColumnsTag,
                ErrorId = ErrorIds.DuplicateId,
                FullId = "18.13.6",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicate value '{0}' in tag '{1}'. {2} {3} '{4}'.", duplicateId, "ReadonlyColumns", "TreeControl", "ID", treeControlId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/ReadonlyColumns' tag should contain a comma separated list of column PIDs for which the value edition via the TreeControl should be disabled." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedValueInTag_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckReadonlyColumnsTag,
                ErrorId = ErrorIds.UntrimmedValueInTag_Sub,
                FullId = "18.13.7",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed value '{0}' in tag '{1}'.", untrimmedValue, "ReadonlyColumns"),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/ReadonlyColumns' tag should contain a comma separated list of column PIDs for which the value edition via the TreeControl should be disabled." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidValueInTag_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string invalidPart)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckReadonlyColumnsTag,
                ErrorId = ErrorIds.InvalidValueInTag_Sub,
                FullId = "18.13.8",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in tag '{0}'.", "ReadonlyColumns", invalidPart),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/ReadonlyColumns' tag should contain a comma separated list of column PIDs for which the value edition via the TreeControl should be disabled." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult IrrelevantColumn(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid, string treeControlId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckReadonlyColumnsTag,
                ErrorId = ErrorIds.IrrelevantColumn,
                FullId = "18.13.9",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Irrelevant column with PID '{0}' in 'TreeControl/ReadonlyColumns'. TreeControl ID '{1}'.", columnPid, treeControlId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'TreeControl/ReadonlyColumns' tag should contain a comma separated list of column PIDs for which the value edition via the TreeControl should be disabled." + Environment.NewLine + "The column PIDs should belong to one of the tables displayed in the TreeControl.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint EmptyTag = 1;
        public const uint UntrimmedTag = 2;
        public const uint InvalidValue = 3;
        public const uint NonExistingIds = 4;
        public const uint NonExistingIds_Sub = 5;
        public const uint DuplicateId = 6;
        public const uint UntrimmedValueInTag_Sub = 7;
        public const uint InvalidValueInTag_Sub = 8;
        public const uint IrrelevantColumn = 9;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckReadonlyColumnsTag = 13;
    }
}