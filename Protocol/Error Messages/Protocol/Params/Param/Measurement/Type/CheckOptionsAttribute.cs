namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Measurement.Type.CheckOptionsAttribute
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
        public static IValidationResult MissingPriorityForSortedColumns(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.MissingPriorityForSortedColumns,
                FullId = "2.31.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing column sorting priorities on table '{0}'.", tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "In case multiple columns are sorted, set a sorting priority for all these columns. In case at least one of the displayed columns is a datetime column, one of these columns should be set as the main column for sorting.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidConnectedMatrixPoints(IValidate test, IReadable referenceNode, IReadable positionNode, string badValue, string minOrMax, string inputOrOutput, string matrixPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.InvalidConnectedMatrixPoints,
                FullId = "2.31.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("'{0}': Invalid '{1}' number of connections for one {2} for matrix '{3}'.", badValue, minOrMax, inputOrOutput, matrixPid),
                HowToFix = "Make sure the total number of possible connections for a single input or output is not negative nor exceeds the total dimensions of the matrix.",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidColumnDimensionsToOutputCount(IValidate test, IReadable referenceNode, IReadable positionNode, string matrixPid, string measurementOutputCount, string dimensionColumnCount)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.InvalidColumnDimensionsToOutputCount,
                FullId = "2.31.4",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Matrix Param '{0}' Measurement/Type@options - matrix:outputCount of '{1}' does not match Param/Type@options - dimensions: columnCount of '{2}'.", matrixPid, measurementOutputCount, dimensionColumnCount),
                HowToFix = "Adjust Measurement to match dimensions or vice versa.",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidMatrixDimensionsToInputCount(IValidate test, IReadable referenceNode, IReadable positionNode, string matrixPid, string measurementInputCount, string dimensionRowCount)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.InvalidMatrixDimensionsToInputCount,
                FullId = "2.31.5",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Matrix Param '{0}' Measurement/Type@options - matrix:inputCount of '{1}' does not match Param/Type@options - dimensions: rowCount of '{2}'.", matrixPid, measurementInputCount, dimensionRowCount),
                HowToFix = "Adjust Measurement to match dimensions or vice versa.",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidMatrixOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionName, string matrixPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.InvalidMatrixOption,
                FullId = "2.31.6",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid syntax for the '{0}' option. Matrix PID '{1}'.", optionName, matrixPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Following options in Measurement/Type@options attribute are required for matrixes:" + Environment.NewLine + " - matrix=InputCount, OutputCount, MinConnectedInputs, MaxConnectedInputs, MinConnectedOutputs, MaxConnectedOutputs",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult MissingMatrixOption(IValidate test, IReadable referenceNode, IReadable positionNode, string optionName, string matrixPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.MissingMatrixOption,
                FullId = "2.31.7",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing '{0}' option for matrix Param. Matrix PID '{1}'.", optionName, matrixPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Following options in Measurement/Type@options attribute are required for matrixes:" + Environment.NewLine + " - matrix=InputCount, OutputCount, MinConnectedInputs, MaxConnectedInputs, MinConnectedOutputs, MaxConnectedOutputs",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult MissingAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string matrixPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.MissingAttribute,
                FullId = "2.31.8",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing attribute '{0}' in {1} '{2}'.", "Measurement/Type@Options", "Matrix", matrixPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Following options in Measurement/Type@options attribute are required for matrixes:" + Environment.NewLine + " - matrix=InputCount, OutputCount, MinConnectedInputs, MaxConnectedInputs, MinConnectedOutputs, MaxConnectedOutputs",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult MissingSortingOnDateTimeColumn(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid, string columnPids)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.MissingSortingOnDateTimeColumn,
                FullId = "2.31.9",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Uncertain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Table not mainly sorted on one of its date(time) column(s). Table PID '{0}'. Date(time) column PIDs '{1}'.", tablePid, columnPids),
                HowToFix = "",
                ExampleCode = "",
                Details = "If a table has any column of type date or datetime, one of those columns should typically be used as sorted column with sort priority 0.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ReferencedParamRTDisplayExpected(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.ReferencedParamRTDisplayExpected,
                FullId = "2.31.10",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("RTDisplay(true) expected on Param '{0}' displayed as table column. Table PID '{1}'.", columnPid, tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Columns referred by the 'Measurement/Type@options' attribute of a displayed table should have its RTDisplay tag set to true." + Environment.NewLine + "A table is considered 'displayed' if its RTDisplay tag and/or its export attribute is set to true.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorCompare
    {
        public static IValidationResult ColumnOrderChanged(IReadable referenceNode, IReadable positionNode, string oldColumnOrder, string tablePid, string newColumnOrder)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckOptionsAttribute,
                ErrorId = ErrorIds.ColumnOrderChanged,
                FullId = "2.31.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Displayed column order with PID's '{0}' in table '{1}' was changed to '{2}'.", oldColumnOrder, tablePid, newColumnOrder),
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
        public const uint ColumnOrderChanged = 1;
        public const uint MissingPriorityForSortedColumns = 2;
        public const uint InvalidConnectedMatrixPoints = 3;
        public const uint InvalidColumnDimensionsToOutputCount = 4;
        public const uint InvalidMatrixDimensionsToInputCount = 5;
        public const uint InvalidMatrixOption = 6;
        public const uint MissingMatrixOption = 7;
        public const uint MissingAttribute = 8;
        public const uint MissingSortingOnDateTimeColumn = 9;
        public const uint ReferencedParamRTDisplayExpected = 10;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckOptionsAttribute = 31;
    }
}