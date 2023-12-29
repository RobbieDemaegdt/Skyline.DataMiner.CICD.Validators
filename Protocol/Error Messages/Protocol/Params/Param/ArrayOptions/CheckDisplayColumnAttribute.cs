namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.ArrayOptions.CheckDisplayColumnAttribute
{
    using System;
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;


    internal static class ErrorCompare
    {
        public static IValidationResult DisplayColumnRemoved(IReadable referenceNode, IReadable positionNode, string columnIdx, string tableId)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckDisplayColumnAttribute,
                ErrorId = ErrorIds.DisplayColumnRemoved,
                FullId = "2.16.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("DisplayColumn attribute with column idx '{0}' on table '{1}' was removed.", columnIdx, tableId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DisplayColumnAdded(IReadable referenceNode, IReadable positionNode, string columnIdx, string tableId)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckDisplayColumnAttribute,
                ErrorId = ErrorIds.DisplayColumnAdded,
                FullId = "2.16.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("DisplayColumn attribute with column idx '{0}' on table '{1}' was added.", columnIdx, tableId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DisplayColumnContentChanged(IReadable referenceNode, IReadable positionNode, string previousColumnIdx, string tableId, string newColumnIdx)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckDisplayColumnAttribute,
                ErrorId = ErrorIds.DisplayColumnContentChanged,
                FullId = "2.16.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("DisplayColumn attribute with column idx '{0}' on table '{1}' was changed to idx '{2}'.", previousColumnIdx, tableId, newColumnIdx),
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
        public const uint DisplayColumnRemoved = 1;
        public const uint DisplayColumnAdded = 2;
        public const uint DisplayColumnContentChanged = 3;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckDisplayColumnAttribute = 16;
    }
}