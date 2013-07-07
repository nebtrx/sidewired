using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Sidewired.Core.Interfaces;
using Sidewired.Core.Utilities;

namespace Sidewired.Core.Domain
{
    /// <summary>
    /// <see cref="IChapter"/> implementation.
    /// </summary>
    public class Chapter : StaticFactory<Chapter>, IChapter
    {
        /// <summary>
        /// <see cref="Chapter"/> parameterless constructor.
        /// </summary>
        public Chapter()
        {
            Id = Guid.NewGuid().ToString("N");
        }

        #region Implementation of IMarker

        /// <summary>
        /// Used to pass the Id property of Marker objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Used to pass the Begin property of Marker objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public TimeSpan Begin { get; set; }

        /// <summary>
        /// Used to pass the End property of Marker objects to the Silverlight Media Player using Sidewired. 
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public TimeSpan End { get; set; }

        /// <summary>
        /// Used to pass the Content property of Marker objects to the Silverlight Media Player using Sidewired.  
        /// </summary>
        public string Content { get; set; }

        #endregion

        #region Implementation of IChapter

        /// <summary>
        /// Used to pass the Title property of Chapter objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Used to pass the Description property of Chapter objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Used to pass the ThumbSource property of Chapter objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public Uri ThumbSource { get; set; }

        #endregion


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

        /// <summary>
        /// Do not use this. It's reserved for serialization intends. Intellisense should not be showing this property unless Resharper Intellisense Configuration prevents it or you are coding in the same solution's assembly.
        /// </summary>
        [XmlElement("ThumbSource")]
        [JsonProperty("ThumbSource")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string SvfThumbSource
        {
            get { return ThumbSource.AsString(); }
            set { ThumbSource = value.AsUri(); }
        }

        #endregion
    }
}
