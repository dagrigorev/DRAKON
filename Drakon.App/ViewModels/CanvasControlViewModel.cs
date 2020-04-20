using System;
using System.CodeDom;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using Drakon.App.Input;
using Drakon.App.Views.Containers;
using Drakon.Core.Containers;
using Prism.Commands;
using Prism.Mvvm;

namespace Drakon.App.ViewModels
{
    /// <summary>
    /// Canvas control view model
    /// </summary>
    public class CanvasControlViewModel : BindableBase
    {
        private object _parent;
        private IDocumentContainer _selectedDocument;
        private ICommand _mouseDownCommand;
        private ICommand _mouseMoveCommand;
        private Point _mousePosition;
        private ICommand _renderCommand;
        private Canvas _renderCanvas;

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

        public ICommand RenderCommand
        {
            get => _renderCommand;
            set => SetProperty(ref _renderCommand, value);
        }

        public IDocumentContainer SelectedDocument
        {
            get => _selectedDocument;
            set => SetProperty(ref _selectedDocument, value);
        }

        public Canvas RenderCanvas
        {
            get => _renderCanvas;
            set => SetProperty(ref _renderCanvas, value);
        }

        public CanvasControlViewModel()
        {
            _selectedDocument = null;
            MouseDownCommand = new DelegateCommand<InputArgs>(HandleCanvasMouseDown);
            MouseMoveCommand = new DelegateCommand<InputArgs>(HandleCanvasMouseMove);
            RenderCommand = new DelegateCommand<Canvas>(HandleCanvasRender);
        }

        private void HandleCanvasMouseDown(InputArgs args)
        {
            if (args != null && Parent is CanvasControl control)
            {
                //Debug.WriteLine($"Clicked to {args.MousePosition}");
                // TODO: Pass commands to model

                control.SchemeCanvas.Children.Add(new Ellipse()
                {
                    Stroke = Brushes.Black,
                    Fill = Brushes.DarkBlue,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalAlignment = VerticalAlignment.Center,
                    StrokeThickness = 5,
                    Width = 50,
                    Height = 75
                });
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

        private void HandleCanvasRender(Canvas canvas)
        {
            Debug.WriteLine("Redraw called");

            canvas.Children.Add(new Ellipse()
            {
                Stroke = Brushes.Black,
                Fill = Brushes.DarkBlue,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Center,
                Width = 50,
                Height = 75,
                Clip = new EllipseGeometry(new Point(200, 200), 100, 100)
            });
        }
    }
}
