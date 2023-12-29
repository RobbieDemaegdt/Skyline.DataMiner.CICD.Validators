namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.ArrayOptions.ColumnOption.CheckOptionsAttribute
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
        public static IValidationResult ViewInvalidSyntax(IValidate test, IReadable referenceNode, IReadable positionNode, string columnIdx, string viewTablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.ViewInvalidSyntax,
                FullId = "2.38.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid syntax on view option of column with IDX '{0}'. View table '{1}'.", columnIdx, viewTablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ViewInvalidColumnReference(IValidate test, IReadable referenceNode, IReadable positionNode, Severity severity, string viewOption, string viewTablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.ViewInvalidColumnReference,
                FullId = "2.38.2",
                Category = Category.Param,
                Severity = severity,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Column view option '{0}' must refer to an existing column of another table. View table PID '{1}'.", viewOption, viewTablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ViewInvalidCombinationFilterChange(IValidate test, IReadable referenceNode, IReadable positionNode, string viewTablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.ViewInvalidCombinationFilterChange,
                FullId = "2.38.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid combination of view table filterChange option with column view option. View table PID '{0}'.", viewTablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "When the filterChange option is used on a view table, its columns can't have the view option.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ForeignKeyMissingRelation(IValidate test, IReadable referenceNode, IReadable positionNode, string fkToTablePid, string fkFromTablePid, string fkColumnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.ForeignKeyMissingRelation,
                FullId = "2.38.4",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing Relation between table '{0}' and table '{1}' due to foreignKey on column '{2}'.", fkToTablePid, fkFromTablePid, fkColumnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Tables directly linked via a foreignKey should always be adjacent in, at least one relation path.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ColumnOptionExpectingRTDisplay(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid, string option, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.ColumnOptionExpectingRTDisplay,
                FullId = "2.38.5",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on column Param '{0}' due to '{1}' in 'ColumnOption@options' attribute. Table PID '{2}'.", columnPid, option, tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Many options from the 'ColumnOption@options' attribute only make sense if the related column is exported or has RTDisplay tag set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ForeignKeyTargetExpectingRTDisplayOnPK(IValidate test, IReadable referenceNode, IReadable positionNode, string pkColumnPid, string foreignKeyOption, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.ForeignKeyTargetExpectingRTDisplayOnPK,
                FullId = "2.38.6",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on PK column Param '{0}' due to '{1}' in 'ColumnOption@options' attribute. Table PID '{2}'.", pkColumnPid, foreignKeyOption, tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "When a table contains a FK to another table. That other table requires its PK column to have its RTDisplay tag set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ForeignKeyColumnInvalidInterpreteType(IValidate test, IReadable referenceNode, IReadable positionNode, string columnIntrepeteType, string fkColumnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.ForeignKeyColumnInvalidInterpreteType,
                FullId = "2.38.7",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}' for {2}. Possible values '{3}'. {4} {5} '{6}'.", columnIntrepeteType, "Interprete/Type", "foreign key column", "string", "FK column", "PID", fkColumnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "A column used as foreign key to a table should be of Interprete/Type 'string'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ForeignKeyColumnInvalidMeasurementType(IValidate test, IReadable referenceNode, IReadable positionNode, string columnMeasurementType, string fkColumnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.ForeignKeyColumnInvalidMeasurementType,
                FullId = "2.38.8",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}' for {2}. Possible values '{3}'. {4} {5} '{6}'.", columnMeasurementType, "Measurement/Type", "foreign key column", "string, number", "FK column", "PID", fkColumnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "A column used as foreign key to a table should be of Measurement/Type 'string' or 'number'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ForeignKeyColumnInvalidType(IValidate test, IReadable referenceNode, IReadable positionNode, string columnType, string fkColumnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.ForeignKeyColumnInvalidType,
                FullId = "2.38.9",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}' for {2}. Possible values '{3}'. {4} {5} '{6}'.", columnType, "Param/Type", "foreign key column", "read", "FK column", "PID", fkColumnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "A column used as foreign key to a table should be of Param/Type 'read'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint ViewInvalidSyntax = 1;
        public const uint ViewInvalidColumnReference = 2;
        public const uint ViewInvalidCombinationFilterChange = 3;
        public const uint ForeignKeyMissingRelation = 4;
        public const uint ColumnOptionExpectingRTDisplay = 5;
        public const uint ForeignKeyTargetExpectingRTDisplayOnPK = 6;
        public const uint ForeignKeyColumnInvalidInterpreteType = 7;
        public const uint ForeignKeyColumnInvalidMeasurementType = 8;
        public const uint ForeignKeyColumnInvalidType = 9;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckOptionsAttribute = 38;
    }
}