namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Interprete.Exceptions.Exception.Display.CheckDisplayTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        internal static IValidationResult UnrecommendedNADisplayValue(IValidate test, IReadable referenceNode, IReadable positionNode, string currentDisplay, string paramPid, string possibleValues)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayTag,
                ErrorId = ErrorIds.UnrecommendedNADisplayValue,
                FullId = "2.40.1",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Unrecommended use of Exception Display '{0}' on Param '{1}'. Possible values '{2}'.", currentDisplay, paramPid, possibleValues),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MissingTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayTag,
                ErrorId = ErrorIds.MissingTag,
                FullId = "2.40.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing tag '{0}' in {1} '{2}'.", "Exception/Display", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Exception tags should always contain a unique Display tag (user-friendly value) and a unique Value tag (internal value).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "2.40.3",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "Exception/Display", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Exception tags should always contain a unique Display tag (user-friendly value) and a unique Value tag (internal value).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "2.40.4",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "Exception/Display", "Param", pid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Exception tags should always contain a unique Display tag (user-friendly value) and a unique Value tag (internal value).",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult DuplicatedValue(IValidate test, IReadable referenceNode, IReadable positionNode, string duplicateValue, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayTag,
                ErrorId = ErrorIds.DuplicatedValue,
                FullId = "2.40.5",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicated {0} {1} '{2}'. {0} IDs '{3}'.", "Param", "Exception/Display", duplicateValue, paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Exception tags should always contain a unique Display tag (user-friendly value) and a unique Value tag (internal value).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult WrongCasing_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string currentValue, string expectedValue, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayTag,
                ErrorId = ErrorIds.WrongCasing_Sub,
                FullId = "2.40.6",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Current value '{0}'. Expected value '{1}'. {2} {3} '{4}'.", currentValue, expectedValue, "Param", "ID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Exception/Display values should follow following title case rules:" + Environment.NewLine + "- Should start with a capital" + Environment.NewLine + "    - First and last word" + Environment.NewLine + "    - Important words (verbs, nouns, adjective, adverb, etc)" + Environment.NewLine + "- Should not start with a capital" + Environment.NewLine + "    - Articles (a, an, the)" + Environment.NewLine + "    - Coordinating conjuctions (and, but, for, nor, or, so, yet)" + Environment.NewLine + "    - Preposition with <4 chars (at, by, to...)",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult WrongCasing(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDisplayTag,
                ErrorId = ErrorIds.WrongCasing,
                FullId = "2.40.7",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("'{0}' values do not follow {1} rules.", "Exception/Display", "title casing"),
                HowToFix = "",
                ExampleCode = "",
                Details = "Exception/Display values should follow following title case rules:" + Environment.NewLine + "- Should start with a capital" + Environment.NewLine + "    - First and last word" + Environment.NewLine + "    - Important words (verbs, nouns, adjective, adverb, etc)" + Environment.NewLine + "- Should not start with a capital" + Environment.NewLine + "    - Articles (a, an, the)" + Environment.NewLine + "    - Coordinating conjuctions (and, but, for, nor, or, so, yet)" + Environment.NewLine + "    - Preposition with <4 chars (at, by, to...)",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint UnrecommendedNADisplayValue = 1;
        public const uint MissingTag = 2;
        public const uint EmptyTag = 3;
        public const uint UntrimmedTag = 4;
        public const uint DuplicatedValue = 5;
        public const uint WrongCasing_Sub = 6;
        public const uint WrongCasing = 7;
    }

    public static class CheckId
    {
        public const uint CheckDisplayTag = 40;
    }
}