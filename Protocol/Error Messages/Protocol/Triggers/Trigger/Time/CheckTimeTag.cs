namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Triggers.Trigger.Time.CheckTimeTag
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
        public static IValidationResult MultipleAfterStartup(IValidate test, IReadable referenceNode, IReadable positionNode, string triggerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTimeTag,
                ErrorId = ErrorIds.MultipleAfterStartup,
                FullId = "5.3.1",
                Category = Category.Trigger,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Multiple after startup Triggers. Trigger IDs '{0}'.", triggerId),
                HowToFix = "Multiple Trigger after Startup Triggers need to be checked and merged into one Trigger.",
                ExampleCode = "",
                Details = "When defining multiple 'after startup' triggers, we have no way to know in which order those triggers will be executed. To keep things under control, it's better to have only one 'after startup' trigger.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint MultipleAfterStartup = 1;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckTimeTag = 3;
    }
}