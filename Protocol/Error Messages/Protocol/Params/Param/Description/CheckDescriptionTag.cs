// <auto-generated>This is auto-generated code by Validator Management Tool. Do not modify.</auto-generated>
namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Description.CheckDescriptionTag
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
        public static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDescriptionTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "2.14.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "Description", "Param", pid, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult MissingTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDescriptionTag,
                ErrorId = ErrorIds.MissingTag,
                FullId = "2.14.4",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing tag '{0}' in {1} '{2}'.", "Description", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDescriptionTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "2.14.5",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "Description", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DuplicatedValue(IValidate test, IReadable referenceNode, IReadable positionNode, string duplicateDescription, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDescriptionTag,
                ErrorId = ErrorIds.DuplicatedValue,
                FullId = "2.14.6",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicated {0} {1} '{2}'. {0} IDs '{3}'.", "Param", "Description", duplicateDescription, paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult WrongCasing_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string currentValue, string expectedValue, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDescriptionTag,
                ErrorId = ErrorIds.WrongCasing_Sub,
                FullId = "2.14.7",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Current value '{0}'. Expected value '{1}'. {2} {3} '{4}'.", currentValue, expectedValue, "Param", "ID", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Param/Description values should follow following title case rules:" + Environment.NewLine + "- Should start with a capital" + Environment.NewLine + "    - First and last word" + Environment.NewLine + "    - Important words (verbs, nouns, adjective, adverb, etc)" + Environment.NewLine + "- Should not start with a capital" + Environment.NewLine + "    - Articles (a, an, the)" + Environment.NewLine + "    - Coordinating conjuctions (and, but, for, nor, or, so, yet)" + Environment.NewLine + "    - Preposition with <4 chars (at, by, to...)",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult WrongCasing(IValidate test, IReadable referenceNode, IReadable positionNode)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDescriptionTag,
                ErrorId = ErrorIds.WrongCasing,
                FullId = "2.14.8",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("'{0}' values do not follow {1} rules.", "Param/Description", "title casing"),
                HowToFix = "",
                ExampleCode = "",
                Details = "Param/Description values should follow following title case rules:" + Environment.NewLine + "- Should start with a capital" + Environment.NewLine + "    - First and last word" + Environment.NewLine + "    - Important words (verbs, nouns, adjective, adverb, etc)" + Environment.NewLine + "- Should not start with a capital" + Environment.NewLine + "    - Articles (a, an, the)" + Environment.NewLine + "    - Coordinating conjuctions (and, but, for, nor, or, so, yet)" + Environment.NewLine + "    - Preposition with <4 chars (at, by, to...)",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorCompare
    {
        public static IValidationResult UpdatedValue(IReadable referenceNode, IReadable positionNode, string paramId, string previousDescription, string newDescription)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckDescriptionTag,
                ErrorId = ErrorIds.UpdatedValue,
                FullId = "2.14.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Description tag on Param '{0}' was changed from '{1}' into '{2}'.", paramId, previousDescription, newDescription),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult RemovedItem(IReadable referenceNode, IReadable positionNode, string descriptionValue, string paramId)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckDescriptionTag,
                ErrorId = ErrorIds.RemovedItem,
                FullId = "2.14.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Description tag with value '{0}' on Param '{1}' was removed.", descriptionValue, paramId),
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
        public const uint UpdatedValue = 1;
        public const uint RemovedItem = 2;
        public const uint UntrimmedTag = 3;
        public const uint MissingTag = 4;
        public const uint EmptyTag = 5;
        public const uint DuplicatedValue = 6;
        public const uint WrongCasing_Sub = 7;
        public const uint WrongCasing = 8;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckDescriptionTag = 14;
    }
}