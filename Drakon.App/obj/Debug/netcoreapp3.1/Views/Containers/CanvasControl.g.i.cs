﻿#pragma checksum "..\..\..\..\..\Views\Containers\CanvasControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30B4F274A6C104243F193686BFCFAD74DC785EF6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Prism.Interactivity;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Regions.Behaviors;
using Prism.Services.Dialogs;
using Prism.Unity;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Xceed.Wpf.AvalonDock;
using Xceed.Wpf.AvalonDock.Controls;
using Xceed.Wpf.AvalonDock.Converters;
using Xceed.Wpf.AvalonDock.Layout;
using Xceed.Wpf.AvalonDock.Themes;


namespace Drakon.App.Views.Containers {
    
    
    /// <summary>
    /// CanvasControl
    /// </summary>
    public partial class CanvasControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\Views\Containers\CanvasControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Drakon.App.Views.Containers.CanvasControl SchemeRenderControl;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\Views\Containers\CanvasControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel CanvasRoot;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\Views\Containers\CanvasControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas SchemeCanvas;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\..\Views\Containers\CanvasControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu CanvasContextMenu;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Drakon.App;component/views/containers/canvascontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Containers\CanvasControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SchemeRenderControl = ((Drakon.App.Views.Containers.CanvasControl)(target));
            return;
            case 2:
            this.CanvasRoot = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.SchemeCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 54 "..\..\..\..\..\Views\Containers\CanvasControl.xaml"
            this.SchemeCanvas.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SchemeCanvas_OnMouseDown);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\..\..\Views\Containers\CanvasControl.xaml"
            this.SchemeCanvas.MouseMove += new System.Windows.Input.MouseEventHandler(this.SchemeCanvas_OnMouseMove);
            
            #line default
            #line hidden
            
            #line 56 "..\..\..\..\..\Views\Containers\CanvasControl.xaml"
            this.SchemeCanvas.LayoutUpdated += new System.EventHandler(this.SchemeCanvas_OnLayoutUpdated);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CanvasContextMenu = ((System.Windows.Controls.ContextMenu)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
