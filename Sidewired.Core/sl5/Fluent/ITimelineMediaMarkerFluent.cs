using System;
using Sidewired.Core.Interfaces;

namespace Sidewired.Core.Fluent
{
    /// <summary>
    /// Fluent extension methods for <see cref="ITimelineMediaMarker"/> instances.
    /// </summary>
    public static class ITimelineMediaMarkerFluent
    {
        /// <summary>
        /// Sets <see cref="ITimelineMediaMarker.Id"/> property of caller <see cref="ITimelineMediaMarker"/> instance to given <see cref="string"/> value.
        /// </summary>
        /// <param name="timelineMediaMarker">Caller <see cref="ITimelineMediaMarker"/> instance.</param>
        /// <param name="id">Given <see cref="string"/> value.</param>
        /// <returns>The caller <see cref="ITimelineMediaMarker"/> instance with <see cref="ITimelineMediaMarker.Id"/> property setted to given <see cref="string"/> value.</returns>
        public static ITimelineMediaMarker WithId(this ITimelineMediaMarker timelineMediaMarker, string id)
        {
            timelineMediaMarker.Id = id;
            return timelineMediaMarker;
        }

        /// <summary>
        /// Sets <see cref="ITimelineMediaMarker.Content"/> property of caller <see cref="ITimelineMediaMarker"/> instance to given <see cref="string"/> value.
        /// </summary>
        /// <param name="timelineMediaMarker">Caller <see cref="ITimelineMediaMarker"/> instance.</param>
        /// <param name="content">Given <see cref="string"/> value.</param>
        /// <returns>The caller <see cref="ITimelineMediaMarker"/> instance with <see cref="ITimelineMediaMarker.Content"/> property setted to given <see cref="string"/> value.</returns>
        public static ITimelineMediaMarker WithContent(this ITimelineMediaMarker timelineMediaMarker, string content)
        {
            timelineMediaMarker.Content = content;
            return timelineMediaMarker;
        }

        /// <summary>
        /// Sets <see cref="ITimelineMediaMarker.Begin"/> property of caller <see cref="ITimelineMediaMarker"/> instance to given <see cref="TimeSpan"/> value.
        /// </summary>
        /// <param name="timelineMediaMarker">Caller <see cref="ITimelineMediaMarker"/> instance.</param>
        /// <param name="begin">Given <see cref="TimeSpan"/> value.</param>
        /// <returns>The caller <see cref="ITimelineMediaMarker"/> instance with <see cref="ITimelineMediaMarker.Begin"/> property setted to given <see cref="TimeSpan"/> value.</returns>
        public static ITimelineMediaMarker WithBegin(this ITimelineMediaMarker timelineMediaMarker, TimeSpan begin)
        {
            timelineMediaMarker.Begin = begin;
            return timelineMediaMarker;
        }

        /// <summary>
        /// Sets <see cref="ITimelineMediaMarker.End"/> property of caller <see cref="ITimelineMediaMarker"/> instance to given <see cref="TimeSpan"/> value.
        /// </summary>
        /// <param name="timelineMediaMarker">Caller <see cref="ITimelineMediaMarker"/> instance.</param>
        /// <param name="end">Given <see cref="TimeSpan"/> value.</param>
        /// <returns>The caller <see cref="ITimelineMediaMarker"/> instance with <see cref="ITimelineMediaMarker.End"/> property setted to given <see cref="TimeSpan"/> value.</returns>
        public static ITimelineMediaMarker WithEnd(this ITimelineMediaMarker timelineMediaMarker, TimeSpan end)
        {
            timelineMediaMarker.End = end;
            return timelineMediaMarker;
        }

        /// <summary>
        /// Sets <see cref="ITimelineMediaMarker.AllowSeek"/> property of caller <see cref="ITimelineMediaMarker"/> instance to true.
        /// </summary>
        /// <param name="timelineMediaMarker">Caller <see cref="ITimelineMediaMarker"/> instance.</param>
        /// <returns>The caller <see cref="ITimelineMediaMarker"/> instance with <see cref="ITimelineMediaMarker.AllowSeek"/> property setted to true.</returns>
        public static ITimelineMediaMarker WithAllowSeek(this ITimelineMediaMarker timelineMediaMarker)
        {
            timelineMediaMarker.AllowSeek = true;
            return timelineMediaMarker;
        }
    }
}