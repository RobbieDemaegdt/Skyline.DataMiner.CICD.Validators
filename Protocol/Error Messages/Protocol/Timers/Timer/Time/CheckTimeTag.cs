namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Timers.Timer.Time.CheckTimeTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;

    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        internal static IValidationResult MissingTag(IValidate test, IReadable referenceNode, IReadable positionNode, string timerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTimeTag,
                ErrorId = ErrorIds.MissingTag,
                FullId = "7.1.1",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing tag '{0}' in {1} '{2}'.", "Time", "Timer", timerId),
                HowToFix = "Choose a value between '1' and '2.073.600.000' (included). The max value corresponds to 24 days.",
                ExampleCode = "",
                Details = "The minimum allowed value for a Timer Time is '1'." + Environment.NewLine + "The maximum allowed value for a Timer Time tag is '2.073.600.000' which corresponds to 24 days." + Environment.NewLine + "An altenative possible value is 'loop' which will cause the timer to continuously go off." + Environment.NewLine + "" + Environment.NewLine + "Also note that, due to a software issue, a value higher than '86.400.000' which corresponds to 24 hours will cause issues on DMA version between 8.5.9.1 and 9.0 CU5.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string timerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTimeTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "7.1.2",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "Time", "Timer", timerId),
                HowToFix = "Choose a value between '1' and '2.073.600.000' (included). The max value corresponds to 24 days.",
                ExampleCode = "",
                Details = "The minimum allowed value for a Timer Time is '1'." + Environment.NewLine + "The maximum allowed value for a Timer Time tag is '2.073.600.000' which corresponds to 24 days." + Environment.NewLine + "An altenative possible value is 'loop' which will cause the timer to continuously go off." + Environment.NewLine + "" + Environment.NewLine + "Also note that, due to a software issue, a value higher than '86.400.000' which corresponds to 24 hours will cause issues on DMA version between 8.5.9.1 and 9.0 CU5.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string timerId, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTimeTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "7.1.3",
                Category = Category.Timer,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "Time", "Timer", timerId, untrimmedValue),
                HowToFix = "Choose a value between '1' and '2.073.600.000' (included). The max value corresponds to 24 days.",
                ExampleCode = "",
                Details = "The minimum allowed value for a Timer Time is '1'." + Environment.NewLine + "The maximum allowed value for a Timer Time tag is '2.073.600.000' which corresponds to 24 days." + Environment.NewLine + "An altenative possible value is 'loop' which will cause the timer to continuously go off." + Environment.NewLine + "" + Environment.NewLine + "Also note that, due to a software issue, a value higher than '86.400.000' which corresponds to 24 hours will cause issues on DMA version between 8.5.9.1 and 9.0 CU5.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult InvalidTagValue(IValidate test, IReadable referenceNode, IReadable positionNode, string tagValue, string allowedValues)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTimeTag,
                ErrorId = ErrorIds.InvalidTagValue,
                FullId = "7.1.4",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{1}' in tag '{0}'. Possible values '{2}'.", "Time", tagValue, allowedValues),
                HowToFix = "Choose a value between '1' and '2.073.600.000' (included). The max value corresponds to 24 days.",
                ExampleCode = "",
                Details = "The minimum allowed value for a Timer Time is '1'." + Environment.NewLine + "The maximum allowed value for a Timer Time tag is '2.073.600.000' which corresponds to 24 days." + Environment.NewLine + "An altenative possible value is 'loop' which will cause the timer to continuously go off." + Environment.NewLine + "" + Environment.NewLine + "Also note that, due to a software issue, a value higher than '86.400.000' which corresponds to 24 hours will cause issues on DMA version between 8.5.9.1 and 9.0 CU5.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult TimerTimeCannotBeLargerThan24Days(IValidate test, IReadable referenceNode, IReadable positionNode, string timeValue, string timerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTimeTag,
                ErrorId = ErrorIds.TimerTimeCannotBeLargerThan24Days,
                FullId = "7.1.5",
                Category = Category.Timer,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Timer Tag value '{0}' is higher than the max allowed value of 24 days. Timer id '{1}'.", timeValue, timerId),
                HowToFix = "Choose a value between '1' and '2.073.600.000' (included). The max value corresponds to 24 days.",
                ExampleCode = "",
                Details = "The minimum allowed value for a Timer Time is '1'." + Environment.NewLine + "The maximum allowed value for a Timer Time tag is '2.073.600.000' which corresponds to 24 days." + Environment.NewLine + "An altenative possible value is 'loop' which will cause the timer to continuously go off." + Environment.NewLine + "" + Environment.NewLine + "Also note that, due to a software issue, a value higher than '86.400.000' which corresponds to 24 hours will cause issues on DMA version between 8.5.9.1 and 9.0 CU5.",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult DuplicateTimer(IValidate test, IReadable referenceNode, IReadable positionNode, string timerTime, string timerIDs)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTimeTag,
                ErrorId = ErrorIds.DuplicateTimer,
                FullId = "7.1.6",
                Category = Category.Timer,
                Severity = Severity.Minor,
                Certainty = Certainty.Uncertain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Duplicate Timer with Time '{0}'. Timer IDs '{1}'.", timerTime, timerIDs),
                HowToFix = "Combine the timers into one.",
                ExampleCode = "",
                Details = "Each timer is a thread which uses resources. Timers are there to be able to have different polling rates. It should not be used to split groups on other factors than the polling rate.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult TooFastTimer(IValidate test, IReadable referenceNode, IReadable positionNode, string timerTime, string timerId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTimeTag,
                ErrorId = ErrorIds.TooFastTimer,
                FullId = "7.1.7",
                Category = Category.Timer,
                Severity = Severity.Minor,
                Certainty = Certainty.Uncertain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Too fast Timer Time '{0}'. Timer ID '{1}'.", timerTime, timerId),
                HowToFix = "Increase the timer time to at least 1s.",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        internal static IValidationResult TooSimilarTimers(IValidate test, IReadable referenceNode, IReadable positionNode, string timerId, string timerTime)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckTimeTag,
                ErrorId = ErrorIds.TooSimilarTimers,
                FullId = "7.1.8",
                Category = Category.Timer,
                Severity = Severity.Minor,
                Certainty = Certainty.Uncertain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Timer Time values too similar. Timer IDs '{0}'. Time values '{1}'.", timerId, timerTime),
                HowToFix = "Change the timer time so that the difference between the specified time and the time of the other timers is at least 1s.",
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
        public const uint MissingTag = 1;
        public const uint EmptyTag = 2;
        public const uint UntrimmedTag = 3;
        public const uint InvalidTagValue = 4;
        public const uint TimerTimeCannotBeLargerThan24Days = 5;
        public const uint DuplicateTimer = 6;
        public const uint TooFastTimer = 7;
        public const uint TooSimilarTimers = 8;
    }

    public static class CheckId
    {
        public const uint CheckTimeTag = 1;
    }
}