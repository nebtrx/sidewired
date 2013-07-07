using System;
using Sidewired.Core.Domain;
using Sidewired.Core.Interfaces;

namespace Sidewired.Core.Fluent
{
    /// <summary>
    /// Fluent extension methods for <see cref="IPlayerSettings"/> instances.
    /// </summary>
    public static class IPlayerSettingsFluent
    {
        /// <summary>
        /// Sets <see cref="IPlayerSettings.AutoPlay"/> property of caller <see cref="IPlayerSettings"/> instance  to true.
        /// </summary>
        /// <param name="playerSettings">Caller <see cref="IPlayerSettings"/> instance.</param>
        /// <returns>The caller <see cref="IPlayerSettings"/> instance with <see cref="IPlayerSettings.AutoPlay"/> property setted to true.</returns>
        public static IPlayerSettings WithAutoPlay(this IPlayerSettings playerSettings)
        {
            playerSettings.AutoPlay = true;
            return playerSettings;
        }

        /// <summary>
        /// Sets <see cref="IPlayerSettings.EnableCachedComposition"/> property of caller <see cref="IPlayerSettings"/> instance  to true.
        /// </summary>
        /// <param name="playerSettings">Caller <see cref="IPlayerSettings"/> instance.</param>
        /// <returns>The caller <see cref="IPlayerSettings"/> instance with <see cref="IPlayerSettings.EnableCachedComposition"/> property setted to true.</returns>
        public static IPlayerSettings WithEnableCachedComposition(this IPlayerSettings playerSettings)
        {
            playerSettings.EnableCachedComposition = true;
            return playerSettings;
        }

        /// <summary>
        /// Sets <see cref="IPlayerSettings.CaptionsVisibility"/> property of caller <see cref="IPlayerSettings"/> instance to given <see cref="FeatureVisibility"/> value.
        /// </summary>
        /// <param name="playerSettings">Caller <see cref="IPlayerSettings"/> instance.</param>
        /// <param name="visibility">Given <see cref="FeatureVisibility"/> value.</param>
        /// <returns>The caller <see cref="IPlayerSettings"/> instance with <see cref="IPlayerSettings.CaptionsVisibility"/> property setted to given <see cref="FeatureVisibility"/> value.</returns>
        public static IPlayerSettings WithCaptionsVisibility(this IPlayerSettings playerSettings, FeatureVisibility visibility)
        {
            playerSettings.CaptionsVisibility = visibility;
            return playerSettings;
        }

        /// <summary>
        /// Sets <see cref="IPlayerSettings.StartMuted"/> property of caller <see cref="IPlayerSettings"/> instance to true.
        /// </summary>
        /// <param name="playerSettings">Caller <see cref="IPlayerSettings"/> instance.</param>
        /// <returns>The caller <see cref="IPlayerSettings"/> instance with <see cref="IPlayerSettings.StartMuted"/> property setted to true.</returns>
        public static IPlayerSettings WithStartMuted(this IPlayerSettings playerSettings)
        {
            playerSettings.StartMuted = true;
            return playerSettings;
        }

        /// <summary>
        /// Adds a <see cref="IPlaylistItem"/> instance to <see cref="IPlayerSettings.Playlist"/> collection of caller <see cref="IPlayerSettings"/> instance.
        /// </summary>
        /// <param name="playerSettings">Caller <see cref="IPlayerSettings"/> instance.</param>
        /// <param name="playlistItem"><see cref="IPlaylistItem"/> instance to add.</param>
        /// <returns>The caller <see cref="IPlayerSettings"/> instance with <see cref="IPlaylistItem"/> instance added to <see cref="IPlayerSettings.Playlist"/> collection.</returns>
        public static IPlayerSettings WithPlaylistItem(this IPlayerSettings playerSettings, IPlaylistItem playlistItem)
        {
            playerSettings.Playlist.Add(playlistItem);
            return playerSettings;
        }

