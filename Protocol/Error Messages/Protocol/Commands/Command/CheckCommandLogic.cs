namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Commands.Command.CheckCommandLogic
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;


    internal static class Error
    {
        internal static IValidationResult MissingCrcCommandAction(IValidate test, IReadable referenceNode, IReadable positionNode, string commandId, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckCommandLogic,
                ErrorId = ErrorIds.MissingCrcCommandAction,
                FullId = "10.1.1",
                Category = Category.Command,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("No '{0}' Action triggered before Command '{1}'. '{0}' Param '{2}'.", "CRC", commandId, pid),
                HowToFix = "Make sure a CRC action is triggered before command.",
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
        public const uint MissingCrcCommandAction = 1;
    }

    public static class CheckId
    {
        public const uint CheckCommandLogic = 1;
    }
}