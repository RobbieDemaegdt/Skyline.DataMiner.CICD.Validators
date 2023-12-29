namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.CheckConnectionPingGroups
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
        public static IValidationResult InvalidPingGroupType(IValidate test, IReadable referenceNode, IReadable positionNode, string connectionType, string groupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConnectionPingGroups,
                ErrorId = ErrorIds.InvalidPingGroupType,
                FullId = "1.26.1",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Ping group for '{0}' connection is not a '{0}' poll group. Group ID '{1}'.", connectionType, groupId),
                HowToFix = "",
                ExampleCode = "",
                Details = "When to define a poll group:" + Environment.NewLine + "If a protocol has, at least, one group of type \"poll\" (no matter on which connection), then, the main connection should have a ping group defined in the protocol." + Environment.NewLine + "" + Environment.NewLine + "How to define a poll group:" + Environment.NewLine + "No matter the (1st) connection type, if a group with id=\"-1\" is defined, it will be the ping group." + Environment.NewLine + "Otherwise:" + Environment.NewLine + "    - SNMP: the first group defined in the XML." + Environment.NewLine + "    - (smart-)serial: " + Environment.NewLine + "        - The pair with ping attribute set to true." + Environment.NewLine + "        - If no such pair, the pair with lowest ID.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult PingSerialPairHasNoResponse(IValidate test, IReadable referenceNode, IReadable positionNode, string connectionType, string pairId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConnectionPingGroups,
                ErrorId = ErrorIds.PingSerialPairHasNoResponse,
                FullId = "1.26.2",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Ping pair for '{0}' connection contains no response. Pair ID '{1}'.", connectionType, pairId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The pair used for the ping group should always contain a response.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult MultiplePingPairsForConnection(IValidate test, IReadable referenceNode, IReadable positionNode, string connectionName, string connectionType, string connectionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConnectionPingGroups,
                ErrorId = ErrorIds.MultiplePingPairsForConnection,
                FullId = "1.26.3",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Multiple ping pairs for connection with name '{0}' and type '{1}'. Connection ID '{2}'.", connectionName, connectionType, connectionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "There should always be one and only one ping pair per (smart-)serial connection.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult MultiplePingPairsForConnection_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string connectionId, string pairId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckConnectionPingGroups,
                ErrorId = ErrorIds.MultiplePingPairsForConnection_Sub,
                FullId = "1.26.4",
                Category = Category.Protocol,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Multiple ping pairs for connection '{0}'. Pair '{1}'.", connectionId, pairId),
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
        public const uint InvalidPingGroupType = 1;
        public const uint PingSerialPairHasNoResponse = 2;
        public const uint MultiplePingPairsForConnection = 3;
        public const uint MultiplePingPairsForConnection_Sub = 4;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckConnectionPingGroups = 26;
    }
}