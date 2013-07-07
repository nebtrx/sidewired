using System;
using Sidewired.Core.Domain;
using Sidewired.Core.Interfaces;

namespace Sidewired.Core.Fluent
{
    /// <summary>
    /// Fluent extension methods for <see cref="IAdvertisement"/> instances.
    /// </summary>
    public static class IAdvertisementFluent
    {

        /// <summary>
        /// Sets <see cref="IAdvertisement.DeliveryMethod"/> property of caller <see cref="IAdvertisement"/> instance to given <see cref="DeliveryMethods"/> value.
        /// </summary>
        /// <param name="advertisement">Caller <see cref="IAdvertisement"/> instance.</param>
        /// <param name="deliveryMethod">Given <see cref="DeliveryMethods"/> value.</param>
        /// <returns>The caller <see cref="IAdvertisement"/> instance with <see cref="IAdvertisement.DeliveryMethod"/> property setted to given <see cref="DeliveryMethods"/> value.</returns>
        public static IAdvertisement WithDeliveryMethod(this IAdvertisement advertisement, DeliveryMethods deliveryMethod)
        {
            advertisement.DeliveryMethod = deliveryMethod;
            return advertisement;
        }

        /// <summary>
        /// Sets <see cref="IAdvertisement.Duration"/> property of caller <see cref="IAdvertisement"/> instance to given <see cref="TimeSpan"/> value.
        /// </summary>
        /// <param name="advertisement">Caller <see cref="IAdvertisement"/> instance.</param>
        /// <param name="duration">Given <see cref="TimeSpan"/> value.</param>
        /// <returns>The caller <see cref="IAdvertisement"/> instance with <see cref="IAdvertisement.Duration"/> property setted to given <see cref="TimeSpan"/> value.</returns>
        public static IAdvertisement WithDuration(this IAdvertisement advertisement, TimeSpan duration)
        {
            advertisement.Duration = duration;
            return advertisement;
        }

        /// <summary>
        /// Sets <see cref="IAdvertisement.StartTime"/> property of caller <see cref="IAdvertisement"/> instance to given <see cref="TimeSpan"/> value.
        /// </summary>
        /// <param name="advertisement">Caller <see cref="IAdvertisement"/> instance.</param>
        /// <param name="startTime">Given <see cref="TimeSpan"/> value.</param>
        /// <returns>The caller <see cref="IAdvertisement"/> instance with <see cref="IAdvertisement.StartTime"/> property setted to given <see cref="TimeSpan"/> value.</returns>
        public static IAdvertisement WithStartTime(this IAdvertisement advertisement, TimeSpan startTime)
        {
            advertisement.StartTime = startTime;
            return advertisement;
        }

        /// <summary>
        /// Sets <see cref="IAdvertisement.PauseTimeline"/> property of caller <see cref="IAdvertisement"/> instance to false.
        /// </summary>
        /// <param name="advertisement">Caller <see cref="IAdvertisement"/> instance.</param>
        /// <returns>The caller <see cref="IAdvertisement"/> instance with <see cref="IAdvertisement.PauseTimeline"/> property setted to true.</returns>
        public static IAdvertisement WithNoTimelinePause(this IAdvertisement advertisement)
        {
            advertisement.PauseTimeline = true;
            return advertisement;
        }

        /// <summary>
        /// Sets <see cref="IAdvertisement.AdSource"/> property of caller <see cref="IAdvertisement"/> instance to given <see cref="System.Uri"/> value.
        /// </summary>
        /// <param name="advertisement">Caller <see cref="IAdvertisement"/> instance.</param>
        /// <param name="adSource">Given <see cref="System.Uri"/> value.</param>
        /// <returns>The caller <see cref="IAdvertisement"/> instance with <see cref="IAdvertisement.AdSource"/> property setted to given <see cref="System.Uri"/> value.</returns>
        public static IAdvertisement WithAdSource(this IAdvertisement advertisement, Uri adSource)
        {
            advertisement.AdSource = adSource;
            return advertisement;
        }

        /// <summary>
        /// Sets <see cref="IAdvertisement.ClickThrough"/> property of caller <see cref="IAdvertisement"/> instance to given <see cref="System.Uri"/> value.
        /// </summary>
        /// <param name="advertisement">Caller <see cref="IAdvertisement"/> instance.</param>
        /// <param name="clickThroughUri">Given <see cref="System.Uri"/> value.</param>
        /// <returns>The caller <see cref="IAdvertisement"/> instance with <see cref="IAdvertisement.ClickThrough"/> property setted to given <see cref="System.Uri"/> value.</returns>
        public static IAdvertisement WithClickThrough(this IAdvertisement advertisement, Uri clickThroughUri)
        {
            advertisement.ClickThrough = clickThroughUri;
            return advertisement;
        }

        /// <summary>
        /// Sets <see cref="IAdvertisement.IsLinearClip"/> property of caller <see cref="IAdvertisement"/> instance  to true.
        /// </summary>
        /// <param name="advertisement">Caller <see cref="IAdvertisement"/> instance.</param>
        /// <returns>The caller <see cref="IAdvertisement"/> instance with <see cref="IAdvertisement.IsLinearClip"/> property setted to true.</returns>
        public static IAdvertisement WithLinearClipBehavior(this IAdvertisement advertisement)
        {
            advertisement.IsLinearClip = true;
            return advertisement;
        }
    }
}
