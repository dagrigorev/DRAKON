using System;
using System.Collections.Generic;
using Drakon.Core.Containers;

namespace Drakon.Core.Containers
{
    /// <summary>
    /// Project container contract
    /// </summary>
    public interface IProjectContainer : IDescripted
    {
        /// <summary>
        /// Project author
        /// </summary>
        string Author { get; set; }

        /// <summary>
        /// Project version
        /// </summary>
        Version Ver { get; set; }

        /// <summary>
        /// Documents collection
        /// </summary>
        IEnumerable<IDocumentContainer> Documents { get; set; }

        /// <summary>
        /// Current active document
        /// </summary>
        IDocumentContainer CurrentDocument { get; set; }
    }
}