using System;
using System.Collections.Generic;
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

namespace Drakon.App.Views.Containers
{
    /// <summary>
    /// Логика взаимодействия для ToolsControl.xaml
    /// </summary>
    public partial class ToolsControl : UserControl
    {
        public ToolsControl()
        {
            InitializeComponent();
        }

        private void ToolsControl_OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            // TODO: Debug vm here
        }
    }
}
