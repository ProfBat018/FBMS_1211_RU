   M S B A M L   `   `   `  ����G  CBestTodoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BestTodoListBestTodoList  5   	       BestTodoList.Main   5   	   6c1/http://schemas.componentone.com/winfx/2006/xaml  W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BestTodoList     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$
  Main��5	   	   $	��300��6   $	��500��6#   $	��200��6/   $	��300��6?    � 
ResizeMode$ 	CanResize=�6N   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��1��6   $��5��6'    �� ShowsPreview$ False��61   $��Center=�5      $��Stretch=�6    � 5   
   $��0��6    � RowDefinitions 5      �� 5      $
��0.3* �6    �� 5      $
��0.5* �6    �� 5      $
��0.3* �6    �� 5      $
��0.3* �6    �� 5      .+�5      ]� $��0��6   .+�5      �� $
��Left=�6   $��Name:��6.   $��75��6>   $��Center=�6I   $��16(�6d   $
��Bold"�6r   �� 5       -   5         ��Name$ NametextBox��5    .    �� TextWrapping$
 Wrap=�6   $��Right=�6C   5!      ]� 5#      $��1��6   .+�5$      �� $
��Left=�6   $��Info:��6.   $��75��6>   $��Center=�6I   $��16(�6d   $
��Bold"�6r   �� 5%      -   5        $
��Info��5%   .   $
 Wrap=�6   $��Right=�6:   5&      ]� 5(      $��2��6   .+�5)      (  "System.Windows.Controls.DatePicker  -   5        $��
DatePicker��5)      $	��175��6/   $
��Left=�6;      FirstDayOfWeek$ Monday=�6Q      IsTodayHighlighted$
 True��6i   �� 5*      -   5        $��TimeBox��5*      $��Right=�6*   5+      ]� 5-      $��3��6   .+�5.      	� 	 d� 	IsChecked$
	 TrueY�6   $
��Left=�6/   $��	Important��6E   $
��Left=�6Y   $��30 0 0 0q�6t   	� 5/      $��Right=�6   $��Not important��65   $��Right=�6M   $��0 0 30 0q�6i   50      �� 52      -   5        $��4��52      $	��ADD��6"   $��24(�60   $
��Bold"�6>   6P   53      �� 54   
   $��2��6   55      56      57      