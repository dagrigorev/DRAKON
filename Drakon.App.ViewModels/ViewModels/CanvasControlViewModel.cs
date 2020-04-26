using System;
using System.CodeDom;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Drakon.App.Input;
using Drakon.App.Renderers;
using Drakon.Core.Containers;
using Drakon.Core.Renderers;
using Prism.Commands;
using Prism.Mvvm;

namespace Drakon.App.ViewModels
{
    /// <summary>
    /// Canvas control view model
    /// </summary>
    public class CanvasControlViewModel : BindableBase
    {
        /// <summary>
        /// Default canvas size
        /// </summary>
        public readonly Size DefaultCanvasSize = new Size(2048, 1080);

        private object _parent;
        private IProjectContainer _currentProject;
        private ICommand _mouseDownCommand;
        private ICommand _mouseMoveCommand;
        private Point _mousePosition;
        private ICommand _renderCommand;
        private IImageRenderer _imageRenderer;
        private ImageSource _imageSource;

        /// <summary>
        /// Current frame
        /// </summary>
        public ImageSource Frame
        {
            get => _imageSource;
            set => SetProperty(ref _imageSource, value);
        }

        /// <summary>
        /// Renderer instance
        /// </summary>
        public IImageRenderer Renderer
        {
            get => _imageRenderer;
            set => SetProperty(ref _imageRenderer, value);
        }

        /// <summary>
        /// Parent object
        /// </summary>
        public object Parent
        {
            get => _parent;
            set => SetProperty(ref _parent, value);
        }

        /// <summary>
        /// Current mouse position
        /// </summary>
        public Point MousePosition
        {
            get => _mousePosition;
            set => SetProperty(ref _mousePosition, value);
        }

        public ICommand MouseDownCommand
        {
            get => _mouseDownCommand;
            set => SetProperty(ref _mouseDownCommand, value);
        }

        public ICommand MouseMoveCommand
        {
            get => _mouseMoveCommand;
            set => SetProperty(ref _mouseMoveCommand, value);
        }

        public IProjectContainer CurrentProject
        {
            get => _currentProject;
            set => SetProperty(ref _currentProject, value);
        }

        /// <summary>
        /// Default constructors. Calls by prism view model locator.
        /// </summary>
        public CanvasControlViewModel()
        {
            _currentProject = null;
            MouseDownCommand = new DelegateCommand<InputArgs>(HandleCanvasMouseDown);
            MouseMoveCommand = new DelegateCommand<InputArgs>(HandleCanvasMouseMove);
            Renderer = new SkiaImageRenderer();

            Frame = Renderer.CreateImage((int)DefaultCanvasSize.Width, (int)DefaultCanvasSize.Height);
            CompositionTarget.Rendering += (o, e) => Renderer.UpdateImage(Frame as WriteableBitmap);
        }

        /// <summary>
        /// Register renderer is sequence
        /// </summary>
        /// <param name="renderer"></param>
        public void RegisterRenderer(IRenderer renderer)
        {
            _imageRenderer.AddRenderAction(canvas =>
            {
                if (renderer.Enabled)
                {
                    renderer.Render(_imageRenderer.Canvas, CurrentProject);
                }
            });
        }

        private void HandleCanvasMouseDown(InputArgs args)
        {
            if (args != null && Parent is UserControl control)
            {
                //Debug.WriteLine($"Clicked to {args.MousePosition}");
                // TODO: Pass commands to model
            }
        }

        private void HandleCanvasMouseMove(InputArgs args)
        {
            if (args != null)
            {
                //Debug.WriteLine($"Moved to {args.MousePosition}");
                // TODO: Pass commands to model
                MousePosition = args.MousePosition;
            }
        }
    }
}
