using System;
using Sidewired.Core.Domain;
using Sidewired.Core.Interfaces;

namespace Sidewired.Core.Fluent
{
    /// <summary>
    /// Fluent extension methods for <see cref="IPlaylistItem"/> instances.
    /// </summary>
    public static class IPlaylistItemFluent
    {
        /// <summary>
        /// Sets <see cref="IPlaylistItem.MediaSource"/> property of caller <see cref="IPlaylistItem"/> instance to given <see cref="Uri"/> value.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="mediaSource">Given <see cref="Uri"/> value.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="IPlaylistItem.MediaSource"/> property setted to given <see cref="Uri"/> value.</returns>
        public static IPlaylistItem WithMediaSource(this IPlaylistItem playlistItem, Uri mediaSource)
        {
            playlistItem.MediaSource = mediaSource;
            return playlistItem;
        }

        /// <summary>
        /// Adds a <see cref="ITimelineMediaMarker"/> instance to <see cref="IPlaylistItem.TimelineMarkers"/> collection of caller <see cref="IPlaylistItem"/> instance.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="timelineMediaMarker"><see cref="ITimelineMediaMarkerFluent"/> instance to add.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="ITimelineMediaMarkerFluent"/> instance added to <see cref="IPlaylistItem.TimelineMarkers"/> collection.</returns>
        public static IPlaylistItem WithTimelineMarker(this IPlaylistItem playlistItem, ITimelineMediaMarker timelineMediaMarker)
        {
            playlistItem.TimelineMarkers.Add(timelineMediaMarker);
            return playlistItem;
        }

        /// <summary>
        /// Adds a new  <see cref="ITimelineMediaMarker"/> instance for <see cref="IPlaylistItem.TimelineMarkers"/> property of caller <see cref="ITimelineMediaMarker"/> instance and executes the given <see cref="Action{ITimelineMediaMarker}"/> action on it.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="action"><see cref="Action{ITimelineMediaMarker}"/> to execute on new <see cref="ITimelineMediaMarker"/> instance.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with a new <see cref="ITimelineMediaMarker"/> instance added to <see cref="IPlaylistItem.TimelineMarkers"/> collection property.</returns>
        public static IPlaylistItem WithTimelineMarker(this IPlaylistItem playlistItem, Action<ITimelineMediaMarker> action)
        {
            var timelineMediaMarker = TimelineMediaMarker.Create();
            playlistItem.TimelineMarkers.Add(timelineMediaMarker);
            action(timelineMediaMarker);
            return playlistItem;
        }

        /// <summary>
        /// Sets <see cref="IPlaylistItem.DeliveryMethod"/> property of caller <see cref="IPlaylistItem"/> instance to given <see cref="DeliveryMethods"/> value.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="deliveryMethod">Given <see cref="DeliveryMethods"/> value.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="IPlaylistItem.DeliveryMethod"/> property setted to given <see cref="DeliveryMethods"/> value.</returns>
        public static IPlaylistItem WithDeliveryMethod(this IPlaylistItem playlistItem, DeliveryMethods deliveryMethod)
        {
            playlistItem.DeliveryMethod = deliveryMethod;
            return playlistItem;
        }

        /// <summary>
        /// Adds a <see cref="IMarkerResource"/> instance to <see cref="IPlaylistItem.MarkerResources"/> collection of caller <see cref="IPlaylistItem"/> instance.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="markerResource"><see cref="IMarkerResource"/> instance to add.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="MarkerResource"/> instance added to <see cref="IPlaylistItem.MarkerResources"/> collection.</returns>
        public static IPlaylistItem WithMarkerResource(this IPlaylistItem playlistItem, IMarkerResource markerResource)
        {
            playlistItem.MarkerResources.Add(markerResource);
            return playlistItem;
        }

