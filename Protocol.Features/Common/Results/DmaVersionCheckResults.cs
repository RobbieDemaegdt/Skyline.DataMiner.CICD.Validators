﻿namespace Skyline.DataMiner.CICD.Validators.Protocol.Features.Common.Results
{
    using System.Collections.Generic;
    using Skyline.DataMiner.CICD.Validators.Protocol.Features.Common.Interfaces;

    internal class DmaVersionCheckResults : IDmaVersionCheckResults
    {
        internal DmaVersionCheckResults()
        {
            Features = new List<Feature>();
        }

        public IReadOnlyCollection<Feature> Features { get; internal set; }
    }
}