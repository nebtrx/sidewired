using System;
using Sidewired.Core.Domain;
using Sidewired.Core.Interfaces;

namespace Sidewired.Core
{
    /// <summary>
    /// Primary static class to configure Sidewired.
    /// </summary>
    public class Sidewired
    {

        static Sidewired() { }

        /// <summary>
        /// Creates a new <see cref="IPlayerSettings"/> instance.
        /// </summary>
        /// <returns>New <see cref="IPlayerSettings"/> instance.</returns>
        public static IPlayerSettings CreatePlayerSettings()
        {
            return PlayerSettings.Create();
        }

        /// <summary>
        /// Creates a new <see cref="IPlayerSettings"/> instance and executes a given <see cref="Action{IPlayerSettings}"/> on it.
        /// </summary>
        /// <param name="action"><see cref="Action{IPlayerSettings}"/> to execute on new <see cref="IPlayerSettings"/> instance.</param>
        /// <returns>New <see cref="IPlayerSettings"/> instance.</returns>
        public static IPlayerSettings CreatePlayerSettingsWith(Action<IPlayerSettings> action)
        {
            IPlayerSettings playerSettings = CreatePlayerSettings();
            action(playerSettings);
            return playerSettings;
        }
    }
}