        /// <summary>
        /// Adds a new  <see cref="IMarkerResource"/> instance for <see cref="IPlaylistItem.MarkerResources"/> property of caller <see cref="IMarkerResource"/> instance and executes the given <see cref="Action{IMarkerResource}"/> action on it.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="action"><see cref="Action{IMarkerResource}"/> to execute on new <see cref="IMarkerResource"/> instance.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with a new <see cref="IMarkerResource"/> instance added to <see cref="IPlaylistItem.MarkerResources"/> collection property.</returns>
        public static IPlaylistItem WithMarkerResource(this IPlaylistItem playlistItem, Action<IMarkerResource> action)
        {
            var markerResource = MarkerResource.Create();
            playlistItem.MarkerResources.Add(markerResource);
            action(markerResource);
            return playlistItem;
        }

        /// <summary>
        /// Adds a <see cref="IAdvertisement"/> instance to <see cref="IPlaylistItem.InterstitialAdvertisements"/> collection of caller <see cref="IPlaylistItem"/> instance.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="advertisement"><see cref="IAdvertisement"/> instance to add.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="IAdvertisement"/> instance added to <see cref="IPlaylistItem.InterstitialAdvertisements"/> collection.</returns>
        public static IPlaylistItem WithInterstitialAdvertisement(this IPlaylistItem playlistItem, IAdvertisement advertisement)
        {
            playlistItem.InterstitialAdvertisements.Add(advertisement);
            return playlistItem;
        }

        /// <summary>
        /// Adds a new  <see cref="IAdvertisement"/> instance for <see cref="IPlaylistItem.InterstitialAdvertisements"/> property of caller <see cref="IAdvertisement"/> instance and executes the given <see cref="Action{IAdvertisement}"/> action on it.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="action"><see cref="Action{IAdvertisement}"/> to execute on new <see cref="IAdvertisement"/> instance.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with a new <see cref="IAdvertisement"/> instance added to <see cref="IPlaylistItem.InterstitialAdvertisements"/> collection property.</returns>
        public static IPlaylistItem WithInterstitialAdvertisement(this IPlaylistItem playlistItem, Action<IAdvertisement> action)
        {
            var advertisement = Advertisement.Create();
            playlistItem.InterstitialAdvertisements.Add(advertisement);
            action(advertisement);
            return playlistItem;
        }


        /// <summary>
        /// Sets <see cref="IPlaylistItem.PreRollAdvertisement"/> property of caller <see cref="IPlaylistItem"/> instance to given <see cref="IAdvertisement"/> instance.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="advertisement">Given <see cref="IAdvertisement"/> instance. </param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="IPlaylistItem.PreRollAdvertisement"/> property setted to given <see cref="IAdvertisement"/> instance.</returns>
        public static IPlaylistItem WithPreRollAdvertisement(this IPlaylistItem playlistItem, IAdvertisement advertisement)
        {
            playlistItem.PreRollAdvertisement = advertisement;
            return playlistItem;
        }

        /// <summary>
        /// Sets a new  <see cref="IPlaylistItem"/> instance for <see cref="IPlaylistItem.PreRollAdvertisement"/> property of caller <see cref="IPlaylistItem"/> instance and executes the given <see cref="Action{IAdvertisement}"/> action on it.
        /// </summary>
        /// <param name="playerSettings">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="action"><see cref="Action{IAdvertisement}"/> to execute on new <see cref="IAdvertisement"/> instance.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="IPlaylistItem.PreRollAdvertisement"/> property setted to new <see cref="IAdvertisement"/> instance.</returns>
        public static IPlaylistItem WithPreRollAdvertisement(this IPlaylistItem playerSettings, Action<IAdvertisement> action)
        {
            playerSettings.PreRollAdvertisement = Advertisement.Create();
            action(playerSettings.PreRollAdvertisement);
            return playerSettings;
        }

