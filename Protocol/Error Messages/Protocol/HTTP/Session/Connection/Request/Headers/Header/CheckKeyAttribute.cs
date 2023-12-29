namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.HTTP.Session.Connection.Request.Headers.Header.CheckKeyAttribute
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        internal static IValidationResult UnknownHeaderKey(IValidate test, IReadable referenceNode, IReadable positionNode, string headerKey, string sessionId, string connectionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckKeyAttribute,
                ErrorId = ErrorIds.UnknownHeaderKey,
                FullId = "8.3.1",
                Category = Category.HTTP,
                Severity = Severity.Major,
                Certainty = Certainty.Uncertain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unknown Header key '{0}' for HTTP request. Session ID '{1}'. Connection ID '{2}'.", headerKey, sessionId, connectionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The community has come to a consensus regarding a list of header keys to be used in HTTP communication." + Environment.NewLine + "The list can be found on following webpage:" + Environment.NewLine + "    https://www.iana.org/assignments/message-headers/message-headers.xhtml " + Environment.NewLine + "" + Environment.NewLine + "This 'Unknown Header Key' message can be returned by the validator in following 2 scenarios:" + Environment.NewLine + "- The data source requires the usage of such unknown header key because the Vendor simply did not adhere to the consensus -> Feel free to suppress the result." + Environment.NewLine + "- The consensus has been updated and DIS is not up to date -> Please report it to the DIS team via the DIS Feedback feature.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedHeaderKey(IValidate test, IReadable referenceNode, IReadable positionNode, string headerKey, string sessionId, string connectionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckKeyAttribute,
                ErrorId = ErrorIds.UntrimmedHeaderKey,
                FullId = "8.3.2",
                Category = Category.HTTP,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed Header key '{0}' for HTTP request. Session ID '{1}'. Connection ID '{2}'.", headerKey, sessionId, connectionId),
                HowToFix = "Trim the key attribute value.",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MissingKeyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string sessionId, string connectionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckKeyAttribute,
                ErrorId = ErrorIds.MissingKeyAttribute,
                FullId = "8.3.3",
                Category = Category.HTTP,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing key attribute. Session ID '{0}'. Connection ID '{1}'.", sessionId, connectionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyKeyAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string sessionId, string connectionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckKeyAttribute,
                ErrorId = ErrorIds.EmptyKeyAttribute,
                FullId = "8.3.4",
                Category = Category.HTTP,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty key attribute. Session ID '{0}'. Connection ID '{1}'.", sessionId, connectionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidHeaderKeyForVerb(IValidate test, IReadable referenceNode, IReadable positionNode, string headerKey, string verb, string sessionId, string connectionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckKeyAttribute,
                ErrorId = ErrorIds.InvalidHeaderKeyForVerb,
                FullId = "8.3.5",
                Category = Category.HTTP,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid Header key '{0}' for HTTP '{1}' request. Session ID '{2}'. Connection ID '{3}'.", headerKey, verb, sessionId, connectionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult RedundantHeaderKey(IValidate test, IReadable referenceNode, IReadable positionNode, string headerKey, string sessionId, string connectionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckKeyAttribute,
                ErrorId = ErrorIds.RedundantHeaderKey,
                FullId = "8.3.6",
                Category = Category.HTTP,
                Severity = Severity.Warning,
                Certainty = Certainty.Uncertain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Header key '{0}' is typically managed automatically by DataMiner. Session ID '{1}'. Connection ID '{2}'.", headerKey, sessionId, connectionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "By default, DataMiner will add a header with key 'User-Agent' and value 'DataMiner'." + Environment.NewLine + "Therefore, specifying it in the driver is redundant unless you want/need a more specific value to be used.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UnsupportedHeaderKey(IValidate test, IReadable referenceNode, IReadable positionNode, Certainty certainty, string headerKey, string sessionId, string connectionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckKeyAttribute,
                ErrorId = ErrorIds.UnsupportedHeaderKey,
                FullId = "8.3.7",
                Category = Category.HTTP,
                Severity = Severity.Major,
                Certainty = certainty,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unsupported Header key '{0}'. Session ID '{1}'. Connection ID '{2}'.", headerKey, sessionId, connectionId),
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
        public const uint UnknownHeaderKey = 1;
        public const uint UntrimmedHeaderKey = 2;
        public const uint MissingKeyAttribute = 3;
        public const uint EmptyKeyAttribute = 4;
        public const uint InvalidHeaderKeyForVerb = 5;
        public const uint RedundantHeaderKey = 6;
        public const uint UnsupportedHeaderKey = 7;
    }

    public static class CheckId
    {
        public const uint CheckKeyAttribute = 3;
    }
}