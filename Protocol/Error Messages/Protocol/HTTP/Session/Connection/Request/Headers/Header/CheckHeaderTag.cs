namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.HTTP.Session.Connection.Request.Headers.Header.CheckHeaderTag
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
        public static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string tagValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckHeaderTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "8.2.1",
                Category = Category.HTTP,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}'. Current value '{1}'.", "Header", tagValue),
                HowToFix = "Trim the Header tag value.",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint UntrimmedTag = 1;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckHeaderTag = 2;
    }
}