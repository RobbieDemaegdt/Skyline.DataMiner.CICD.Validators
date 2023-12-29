namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.HTTP.Session.Connection.Request.Headers.Header.CheckPidAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        internal static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string sessionId, string connectionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPidAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "8.11.1",
                Category = Category.HTTP,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'. {7} {8} '{9}'.", "Request/Headers/Header@pid", "Param", "ID", pid, "HTTP Session", "ID", sessionId, "Connection", "ID", connectionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Use this attribute to specify the id of an existing parameter containing the value for this request header.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string sessionId, string connectionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPidAttribute,
                ErrorId = ErrorIds.EmptyAttribute,
                FullId = "8.11.2",
                Category = Category.HTTP,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty attribute '{0}' in {1} '{2}'. {3} {4} '{5}'.", "Request/Headers/Header@pid", "HTTP Session", sessionId, "Connection", "ID", connectionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Use this attribute to specify the id of an existing parameter containing the value for this request header.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string pidValue, string httpSessionId, string connectionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckPidAttribute,
                ErrorId = ErrorIds.InvalidAttribute,
                FullId = "8.11.3",
                Category = Category.HTTP,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in attribute '{0}'. {2} {4} '{3}'. {5} {7} '{6}'.", "Request/Headers/Header@pid", pidValue, "HTTP Session", httpSessionId, "ID", "Connection", connectionId, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "Use this attribute to specify the id of an existing parameter containing the value for this request header.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint NonExistingId = 1;
        public const uint EmptyAttribute = 2;
        public const uint InvalidAttribute = 3;
    }

    public static class CheckId
    {
        public const uint CheckPidAttribute = 11;
    }
}