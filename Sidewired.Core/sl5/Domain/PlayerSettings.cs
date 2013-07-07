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
    /// <see cref="IPlayerSettings"/> implementation.
    /// </summary>
    public class PlayerSettings : StaticFactory<PlayerSettings>, IPlayerSettings
    {
        /// <summary>
        /// <see cref="PlayerSettings"/>' parameterless constructor.
        /// </summary>
        public PlayerSettings()
        {
            Playlist = new List<IPlaylistItem>();
            IsControlStripVisible = true;
        }

        /// <summary>
        /// Collection used to pass the relation of <see cref="IPlaylistItem"/> target objects in Playlist property to the Silverlight Media Player using Sidewired.
        /// </summary> 
        [XmlIgnore]
        [JsonIgnore]
        public List<IPlaylistItem> Playlist { get; set; }

        /// <summary>
        /// Used to pass the AutoPlay property to the Silverlight Media Player using Sidewired.
        /// </summary>
        public bool AutoPlay { get; set; }

        /// <summary>
        /// Used to pass the EnableCachedComposition property to the Silverlight Media Player using Sidewired.
        /// </summary>
        public bool EnableCachedComposition { get; set; }

        /// <summary>
        /// Used to pass the CaptionsVisibility property to the Silverlight Media Player using Sidewired.
        /// </summary>
        public FeatureVisibility CaptionsVisibility { get; set; }

        /// <summary>
        /// Used to pass the StartMuted property to the Silverlight Media Player using Sidewired.
        /// </summary>
        public bool StartMuted { get; set; }

        /// <summary>
        /// Used to pass the IsControlStripVisible property to the Silverlight Media Player using Sidewired.
        /// </summary>
        public bool IsControlStripVisible { get; set; }

        /// <summary>
        /// Used to pass the IsControlStripVisible property to the Silverlight Media Player using Sidewired.
        /// </summary>
        public bool ContinuousPlay { get; set; }

        /// <summary>
        /// Used to pass the PlaylistVisibility property to the Silverlight Media Player using Sidewired.
        /// </summary>
        public FeatureVisibility PlaylistVisibility { get; set; }

        /// <summary>
        /// Used to pass the Xaml's Theme URI to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public Uri XamlThemeSource { get; set; }

        #region Serialization Purpose

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("PlaylistItem")]
        [JsonProperty("Playlist")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ObservableCollection<PlaylistItem> SvfPlaylist
        {
            get { return Playlist.SerializableCollectionFor<IPlaylistItem, PlaylistItem>(); }
        }

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("XamlThemeSource")]
        [JsonProperty("XamlThemeSource")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string SvfXamlThemeSource
        {
            get { return XamlThemeSource.AsString(); }
            set { XamlThemeSource = value.AsUri(); }
        }

	    #endregion
    }
}
