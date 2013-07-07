using System;

namespace Sidewired.Core.Interfaces
{
    /// <summary>
    /// Operation contract for marquer objects
    /// </summary>
    public interface IMarker
    {

        /// <summary>
        /// Used to pass the Id property of Marker objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        string Id { get; set; }
        
        /// <summary>
        /// Used to pass the Begin property of Marker objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        TimeSpan Begin { get; set; }

        /// <summary>
        /// Used to pass the End property of Marker objects to the Silverlight Media Player using Sidewired. 
        /// </summary>
        TimeSpan End { get; set; }

        /// <summary>
        /// Used to pass the Content property of Marker objects to the Silverlight Media Player using Sidewired.  
        /// </summary>
        string Content { get; set; }
    }
}