   M S B A M L   `   `   `  ����U  QSystem.Runtime, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem  5   	    
Drakon.App!   Drakon.App.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   S OPrism.Wpf, Version=7.2.0.1422, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Y UPrism.Unity.Wpf, Version=7.2.0.1422, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5   	   X	 TXceed.Wpf.Toolkit, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit 	 5   	   i
 eXceed.Wpf.AvalonDock.Themes.VS2010, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4[ WXceed.Wpf.AvalonDock, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4h dXceed.Wpf.AvalonDock.Themes.Metro, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4g cXceed.Wpf.AvalonDock.Themes.Aero, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4=xcad,http://schemas.xceed.com/wpf/xaml/avalondock 
    5   	   ?system,clr-namespace:System;assembly=System.Runtime 
    5   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel$
  True��5   	   $	��350��5	   !   $	��525��6.    � Title 6	   �� *Title+ J� InputBindings 5
      �� 5      
 �� Key$ N��6    �� 	Modifiers$ Controlf�6    �� Command 6-   �� *NewFileCommand+6R   �� 5      $ O��6   $ Controlf�6    6-   �� *OpenFileCommand+6S   �� 5      $ S��6   $ Controlf�6    6-   �� *SaveFileCommand+6S   �� 5      $ Q��6   $ Controlf�6    6-   �� *ExitCommand+6O    � 	Resources 5         	FileImage H� Drawing I� ClipGeometry	 � Brush
 � Geometry  	OpenImage  
AboutImage I� Opacity �� RadiusX �� RadiusY �� Rect @� RadiusX @� RadiusY @� Center  QuestionsImage��%8	  &	        &	 I    &	 q    &	 �    H� 5       5      I� 5   
   4 ��        �     l�� l� l�� l�    �        	.��5      � 	 �	#FF90CAF9O
 �� l� l��        � Zb@��� Zb@��� z @��� z ��- р����- � Zb@]� 6.   � 5      	 �	#FFE1F5FE=
 �� l� l��        �vK��� ѠvK��� �@����� �@�� �D 6.   5      5      H� 5       5      I� 5   
   4 ��        �     l�� l� l�� l�    �        	.��5      � 	 �	#FFFFA000�
 �� l� l��        ���C � р�O � р� z � z  z �@�X  z  	= @��  	=  � � 	=  Q%� 	= ��F@�X  Zb z  Zb��S Zb�`m Zb�ހ��N�ހ@�4рހ $� Ӏހ@�� @ge � ��C � 6.   � 5      	 �	#FFFFCA28�
 �� l� l��        �����Ѡu� ����w� �� �� @(@�  E� z  Zb� �] Zb� �z Zb���@�L�H�`�/� n��_Z�@���5`�������6.   5      5!      H� 5#       5$      I� 5%   
   4 ��        �     l�� l� l�� l�    �        	.��5&      � 	 �	#FF2196F3�
 �� l� l��        �@�4 Zb��ا  Zb�@KL ���@KL  � �@KL `��  ~u ��[ �ا ��[ �@�4��[ ���f��[ � �`�� � � � �� ����� � '9��f Zb@�4 Zb6.   I� 5'      $ 1Q�6   .��5(      � 	 �	#FFFFFFFF
 5)      �� 5*      $ 0Q�6$   $ 0Q�60   $ 
22,20,4,11�6<   5,      � 5-      	 �	#FFFFFFFF
 5.      @� 5/      $ 2Q�6"   $ 2Q�6.   $ 24,15&�6:   51      52      53      55      H� 57       58      I� 59   
   4 ��        �     l�� l� l�� l�    �        	.��5:      � 	 �	#FF42A5F5O
 �� l� l��        � Q% c�� Q% c�� z  c�� z  z � ?� z � Q% $� 6.   � 5;      	 �	#FF90CAF9O
 �� l� l��        � Zb Zb� Zb Zb� �  Zb� �  	= � H� 	= � Zb � 6.   � 5<      	 �	#FFE1F5FE=
 �� l� l��        �vK@]� ѠvK@]� ���@]� ���`�S 6.   � 5=      	 �	#FF1976D2�
 �� l� l��        � �u�ү� �u�h�Ŭ`�l�Ŭ��AӠŬ�G7`����! A���!Ӡ�o��! 6n�T: 6n@o@� E@o@� E��5 �I Y  A� Y ��q� Y ����G7�����AӀ���]w�����~����Y�� �u�Y����r�:����r�-���r`W�@��`W�� 
�`W�����-�����:�S��������@@`��������@@@��������@@S �u������@@��r�����@@��r�:�6.   5>      5@      5A      .��5B      �  � RowDefinitions 5C      �� 5D      $��30 �6   $��30��6"   63   �� 5E      $��* �6   6#   �� 5F      $��30 �6   $��30��6"   63   .+�5H      o� $	��Top=�6   $��2,5,2,5q�6#   $��0��64   $��30��6A   $��30��6M   .@�5I      m� $
��File��6   .@�5J   
   m� $	��New��6   $��2,5,2,5q�6C    m� Command 6    �� *NewFileCommand+ m� Icon 5K      �� 5L      #��[  6   $��Stretch=�68   $��Stretch=�6T   5N      m� 5O   
   $
��Open��6   $��2,5,2,5q�6E    6!   �� *OpenFileCommand+ 5P      �� 5Q      #��[ 6   $��Stretch=�68   $��Stretch=�6T   5S      m� 5T   
   $
��Save��6   $��2,5,2,5q�6E    6!   �� *SaveFileCommand+6E   �� 5U   
   m� 5V   
   $
��Exit��6   $��2,5,2,5q�6A    6!   �� *ExitCommand+6A   5W   	   m� 5X      $
��Help��6   .@�5Y   
   m� $��Documentation��6   $��2,5,2,5q�6*    5Z      �� 5[      #��[ 6   $��Stretch=�6=   $��Stretch=�6Y   5]      m� 5^   
   $��About��6   $��2,5,2,5q�6"    5_      �� 5`      #��[ 6   $��Stretch=�69   $��Stretch=�6U   5b      5c   	   5d      )  #Xceed.Wpf.AvalonDock.DockingManager  5e      $��1��6      AllowMixedOrientation$
 True��5f      
