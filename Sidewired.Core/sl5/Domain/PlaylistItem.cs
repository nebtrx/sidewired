using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Sidewired.Core.Interfaces;
using Sidewired.Core.Utilities;

namespace Sidewired.Core.Domain
{
    /// <summary>
    /// <see cref="IPlaylistItem"/> implementation.
    /// </summary>
    public class PlaylistItem : StaticFactory<PlaylistItem>,IPlaylistItem
    {
        /// <summary>
        /// <see cref="PlaylistItem"/>'s parameterless constructor.
        /// </summary>
        public PlaylistItem()
        {
            TimelineMarkers = new List<ITimelineMediaMarker>();
            MarkerResources = new List<IMarkerResource>();
            InterstitialAdvertisements = new List<IAdvertisement>();
            Chapters = new List<IChapter>();
            VideoStretchMode = Stretch.Uniform;
        }

        /// <summary>
        /// Collection used to pass the relation of <see cref="ITimelineMediaMarker"/> target objects in TimelineMarkers property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public List<ITimelineMediaMarker> TimelineMarkers { get; set; }

        /// <summary>
        /// Collection used to pass the relation of <see cref="IChapter"/> target objects in TimelineMarkers property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public List<IChapter> Chapters { get; set; }

        /// <summary>
        /// Used to pass the MediaSource property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public Uri MediaSource { get; set; }

        /// <summary>
        /// Used to pass the DeliveryMethod property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        public DeliveryMethods DeliveryMethod { get; set; }

        /// <summary>
        /// Collection used to pass the relation of <see cref="IMarkerResource"/> target objects in MarkerResources property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public List<IMarkerResource> MarkerResources { get; set; }

        /// <summary>
        /// Collection used to pass the relation of <see cref="IAdvertisement"/> objects of TimelineMarkers property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public List<IAdvertisement> InterstitialAdvertisements { get; set; }

        /// <summary>
        /// Used to pass the <see cref="IAdvertisement"/> target object in PreRollAdvertisement property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public IAdvertisement PreRollAdvertisement { get; set; }

        /// <summary>
        /// Used to pass the <see cref="IAdvertisement"/> target object in PostRollAdvertisement property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public IAdvertisement PostRollAdvertisement { get; set; }

        /// <summary>
        /// Used to pass the ThumbSource property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public Uri ThumbSource { get; set; }

        /// <summary>
        /// Used to pass the S3DProperties property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public IS3DProperties S3DProperties { get; set; }

        /// <summary>
        /// Used to pass the JumpToLive property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        public bool JumpToLive { get; set; }

        /// <summary>
        /// Used to pass the Title property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Used to pass the VideoStretchMode property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        public Stretch VideoStretchMode { get; set; }

        /// <summary>
        /// Used to pass the LiveDvrRequired property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        public bool LiveDvrRequired { get; set; }

        /// <summary>
        /// Used to pass the StartPosition property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore] 
        public TimeSpan? StartPosition { get; set; }

        /// <summary>
        /// Used to pass the Duration property of playlist items to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public TimeSpan? Duration { get; set; }

        #region Serialization Purpose

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("MediaSource")]
        [JsonProperty("MediaSource")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string SvfMediaSource
        {
            get { return MediaSource.AsString(); }
            set { MediaSource = value.AsUri(); }
        }

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("ThumbSource")]
        [JsonProperty("ThumbSource")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string SvfThumbSource
        {
            get { return ThumbSource.AsString(); }
            set { ThumbSource = value.AsUri(); }
        }

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("PreRollAdvertisement")]
        [JsonProperty("PreRollAdvertisement")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Advertisement SvfPreRollAdvertisement
        {
            get { return PreRollAdvertisement as Advertisement; }
            set { PreRollAdvertisement = value; }
        }

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("PostRollAdvertisement")]
        [JsonProperty("PostRollAdvertisement")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Advertisement SvfPostRollAdvertisement
        {
            get { return PostRollAdvertisement as Advertisement; }
            set { PostRollAdvertisement = value; }
        }


        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("InterstitialAdvertisement")]
        [JsonProperty("InterstitialAdvertisements")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ObservableCollection<Advertisement> SvfInterstitialAdvertisements
        {
            get { return InterstitialAdvertisements.SerializableCollectionFor<IAdvertisement, Advertisement>(); }
        }

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("MarkerResource")]
        [JsonProperty("MarkerResources")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ObservableCollection<MarkerResource> SvfMarkerResources
        {
            get { return MarkerResources.SerializableCollectionFor<IMarkerResource, MarkerResource>(); }
        }

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("TimelineMediaMarker")]
        [JsonProperty("TimelineMarkers")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ObservableCollection<TimelineMediaMarker> SvfTimelineMarkers
        {
            get { return TimelineMarkers.SerializableCollectionFor<ITimelineMediaMarker, TimelineMediaMarker>(); }
        }

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("Chapter")]
        [JsonProperty("Chapters")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ObservableCollection<Chapter> SvfChapters
        {
            get { return Chapters.SerializableCollectionFor<IChapter, Chapter>(); }
        }


        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("S3DProperties")]
        [JsonProperty("S3DProperties")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public S3DProperties SvfS3DProperties
        {
            get { return S3DProperties as S3DProperties; }
            set { S3DProperties = value; }
        }

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("Duration")]
        [JsonProperty("Duration")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string SvfDuration
        {
            get { return Duration.AsString(); }
            set { Duration = value.AsTimeSpan(); }
        }

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("StartPosition")]
        [JsonProperty("StartPosition")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string SvfStartPosition
        {
            get { return StartPosition.AsString(); }
            set { StartPosition = value.AsTimeSpan(); }
        }

        #endregion
    }
}