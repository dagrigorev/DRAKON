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

namespace Drakon.App.Views.Containers
{
    /// <summary>
    /// Логика взаимодействия для OptionsControl.xaml
    /// </summary>
    public partial class OptionsControl : UserControl
    {
        public OptionsControl()
        {
            InitializeComponent();
        }

        private void OptionsPropertyGrid_OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
#if DEBUG
            Debug.WriteLine($"DataContextChanged for {sender.ToString()}");
#endif
        }
    }
}