        /// <summary>
        /// Adds a new  <see cref="IPlaylistItem"/> instance for <see cref="IPlayerSettings.Playlist"/> property of caller <see cref="IPlayerSettings"/> instance and executes the given <see cref="Action{IPlaylistItem}"/> action on it.
        /// </summary>
        /// <param name="playerSettings">Caller <see cref="IPlayerSettings"/> instance.</param>
        /// <param name="action"><see cref="Action{IPlaylistItem}"/> to execute on new <see cref="IPlaylistItem"/> instance.</param>
        /// <returns>The caller <see cref="IPlayerSettings"/> instance with a new <see cref="IPlaylistItem"/> instance added to <see cref="IPlayerSettings.Playlist"/> collection property.</returns>
        public static IPlayerSettings WithPlaylistItem(this IPlayerSettings playerSettings, Action<IPlaylistItem> action)
        {
            var playlisItem = PlaylistItem.Create();
            playerSettings.Playlist.Add(playlisItem);
            action(playlisItem);
            return playerSettings;
        }

        /// <summary>
        /// Sets <see cref="IPlayerSettings.IsControlStripVisible"/> property of caller <see cref="IPlayerSettings"/> instance  to false.
        /// </summary>
        /// <param name="playerSettings">Caller <see cref="IPlayerSettings"/> instance.</param>
        /// <returns>The caller <see cref="IPlayerSettings"/> instance with <see cref="IPlayerSettings.IsControlStripVisible"/> property setted to true.</returns>
        public static IPlayerSettings WithNoControlStrip(this IPlayerSettings playerSettings)
        {
            playerSettings.IsControlStripVisible = false;
            return playerSettings;
        }

        /// <summary>
        /// Sets <see cref="IPlayerSettings.ContinuousPlay"/> property of caller <see cref="IPlayerSettings"/> instance  to true.
        /// </summary>
        /// <param name="playerSettings">Caller <see cref="IPlayerSettings"/> instance.</param>
        /// <returns>The caller <see cref="IPlayerSettings"/> instance with <see cref="IPlayerSettings.ContinuousPlay"/> property setted to true.</returns>
        public static IPlayerSettings WithContinuousPlay(this IPlayerSettings playerSettings)
        {
            playerSettings.ContinuousPlay = true;
            return playerSettings;
        }

        /// <summary>
        /// Sets <see cref="IPlayerSettings.PlaylistVisibility"/> property of caller <see cref="IPlayerSettings"/> instance to given <see cref="FeatureVisibility"/> value.
        /// </summary>
        /// <param name="playerSettings">Caller <see cref="IPlayerSettings"/> instance.</param>
        /// <param name="visibility">Given <see cref="FeatureVisibility"/> value.</param>
        /// <returns>The caller <see cref="IPlayerSettings"/> instance with <see cref="IPlayerSettings.PlaylistVisibility"/> property setted to given <see cref="FeatureVisibility"/> value.</returns>
        public static IPlayerSettings WithPlaylistVisibility(this IPlayerSettings playerSettings, FeatureVisibility visibility)
        {
            playerSettings.PlaylistVisibility = visibility;
            return playerSettings;
        }

        /// <summary>
        /// Sets <see cref="IPlayerSettings.XamlThemeSource"/> property of caller <see cref="IPlayerSettings"/> instance to given <see cref="Uri"/> value.
        /// </summary>
        /// <param name="playerSettings">Caller <see cref="IPlayerSettings"/> instance.</param>
        /// <param name="xamlThemeSource">Given <see cref="Uri"/> value.</param>
        /// <returns>The caller <see cref="IPlayerSettings"/> instance with <see cref="IPlayerSettings.XamlThemeSource"/> property setted to given <see cref="Uri"/> value.</returns>
        public static IPlayerSettings WithSource(this IPlayerSettings playerSettings, Uri xamlThemeSource)
        {
            playerSettings.XamlThemeSource = xamlThemeSource;
            return playerSettings;
        }
    }
}
