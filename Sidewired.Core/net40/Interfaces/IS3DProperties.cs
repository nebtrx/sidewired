using Sidewired.Core.Domain;

namespace Sidewired.Core.Interfaces
{
    /// <summary>
    /// Operation contract of the target object used to pass S3DProperties objects in the initial settings to the Silverlight Media Player using Sidewired.
    /// </summary>
    public interface IS3DProperties
    {
        /// <summary>
        /// Used to pass the S3DContent property of playlist items' S3DProperties to the Silverlight Media Player using Sidewired.
        /// </summary>
        S3DContents S3DContent { get; set; }

        /// <summary>
        /// Used to pass the S3DEyePriority property of playlist items' S3DProperties to the Silverlight Media Player using Sidewired. 
        /// </summary>
        S3DEyePriorities S3DEyePriority { get; set; }

        /// <summary>
        /// Used to pass the S3DFormat property of playlist items' S3DProperties to the Silverlight Media Player using Sidewired. 
        /// </summary>
        S3DFormats S3DFormat { get; set; }

        /// <summary>
        /// Used to pass the S3DLeftEyePAR property of playlist items' S3DProperties to the Silverlight Media Player using Sidewired.  
        /// </summary>
        double S3DLeftEyePAR { get; set; }

        /// <summary>
        /// Used to pass the S3DRightEyePAR property of playlist items' S3DProperties to the Silverlight Media Player using Sidewired.  
        /// </summary>
        double S3DRightEyePAR { get; set; }

        /// <summary>
        /// Used to pass the S3DSubsamplingMode property of playlist items' S3DProperties to the Silverlight Media Player using Sidewired.  
        /// </summary>
        S3DSubsamplingModes S3DSubsamplingMode { get; set; }

        /// <summary>
        /// Used to pass the S3DSubsamplingOrder property of playlist items' S3DProperties to the Silverlight Media Player using Sidewired.  
        /// </summary>
        S3DSubsamplingOrders S3DSubsamplingOrder { get; set; }
    }
}
