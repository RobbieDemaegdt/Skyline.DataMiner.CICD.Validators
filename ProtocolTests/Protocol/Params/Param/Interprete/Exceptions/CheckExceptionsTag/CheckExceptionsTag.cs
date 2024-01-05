namespace ProtocolTests.Protocol.Params.Param.Interprete.Exceptions.CheckExceptionsTag
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Interprete.Exceptions.CheckExceptionsTag;

    [TestClass]
    public class Compare
    {
        private readonly ICompare compare = new CheckExceptionsTag();

        #region Valid Checks

        [TestMethod]
        public void Param_CheckExceptionsTag_Valid()
        {
            Generic.CompareData data = new Generic.CompareData
            {
                TestType = Generic.TestType.Valid,
                FileNameBase = "Valid",
                ExpectedResults = new List<IValidationResult>()
            };

            Generic.Compare(compare, data);
        }

        #endregion

        #region Invalid Checks

        [TestMethod]
        public void Param_CheckExceptionsTag_AddedException()
        {
            Generic.CompareData data = new Generic.CompareData
            {
                TestType = Generic.TestType.Invalid,
                FileNameBase = "AddedException",
                ExpectedResults = new List<IValidationResult>
                {
                    ErrorCompare.AddedException(null, null, "1", "100"),
                    ErrorCompare.AddedException(null, null, "2", "101"),

                    ErrorCompare.AddedException(null, null, "1", "200"),
                    ErrorCompare.AddedException(null, null, "2", "201"),

                    ErrorCompare.AddedException(null, null, "1", "300"),
                    ErrorCompare.AddedException(null, null, "2", "301"),
                }
            };

            Generic.Compare(compare, data);
        }

        [TestMethod]
        public void Param_CheckExceptionsTag_RemovedException()
        {
            Generic.CompareData data = new Generic.CompareData
            {
                TestType = Generic.TestType.Invalid,
                FileNameBase = "RemovedException",
                ExpectedResults = new List<IValidationResult>
                {
                    ErrorCompare.RemovedException(null, null, "1", "100"),
                    ErrorCompare.RemovedException(null, null, "2", "101"),
                }
            };

            Generic.Compare(compare, data);
        }

        [TestMethod]
        public void Param_CheckExceptionsTag_UpdatedExceptionValueTag()
        {
            Generic.CompareData data = new Generic.CompareData
            {
                TestType = Generic.TestType.Invalid,
                FileNameBase = "UpdatedExceptionValueTag",
                ExpectedResults = new List<IValidationResult>
                {
                    ErrorCompare.UpdatedExceptionValueTag(null, null, "1", "100", "1", "2"),
                }
            };

            Generic.Compare(compare, data);
        }

        #endregion
    }

    [TestClass]
    public class Attribute
    {
        private readonly IRoot root = new CheckExceptionsTag();

        [TestMethod]
        public void Param_CheckExceptionsTag_CheckCategory() => Generic.CheckCategory(root, Category.Param);

        [TestMethod]
        public void Param_CheckExceptionsTag_CheckId() => Generic.CheckId(root, CheckId.CheckExceptionsTag);
    }
}