﻿namespace Protocol.FeaturesTests.Features._10._0
{
	using System.Linq;
	using FluentAssertions;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Skyline.DataMiner.CICD.Validators.Common.Data;
	using Skyline.DataMiner.CICD.Validators.Protocol.Features.Common;
	using Skyline.DataMiner.CICD.Validators.Protocol.Features.Common.Results;
	using Skyline.DataMiner.CICD.Validators.Protocol.Features.Features;

	[TestClass]
    public class DynamicParameterReplicationTests
    {
        private static DynamicParameterReplication check;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            check = new DynamicParameterReplication();
        }

        [TestMethod]
        public void CheckIsUsed()
        {
            const string code = "<Protocol><Params><Param><Replication><Element dynamic='1'/></Replication></Param></Params></Protocol>";
            var input = new ProtocolInputData(code);

            FeatureCheckContext context = new FeatureCheckContext(input);

            var result = check.CheckIfUsed(context);
            var expected = context.Model.Protocol.Params.Select(x => new FeatureCheckResultItem(x));

            Assert.IsTrue(result.IsUsed);
            result.FeatureItems.Should().BeEquivalentTo(expected);
        }
    }
}