        /// <summary>
        /// Sets <see cref="IPlaylistItem.PostRollAdvertisement"/> property of caller <see cref="IPlaylistItem"/> instance to given <see cref="IAdvertisement"/> instance.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="advertisement">Given <see cref="IAdvertisement"/> instance. </param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="IPlaylistItem.PostRollAdvertisement"/> property setted to given <see cref="IAdvertisement"/> instance.</returns>
        public static IPlaylistItem WithPostRollAdvertisement(this IPlaylistItem playlistItem, IAdvertisement advertisement)
        {
            playlistItem.PostRollAdvertisement = advertisement;
            return playlistItem;
        }

        /// <summary>
        /// Sets a new  <see cref="IPlaylistItem"/> instance for <see cref="IPlaylistItem.PostRollAdvertisement"/> property of caller <see cref="IPlaylistItem"/> instance and executes the given <see cref="Action{IAdvertisement}"/> action on it.
        /// </summary>
        /// <param name="playerSettings">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="action"><see cref="Action{IAdvertisement}"/> to execute on new <see cref="IAdvertisement"/> instance.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="IPlaylistItem.PostRollAdvertisement"/> property setted to new <see cref="IAdvertisement"/> instance.</returns>
        public static IPlaylistItem WithPostRollAdvertisement(this IPlaylistItem playerSettings, Action<IAdvertisement> action)
        {
            playerSettings.PostRollAdvertisement = Advertisement.Create();
            action(playerSettings.PostRollAdvertisement);
            return playerSettings;
        }

        /// <summary>
        /// Sets <see cref="IPlaylistItem.ThumbSource"/> property of caller <see cref="IPlaylistItem"/> instance to given <see cref="Uri"/> value.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="thumbSource">Given <see cref="Uri"/> value.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="IPlaylistItem.ThumbSource"/> property setted to given <see cref="Uri"/> value.</returns>
        public static IPlaylistItem WithThumbSource(this IPlaylistItem playlistItem, Uri thumbSource)
        {
            playlistItem.ThumbSource = thumbSource;
            return playlistItem;
        }

        /// <summary>
        /// Sets <see cref="IPlaylistItem.S3DProperties"/> property of caller <see cref="IPlaylistItem"/> instance to given <see cref="IS3DProperties"/> instance.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="s3DProperties">Given <see cref="IS3DProperties"/> instance. </param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="IPlaylistItem.S3DProperties"/> property setted to given <see cref="IS3DProperties"/> instance.</returns>
        public static IPlaylistItem WithS3DProperties(this IPlaylistItem playlistItem, IS3DProperties s3DProperties)
        {
            playlistItem.S3DProperties = s3DProperties;
            return playlistItem;
        }

        /// <summary>
        /// Sets a new  <see cref="IS3DProperties"/> instance for <see cref="IPlaylistItem.S3DProperties"/> property of caller <see cref="IPlaylistItem"/> instance and executes the given <see cref="Action{IS3DProperties}"/> action on it.
        /// </summary>
        /// <param name="playerSettings">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="action"><see cref="Action{IS3DProperties}"/> to execute on new <see cref="IS3DProperties"/> instance.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="IPlaylistItem.S3DProperties"/> property setted to new <see cref="IS3DProperties"/> instance.</returns>
        public static IPlaylistItem WithS3DProperties(this IPlaylistItem playerSettings, Action<IS3DProperties> action)
        {
            playerSettings.S3DProperties = S3DProperties.Create();
            action(playerSettings.S3DProperties);
            return playerSettings;
        }

        /// <summary>
        /// Sets <see cref="IPlaylistItem.JumpToLive"/> property of caller <see cref="IPlaylistItem"/> instance  to true.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="IPlaylistItem.JumpToLive"/> property setted to true.</returns>
        public static IPlaylistItem WithJumpToLive(this IPlaylistItem playlistItem)
        {
            playlistItem.JumpToLive = true;
            return playlistItem;
        }

        /// <summary>
        /// Sets <see cref="IPlaylistItem.Title"/> property of caller <see cref="IPlaylistItem"/> instance to given <see cref="string"/> value.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="title">Given <see cref="string"/> value.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="IPlaylistItem.Title"/> property setted to given <see cref="string"/> value.</returns>
        public static IPlaylistItem WithTitle(this IPlaylistItem playlistItem, string title)
        {
            playlistItem.Title = title;
            return playlistItem;
        }

