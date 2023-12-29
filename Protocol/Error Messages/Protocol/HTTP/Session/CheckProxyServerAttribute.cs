namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.HTTP.Session.CheckProxyServerAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        internal static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string sessionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckProxyServerAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "8.6.1",
                Category = Category.HTTP,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "proxyServer", "Param", "ID", pid, "HTTP Session", "ID", sessionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Use this attribute to specify a hardcoded proxy server or the id of an existing parameter containing the proxy server.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint NonExistingId = 1;
    }

    public static class CheckId
    {
        public const uint CheckProxyServerAttribute = 6;
    }
}