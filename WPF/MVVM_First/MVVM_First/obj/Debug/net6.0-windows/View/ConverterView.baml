   M S B A M L   `   `   `  ����E  AMVVM_First, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVM_First.ViewMVVM_First.View  5   	   #    MVVM_First.View.ConverterView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MVVM_First.View     5   	   -   5          �Name$  	Converter��5	   	    � Title$ ConverterView��5   	   $	��400��6   $	��450��6,   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $
��0.3* �6   �� 5      $
��0.3* �6   �� 5      $
��0.3* �6   �� 5      $
��0.3* �6   �� 5      $
��0.3* �6   �� 5      .+�5   
   �� $��0��6   $��Currency by 1211��5      $��Center=�5      $��Center=�5      $��20(�5      $
��Bold"�5      ]� 5   
   $��1��6   .+�5      �� $
��From��6   $
��Left=�5       $��Center=�5!      $��60��5"      �� 5$       �� 
IsEditable$
 True��5%      $
��Left=�5&      $��5q�5'      ��5(      �� *AllCurrency+ �� SelectedIndex 5)      �� *SelectedItemFrom+5*      5+      ]� 5-   
   $��2��6   .+�5.      �� $��To��50      $
��Left=�51      $��Center=�52      $��60��53      ��5/      �� *
LabelColor+53      �� 55      $
 True��56      $��Right=�57      $��5q�58      ��59      �� *AllCurrency+ 5:      �� *SelectedItemTo+5;      ]� 5=   
   $��3��6   .+�5?      �� $
��Left=�6   $��Center=�5@      $��60��5A      $��Amount��5B      �� 5D      $��Right=�5F      $��5q�5G      ��5E      �� *Amount+5G      5H      ]� 5J   
   $��4��6   .+�5L      �� $
��Left=�6   $��Center=�5M      $��60��5N      $��Result��5O      �� 5Q      $��Right=�5S      $��5q�5T      ��5R      �� *Result+5T      5U      �� 5W   
   $��5q�64   $��5��6?   $��Convert��6L   ��6   �� *ConvertCommand+6L   �� 5Y   
   $��5q�6   $��6��6   ��6*   �� *TestCollection+��5Z      �� 5[      .R�5\      �� ��6!   �� *DataContext.Color+ �� ElementName$ 	Converter��.+�5]      �� ��6    �� *Id+�� 5^      ��6    �� *Name+�� 5_      ��6#   �� *	IsMarried+5`      5a      5c      5d      5e      