namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.HTTP.Session.CheckProxyPasswordAttribute
{
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Models.Protocol.Read.Linking;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common.Attributes;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common.Extensions;
    using Skyline.DataMiner.CICD.Validators.Protocol.Generic;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    [Test(CheckId.CheckProxyPasswordAttribute, Category.HTTP)]
    internal class CheckProxyPasswordAttribute : IValidate/*, ICodeFix, ICompare*/
    {
        public List<IValidationResult> Validate(ValidatorContext context)
        {
            List<IValidationResult> results = new List<IValidationResult>();

            foreach (IHTTPSession session in context.EachHttpSessionWithValidId())
            {
                if (session.ProxyPassword == null)
                {
                    continue;
                }

                (GenericStatus valueStatus, uint _) = GenericTests.CheckBasics<uint>(session.ProxyPassword.Value);

                if (valueStatus.HasFlag(GenericStatus.Empty))
                {
                    // Error message to add later
                    continue;
                }

                if (valueStatus.HasFlag(GenericStatus.Invalid))
                {
                    // Invalid value, error to add later
                    continue;
                }

                if (!context.ProtocolModel.TryGetObjectByKey<IParamsParam>(Mappings.ParamsById, session.ProxyPassword.Value, out _))
                {
                    results.Add(Error.NonExistingId(this, session, session, session.ProxyPassword.Value, session.Id.RawValue));
                    continue;
                }
            }

            return results;
        }

        ////public ICodeFixResult Fix(CodeFixContext context)
        ////{
        ////    CodeFixResult result = new CodeFixResult();

        ////    switch (context.Result.ErrorId)
        ////    {

        ////        default:
        ////            result.Message = String.Format("This error ({0}) isn't implemented.", context.Result.ErrorId.ToString());
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
}