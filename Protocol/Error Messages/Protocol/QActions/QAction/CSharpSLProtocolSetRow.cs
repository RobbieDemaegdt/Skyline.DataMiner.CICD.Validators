namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.QActions.QAction.CSharpSLProtocolSetRow
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
        public static IValidationResult NonExistingParam(IValidate test, IReadable referenceNode, IReadable positionNode, string tablePid, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpSLProtocolSetRow,
                ErrorId = ErrorIds.NonExistingParam,
                FullId = "3.8.1",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}' references a non-existing '{1}' with {2} '{3}'. QAction ID '{4}'.", "SLProtocol.SetRow", "table", "PID", tablePid, qactionId),
                HowToFix = "",
                ExampleCode = "protocol.SetRow(Parameter.TableName.tablePid, key, row);",
                Details = "SLProtocol.SetRow is used to update the values of a table row." + Environment.NewLine + "Make sure to provide it with an ID of a table parameter that exists." + Environment.NewLine + "Using Parameter class is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult HardCodedPid(IValidate test, IReadable referenceNode, IReadable positionNode, string hardCodedTablePid, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpSLProtocolSetRow,
                ErrorId = ErrorIds.HardCodedPid,
                FullId = "3.8.2",
                Category = Category.QAction,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unrecommended use of magic number '{0}', use '{1}' {2} instead. QAction ID '{3}'.", hardCodedTablePid, "Parameter", "class", qactionId),
                HowToFix = "",
                ExampleCode = "protocol.SetRow(Parameter.TableName.tablePid, key, row);",
                Details = "SLProtocol.SetRow is used to update the values of a table row." + Environment.NewLine + "Make sure to provide it with an ID of a table parameter that exists." + Environment.NewLine + "Using Parameter class is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ParamMissingHistorySet(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpSLProtocolSetRow,
                ErrorId = ErrorIds.ParamMissingHistorySet,
                FullId = "3.8.3",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("{0} overload with '{1}' argument requires '{2}'. {3} {4} '{5}'.", "SLProtocol.SetRow", "ValueType timeInfo", "Param@historySet=true", "column", "PID", columnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Every overload of the 'SLProtocol.SetRow' method having the 'ValueType timeInfo' argument is meant to execute a historySet." + Environment.NewLine + "Such method requires the columns of table to be set to have the 'Param@historySet' attribute set to 'true'.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint NonExistingParam = 1;
        public const uint HardCodedPid = 2;
        public const uint ParamMissingHistorySet = 3;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CSharpSLProtocolSetRow = 8;
    }
}