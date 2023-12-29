namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Name.CheckColumnNames
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
        public static IValidationResult MissingTableNameAsPrefixes(IValidate test, IReadable referenceNode, IReadable positionNode, string tableName, string tablePid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckColumnNames,
                ErrorId = ErrorIds.MissingTableNameAsPrefixes,
                FullId = "2.53.1",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing table name '{0}' in front of column names. Table PID '{1}'.", tableName, tablePid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The name of column parameters should start with the name of the table they belong to.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult MissingTableNameAsPrefix(IValidate test, IReadable referenceNode, IReadable positionNode, string tableName, string columnName, string columnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckColumnNames,
                ErrorId = ErrorIds.MissingTableNameAsPrefix,
                FullId = "2.53.2",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing table name '{0}' in front of column name '{1}'. Column PID '{2}'.", tableName, columnName, columnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The name of column parameters should start with the name of the table they belong to.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint MissingTableNameAsPrefixes = 1;
        public const uint MissingTableNameAsPrefix = 2;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckColumnNames = 53;
    }
}