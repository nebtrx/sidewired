using System;
using System.Threading;
using Sidewired.Core.Interfaces;

namespace Sidewired.Core
{
    /// <summary>
    /// Primary static class to configure Sidewired.
    /// </summary>
    public class Sidewired
    {
        private static readonly Lazy<ThreadLocal<IPlayerSettings>> _implicitPlayerSettings = new Lazy<ThreadLocal<IPlayerSettings>>(() => new ThreadLocal<IPlayerSettings>(CreatePlayerSettings), LazyThreadSafetyMode.PublicationOnly);

        static Sidewired(){}

        /// <summary>
        /// Creates a new <see cref="IPlayerSettings"/> instance.
        /// </summary>
        /// <returns>New <see cref="IPlayerSettings"/> instance.</returns>
        public static IPlayerSettings CreatePlayerSettings()
        {
            return Domain.PlayerSettings.Create();
        }

        /// <summary>
        /// Creates a new <see cref="IPlayerSettings"/> instance and executes a given <see cref="Action{IPlayerSettings}"/> on it.
        /// </summary>
        /// <param name="action"><see cref="Action{IPlayerSettings}"/> to execute on new <see cref="IPlayerSettings"/> instance.</param>
        /// <returns>New <see cref="IPlayerSettings"/> instance.</returns>
        public static IPlayerSettings CreatePlayerSettingsWith(Action<IPlayerSettings> action )
        {
            IPlayerSettings playerSettings = CreatePlayerSettings();
            action(playerSettings);
            return playerSettings;
        }

        /// <summary>
        /// Gets the <see cref="IPlayerSettings"/> implicitly defined using method <see cref="WirePlayerSettings"/>.
        /// </summary>
        public static IPlayerSettings PlayerSettings
        {
            get { return _implicitPlayerSettings.Value.Value; }
        }


        /// <summary>
        /// Defines the implicit <see cref="IPlayerSettings"/> by executing a given <see cref="Action{IPlayerSettings}"/> on a static field.
        /// </summary>
        /// <param name="action"><see cref="Action{IPlayerSettings}"/> to execute on implicit <see cref="IPlayerSettings"/> instance.</param>
        public static void WirePlayerSettings(Action<IPlayerSettings> action)
        {
            action(_implicitPlayerSettings.Value.Value);
        }
    }
}
