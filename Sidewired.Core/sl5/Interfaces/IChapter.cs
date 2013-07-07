using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sidewired.Core.Interfaces
{
    /// <summary>
    /// Operation contract of the target object used to pass Chapter objects in the initial settings to the Silverlight Media Player using Sidewired.
    /// </summary>
    public interface IChapter: IMarker
    {
        /// <summary>
        /// Used to pass the Title property of Chapter objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Used to pass the Description property of Chapter objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Used to pass the ThumbSource property of Chapter objects to the Silverlight Media Player using Sidewired.
        /// </summary>
        Uri ThumbSource { get; set; }
    }
}
