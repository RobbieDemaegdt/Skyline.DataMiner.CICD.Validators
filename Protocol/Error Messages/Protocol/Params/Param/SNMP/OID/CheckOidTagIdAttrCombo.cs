namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.SNMP.OID.CheckOidTagIdAttrCombo
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
        public static IValidationResult ExcessiveAttribute(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOidTagIdAttrCombo,
                ErrorId = ErrorIds.ExcessiveAttribute,
                FullId = "2.47.1",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unsupported attribute '{0}' in {1} '{2}'.", "SNMP/OID@id", "Param", pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The SNMP/OID@id attribute needs to refer to a standalone read Param and can be used in following situations:" + Environment.NewLine + "- Subtables: the id should refer to a parameter that will allow to filter on the list of instances to be polled." + Environment.NewLine + "- Tables with filtered rows: each column should contain an id attribute that refers to a parameter that will allow to filter on the instances to be polled." + Environment.NewLine + "- Dynamic OID: the id should refer to a parameter that will allow to dynamically define the full OID." + Environment.NewLine + "Except for subtables, the id attribute only makes sense in case a wildcard is present in the OID tag value.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidCombo(IValidate test, IReadable referenceNode, IReadable positionNode, string oidValue, string idValue, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckOidTagIdAttrCombo,
                ErrorId = ErrorIds.InvalidCombo,
                FullId = "2.47.2",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid combination of OID value '{0}' and SNMP/OID@id value '{1}' in Param '{2}'.", oidValue, idValue, pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "The SNMP/OID@id attribute needs to refer to a standalone read Param and can be used in following situations:" + Environment.NewLine + "- Subtables: the id should refer to a parameter that will allow to filter on the list of instances to be polled." + Environment.NewLine + "- Tables with filtered rows: each column should contain an id attribute that refers to a parameter that will allow to filter on the instances to be polled." + Environment.NewLine + "- Dynamic OID: the id should refer to a parameter that will allow to dynamically define the full OID." + Environment.NewLine + "Except for subtables, the id attribute only makes sense in case a wildcard is present in the OID tag value.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint ExcessiveAttribute = 1;
        public const uint InvalidCombo = 2;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckOidTagIdAttrCombo = 47;
    }
}