namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Display.CheckDisplayTag
{
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common.Attributes;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Helpers;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    [Test(CheckId.CheckDisplayTag, Category.Protocol)]
    internal class CheckDisplayTag : IValidate /*, ICodeFix, ICompare*/
    {
        public List<IValidationResult> Validate(ValidatorContext context)
        {
            List<IValidationResult> results = new List<IValidationResult>();

            ValidateHelper helper = new ValidateHelper(this, context, results);
            helper.Validate();

            return results;
        }

        ////public ICodeFixResult Fix(CodeFixContext context)
        ////{
        ////    CodeFixResult result = new CodeFixResult();

        ////    switch (context.Result.ErrorId)
        ////    {

        ////        default:
        ////            result.Message = $"This error ({context.Result.ErrorId}) isn't implemented.";
        ////            break;
        ////    }

        ////    return result;
        ////}
        
        ////public List<IValidationResult> Compare(MajorChangeCheckContext context)
        ////{
        ////    List<IValidationResult> results = new List<IValidationResult>();

        ////    return results;
        ////}
    }

    internal class ValidateHelper : ValidateHelperBase
    {
        private readonly IProtocol protocol;

        public ValidateHelper(IValidate test, ValidatorContext context, List<IValidationResult> results)
            : base(test, context, results)
        {
            protocol = context.ProtocolModel.Protocol;          
        }

        public void Validate()
        {
            if (protocol == null)
            {
                return;
            }

            var display = protocol.Display;

            // Missing
            if (display == null)
            {
                results.Add(Error.MissingTag(test, protocol, protocol));              
            }
        }
    }
}