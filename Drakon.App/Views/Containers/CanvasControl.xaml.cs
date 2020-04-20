using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Drakon.App.Input;
using Drakon.App.ViewModels;

namespace Drakon.App.Views.Containers
{
    /// <summary>
    /// Логика взаимодействия для CanvasControl.xaml
    /// </summary>
    public partial class CanvasControl : UserControl
    {
        public Point? MousePosition => (DataContext as CanvasControlViewModel)?.MousePosition;

        private ConverterMaster _converter;

        /// <summary>
        /// Default constructor.
        /// Initializes default converter pipe.
        /// </summary>
        public CanvasControl()
        {
            InitializeComponent();

            _converter = new ConverterMaster
            {
                Parent = this
            };

            ((CanvasControlViewModel) DataContext).Parent = this;
        }

        /// <summary>
        /// Invokes VM command
        /// </summary>
        /// <param name="args"></param>
        private void InvokeMouseDownCommad(object args)
        {
            if (DataContext is CanvasControlViewModel vm)
            {
                vm.MouseDownCommand.Execute(_converter.Convert(args));
            }
        }

        /// <summary>
        /// Invokes VM command
        /// </summary>
        /// <param name="args"></param>
        private void InvokeMouseMoveCommad(object args)
        {
            if (DataContext is CanvasControlViewModel vm)
            {
                vm.MouseMoveCommand.Execute(_converter.Convert(args));
            }
        }

        private void InvokeRenderCommand(Canvas canvas)
        {
        }

        /// <summary>
        /// Handles mouse down event in canvas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SchemeCanvas_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            InvokeMouseDownCommad(e);
        }

        private void SchemeCanvas_OnMouseMove(object sender, MouseEventArgs e)
        {
            InvokeMouseMoveCommad(e);
        }

        private void SchemeCanvas_OnLayoutUpdated(object? sender, EventArgs e)
        {
            InvokeRenderCommand(SchemeCanvas);
        }
    }
}
