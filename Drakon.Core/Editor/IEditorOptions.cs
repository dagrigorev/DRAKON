using System;
using System.ComponentModel;
using System.Drawing;
using Drakon.Core.Common.ObservableBase;

namespace Drakon.Core.Editor
{
    /// <summary>
    /// Editor options contract
    /// </summary>
    public interface IEditorOptions : IObservable
    {
        /// <summary>
        /// Background color
        /// </summary>
        [Category("Design")]
        [Description("Editor canvas background color.")]
        Color BackgroundColor { get; set; }

        /// <summary>
        /// Default title
        /// </summary>
        [Category("Design")]
        [Description("Editor's default title.")]
        string DefaultTitle { get; set; }

        /// <summary>
        /// Default version
        /// </summary>
        Version DefaultProjectVersion { get; }

        void SetDefault();
    }
}