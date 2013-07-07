using System;
using System.Collections.Generic;
using Sidewired.Core.Domain;

namespace Sidewired.Core.Interfaces
{
    /// <summary>
    /// Operation contract of the target object used to pass the player settings to the Silverlight Media Player using Sidewired.
    /// </summary>
    public interface IPlayerSettings
    {
        /// <summary>
        /// Collection used to pass the relation of <see cref="IPlaylistItem"/> target objects in Playlist property to the Silverlight Media Player using Sidewired.
        /// </summary> 
        List<IPlaylistItem> Playlist { get; set; }

        /// <summary>
        /// Used to pass the AutoPlay property to the Silverlight Media Player using Sidewired.
        /// </summary>
        bool AutoPlay { get; set; }

        /// <summary>
        /// Used to pass the EnableCachedComposition property to the Silverlight Media Player using Sidewired.
        /// </summary>
        bool EnableCachedComposition { get; set; }

        /// <summary>
        /// Used to pass the CaptionsVisibility property to the Silverlight Media Player using Sidewired.
        /// </summary>
        FeatureVisibility CaptionsVisibility { get; set; }

        /// <summary>
        /// Used to pass the StartMuted property to the Silverlight Media Player using Sidewired.
        /// </summary>
        bool StartMuted { get; set; }

        /// <summary>
        /// Used to pass the IsControlStripVisible property to the Silverlight Media Player using Sidewired.
        /// </summary>
        bool IsControlStripVisible { get; set; }

        /// <summary>
        /// Used to pass the IsControlStripVisible property to the Silverlight Media Player using Sidewired.
        /// </summary>
        bool ContinuousPlay { get; set; }

        /// <summary>
        /// Used to pass the PlaylistVisibility property to the Silverlight Media Player using Sidewired.
        /// </summary>
        FeatureVisibility PlaylistVisibility { get; set; }

        /// <summary>
        /// Used to pass the Xaml's Theme URI to the Silverlight Media Player using Sidewired.
        /// </summary>
        Uri XamlThemeSource { get; set; }
    }
}