   M S B A M L   `   `   `  ����@  <Bravo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Bravo.View
Bravo.View  5      1clr-namespace:Bravo.ViewModelBravo.ViewModel  5          Bravo.View.HomeView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Bravo.View     5      3	ViewModelclr-namespace:Bravo.ViewModel     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��50      �  � RowDefinitions 51   
   �� 52      $
��0.1* �6   �� 53      .+�56   
   ��  �� 
IsEditable$
 True��57       �� SelectedItem 58      �� *
Selected+��59      �� *ProductsList+5:      � 5<   
   $��1��6    � ColumnDefinitions 5=      �� 5>      $
��0.5* �6#   �� 5?       5A      �� 5B      $��2* �6    �� 5C      �� 5D      �� 5E      $
��0.3* �6    .+�5H      �� $��0��6   $��0��6&   .+�5I      �� $��	0 15 0 15q�6   $��Center=�6/   ��6J   ��  �� Path$ Selected.Name� �� StringFormat$ 	Name: {0}���� 5J      $��	0 15 0 15q�6   $��Center=�6/   ��6J   �� $ Selected.Manufacturer�$ Manufacturer: {0}���� 5K      $��	0 15 0 15q�6   $��Center=�6/   ��6J   �� $ Selected.Price�$ 
Price: {0}��5L      �� 5N      $��1��5O      $��3��5P      ��5Q      �� 5R      .R�5S      �� 5U      5V      5X      �� 5Z      $��3��5\      $��0��5]      $��2��5^      
��� � ���5[      �� *
AddCommand+.��5`      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Approve=�6*   $��23��69   $��28��6E   5a      5b      5c      5e      