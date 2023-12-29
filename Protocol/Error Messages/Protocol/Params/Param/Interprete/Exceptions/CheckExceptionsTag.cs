namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Interprete.Exceptions.CheckExceptionsTag
{
    using System;
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;


    internal static class ErrorCompare
    {
        public static IValidationResult UpdatedExceptionValueTag(IReadable referenceNode, IReadable positionNode, string exceptionId, string paramPid, string previousExceptionValue, string newExceptionValue)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckExceptionsTag,
                ErrorId = ErrorIds.UpdatedExceptionValueTag,
                FullId = "2.36.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Exception value tag for exception with id '{0}' on Param '{1}' was changed from '{2}' to '{3}'.", exceptionId, paramPid, previousExceptionValue, newExceptionValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "Updating the exceptions value tag will have impact on existing alarm templates as an exception value is preceded by a '$' sign in the alarm template.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult RemovedException(IReadable referenceNode, IReadable positionNode, string exceptionId, string paramPid)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckExceptionsTag,
                ErrorId = ErrorIds.RemovedException,
                FullId = "2.36.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Exception with id '{0}' was removed from Param '{1}'.", exceptionId, paramPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Removing an exception value will have impact on existing alarm templates as an exception value is preceded by a '$' sign in the alarm template.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult AddedException(IReadable referenceNode, IReadable positionNode, string exceptionId, string paramPid)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckExceptionsTag,
                ErrorId = ErrorIds.AddedException,
                FullId = "2.36.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Exception with id '{0}' was added to Param '{1}'.", exceptionId, paramPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Adding an exception will have impact on existing alarm templates as an exception value is preceded by a '$' sign in the alarm template.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint UpdatedExceptionValueTag = 1;
        public const uint RemovedException = 2;
        public const uint AddedException = 3;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckExceptionsTag = 36;
    }
}