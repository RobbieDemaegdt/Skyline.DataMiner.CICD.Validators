namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.ArrayOptions.CheckIndexAttribute
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
        public static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIndexAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "2.46.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}' in {1} '{2}'.", "index", "table", tablePid),
                HowToFix = "Add the attribute with value 0.",
                ExampleCode = "",
                Details = "The value should correspond to one of the column IDXs. '0' (corresponding to the first column) is the recommended value. The referred column should be of Interprete/Type 'string'.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIndexAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "2.46.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'.", "index", "table", tablePid),
                HowToFix = " Add the attribute with value 0.",
                ExampleCode = "",
                Details = "The value should correspond to one of the column IDXs. '0' (corresponding to the first column) is the recommended value. The referred column should be of Interprete/Type 'string'.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidAttributeValue(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid, string currentValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIndexAttribute,
                ErrorId = ErrorIds.InvalidAttributeValue,
                FullId = "2.46.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unsupported attribute '{0}' in {1} '{2}'. Current value '{3}'.", "index", "table", tablePid, currentValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "The value should correspond to one of the column IDXs. '0' (corresponding to the first column) is the recommended value. The referred column should be of Interprete/Type 'string'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NonExistingColumn(IValidate test, IReadable referenceNode, IReadable positionNode, string indexValue, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIndexAttribute,
                ErrorId = ErrorIds.NonExistingColumn,
                FullId = "2.46.4",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Reference to non-existing column with IDX '{0}' in attribute 'index'. Table ID '{1}'.", indexValue, tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The value should correspond to one of the column IDXs. '0' (corresponding to the first column) is the recommended value. The referred column should be of Interprete/Type 'string'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedValue(IValidate test, IReadable referenceNode, IReadable positionNode, string indexValue, string tablePid, string recommendedIndex)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIndexAttribute,
                ErrorId = ErrorIds.UnrecommendedValue,
                FullId = "2.46.5",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Unrecommended value '{0}' in attribute 'index'. Recommended values '{2}'. Table ID '{1}'.", indexValue, tablePid, recommendedIndex),
                HowToFix = "",
                ExampleCode = "",
                Details = "The value should correspond to one of the column IDXs. '0' (corresponding to the first column) is the recommended value. The referred column should be of Interprete/Type 'string'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid, string untrimmedIndex)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIndexAttribute,
                ErrorId = ErrorIds.UntrimmedAttribute,
                FullId = "2.46.6",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed attribute '{0}' in {1} '{2}'. Current value '{3}'.", "index", "table", tablePid, untrimmedIndex),
                HowToFix = "",
                ExampleCode = "",
                Details = "The value should correspond to one of the column IDXs. '0' (corresponding to the first column) is the recommended value. The referred column should be of Interprete/Type 'string'.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidColumnInterpreteType(IValidate test, IReadable referenceNode, IReadable positionNode, string columnIntrepeteType, string pkColumnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIndexAttribute,
                ErrorId = ErrorIds.InvalidColumnInterpreteType,
                FullId = "2.46.7",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}' for {2}. Possible values '{3}'. {4} {5} '{6}'.", columnIntrepeteType, "Interprete/Type", "primary key column", "string", "PK column", "PID", pkColumnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The column used as primary key of a table should be of Interprete/Type 'string'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidColumnMeasurementType(IValidate test, IReadable referenceNode, IReadable positionNode, string columnMeasurementType, string pkColumnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIndexAttribute,
                ErrorId = ErrorIds.InvalidColumnMeasurementType,
                FullId = "2.46.8",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}' for {2}. Possible values '{3}'. {4} {5} '{6}'.", columnMeasurementType, "Measurement/Type", "primary key column", "string, number", "PK column", "PID", pkColumnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The column used as primary key of a table should be of Mesurement/Type 'string' or 'number'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidColumnType(IValidate test, IReadable referenceNode, IReadable positionNode, string columnType, string pkColumnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIndexAttribute,
                ErrorId = ErrorIds.InvalidColumnType,
                FullId = "2.46.9",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}' for {2}. Possible values '{3}'. {4} {5} '{6}'.", columnType, "Param/Type", "primary key column", "read", "PK column", "PID", pkColumnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The column used as primary key of a table should be of Param/Type 'read'.",
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
        public const uint InvalidAttributeValue = 3;
        public const uint NonExistingColumn = 4;
        public const uint UnrecommendedValue = 5;
        public const uint UntrimmedAttribute = 6;
        public const uint InvalidColumnInterpreteType = 7;
        public const uint InvalidColumnMeasurementType = 8;
        public const uint InvalidColumnType = 9;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckIndexAttribute = 46;
    }
}