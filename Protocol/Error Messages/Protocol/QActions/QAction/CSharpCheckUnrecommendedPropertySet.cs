namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.QActions.QAction.CSharpCheckUnrecommendedPropertySet
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
        public static IValidationResult UnrecommendedCultureInfoDefaultThreadCurrentCulture(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedPropertySet,
                ErrorId = ErrorIds.UnrecommendedCultureInfoDefaultThreadCurrentCulture,
                FullId = "3.37.1",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Setting property '{0}.{1}' is unrecommended. QAction ID '{2}'.", "CultureInfo", "DefaultThreadCurrentCulture", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Changing application domain settings should not be performed as QActions from other connectors might be impacted by this change.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedThreadCurrentThreadCurrentCulture(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedPropertySet,
                ErrorId = ErrorIds.UnrecommendedThreadCurrentThreadCurrentCulture,
                FullId = "3.37.2",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Setting property '{0}.{1}' is unrecommended. QAction ID '{2}'.", "Thread.CurrentThread", "CurrentCulture", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "As the threads that execute QAction code are part of a thread pool, changing a setting on a thread in a QAction can affect other QActions of other connectors.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedThreadCurrentThreadCurrentUICulture(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedPropertySet,
                ErrorId = ErrorIds.UnrecommendedThreadCurrentThreadCurrentUICulture,
                FullId = "3.37.3",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Setting property '{0}.{1}' is unrecommended. QAction ID '{2}'.", "Thread.CurrentThread", "CurrentUICulture", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "As the threads that execute QAction code are part of a thread pool, changing a setting on a thread in a QAction can affect other QActions of other connectors.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint UnrecommendedCultureInfoDefaultThreadCurrentCulture = 1;
        public const uint UnrecommendedThreadCurrentThreadCurrentCulture = 2;
        public const uint UnrecommendedThreadCurrentThreadCurrentUICulture = 3;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CSharpCheckUnrecommendedPropertySet = 37;
    }
}