using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sidewired.Core.Interfaces;

namespace Sidewired.Core.Fluent
{
    /// <summary>
    /// Fluent extension methods for <see cref="IChapter"/> instances.
    /// </summary>
    public static class IChapterFluent
    {
        /// <summary>
        /// Sets <see cref="IChapter.Id"/> property of caller <see cref="IChapter"/> instance to given <see cref="string"/> value.
        /// </summary>
        /// <param name="chapter">Caller <see cref="IChapter"/> instance.</param>
        /// <param name="id">Given <see cref="string"/> value.</param>
        /// <returns>The caller <see cref="IChapter"/> instance with <see cref="IChapter.Id"/> property setted to given <see cref="string"/> value.</returns>
        public static IChapter WithId(this IChapter chapter, string id)
        {
            chapter.Id = id;
            return chapter;
        }

        /// <summary>
        /// Sets <see cref="IChapter.Content"/> property of caller <see cref="IChapter"/> instance to given <see cref="string"/> value.
        /// </summary>
        /// <param name="chapter">Caller <see cref="IChapter"/> instance.</param>
        /// <param name="content">Given <see cref="string"/> value.</param>
        /// <returns>The caller <see cref="IChapter"/> instance with <see cref="IChapter.Content"/> property setted to given <see cref="string"/> value.</returns>
        public static IChapter WithContent(this IChapter chapter, string content)
        {
            chapter.Content = content;
            return chapter;
        }
        
        /// <summary>
        /// Sets <see cref="IChapter.Title"/> property of caller <see cref="IChapter"/> instance to given <see cref="string"/> value.
        /// </summary>
        /// <param name="chapter">Caller <see cref="IChapter"/> instance.</param>
        /// <param name="title">Given <see cref="string"/> value.</param>
        /// <returns>The caller <see cref="IChapter"/> instance with <see cref="IChapter.Title"/> property setted to given <see cref="string"/> value.</returns>
        public static IChapter WithTitle(this IChapter chapter, string title)
        {
            chapter.Title = title;
            return chapter;
        }

        /// <summary>
        /// Sets <see cref="IChapter.Description"/> property of caller <see cref="IChapter"/> instance to given <see cref="string"/> value.
        /// </summary>
        /// <param name="chapter">Caller <see cref="IChapter"/> instance.</param>
        /// <param name="description">Given <see cref="string"/> value.</param>
        /// <returns>The caller <see cref="IChapter"/> instance with <see cref="IChapter.Description"/> property setted to given <see cref="string"/> value.</returns>
        public static IChapter WithDescription(this IChapter chapter, string description)
        {
            chapter.Description = description;
            return chapter;
        }

        /// <summary>
        /// Sets <see cref="IChapter.Begin"/> property of caller <see cref="IChapter"/> instance to given <see cref="TimeSpan"/> value.
        /// </summary>
        /// <param name="chapter">Caller <see cref="IChapter"/> instance.</param>
        /// <param name="begin">Given <see cref="TimeSpan"/> value.</param>
        /// <returns>The caller <see cref="IChapter"/> instance with <see cref="IChapter.Begin"/> property setted to given <see cref="TimeSpan"/> value.</returns>
        public static IChapter WithBegin(this IChapter chapter, TimeSpan begin)
        {
            chapter.Begin = begin;
            return chapter;
        }

        /// <summary>
        /// Sets <see cref="IChapter.End"/> property of caller <see cref="IChapter"/> instance to given <see cref="TimeSpan"/> value.
        /// </summary>
        /// <param name="chapter">Caller <see cref="IChapter"/> instance.</param>
        /// <param name="end">Given <see cref="TimeSpan"/> value.</param>
        /// <returns>The caller <see cref="IChapter"/> instance with <see cref="IChapter.End"/> property setted to given <see cref="TimeSpan"/> value.</returns>
        public static IChapter WithEnd(this IChapter chapter, TimeSpan end)
        {
            chapter.End = end;
            return chapter;
        }

        /// <summary>
        /// Sets <see cref="IChapter.ThumbSource"/> property of caller <see cref="IChapter"/> instance to given <see cref="Uri"/> value.
        /// </summary>
        /// <param name="markerResource">Caller <see cref="IChapter"/> instance.</param>
        /// <param name="source">Given <see cref="Uri"/> value.</param>
        /// <returns>The caller <see cref="IChapter"/> instance with <see cref="IChapter.ThumbSource"/> property setted to given <see cref="Uri"/> value.</returns>
        public static IChapter WithThumbSource(this IChapter markerResource, Uri source)
        {
            markerResource.ThumbSource = source;
            return markerResource;
        }
    }
}
