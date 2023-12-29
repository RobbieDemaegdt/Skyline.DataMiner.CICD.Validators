namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Timers.Timer.Condition.CheckConditionTag
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
        public static IValidationResult InvalidCondition(IValidate test, IReadable referenceNode, IReadable positionNode, string conditionString, string invalidityReason, string timerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConditionTag,
                ErrorId = ErrorIds.InvalidCondition,
                FullId = "7.4.1",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid condition '{0}'. Reason '{1}'. {2} {3} '{4}'.", conditionString, invalidityReason, "Timer", "ID", timerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "A 'Timer/Condition' should always contain a statement returning a boolean." + Environment.NewLine + "See DDL for more information." + Environment.NewLine + "" + Environment.NewLine + "Here are a few examples of mistakes covered by this error:" + Environment.NewLine + "- Empty condition." + Environment.NewLine + "- Malformed condition:" + Environment.NewLine + "  - The 'id:' placeholder used to retrieve a parameter value is incorrectly defined." + Environment.NewLine + "  - The number of opening & closing parenthesis is not matching." + Environment.NewLine + "  - '&&', '||' is used instead of 'AND', 'OR'." + Environment.NewLine + "- Condition that is not a boolean expression." + Environment.NewLine + "- Fully hard-coded boolean expression (No reference to any parameter value)." + Environment.NewLine + "- etc.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId, string timerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConditionTag,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "7.4.2",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Tag '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "Timer/Condition", "Param", "PID", paramId, "Timer", "ID", timerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "A 'Timer/Condition' should always contain a statement returning a boolean." + Environment.NewLine + "See DDL for more information." + Environment.NewLine + "" + Environment.NewLine + "Here are a few examples of mistakes covered by this error:" + Environment.NewLine + "- Empty condition." + Environment.NewLine + "- Malformed condition:" + Environment.NewLine + "  - The 'id:' placeholder used to retrieve a parameter value is incorrectly defined." + Environment.NewLine + "  - The number of opening & closing parenthesis is not matching." + Environment.NewLine + "  - '&&', '||' is used instead of 'AND', 'OR'." + Environment.NewLine + "- Condition that is not a boolean expression." + Environment.NewLine + "- Fully hard-coded boolean expression (No reference to any parameter value)." + Environment.NewLine + "- etc.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedCondition(IValidate test, IReadable referenceNode, IReadable positionNode, string timerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConditionTag,
                ErrorId = ErrorIds.UnrecommendedCondition,
                FullId = "7.4.3",
                Category = Category.Timer,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unrecommended condition on Timer. Timer ID '{0}'.", timerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The usage of a Condition within a Timer is unrecommended for performance reasons. See DDL for more information.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ConditionCanBeSimplified(IValidate test, IReadable referenceNode, IReadable positionNode, string conditionString, string timerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConditionTag,
                ErrorId = ErrorIds.ConditionCanBeSimplified,
                FullId = "7.4.4",
                Category = Category.Timer,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Condition '{0}' can be simplified. {1} {2} '{3}'.", conditionString, "Timer", "ID", timerId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The 'Timer/Condition' can be simplified. Some examples of when the condition can be simplified:" + Environment.NewLine + "  - The condition contains redundant parentheses." + Environment.NewLine + "  - The condition does not contain a variable and therefore can either be dropped completely (or a variable must be included).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint InvalidCondition = 1;
        public const uint NonExistingId = 2;
        public const uint UnrecommendedCondition = 3;
        public const uint ConditionCanBeSimplified = 4;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckConditionTag = 4;
    }
}