using System;
using System.ComponentModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Sidewired.Core.Interfaces;
using Sidewired.Core.Utilities;

namespace Sidewired.Core.Domain
{
    /// <summary>
    /// <see cref="ITimelineMediaMarker"/> implementation.
    /// </summary>
    public class TimelineMediaMarker : StaticFactory<TimelineMediaMarker>, ITimelineMediaMarker
    {
        /// <summary>
        /// <see cref="TimelineMediaMarker"/> parameterless constructor.
        /// </summary>
        public TimelineMediaMarker()
        {
            Id = Guid.NewGuid().ToString("N");
        }

        /// <summary>
        /// Used to pass the Id property of Marker objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Used to pass the Begin property of TimelineMediaMarker objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public TimeSpan Begin { get; set; }

        /// <summary>
        /// Used to pass the End property of TimelineMediaMarker objects to the Silverlight Media Player using Sidewired. 
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public TimeSpan End { get; set; }

        /// <summary>
        /// Used to pass the Content property of TimelineMediaMarker objects to the Silverlight Media Player using Sidewired.  
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Used to pass the AllowSeek property of TimelineMediaMarker objects to the Silverlight Media Player using Sidewired.  
        /// </summary>
        public bool AllowSeek { get; set; }

        #region Serialization Purpose
        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("Begin")]
        [JsonProperty("Begin")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string SvfBegin
        {
            get { return Begin.AsString(); }
            set { Begin = value.AsTimeSpan(); }
        }

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("End")]
        [JsonProperty("End")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string SvfEnd
        {
            get { return End.AsString(); }
            set { End = value.AsTimeSpan(); }
        } 
        #endregion
    }
}