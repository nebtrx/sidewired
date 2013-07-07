using System;
using Sidewired.Core.Interfaces;

namespace Sidewired.Core.Fluent
{
    /// <summary>
    /// Fluent extension methods for <see cref="IMarkerResource"/> instances.
    /// </summary>
    public static class IMarkerResourceFluent
    {
        /// <summary>
        /// Sets <see cref="IMarkerResource.Format"/> property of caller <see cref="IMarkerResource"/> instance to given <see cref="string"/> value.
        /// </summary>
        /// <param name="markerResource">Caller <see cref="IMarkerResource"/> instance.</param>
        /// <param name="format">Given <see cref="string"/> value.</param>
        /// <returns>The caller <see cref="IMarkerResource"/> instance with <see cref="IMarkerResource.Format"/> property setted to given <see cref="string"/> value.</returns>
        public static IMarkerResource WithFormat(this IMarkerResource markerResource, string format)
        {
            markerResource.Format = format;
            return markerResource;
        }

        /// <summary>
        /// Sets <see cref="IMarkerResource.Source"/> property of caller <see cref="IMarkerResource"/> instance to given <see cref="Uri"/> value.
        /// </summary>
        /// <param name="markerResource">Caller <see cref="IMarkerResource"/> instance.</param>
        /// <param name="source">Given <see cref="Uri"/> value.</param>
        /// <returns>The caller <see cref="IMarkerResource"/> instance with <see cref="IMarkerResource.Source"/> property setted to given <see cref="Uri"/> value.</returns>
        public static IMarkerResource WithSource(this IMarkerResource markerResource, Uri source)
        {
            markerResource.Source = source;
            return markerResource;
        }

        /// <summary>
        /// Sets <see cref="IMarkerResource.PollingInterval"/> property of caller <see cref="IMarkerResource"/> instance to given <see cref="TimeSpan"/> value.
        /// </summary>
        /// <param name="markerResource">Caller <see cref="IMarkerResource"/> instance.</param>
        /// <param name="pollingInterval">Given <see cref="TimeSpan"/> value.</param>
        /// <returns>The caller <see cref="IMarkerResource"/> instance with <see cref="IMarkerResource.PollingInterval"/> property setted to given <see cref="TimeSpan"/> value.</returns>
        public static IMarkerResource WithPollingInterval(this IMarkerResource markerResource, TimeSpan pollingInterval)
        {
            markerResource.PollingInterval = pollingInterval;
            return markerResource;
        }
    }
}
