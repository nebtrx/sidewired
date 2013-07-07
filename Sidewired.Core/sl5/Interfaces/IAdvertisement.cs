using System;
using Sidewired.Core.Domain;

namespace Sidewired.Core.Interfaces
{
    /// <summary>
    /// Operation contract of the target object used to pass Advertisement objects in the initial settings to the Silverlight Media Player using Sidewired.
    /// </summary>
    public interface IAdvertisement
    {
        /// <summary>
        /// Used to pass the AdSource property of Advertisement objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        Uri AdSource { get; set; }

        /// <summary>
        /// Used to pass the DeliveryMethod property of Advertisement objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        DeliveryMethods DeliveryMethod { get; set; }

        /// <summary>
        /// Used to pass the Duration property of Advertisement objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        TimeSpan? Duration { get; set; }

        /// <summary>
        /// Used to pass the PauseTimeline property of Advertisement objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        bool PauseTimeline { get; set; }

        /// <summary>
        /// Used to pass the StartTime property of Advertisement objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        TimeSpan? StartTime { get; set; }

        /// <summary>
        /// Used to pass the ClickThrough property of Advertisement objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        Uri ClickThrough { get; set; }

        /// <summary>
        /// Used to pass the IsLinearClip property of Advertisement objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        bool IsLinearClip { get; set; }
    }
}