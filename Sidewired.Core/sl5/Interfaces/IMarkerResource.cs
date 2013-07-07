using System;

namespace Sidewired.Core.Interfaces
{
    /// <summary>
    /// Operation contract of the target object used to pass MarkerResource objects in the initial settings to the Silverlight Media Player using Sidewired.
    /// </summary>
    public interface IMarkerResource
    {
        /// <summary>
        /// Used to pass the Source property of MarkerResource objects the Silverlight Media Player using Sidewired.
        /// </summary>
        Uri Source { get; set; }

        /// <summary>
        /// Used to pass the Format property of MarkerResource objects the Silverlight Media Player using Sidewired. 
        /// </summary>
        string Format { get; set; }

        /// <summary>
        /// Used to pass the PollingInterval property of MarkerResource objects the Silverlight Media Player using Sidewired. 
        /// </summary>
        TimeSpan? PollingInterval { get; set; }
        
    }
}