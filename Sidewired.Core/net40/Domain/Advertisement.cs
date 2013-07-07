using System;
using System.ComponentModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Sidewired.Core.Interfaces;
using Sidewired.Core.Utilities;

namespace Sidewired.Core.Domain
{
    /// <summary>
    /// <see cref="IAdvertisement"/> implementation.
    /// </summary>
    public class Advertisement : StaticFactory<Advertisement>, IAdvertisement
    {
        /// <summary>
        /// <see cref="Advertisement"/> parameterless constructor
        /// </summary>
        public Advertisement()
        {
            PauseTimeline = true;
        }

        /// <summary>
        /// Used to pass the AdSource property of Advertisement objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public Uri AdSource { get; set; }

        /// <summary>
        /// Used to pass the DeliveryMethod property of Advertisement objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        public DeliveryMethods DeliveryMethod { get; set; }

        /// <summary>
        /// Used to pass the Duration property of Advertisement objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public TimeSpan? Duration { get; set; }

        /// <summary>
        /// Used to pass the PauseTimeline property of Advertisement objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        public bool PauseTimeline { get; set; }

        /// <summary>
        /// Used to pass the StartTime property of Advertisement objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public TimeSpan? StartTime { get; set; }

        /// <summary>
        /// Used to pass the ClickThrough property of Advertisement objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public Uri ClickThrough { get; set; }

        /// <summary>
        /// Used to pass the IsLinearClip property of Advertisement objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        public bool IsLinearClip { get; set; }

        #region Serialization Purpose

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("AdSource")]
        [JsonProperty("AdSource")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string SvfAdSource
        {
            get { return AdSource.AsString(); }
            set { AdSource = value.AsUri(); }
        } 

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("Duration")]
        [JsonProperty("Duration")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string SvfDuration
        {
            get { return Duration.AsString(); }
            set { Duration = value.AsTimeSpan(); }
        }

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("StartTime")]
        [JsonProperty("StartTime")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string SvfStartTime
        {
            get { return StartTime.AsString(); }
            set { StartTime = value.AsTimeSpan(); }
        }

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("ClickThrough")]
        [JsonProperty("ClickThrough")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string SvfClickThrough
        {
            get { return ClickThrough.AsString(); }
            set
            {
                ClickThrough = value.AsUri();
            }
        }
        
        #endregion
    }
}