using System;
using System.ComponentModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Sidewired.Core.Interfaces;
using Sidewired.Core.Utilities;

namespace Sidewired.Core.Domain
{
    /// <summary>
    /// <see cref="IMarkerResource"/> implmentation.
    /// </summary>
    public class MarkerResource : StaticFactory<MarkerResource>, IMarkerResource
    {
        /// <summary>
        /// Used to pass the Format property of MarkerResource objects the Silverlight Media Player using Sidewired. 
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Used to pass the PollingInterval property of MarkerResource objects the Silverlight Media Player using Sidewired. 
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public TimeSpan? PollingInterval { get; set; }

        /// <summary>
        /// Used to pass the Source property of MarkerResource objects the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public Uri Source { get; set; }

        #region Serialization Purpose

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("Source")]
        [JsonProperty("Source")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string SvfSource
        {
            get { return Source.AsString(); }
            set { Source = value.AsUri(); }
        }

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("PollingInterval")]
        [JsonProperty("PollingInterval")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string SvfPollingInterval
        {
            get { return PollingInterval.AsString(); }
            set { PollingInterval = value.AsTimeSpan(); }
        } 

        #endregion
        
    }
}