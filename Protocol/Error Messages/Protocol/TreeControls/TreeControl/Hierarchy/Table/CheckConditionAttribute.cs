namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.TreeControls.TreeControl.Hierarchy.Table.CheckConditionAttribute
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
        public static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConditionAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "18.5.1",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "Table@condition", "TreeControl", treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Hierarchy/Table@condition attribute should have one of the following format:" + Environment.NewLine + "- {conditionColumnPid}:{conditionValue}" + Environment.NewLine + "- {conditionColumnPid}:{conditionValue};filter:fk={fkColumnPid}" + Environment.NewLine + "where:" + Environment.NewLine + "- {conditionColumnPid} refers to a column which should have its RTDisplay set to true." + Environment.NewLine + "- {conditionValue} allows to specify the value to be present in column referred by {conditionColumnPid} for the condition to match.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedColumnPid(IValidate test, IReadable referenceNode, IReadable positionNode, string untrimmedColumnPid, string treeControlId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConditionAttribute,
                ErrorId = ErrorIds.UntrimmedColumnPid,
                FullId = "18.5.2",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed value '{0}' in attribute 'Table@condition' in TreeControl '{1}'.", untrimmedColumnPid, treeControlId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Hierarchy/Table@condition attribute should have one of the following format:" + Environment.NewLine + "- {conditionColumnPid}:{conditionValue}" + Environment.NewLine + "- {conditionColumnPid}:{conditionValue};filter:fk={fkColumnPid}" + Environment.NewLine + "where:" + Environment.NewLine + "- {conditionColumnPid} refers to a column which should have its RTDisplay set to true." + Environment.NewLine + "- {conditionValue} allows to specify the value to be present in column referred by {conditionColumnPid} for the condition to match.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string attributeValue, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConditionAttribute,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "18.5.3",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'. {2} {4} '{3}'.", "Table@condition", attributeValue, "TreeControl", treeControlPid, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "Hierarchy/Table@condition attribute should have one of the following format:" + Environment.NewLine + "- {conditionColumnPid}:{conditionValue}" + Environment.NewLine + "- {conditionColumnPid}:{conditionValue};filter:fk={fkColumnPid}" + Environment.NewLine + "where:" + Environment.NewLine + "- {conditionColumnPid} refers to a column which should have its RTDisplay set to true." + Environment.NewLine + "- {conditionValue} allows to specify the value to be present in column referred by {conditionColumnPid} for the condition to match.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConditionAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "18.5.4",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}@{1}' references a non-existing '{2}' with {3} '{4}'.", "Hierarchy/Table", "condition", "Column", "PID", columnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Hierarchy/Table@condition attribute should have one of the following format:" + Environment.NewLine + "- {conditionColumnPid}:{conditionValue}" + Environment.NewLine + "- {conditionColumnPid}:{conditionValue};filter:fk={fkColumnPid}" + Environment.NewLine + "where:" + Environment.NewLine + "- {conditionColumnPid} refers to a column which should have its RTDisplay set to true." + Environment.NewLine + "- {conditionValue} allows to specify the value to be present in column referred by {conditionColumnPid} for the condition to match.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidValueInAttribute_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string optionName, string treeControlId, string optionValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConditionAttribute,
                ErrorId = ErrorIds.InvalidValueInAttribute_Sub,
                FullId = "18.5.5",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid option '{0}' in attribute '{1}'. {2} {3} '{4}'. Current Value '{5}'.", optionName, "Table@condition", "TreeControl", "ID", treeControlId, optionValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Hierarchy/Table@condition attribute should have one of the following format:" + Environment.NewLine + "- {conditionColumnPid}:{conditionValue}" + Environment.NewLine + "- {conditionColumnPid}:{conditionValue};filter:fk={fkColumnPid}" + Environment.NewLine + "where:" + Environment.NewLine + "- {conditionColumnPid} refers to a column which should have its RTDisplay set to true." + Environment.NewLine + "- {conditionValue} allows to specify the value to be present in column referred by {conditionColumnPid} for the condition to match.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult MissingValueInAttribute_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string valueName, string treeControlId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConditionAttribute,
                ErrorId = ErrorIds.MissingValueInAttribute_Sub,
                FullId = "18.5.6",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing value '{0}' in attribute '{1}'. {2} {3} '{4}'.", valueName, "Table@condition", "TreeControl", "ID", treeControlId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Hierarchy/Table@condition attribute should have one of the following format:" + Environment.NewLine + "- {conditionColumnPid}:{conditionValue}" + Environment.NewLine + "- {conditionColumnPid}:{conditionValue};filter:fk={fkColumnPid}" + Environment.NewLine + "where:" + Environment.NewLine + "- {conditionColumnPid} refers to a column which should have its RTDisplay set to true." + Environment.NewLine + "- {conditionValue} allows to specify the value to be present in column referred by {conditionColumnPid} for the condition to match.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ReferencedColumnExpectingRTDisplay(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid, string treeControlPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConditionAttribute,
                ErrorId = ErrorIds.ReferencedColumnExpectingRTDisplay,
                FullId = "18.5.7",
                Category = Category.TreeControl,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on Param '{0}' referred as condition column in 'Hierarchy/Table@condition' attribute. TreeControl PID '{1}'.", columnPid, treeControlPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Hierarchy/Table@condition attribute should have one of the following format:" + Environment.NewLine + "- {conditionColumnPid}:{conditionValue}" + Environment.NewLine + "- {conditionColumnPid}:{conditionValue};filter:fk={fkColumnPid}" + Environment.NewLine + "where:" + Environment.NewLine + "- {conditionColumnPid} refers to a column which should have its RTDisplay set to true." + Environment.NewLine + "- {conditionValue} allows to specify the value to be present in column referred by {conditionColumnPid} for the condition to match.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint EmptyAttribute = 1;
        public const uint UntrimmedColumnPid = 2;
        public const uint InvalidValue = 3;
        public const uint NonExistingId = 4;
        public const uint InvalidValueInAttribute_Sub = 5;
        public const uint MissingValueInAttribute_Sub = 6;
        public const uint ReferencedColumnExpectingRTDisplay = 7;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckConditionAttribute = 5;
    }
}