���   �$��1q�5h         DocumentHeaderTemplate 5i      �� 5j   
   .R�5k      ��  �� Orientation$ 
Horizontal=�6   .+�5l      �� ��6   �� *Title+5m      5n         Layout. 5p      ,  &Xceed.Wpf.AvalonDock.Layout.LayoutRoot  -   5        _layoutRoot��   	RootPanel. 5q   
   -  'Xceed.Wpf.AvalonDock.Layout.LayoutPanel     Orientation$ 
Horizontal=�6   �  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.ILayoutPanelElement, Xceed.Wpf.AvalonDock, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]   Children. 5r      6  0Xceed.Wpf.AvalonDock.Layout.LayoutAnchorablePane  �  �Xceed.Wpf.AvalonDock.Layout.LayoutPositionableGroup`1[[Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable, Xceed.Wpf.AvalonDock, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]   	DockWidth$	 200 �6&   �  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable, Xceed.Wpf.AvalonDock, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]   Children. 5s      2	  ,Xceed.Wpf.AvalonDock.Layout.LayoutAnchorable	  /
  )Xceed.Wpf.AvalonDock.Layout.LayoutContent 
  	ContentId$ 
properties��6$    
  Title$ 
Properties��6;     	  CanHide$  False��6N   ! 
  CanClose$! False��6^   " 	  AutoHideWidth$	" 240Q�5t   '   # 
  Content.# 5u      1 	 +Xceed.Wpf.Toolkit.PropertyGrid.PropertyGrid  $   NameColumnWidth$	$ 110Q�6"   %   SelectedObject% 5v      �� & �� ElementName$& _layoutRoot��' �� Path$!' LastFocusedDocument.Content�5w      5x      9  3Xceed.Wpf.AvalonDock.Layout.LayoutDocumentPaneGroup  5y      �  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.ILayoutDocumentPane, Xceed.Wpf.AvalonDock, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]](   Children.( 5z      4  .Xceed.Wpf.AvalonDock.Layout.LayoutDocumentPane  �  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.LayoutContent, Xceed.Wpf.AvalonDock, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]])   Children.) 5{      0  *Xceed.Wpf.AvalonDock.Layout.LayoutDocument  $ 	document1��6$   $ 
Document 1��6:   * 
  
IconSource#* [  6M   .# 5|      �� $��Document 1 Content��6   $��Center=�66   $��Center=�6S   5}        5~      $ 	document2��6$   $ 
Document 2��6:   #* [  6M   .# 5      �� $��Document 2 Content��6   + �� AcceptsReturn$
+ True��64   5�      5�      5�      ;  5Xceed.Wpf.AvalonDock.Layout.LayoutAnchorablePaneGroup  5�      �  �Xceed.Wpf.AvalonDock.Layout.LayoutPositionableGroup`1[[Xceed.Wpf.AvalonDock.Layout.ILayoutAnchorablePane, Xceed.Wpf.AvalonDock, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]],   	DockWidth$	, 125 �6+   �  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.ILayoutAnchorablePane, Xceed.Wpf.AvalonDock, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]-   Children.- 5�        . 5�      	  $ alarms��6&   $ Alarms��69   .# 5�      �� .@�5�      ��Alarm 1��6+   ��5�      Alarm 2��6+   ��5�      Alarm 3��6+   5�      5�      	  5�      $ journal��6&   $ Journal��6:   .# 5�      �� . �5�      /� .T�5�      J� $��14(�6    $��Segoe)�6.   .*�6A   .*�5�      *(This is the content of the Journal Pane.�� A �� 5�      .�6   RichTextBox6*    has been added here5�      5�      5�      5�      5�      5�      5�      .   LeftSide. 5�   
   2  ,Xceed.Wpf.AvalonDock.Layout.LayoutAnchorSide  5�      �  �Xceed.Wpf.AvalonDock.Layout.LayoutGroup`1[[Xceed.Wpf.AvalonDock.Layout.LayoutAnchorGroup, Xceed.Wpf.AvalonDock, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4]]/   Children./ 5�      3  -Xceed.Wpf.AvalonDock.Layout.LayoutAnchorGroup  . 5�      	  $ Agenda��6&   $ agenda��65   .# 5�      �� $��Agenda Content��6   $��10q�62   $��18(�6>   $��Black"�6L   $
��Wrap=�6_   5�      	  5�      $ Contacts��6&   $ contacts��67   .# 5�      �� $��Contacts Content��6   $��10q�64   $��18(�6@   $��Black"�6N   $
��Wrap=�6a   5�      5�      5�      5�   	   5�      �� 5�      $��2��6   .@�5�      �� .��5�   
   �� $��Sample status label��6   5�   	   5�      5�      5�      