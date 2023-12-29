namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.ParameterGroups.Group.CheckGroupTag
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
        public static IValidationResult IncompatibleParamReferences(IValidate test, IReadable referenceNode, IReadable positionNode, string parameterGroupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckGroupTag,
                ErrorId = ErrorIds.IncompatibleParamReferences,
                FullId = "16.5.3",
                Category = Category.ParameterGroup,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Incompatible links to parameters via 'Group@dynamicId' attribute and 'Group/Params' element. ParameterGroup ID '{0}'.", parameterGroupId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Different type of DCF interfaces can be created:" + Environment.NewLine + "  - Standalone interface: without 'Group@dynamicId' attribute" + Environment.NewLine + "      - Without alarm linking: without 'Group/Params' element" + Environment.NewLine + "      - With alarm linking: with 'Group/Params/Param' element(s)" + Environment.NewLine + "  - Dynamic interfaces: with 'Group@dynamicId' and 'Group@dynamicIndex' attributes.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorCompare
    {
        public static IValidationResult DcfParameterGroupRemoved(IReadable referenceNode, IReadable positionNode, string groupId)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckGroupTag,
                ErrorId = ErrorIds.DcfParameterGroupRemoved,
                FullId = "16.5.1",
                Category = Category.ParameterGroup,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("ParameterGroup '{0}' was removed.", groupId),
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
        public const uint DcfParameterGroupRemoved = 1;
        public const uint IncompatibleParamReferences = 3;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckGroupTag = 5;
    }
}