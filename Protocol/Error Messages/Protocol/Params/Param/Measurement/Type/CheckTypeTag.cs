namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Measurement.Type.CheckTypeTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        internal static IValidationResult TogglebuttonRecommended(IValidate test, IReadable referenceNode, IReadable positionNode, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTypeTag,
                ErrorId = ErrorIds.TogglebuttonRecommended,
                FullId = "2.37.1",
                Category = Category.Param,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Measurement/Type 'togglebutton' is recommended for Param with ID '{0}'.", pid),
                HowToFix = "Change measurement type to 'togglebutton'.",
                ExampleCode = "",
                Details = "When we have only two possible discreet values and it is obvious from reading one what the other one is, we should use a togglebutton.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MatrixInvalidInterpreteRawType(IValidate test, IReadable referenceNode, IReadable positionNode, string rawType, string matrixPid, bool hasCodeFix)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTypeTag,
                ErrorId = ErrorIds.MatrixInvalidInterpreteRawType,
                FullId = "2.37.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid RawType '{0}' for matrix Param '{1}'. Expected RawType 'other'.", rawType, matrixPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = hasCodeFix,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MatrixInvalidInterpreteType(IValidate test, IReadable referenceNode, IReadable positionNode, string interpreteType, string matrixPid, string expectedInterpreteType, bool hasCodeFix)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTypeTag,
                ErrorId = ErrorIds.MatrixInvalidInterpreteType,
                FullId = "2.37.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid Interprete/Type '{0}' for matrix Param '{1}'. Expected Type '{2}'.", interpreteType, matrixPid, expectedInterpreteType),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = hasCodeFix,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MatrixInvalidInterpreteLengthType(IValidate test, IReadable referenceNode, IReadable positionNode, string lengthType, string matrixPid, bool hasCodeFix)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTypeTag,
                ErrorId = ErrorIds.MatrixInvalidInterpreteLengthType,
                FullId = "2.37.4",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid LengthType '{0}' for matrix Param '{1}'. Expected LengthType 'next param'.", lengthType, matrixPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = hasCodeFix,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MatrixAlarmingDisabled(IValidate test, IReadable referenceNode, IReadable positionNode, string matrixPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTypeTag,
                ErrorId = ErrorIds.MatrixAlarmingDisabled,
                FullId = "2.37.5",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("{0} Param '{1}' should be alarmed.", "Matrix", matrixPid),
                HowToFix = "Enable alarming.",
                ExampleCode = "",
                Details = "Matrix parameters should always be alarmed.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MatrixTrendingEnabled(IValidate test, IReadable referenceNode, IReadable positionNode, string matrixPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTypeTag,
                ErrorId = ErrorIds.MatrixTrendingEnabled,
                FullId = "2.37.6",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("{0} Param '{1}' should not be trended.", "Matrix", matrixPid),
                HowToFix = "Disable trending.",
                ExampleCode = "",
                Details = "Matrix parameters should never be trended.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MatrixSetterOnWrite(IValidate test, IReadable referenceNode, IReadable positionNode, string matrixPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTypeTag,
                ErrorId = ErrorIds.MatrixSetterOnWrite,
                FullId = "2.37.7",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unsupported attribute '{0}' in {1} '{2}'. Current value '{3}'.", "setter", "Matrix", matrixPid, "true"),
                HowToFix = "Remove the setter attribute.",
                ExampleCode = "",
                Details = "Matrix write parameters should never have a setter = true.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult MatrixInvalidInterprete(IValidate test, IReadable referenceNode, IReadable positionNode, string matrixPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTypeTag,
                ErrorId = ErrorIds.MatrixInvalidInterprete,
                FullId = "2.37.8",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid Interprete for matrix Param '{0}'.", matrixPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidParamType(IValidate test, IReadable referenceNode, IReadable positionNode, string paramType, string measurementType, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTypeTag,
                ErrorId = ErrorIds.InvalidParamType,
                FullId = "2.37.9",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in '{1}' for '{2}'. {3} {4} '{5}'.", paramType, "Param/Type", measurementType, "Param", "ID", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Following kind of parameters require the Param/Type tag to be set to 'write' or 'writebit':" + Environment.NewLine + "- button" + Environment.NewLine + "- togglebutton" + Environment.NewLine + "- pagebutton",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTypeTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "2.37.10",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "Measurement/Type", "Param", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string measurementType, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTypeTag,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "2.37.11",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}'. {2} {4} '{3}'.", measurementType, "Measurement/Type", "Param", paramId, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTypeTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "2.37.12",
                Category = Category.Param,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "Measurement/Type", "Param", paramId, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint TogglebuttonRecommended = 1;
        public const uint MatrixInvalidInterpreteRawType = 2;
        public const uint MatrixInvalidInterpreteType = 3;
        public const uint MatrixInvalidInterpreteLengthType = 4;
        public const uint MatrixAlarmingDisabled = 5;
        public const uint MatrixTrendingEnabled = 6;
        public const uint MatrixSetterOnWrite = 7;
        public const uint MatrixInvalidInterprete = 8;
        public const uint InvalidParamType = 9;
        public const uint EmptyTag = 10;
        public const uint InvalidValue = 11;
        public const uint UntrimmedTag = 12;
    }

    public static class CheckId
    {
        public const uint CheckTypeTag = 37;
    }
}