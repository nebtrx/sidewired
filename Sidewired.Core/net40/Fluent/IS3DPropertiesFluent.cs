using Sidewired.Core.Domain;
using Sidewired.Core.Interfaces;

namespace Sidewired.Core.Fluent
{
    /// <summary>
    /// Fluent extension methods for <see cref="IS3DProperties"/> instances.
    /// </summary>
    public static class IS3DPropertiesFluent
    {
        /// <summary>
        /// Sets <see cref="IS3DProperties.S3DContent"/> property of caller <see cref="IS3DProperties"/> instance to given <see cref="S3DContents"/> value.
        /// </summary>
        /// <param name="s3DProperties">Caller <see cref="IS3DProperties"/> instance.</param>
        /// <param name="s3DContent">Given <see cref="S3DContents"/> value.</param>
        /// <returns>The caller <see cref="IS3DProperties"/> instance with <see cref="IS3DProperties.S3DContent"/> property setted to given <see cref="S3DContents"/> value.</returns>
        public static IS3DProperties WithS3DContent(this IS3DProperties s3DProperties, S3DContents s3DContent)
        {
            s3DProperties.S3DContent = s3DContent;
            return s3DProperties;
        }

        /// <summary>
        /// Sets <see cref="IS3DProperties.S3DEyePriority"/> property of caller <see cref="IS3DProperties"/> instance to given <see cref="S3DEyePriorities"/> value.
        /// </summary>
        /// <param name="s3DProperties">Caller <see cref="IS3DProperties"/> instance.</param>
        /// <param name="s3DEyePriority">Given <see cref="S3DEyePriorities"/> value.</param>
        /// <returns>The caller <see cref="IS3DProperties"/> instance with <see cref="IS3DProperties.S3DEyePriority"/> property setted to given <see cref="S3DEyePriorities"/> value.</returns>
        public static IS3DProperties WithS3DEyePriority(this IS3DProperties s3DProperties, S3DEyePriorities s3DEyePriority)
        {
            s3DProperties.S3DEyePriority = s3DEyePriority;
            return s3DProperties;
        }

        /// <summary>
        /// Sets <see cref="IS3DProperties.S3DFormat"/> property of caller <see cref="IS3DProperties"/> instance to given <see cref="S3DFormats"/> value.
        /// </summary>
        /// <param name="s3DProperties">Caller <see cref="IS3DProperties"/> instance.</param>
        /// <param name="s3DFormat">Given <see cref="S3DFormats"/> value.</param>
        /// <returns>The caller <see cref="IS3DProperties"/> instance with <see cref="IS3DProperties.S3DFormat"/> property setted to given <see cref="S3DFormats"/> value.</returns>
        public static IS3DProperties WithS3DFormat(this IS3DProperties s3DProperties, S3DFormats s3DFormat)
        {
            s3DProperties.S3DFormat = s3DFormat;
            return s3DProperties;
        }

        /// <summary>
        /// Sets <see cref="IS3DProperties.S3DLeftEyePAR"/> property of caller <see cref="IS3DProperties"/> instance to given <see cref="double"/> value.
        /// </summary>
        /// <param name="s3DProperties">Caller <see cref="IS3DProperties"/> instance.</param>
        /// <param name="s3DLeftEyePAR">Given <see cref="double"/> value.</param>
        /// <returns>The caller <see cref="IS3DProperties"/> instance with <see cref="IS3DProperties.S3DLeftEyePAR"/> property setted to given <see cref="double"/> value.</returns>
        public static IS3DProperties WithS3DLeftEyePAR(this IS3DProperties s3DProperties, double s3DLeftEyePAR)
        {
            s3DProperties.S3DLeftEyePAR = s3DLeftEyePAR;
            return s3DProperties;
        }

        /// <summary>
        /// Sets <see cref="IS3DProperties.S3DRightEyePAR"/> property of caller <see cref="IS3DProperties"/> instance to given <see cref="double"/> value.
        /// </summary>
        /// <param name="s3DProperties">Caller <see cref="IS3DProperties"/> instance.</param>
        /// <param name="s3DRightEyePAR">Given <see cref="double"/> value.</param>
        /// <returns>The caller <see cref="IS3DProperties"/> instance with <see cref="IS3DProperties.S3DRightEyePAR"/> property setted to given <see cref="double"/> value.</returns>
        public static IS3DProperties WithS3DRightEyePAR(this IS3DProperties s3DProperties, double s3DRightEyePAR)
        {
            s3DProperties.S3DRightEyePAR = s3DRightEyePAR;
            return s3DProperties;
        }

        /// <summary>
        /// Sets <see cref="IS3DProperties.S3DSubsamplingMode"/> property of caller <see cref="IS3DProperties"/> instance to given <see cref="S3DSubsamplingModes"/> value.
        /// </summary>
        /// <param name="s3DProperties">Caller <see cref="IS3DProperties"/> instance.</param>
        /// <param name="s3SubsamplingMode">Given <see cref="S3DSubsamplingModes"/> value.</param>
        /// <returns>The caller <see cref="IS3DProperties"/> instance with <see cref="IS3DProperties.S3DRightEyePAR"/> property setted to given <see cref="S3DSubsamplingModes"/> value.</returns>
        public static IS3DProperties WithS3DSubsamplingMode(this IS3DProperties s3DProperties, S3DSubsamplingModes s3SubsamplingMode)
        {
            s3DProperties.S3DSubsamplingMode = s3SubsamplingMode;
            return s3DProperties;
        }

        /// <summary>
        /// Sets <see cref="IS3DProperties.S3DSubsamplingOrder"/> property of caller <see cref="IS3DProperties"/> instance to given <see cref="S3DSubsamplingOrders"/> value.
        /// </summary>
        /// <param name="s3DProperties">Caller <see cref="IS3DProperties"/> instance.</param>
        /// <param name="s3SubsamplingOrder">Given <see cref="S3DSubsamplingOrders"/> value.</param>
        /// <returns>The caller <see cref="IS3DProperties"/> instance with <see cref="IS3DProperties.S3DRightEyePAR"/> property setted to given <see cref="S3DSubsamplingModes"/> value.</returns>
        public static IS3DProperties WithS3DSubsamplingOrder(this IS3DProperties s3DProperties, S3DSubsamplingOrders s3SubsamplingOrder)
        {
            s3DProperties.S3DSubsamplingOrder = s3SubsamplingOrder;
            return s3DProperties;
        }
    }
}