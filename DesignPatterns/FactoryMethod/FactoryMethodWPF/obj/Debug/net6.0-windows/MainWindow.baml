   M S B A M L   `   `   `  ����K  GFactoryMethodWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:FactoryMethodWPFFactoryMethodWPF  5   	   !    FactoryMethodWPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:FactoryMethodWPF     5   	   X TXceed.Wpf.Toolkit, Version=4.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   $	��500��65   $	��400��6D    � 	Resources 5         MyLabel �� 
TargetType �� Property �� Value  	MyTextBox��%�   &	        &	 p     �� 5   
   " ��6    .�5      ��  � ��$ Center=�62   �� 5       � ��$ 15(�6)   5      �� 5   
   " ��6"   .�5      ��  � ��$ 15(�6)   �� 5       � ��$ Center=�62   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   ]� $��0��6   .+�5      �� -   5         ��Name$ ProductsBox��5      $��5q�6+   $
��Left=�66   5      5       � 5"   
   $��1��6    � RowDefinitions 5#      �� 5$      $��50 �6    �� 5%      $��50 �6    �� 5&      $	��150 �6    �� 5'      �� 5(      $��30 �6    .+�5+      ]� $��0��6   .+�5,      �� $��Count��6   $
��Left=�6(   #��[  6>   �� 5-      -   5         ��Name$ Count��5-      $��Right=�6)   #��[ 6@   5.      ]� 50      $��1��6   .+�51      �� $
��Left=�6   .+�52      	� -   5        	 	�Name$	 	CashRadio��52   >   $
��Cash��6Q   $
��Left=�6`   	� 53      -   5        $	 	CardRadio��53   >   $��Credit Card��6Q   $��Right=�6g   	� 54      -   5        $	 Crypto��54   ;   $��Crypto��6K   $��Right=�6\   55      �� 56      -   5        $��CardAndCryptoBox��56      $��Right=�63   $��10q�6J   58      � 5:      $��2��6    5;      �� 5<      �� 5=       5@      �� 5A      $	��110 �6'   �� 5B      .+�5E      �� $��0��6   $��0��6%   $��Card Number:��65   #��[  6M   %  Xceed.Wpf.Toolkit.MaskedTextBox  5F      $
��Left=�6%   $��0��6@   $��1��6M   $��30��6]   $	��100��6i   $��5q�6u   
   Mask$
 0000 0000 0000 0000��6�   � 5H      $��1��6   $��2��6)   .+�5I      �� $��Year:��6   #��[  6-     5J      $��30��6*   $��50��66   $��5q�6A   $

 0000��6M   �� 5L      $
��CVV:��6   #��[  6,     5M      $��30��6*   $��50��66   $��5q�6A   $	
 000��6M   5N      5O      �� 5Q      -   5        $ ProductsForBuy��5Q      $��3��6.   5S      � 5U      $��4��6    5V      �� 5W      �� 5X      .+�5[      �� -   5         ��Name$ 	BuyButton��5[   A   $��0��61   $	��Buy��6T   �� 5\      -	   5        $ 	AddButton��5\   A   $��1��61   $	��Add��6T   5]      5_      5`      5c      