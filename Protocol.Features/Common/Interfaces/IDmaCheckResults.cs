﻿namespace Skyline.DataMiner.CICD.Validators.Protocol.Features.Common.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Holds the features that are used.
    /// </summary>
    public interface IDmaVersionCheckResults
    {
        /// <summary>
        /// Gets the features that are used.
        /// </summary>
        IReadOnlyCollection<IFeature> Features { get; }
    }
}