namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Type.CheckDatabaseOptionsAttribute
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
        public static IValidationResult EnabledPartitionedTrending(IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckDatabaseOptionsAttribute,
                ErrorId = ErrorIds.EnabledPartitionedTrending,
                FullId = "1.17.1",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = "Partitioned trending was enabled on protocol.",
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
        public const uint EnabledPartitionedTrending = 1;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckDatabaseOptionsAttribute = 17;
    }
}