        /// <summary>
        /// Sets <see cref="IPlaylistItem.LiveDvrRequired"/> property of caller <see cref="IPlaylistItem"/> instance  to true.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="IPlaylistItem.LiveDvrRequired"/> property setted to true.</returns>
        public static IPlaylistItem WithLiveDvrRequired(this IPlaylistItem playlistItem)
        {
            playlistItem.LiveDvrRequired = true;
            return playlistItem;
        }

        /// <summary>
        /// Sets <see cref="IPlaylistItem.VideoStretchMode"/> property of caller <see cref="IPlaylistItem"/> instance to given <see cref="Stretch"/> value.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="videoStretchMode">Given <see cref="Stretch"/> value.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="IPlaylistItem.VideoStretchMode"/> property setted to given <see cref="Stretch"/> value.</returns>
        public static IPlaylistItem WithVideoStretchMode(this IPlaylistItem playlistItem, Stretch videoStretchMode)
        {
            playlistItem.VideoStretchMode = videoStretchMode;
            return playlistItem;
        }

        /// <summary>
        /// Sets <see cref="IPlaylistItem.Duration"/> property of caller <see cref="IPlaylistItem"/> instance to given <see cref="TimeSpan"/> value.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="duration">Given <see cref="TimeSpan"/> value.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="IPlaylistItem.Duration"/> property setted to given <see cref="TimeSpan"/> value.</returns>
        public static IPlaylistItem WithDuration(this IPlaylistItem playlistItem, TimeSpan duration)
        {
            playlistItem.Duration = duration;
            return playlistItem;
        }

        /// <summary>
        /// Sets <see cref="IPlaylistItem.StartPosition"/> property of caller <see cref="IPlaylistItem"/> instance to given <see cref="TimeSpan"/> value.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="startPosition">Given <see cref="TimeSpan"/> value.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="IPlaylistItem.StartPosition"/> property setted to given <see cref="TimeSpan"/> value.</returns>
        public static IPlaylistItem WithStartPosition(this IPlaylistItem playlistItem, TimeSpan startPosition)
        {
            playlistItem.StartPosition = startPosition;
            return playlistItem;
        }

        /// <summary>
        /// Adds a <see cref="IChapter"/> instance to <see cref="IPlaylistItem.Chapters"/> collection of caller <see cref="IPlaylistItem"/> instance.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="timelineMediaMarker"><see cref="IChapterFluent"/> instance to add.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with <see cref="IChapterFluent"/> instance added to <see cref="IPlaylistItem.Chapters"/> collection.</returns>
        public static IPlaylistItem WithChapters(this IPlaylistItem playlistItem, IChapter timelineMediaMarker)
        {
            playlistItem.Chapters.Add(timelineMediaMarker);
            return playlistItem;
        }

        /// <summary>
        /// Adds a new  <see cref="IChapter"/> instance for <see cref="IPlaylistItem.Chapters"/> property of caller <see cref="IChapter"/> instance and executes the given <see cref="Action{IChapter}"/> action on it.
        /// </summary>
        /// <param name="playlistItem">Caller <see cref="IPlaylistItem"/> instance.</param>
        /// <param name="action"><see cref="Action{IChapter}"/> to execute on new <see cref="IChapter"/> instance.</param>
        /// <returns>The caller <see cref="IPlaylistItem"/> instance with a new <see cref="IChapter"/> instance added to <see cref="IPlaylistItem.Chapters"/> collection property.</returns>
        public static IPlaylistItem WithChapters(this IPlaylistItem playlistItem, Action<IChapter> action)
        {
            var timelineMediaMarker = Chapter.Create();
            playlistItem.Chapters.Add(timelineMediaMarker);
            action(timelineMediaMarker);
            return playlistItem;
        }
    }
}