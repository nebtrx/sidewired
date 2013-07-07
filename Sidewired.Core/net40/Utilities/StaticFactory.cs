namespace Sidewired.Core.Utilities
{
    /// <summary>
    /// Allows to subclasses to create instances using a static constructor method.
    /// </summary>
    /// <typeparam name="T">Type.</typeparam>
    public class StaticFactory<T> where T : class, new()
    {
        /// <summary>
        /// Creates a new instance of <see cref="T"/>.
        /// </summary>
        /// <returns>A new instance of <see cref="T"/>.</returns>
        public static T Create()
        {
            return new T();
        }
    }
}
