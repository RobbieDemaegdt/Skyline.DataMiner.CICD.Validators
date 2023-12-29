namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Groups.Group.Content.CheckContentTag
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
        public static IValidationResult IncompatibleContentWithGroupType(IValidate test, IReadable referenceNode, IReadable positionNode, string groupType, string contentChildTagName, string groupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckContentTag,
                ErrorId = ErrorIds.IncompatibleContentWithGroupType,
                FullId = "4.10.1",
                Category = Category.Group,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Incompatible 'Group/Content' child '{1}' with 'Group/Type' '{0}'. Group ID '{2}'.", groupType, contentChildTagName, groupId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Depending on the Group/Type, the Group/Content can only contain certain tags:" + Environment.NewLine + "- 'poll': Can contain multiple instances of one of the below tags but not a mix of them:" + Environment.NewLine + "    - 'Param'" + Environment.NewLine + "    - 'Pair'" + Environment.NewLine + "    - 'Session'" + Environment.NewLine + "- 'action' / 'poll action': Can only contain Action tags." + Environment.NewLine + "- 'trigger' / 'poll trigger': Can only contain Trigger tags.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult MixedTypes(IValidate test, IReadable referenceNode, IReadable positionNode, string contentTypes, string groupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckContentTag,
                ErrorId = ErrorIds.MixedTypes,
                FullId = "4.10.2",
                Category = Category.Group,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unsupported mixed group content '{0}'. Group ID '{1}'.", contentTypes, groupId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Depending on the Group/Type, the Group/Content can only contain certain tags:" + Environment.NewLine + "- 'poll': Can contain multiple instances of one of the below tags but not a mix of them:" + Environment.NewLine + "    - 'Param'" + Environment.NewLine + "    - 'Pair'" + Environment.NewLine + "    - 'Session'" + Environment.NewLine + "- 'action' / 'poll action': Can only contain Action tags." + Environment.NewLine + "- 'trigger' / 'poll trigger': Can only contain Trigger tags.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult MaxItemsMultipleGet(IValidate test, IReadable referenceNode, IReadable positionNode, string groupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckContentTag,
                ErrorId = ErrorIds.MaxItemsMultipleGet,
                FullId = "4.10.3",
                Category = Category.Group,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Group with 'multipleGet' true contains more than 20 content elements. Group ID '{0}'.", groupId),
                HowToFix = "",
                ExampleCode = "",
                Details = "When 'Content@multipleGet' is set to true. It recommended to limit the Group/Content to a max of 20 Param tags.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult MaxItems(IValidate test, IReadable referenceNode, IReadable positionNode, string groupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckContentTag,
                ErrorId = ErrorIds.MaxItems,
                FullId = "4.10.4",
                Category = Category.Group,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Group contains more than 10 content elements. Group ID '{0}'.", groupId),
                HowToFix = "",
                ExampleCode = "",
                Details = "It is recommended to limit the Group/Content to a max of 10 tags.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult MissingTag(IValidate test, IReadable referenceNode, IReadable positionNode, string groupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckContentTag,
                ErrorId = ErrorIds.MissingTag,
                FullId = "4.10.5",
                Category = Category.Group,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing tag '{0}' in {1} '{2}'.", "Content", "Group", groupId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Typically, a non-empty 'Group/Content' is mandatory on groups except for the following exceptional cases where the Content tag should be ommitted:" + Environment.NewLine + "- Multi-threaded groups" + Environment.NewLine + "- When the protocol doesn't have any group at all. In that case, it is needed to add a Group without any content.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint IncompatibleContentWithGroupType = 1;
        public const uint MixedTypes = 2;
        public const uint MaxItemsMultipleGet = 3;
        public const uint MaxItems = 4;
        public const uint MissingTag = 5;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckContentTag = 10;
    }
}