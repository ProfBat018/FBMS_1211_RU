   M S B A M L   `   `   `  ����E  AMVVM_Views, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVM_Views.ViewMVVM_Views.View  5          MVVM_Views.View.FirstView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVM_Views.View     5      
�������  � 	Resources  5       �� 
TargetType   	TestStyle �� Property �� Value��%x   &	        �� 5   
   " ��6   .�5      ��  � ��$ 30(�6)   �� 5       � ��
 �  ��6+   5      5/      .��52      �  � RowDefinitions 53   
   �� 54      $
��0.3* �6   �� 55      $
��0.3* �6   �� 56      $
��0.3* �6   �� 57      $
��0.3* �6   �� 58      $
��0.3* �6   �� 59      $
��0.3* �6   �� 5:      .+�5=   
   �� $��0��6   $��Currency by 1211��5>      $��Center=�5?      $��Center=�5@      $��20(�5A      $
��Bold"�5B      ]� 5D   
   $��1��6   .+�5F      �� $
��From��6   $
��Left=�5G      $��Center=�5H      $��60��5I      �� 5K       �� 
IsEditable$
 True��5L      $
��Left=�5M      $��5q�5N      ��5O      �� *AllCurrency+ �� SelectedIndex 5P      �� *SelectedItemFrom+5Q      5R      ]� 5T   
   $��2��6   .+�5U      �� $��To��5W      $
��Left=�5X      $��Center=�5Y      $��60��5Z      ��5V      �� *
LabelColor+5Z      �� 5\      $
 True��5]      $��Right=�5^      $��5q�5_      ��5`      �� *AllCurrency+ 5a      �� *SelectedItemTo+5b      ]� 5d   
   $��3��6   .+�5f      �� $
��Left=�6   $��Center=�5g      $��60��5h      $��Amount��5i      �� 5k      $��Right=�5m      $��5q�5n      ��5l      �� *Amount+ �� UpdateSourceTrigger$ PropertyChanged=�5n      5o      ]� 5q   
   $��4��6   .+�5s      �� $
��Left=�5t      $��Center=�5u      $��60��5v      $��Result��5w      �� 5y      $��Right=�5{      $��5q�5|      ��5z      �� *Result+5|      5}      �� 5   
   #��[  6   $��5q�64   $��5��6?   $��Convert��6L   �� 5�   
   $��5q�6   $��6��6   ��6*   �� *TestCollection+��5�      �� 5�      .R�5�      �� .+�5�      �� ��6    �� *Id+�� 5�      ��6    �� *Name+�� 5�      ��6#   �� *	IsMarried+5�      5�      5�      5�      5�      