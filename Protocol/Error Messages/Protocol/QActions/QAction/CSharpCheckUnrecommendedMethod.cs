namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.QActions.QAction.CSharpCheckUnrecommendedMethod
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
        public static IValidationResult UnrecommendedThreadAbort(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedThreadAbort,
                FullId = "3.15.1",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "System.Threading.Thread", "Abort", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Thread.Abort method should be used with caution." + Environment.NewLine + "Particularly when you call it to abort a thread other than the current thread, you do not know what code has executed or failed to execute when the ThreadAbortException is thrown." + Environment.NewLine + "You also cannot be certain of the state of your application or any application and user state that it's responsible for preserving." + Environment.NewLine + "For example, calling Thread.Abort may prevent the execution of static constructors or the release of unmanaged resources." + Environment.NewLine + "" + Environment.NewLine + "Instead, some logic to nicely end the thread should be implemented." + Environment.NewLine + "This is usually implemented according to the cooperative cancellation model.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedSlProtocolGetParameterIndex(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedSlProtocolGetParameterIndex,
                FullId = "3.15.2",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "GetParameterIndex", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.GetParameterIndex' method is used to get the value of a specific cell in a table." + Environment.NewLine + "The problem with this call is that it relies on an indexer to identify the row for which a cell value needs to be retrieved." + Environment.NewLine + "However, the order of rows in element tables is not guaranteed." + Environment.NewLine + "Meaning, using an index (row position) is not ideal." + Environment.NewLine + "" + Environment.NewLine + "Instead, it is recommended to use the 'SLProtocol.GetParameterIndexByKey' method which relies on the primary key of the rows.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedSlProtocolSetParameterIndex(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedSlProtocolSetParameterIndex,
                FullId = "3.15.3",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "SetParameterIndex", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.SetParameterIndex' method is used to set the value of a specific cell in a table." + Environment.NewLine + "The problem with this call is that it relies on an indexer to identify the row for which a cell value needs to be updated." + Environment.NewLine + "However, the order of rows in element tables is not guaranteed." + Environment.NewLine + "Meaning, using an index (row position) is not ideal." + Environment.NewLine + "" + Environment.NewLine + "Instead, it is recommended to use the 'SLProtocol.SetParameterIndexByKey' method which relies on the primary key of the rows.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedSlProtocolSetParametersIndex(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedSlProtocolSetParametersIndex,
                FullId = "3.15.4",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "SetParametersIndex", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.SetParametersIndex' method is used to set the value of a specific cells in a table." + Environment.NewLine + "The problem with this call is that it relies on an indexer to identify the rows for which a cells values need to be updated." + Environment.NewLine + "However, the order of rows in element tables is not guaranteed." + Environment.NewLine + "Meaning, using an index (row position) is not ideal." + Environment.NewLine + "" + Environment.NewLine + "Instead, it is recommended to use the 'SLProtocol.SetParametersIndexByKey' method which relies on the primary key of the rows.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyDataMinerNTGetRemoteTrend(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyDataMinerNTGetRemoteTrend,
                FullId = "3.15.5",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyDataMiner(216/*NT_GET_REMOTE_TREND*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyDataMiner(216/*NT_GET_REMOTE_TREND*/, ...)' method is now considered obsolete." + Environment.NewLine + "" + Environment.NewLine + "Instead, the 'GetTrendDataMessage' SLNet message is recommended as it is more efficient and up to date.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyDataMinerNTGetRemoteTrendAvg(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyDataMinerNTGetRemoteTrendAvg,
                FullId = "3.15.6",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyDataMiner(260/*NT_GET_REMOTE_TREND_AVG*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyDataMiner(260/*NT_GET_REMOTE_TREND_AVG*/, ...)' method is now considered obsolete." + Environment.NewLine + "" + Environment.NewLine + "Instead, the 'GetTrendDataMessage' SLNet message is recommended as it is more efficient and up to date.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNTDeleteRow(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNTDeleteRow,
                FullId = "3.15.7",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(156/*NT_DELETE_ROW*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(156/*NT_DELETE_ROW*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.DeleteRow()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNTAddRow(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNTAddRow,
                FullId = "3.15.8",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(149/*NT_ADD_ROW*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(149/*NT_ADD_ROW*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.AddRow()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_CHECK_TRIGGER(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_CHECK_TRIGGER,
                FullId = "3.15.9",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(134/*NT_CHECK_TRIGGER*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(134/*NT_CHECK_TRIGGER*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.CheckTrigger()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_GET_DATA(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_GET_DATA,
                FullId = "3.15.10",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(60/*NT_GET_DATA*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(60/*NT_GET_DATA*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.GetData()' is recommended." + Environment.NewLine + "" + Environment.NewLine + "If the intention was only to check if the parameter is empty, then 'SLProtocol.IsEmpty()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_GET_KEY_POSITION(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_GET_KEY_POSITION,
                FullId = "3.15.11",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(163/*NT_GET_KEY_POSITION*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(163/*NT_GET_KEY_POSITION*/, ...)' method is now considered obsolete." + Environment.NewLine + "" + Environment.NewLine + "Instead of relying on row positions, working directly with calls relying on primary keys is recommended" + Environment.NewLine + "" + Environment.NewLine + "Examples:" + Environment.NewLine + " - Use 'SLProtocol.GetParameterIndexByKey()' instead of 'SLProtocol.GetParameterIndex()'.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_GET_PARAMETER(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_GET_PARAMETER,
                FullId = "3.15.12",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(73/*NT_GET_PARAMETER*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(73/*NT_GET_PARAMETER*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.GetParameter()' or 'SLProtocol.GetParameters()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_GET_PARAMETER_BY_DATA(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_GET_PARAMETER_BY_DATA,
                FullId = "3.15.13",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol( 87/*NT_GET_PARAMETER_BY_DATA*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol( 87/*NT_GET_PARAMETER_BY_DATA*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.GetParameterByData()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_GET_PARAMETER_BY_NAME(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_GET_PARAMETER_BY_NAME,
                FullId = "3.15.14",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(85/*NT_GET_PARAMETER_BY_NAME*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(85/*NT_GET_PARAMETER_BY_NAME*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.GetParameterByName()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_GET_DESCRIPTION(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_GET_DESCRIPTION,
                FullId = "3.15.15",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(77/*NT_GET_DESCRIPTION*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(77/*NT_GET_DESCRIPTION*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.GetParameterDescription()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_GET_PARAMETER_INDEX(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_GET_PARAMETER_INDEX,
                FullId = "3.15.16",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(122/*NT_GET_PARAMETER_INDEX*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(122/*NT_GET_PARAMETER_INDEX*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.GetParameterIndexByKey()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_GET_ITEM_DATA(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_GET_ITEM_DATA,
                FullId = "3.15.17",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(88/*NT_GET_ITEM_DATA*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(88/*NT_GET_ITEM_DATA*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.GetParameterItemData()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_GET_ROW(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_GET_ROW,
                FullId = "3.15.18",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(215/*NT_GET_ROW*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(215/*NT_GET_ROW*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.GetRow()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_ARRAY_ROW_COUNT(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_ARRAY_ROW_COUNT,
                FullId = "3.15.19",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(195/*NT_ARRAY_ROW_COUNT*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(195/*NT_ARRAY_ROW_COUNT*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.RowCount()' is recommended." + Environment.NewLine + "" + Environment.NewLine + "If the intention is to loop over rows based on the result, using a call to get columns straight away is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_NOTIFY_DISPLAY(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_NOTIFY_DISPLAY,
                FullId = "3.15.20",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(123/*NT_NOTIFY_DISPLAY*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(123/*NT_NOTIFY_DISPLAY*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.SendToDisplay()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_SET_PARAMETER_WITH_HISTORY(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_SET_PARAMETER_WITH_HISTORY,
                FullId = "3.15.21",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(256/*NT_SET_PARAMETER_WITH_HISTORY*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(256/*NT_SET_PARAMETER_WITH_HISTORY*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.SetParameter()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_SET_PARAMETER_BY_DATA(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_SET_PARAMETER_BY_DATA,
                FullId = "3.15.22",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(86/*NT_SET_PARAMETER_BY_DATA*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(86/*NT_SET_PARAMETER_BY_DATA*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.SetParameterByData()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_SET_PARAMETER_BY_NAME(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_SET_PARAMETER_BY_NAME,
                FullId = "3.15.23",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(84/*NT_SET_PARAMETER_BY_NAME*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(84/*NT_SET_PARAMETER_BY_NAME*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.SetParameterByName()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_SET_DESCRIPTION(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_SET_DESCRIPTION,
                FullId = "3.15.24",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(131/*NT_SET_DESCRIPTION*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(131/*NT_SET_DESCRIPTION*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.SetParameterDescription()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_SET_ITEM_DATA(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_SET_ITEM_DATA,
                FullId = "3.15.25",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(89/*NT_SET_ITEM_DATA*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(89/*NT_SET_ITEM_DATA*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.SetParameterItemData()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnrecommendedNotifyProtocolNT_SET_ROW(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckUnrecommendedMethod,
                ErrorId = ErrorIds.UnrecommendedNotifyProtocolNT_SET_ROW,
                FullId = "3.15.26",
                Category = Category.QAction,
                Severity = Severity.Minor,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Method '{0}.{1}' is unrecommended. QAction ID '{2}'.", "SLProtocol", "NotifyProtocol(225/*NT_SET_ROW*/, ...)", qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'SLProtocol.NotifyProtocol(225/*NT_SET_ROW*/, ...)' method is now considered unrecommended." + Environment.NewLine + "" + Environment.NewLine + "Instead, the wrapper method 'SLProtocol.SetRow()' is recommended.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint UnrecommendedThreadAbort = 1;
        public const uint UnrecommendedSlProtocolGetParameterIndex = 2;
        public const uint UnrecommendedSlProtocolSetParameterIndex = 3;
        public const uint UnrecommendedSlProtocolSetParametersIndex = 4;
        public const uint UnrecommendedNotifyDataMinerNTGetRemoteTrend = 5;
        public const uint UnrecommendedNotifyDataMinerNTGetRemoteTrendAvg = 6;
        public const uint UnrecommendedNotifyProtocolNTDeleteRow = 7;
        public const uint UnrecommendedNotifyProtocolNTAddRow = 8;
        public const uint UnrecommendedNotifyProtocolNT_CHECK_TRIGGER = 9;
        public const uint UnrecommendedNotifyProtocolNT_GET_DATA = 10;
        public const uint UnrecommendedNotifyProtocolNT_GET_KEY_POSITION = 11;
        public const uint UnrecommendedNotifyProtocolNT_GET_PARAMETER = 12;
        public const uint UnrecommendedNotifyProtocolNT_GET_PARAMETER_BY_DATA = 13;
        public const uint UnrecommendedNotifyProtocolNT_GET_PARAMETER_BY_NAME = 14;
        public const uint UnrecommendedNotifyProtocolNT_GET_DESCRIPTION = 15;
        public const uint UnrecommendedNotifyProtocolNT_GET_PARAMETER_INDEX = 16;
        public const uint UnrecommendedNotifyProtocolNT_GET_ITEM_DATA = 17;
        public const uint UnrecommendedNotifyProtocolNT_GET_ROW = 18;
        public const uint UnrecommendedNotifyProtocolNT_ARRAY_ROW_COUNT = 19;
        public const uint UnrecommendedNotifyProtocolNT_NOTIFY_DISPLAY = 20;
        public const uint UnrecommendedNotifyProtocolNT_SET_PARAMETER_WITH_HISTORY = 21;
        public const uint UnrecommendedNotifyProtocolNT_SET_PARAMETER_BY_DATA = 22;
        public const uint UnrecommendedNotifyProtocolNT_SET_PARAMETER_BY_NAME = 23;
        public const uint UnrecommendedNotifyProtocolNT_SET_DESCRIPTION = 24;
        public const uint UnrecommendedNotifyProtocolNT_SET_ITEM_DATA = 25;
        public const uint UnrecommendedNotifyProtocolNT_SET_ROW = 26;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CSharpCheckUnrecommendedMethod = 15;
    }
}