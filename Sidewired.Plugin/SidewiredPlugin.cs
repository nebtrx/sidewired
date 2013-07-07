using System;
using System.ComponentModel.Composition;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Markup;
using Microsoft.SilverlightMediaFramework.Plugins;
using Microsoft.SilverlightMediaFramework.Plugins.Metadata;
using Microsoft.SilverlightMediaFramework.Plugins.Primitives;
using Microsoft.SilverlightMediaFramework.Utilities.Extensions;

namespace Sidewired.Plugin
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [ExportGenericPlugin(PluginName = PluginName, PluginDescription = PluginDescription, PluginVersion = PluginVersion)]
    public class SidewiredPlugin : IGenericPlugin
    {
        private const string PluginName = "SidewiredPlugin";
        private const string PluginDescription = "Loads player settings from a higly descriptive formatted XML string defined in the init params and bypass to it.";
        private const string PluginVersion = "1.0";

        private Microsoft.SilverlightMediaFramework.Core.SMFPlayer _player;

        #region Implementation of IPlugin

        /// <summary>
        /// Loads the plug-in.
        /// </summary>
        public void Load()
        {
            if (!IsLoaded)
            {
                LoadPlayerSettings();
                IsLoaded = true;
                PluginLoaded.IfNotNull(i => i(this));
            }
        }

        private void LoadPlayerSettings()
        {
            SettingsAdapter.ApplyInitialSettingsToPlayer(Application.Current.Host.InitParams, _player);
            UpdatePlayerTheme();
        }

        private void UpdatePlayerTheme()
        {
            Uri xamlThemeSource;
            if (XamlThemeLoader.TryGetPlayerXamlThemeSource(Application.Current.Host.InitParams, out xamlThemeSource))
            {
                ApplyXamlThemeToPlayer(xamlThemeSource);
            }
        }

        private void ApplyXamlThemeToPlayer(Uri xamlThemeSource)
        {
            xamlThemeSource.IfNotNull(uri =>
            {
                WebClient wc = new WebClient();
                wc.DownloadStringCompleted += delegate(object sender, DownloadStringCompletedEventArgs args)
                {
                    var themeResourceDictionary = XamlReader.Load(args.Result) as ResourceDictionary;
                    themeResourceDictionary.IfNotNull(dictionary =>
                    {
                        // It isn't to keep track of applied themes
                        // there is a slow propability this becomes a memory leak troble in future
                        Application.Current.Resources.MergedDictionaries.Add(dictionary);
                        _player.Style = (Style)Application.Current.Resources.MergedDictionaries.LastOrDefault()["PlayerStyle"];
                    });
                };
                wc.DownloadStringAsync(uri, uri);
            });

        }

        /// <summary>
        /// Unloads the plug-in.
        /// </summary>
        public void Unload()
        {
            IsLoaded = false;
            PluginUnloaded.IfNotNull(i => i(this));
        }

        /// <summary>
        /// Gets a value indicating whether a plug-in is currently loaded.
        /// </summary>
        public bool IsLoaded { get; private set; }

        public event Action<IPlugin, LogEntry> LogReady;
        public event Action<IPlugin> PluginLoaded;
        public event Action<IPlugin> PluginUnloaded;
        public event Action<IPlugin, Exception> PluginLoadFailed;
        public event Action<IPlugin, Exception> PluginUnloadFailed;

        #endregion

        #region Implementation of IPlayerConsumer

        /// <summary>
        /// Passes a reference to the Player
        /// </summary>
        /// <param name="Player">A reference to the Player</param>
        public void SetPlayer(FrameworkElement Player)
        {
            _player = Player as Microsoft.SilverlightMediaFramework.Core.SMFPlayer;
            Load();
        }

        #endregion
    }

}
