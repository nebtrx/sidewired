using Sidewired.Core.Interfaces;
using Sidewired.Core.Utilities;

namespace Sidewired.Core.Domain
{
    /// <summary>
    /// <see cref="IPlaylistItem"/> implementation.
    /// </summary>
    public class S3DProperties : StaticFactory<S3DProperties>, IS3DProperties
    {
        /// <summary>
        /// <see cref="S3DProperties"/>' parameterless constructor.
        /// </summary>
        public S3DProperties()
        {
            S3DContent = S3DContents.Pair;
            S3DEyePriority = S3DEyePriorities.LeftFirst;
            S3DFormat = S3DFormats.SideBySide;
            S3DLeftEyePAR = 2.0;
            S3DRightEyePAR = 2.0;
        }

        #region Implementation of IS3DProperties

        /// <summary>
        /// Used to pass the S3DContent property of playlist items' S3DProperties to the Silverlight Media Player using Sidewired.
        /// </summary>
        public S3DContents S3DContent { get; set; }

        /// <summary>
        /// Used to pass the S3DEyePriority property of playlist items' S3DProperties to the Silverlight Media Player using Sidewired. 
        /// </summary>
        public S3DEyePriorities S3DEyePriority { get; set; }

        /// <summary>
        /// Used to pass the S3DFormat property of playlist items' S3DProperties to the Silverlight Media Player using Sidewired. 
        /// </summary>
        public S3DFormats S3DFormat { get; set; }

        /// <summary>
        /// Used to pass the S3DLeftEyePAR property of playlist items' S3DProperties to the Silverlight Media Player using Sidewired.  
        /// </summary>
        public double S3DLeftEyePAR { get; set; }

        /// <summary>
        /// Used to pass the S3DRightEyePAR property of playlist items' S3DProperties to the Silverlight Media Player using Sidewired.  
        /// </summary>
        public double S3DRightEyePAR { get; set; }

        /// <summary>
        /// Used to pass the S3DSubsamplingMode property of playlist items' S3DProperties to the Silverlight Media Player using Sidewired.  
        /// </summary>
        public S3DSubsamplingModes S3DSubsamplingMode { get; set; }

        /// <summary>
        /// Used to pass the S3DSubsamplingOrder property of playlist items' S3DProperties to the Silverlight Media Player using Sidewired.  
        /// </summary>
        public S3DSubsamplingOrders S3DSubsamplingOrder { get; set; }

        #endregion
    }
}
