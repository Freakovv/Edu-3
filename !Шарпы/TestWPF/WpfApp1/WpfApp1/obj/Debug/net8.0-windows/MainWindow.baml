   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    WpfApp1   WpfApp1.MainWindow   5      6mah,http://metro.mahapps.com/winfx/xaml/controls   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  Sign in��5   	   $	��700��5   	   $	��800��5   	    � WindowStartupLocation$ CenterScreen=�5   	   ���#1E1E1E � 
ResizeMode$ NoResize=�5
   	   .��5      � .+�5   
   �� ���#2D2D2D �� CornerRadius$ 10��5      $	��330��5      $	��480��5      $��Center=�5      $��Center=�5      ._�5      �� $��20q�6   $��Center=�6%   .+�5      �� $��logo.png��6   $	��120��5      $��40��5      $��Center=�5      $��
0,0,110,20q�65   �� 5      $��Sign in with Google��6   $��Stretch=�5      $��Center=�5       $��10q�5!      $��0,0,0,10q�5"      ���#333333
����������#444444$��1q�5&      $��14(�5'      $��Medium"�5(       � Cursor$
 Hand��5)         MahApps.Styles.Button#��[  5*      ��5,      �� 5-       �� 
TargetType" ��6*   .R�5.      ��  ��Name$ border��6%   #��z��5/      #��z��50      #��z��51      $ 5��52      ._�53   "   ��  �� Orientation$ 
Horizontal=�6-   $��Center=�54      $��Center=�55      .+�56   &   �� #��z��60   $��Center=�57       �� 58   &   $,��&/WpfApp1;component/icons/google-48.png��6,   $��20��59   $   $��20��5:   $   $��5,0,0,0q�5;   $   5<   #   5=      5>      5@      � 5D      $��	0,10,0,10q�6    � ColumnDefinitions 5E      �� 5F      $��* �6+   �� 5G      $
��Auto �6+   �� 5H      $��* �6+   .+�5J      �� $��0��6   ���#444444		 �� X1$	 0��5L      	
 �� Y1$
 1��5M      	 �� X2$ 1��5N      	 �� Y2$ 1��5O       �� Stretch$
 Fill=�5P      $��Center=�5Q      �� 5R      $��1��6    $��OR��5S       ���#888888$
��10,0q�5U       $��Center=�5V       �� 5W      $��2��6   ���#444444$	 0��5Y      $
 1��5Z      $ 1��5[      $ 1��5\      $
 Fill=�5]      $��Center=�5^      5_      �� 5b      *   $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Email��6      ClearTextButton$
 True��5c      ���#333333
����������#444444$��1q�5g      $��10q�5h      $��14(�5i      $��0,0,0,10q�5j      G� 5m      $ Password��6   ���#333333
����������#444444$��1q�5q      $��10q�5r      $��14(�5s      $��0,0,0,10q�5t      �� 5w      $��Forgot your password?��6   ���#888888$��Right=�5y      $��0,0,0,10q�5z      $
 Hand��5{      $��12(�5|      ��5}      �� 5~       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value$
 None{�6@    �� Triggers 5�      P� 5�   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5�   &   ��  � ��$ 	Underline{�6H   5�   #   5�      5�      �� 5�      $��Sign in��6   $��Stretch=�5�      $��Center=�5�      $��10q�5�      ���	#FF0078D7
�������
������ $��1q�5�      $��14(�5�      $��Medium"�5�      $
 Hand��5�      '   !MahApps.Metro.Controls.ItemHelper   HoverBackgroundBrush
 � � �   SelectedBackgroundBrush
 � � �5�      �� 5�      ���#888888$��Center=�5�      $��0,10,0,0q�5�      $��12(�5�      
�5�      �� 5�      $�Sign up��6   ���	#FF0078D7 �� TextDecorations$ 	Underline{�5�       � Cursor$
 Hand��5�       �� 5�      $(�" if you don't have an account yet.��6   5�      5�      5�      5�      5�      