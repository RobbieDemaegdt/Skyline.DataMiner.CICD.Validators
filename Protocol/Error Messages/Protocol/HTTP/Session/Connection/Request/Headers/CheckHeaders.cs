namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.HTTP.Session.Connection.Request.Headers.CheckHeaders
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        internal static IValidationResult MissingHeaderForVerb(IValidate test, IReadable referenceNode, IReadable positionNode, string headerKey, string verb, string sessionId, string connectionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckHeaders,
                ErrorId = ErrorIds.MissingHeaderForVerb,
                FullId = "8.1.1",
                Category = Category.HTTP,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing Header '{0}' in HTTP '{1}' request. Session ID '{2}'. Connection ID '{3}'.", headerKey, verb, sessionId, connectionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult DuplicateHeaderKeys(IValidate test, IReadable referenceNode, IReadable positionNode, string headerKey, string sessionId, string connectionId, bool hasCodeFix)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckHeaders,
                ErrorId = ErrorIds.DuplicateHeaderKeys,
                FullId = "8.1.2",
                Category = Category.HTTP,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicate Header '{0}' in HTTP request. Session ID '{1}'. Connection ID '{2}'.", headerKey, sessionId, connectionId),
                HowToFix = "Merge the duplicate headers into one by providing a comma separated list of values.",
                ExampleCode = "",
                Details = "",
                HasCodeFix = hasCodeFix,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint MissingHeaderForVerb = 1;
        public const uint DuplicateHeaderKeys = 2;
    }

    public static class CheckId
    {
        public const uint CheckHeaders = 1;
    }
}