using System;
using System.ComponentModel;
using System.Drawing;
using Drakon.Core.Common.ObservableBase;
using Drakon.Core.Editor;

namespace Drakon.Core.Default.Editor
{
    /// <summary>
    /// Editor options implementation
    /// </summary>
    public class EditorOptions : Observable, IEditorOptions
    {
        private string _defaultTitle;
        private Color _backgroundColor;

        [Category("Design")]
        [Description("Editor canvas background color.")]
        public Color BackgroundColor
        {
            get => _backgroundColor;
            set => SetProperty(ref _backgroundColor, value);
        }

        /// <summary>
        /// Application default title
        /// </summary>
        [Category("Design")]
        [Description("Editor's default title.")]
        public string DefaultTitle
        {
            get => _defaultTitle;
            set => SetProperty(ref _defaultTitle, value);
        }

        /// <summary>
        /// Default app version
        /// </summary>
        public Version DefaultProjectVersion { get; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public EditorOptions()
        {
            DefaultProjectVersion = Version.Parse("0.0.1");
            
            SetDefault();
        }

        public void SetDefault()
        {
            DefaultTitle = "DRAKON";
        }
    }
}