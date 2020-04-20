using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Drakon.App.Input
{
    public class InputArgs
    {
        public Point MousePosition { get; set; }
        public MouseButtonState LeftButtonState { get; set; }
        public MouseButtonState MiddleButtonState { get; set; }
        public MouseButtonState RightButtonState { get; set; }

        public InputArgs()
        {
        }
    }
}
