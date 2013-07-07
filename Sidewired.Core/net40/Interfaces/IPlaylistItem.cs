using System;
using System.Collections.Generic;
using Sidewired.Core.Domain;

namespace Sidewired.Core.Interfaces
{
    /// <summary>
    /// Operation contract of the target object used to pass playlist items in the initial settings to the Silverlight Media Player using Sidewired.
    /// </summary>
    public interface IPlaylistItem
    {
        /// <summary>
        /// Collection used to pass the relation of <see cref="ITimelineMediaMarker"/> target objects in TimelineMarkers property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        List<ITimelineMediaMarker> TimelineMarkers { get; set; }

        /// <summary>
        /// Collection used to pass the relation of <see cref="IChapter"/> target objects in TimelineMarkers property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        List<IChapter> Chapters { get; set; }

        /// <summary>
        /// Used to pass the MediaSource property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        Uri MediaSource { get; set; }

        /// <summary>
        /// Used to pass the DeliveryMethod property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        DeliveryMethods DeliveryMethod { get; set; }

        /// <summary>
        /// Collection used to pass the relation of <see cref="IMarkerResource"/> target objects in MarkerResources property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        List<IMarkerResource> MarkerResources { get; set; }

        /// <summary>
        /// Collection used to pass the relation of <see cref="IAdvertisement"/> objects of TimelineMarkers property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        List<IAdvertisement> InterstitialAdvertisements { get; set; }
        
        /// <summary>
        /// Used to pass the <see cref="IAdvertisement"/> target object in PreRollAdvertisement property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        IAdvertisement PreRollAdvertisement { get; set; }

        /// <summary>
        /// Used to pass the <see cref="IAdvertisement"/> target object in PostRollAdvertisement property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        IAdvertisement PostRollAdvertisement { get; set; }

        /// <summary>
        /// Used to pass the ThumbSource property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        Uri ThumbSource { get; set; }

        /// <summary>
        /// Used to pass the S3DProperties property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        IS3DProperties S3DProperties { get; set; }

        /// <summary>
        /// Used to pass the JumpToLive property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        bool JumpToLive { get; set; }

        /// <summary>
        /// Used to pass the Title property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Used to pass the VideoStretchMode property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        Stretch VideoStretchMode { get; set; }

        /// <summary>
        /// Used to pass the LiveDvrRequired property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        bool LiveDvrRequired { get; set; }

        /// <summary>
        /// Used to pass the StartPosition property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        TimeSpan? StartPosition { get; set; }

        /// <summary>
        /// Used to pass the Duration property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        TimeSpan? Duration { get; set; }
    }
}