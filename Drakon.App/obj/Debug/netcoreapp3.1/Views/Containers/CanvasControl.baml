   M S B A M L   `   `   `  ����U  QSystem.Runtime, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem  5       
Drakon.App/   )Drakon.App.Views.Containers.CanvasControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      S OPrism.Wpf, Version=7.2.0.1422, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Y UPrism.Unity.Wpf, Version=7.2.0.1422, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      i	 eXceed.Wpf.AvalonDock.Themes.VS2010, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4[
 WXceed.Wpf.AvalonDock, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4h dXceed.Wpf.AvalonDock.Themes.Metro, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4g cXceed.Wpf.AvalonDock.Themes.Aero, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4=xcad,http://schemas.xceed.com/wpf/xaml/avalondock 	 
   5      ?system,clr-namespace:System;assembly=System.Runtime 	 
   5      -   5          >�Name$  SchemeRenderControl��5      !  Prism.Mvvm.ViewModelLocator   AutoWireViewModel$
 True��5
      .��5      �� -   5         ��Name$ 
CanvasRoot��5       � 	Resources 5   
      MyGridBrushResource j� Viewport j� ViewportUnits j� TileMode L� Drawing � Brush	 � Geometry
 �� Rect  MyGridBorderStyle �� Property �� Value��%K  &	        &	 c    7   L� 5      $ 	0,0,10,10�67   $ Absolute=�6L   $
 Tile=�6e    5      I� 5      .��5      � 
 �����	 5      �� 5   "   $
 0,0,1,1�64   5      � 5      +	 ��        �@B     �@B �� �    �� 	 �#A5A5A56M   � 5      +	 ��        �    @B Ѡ� @B Ѡ�     	 �#A5A5A56M   5      5      �� 5      .�5       ��  � ��8   66   �� 5!       � ��$ Center=�6I   �� 5"       � ��$	 Top=�6G   �� 5#       � ��
 �   �67   �� 5$       � ��$ 1q�6;   5%      5&      .+�5(   
   ��  � ContextMenu 5)      1 
 +Xceed.Wpf.AvalonDock.Controls.ContextMenuEx  5*      .@�5+      m� $��Place here...��6   m� 5,      $��Remove��6   m� 5-      $��Rotate 90 at right��6   5.      .+�51      �� #��[ 6   ._�52      �� -   5         ��Name$ SchemeCanvas��52      
������ ��53      �� *ActualWidth+ �� ElementName$ 
CanvasRoot����54      �� *ActualHeight+$ 
CanvasRoot�� 5:      �� 5;      -   5        $��CanvasContextMenu��5;   &   $y�Visible=�6?   5=      5@      5A      5B      5C      5D      