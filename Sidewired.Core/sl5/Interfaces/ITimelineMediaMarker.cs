using System;

namespace Sidewired.Core.Interfaces
{
    /// <summary>
    /// Operation contract of the target object used to pass TimelineMediaMarker objects in the initial settings to the Silverlight Media Player using Sidewired.
    /// </summary>
    public interface ITimelineMediaMarker : IMarker
    {
        /// <summary>
        /// Used to pass the AllowSeek property of TimelineMediaMarker objects to the Silverlight Media Player using Sidewired.  
        /// </summary>
        bool AllowSeek { get; set; }
    }
}