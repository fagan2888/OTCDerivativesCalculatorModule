   M S B A M L   `   `   `  ����  
XmlBuilder@    :XmlBuilder.Views.StructuredProduct.View.UnderlyingEditView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  UnderlyingEditView��5   	   $	��500��6$   $	��500��61   .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $��- Underlying List��6   &   System.Windows.Controls.DataGrid  5      -   5          Name$ Underlying_DataGrid_��5         AutoGenerateColumns .  ��65   ��  �� Path$ BaseIndexList_�   Columns 5	      0  *System.Windows.Controls.DataGridTextColumn  5
      ,  &System.Windows.Controls.DataGridColumn   Header$	 Sym��6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� $
 Sym_�6G     5      $
 Code��6H    6)   �� $ Code_�6H     5      $
 Name��6H    6)   �� $ Name_�6H     5      $
 Type��6H    6)   �� $ Type_�6H     5      $ Description��6O    6)   �� $ Description_�6O   5      �� 5      $��- Data Information��6   �� 5      $ 
Horizontal=�6   .+�5      �� $ Vertical=�6   .+�5      �� -   5        $��DataTabControl_��5   .   $	��100��6!   $	��200��6E   .@�5      �� -   5        $��Stock_TabItem��5   1   $��Stock��6"   .��5      � .+�5   "   �� -   5         ��Name$ stockListView_��5   +   ��6C   �� $ StockDataList_�	 �� View	 5   &   �� 5   *   .P�5   .   �� $
��Name��6=   
 �� DisplayMemberBinding
 6K   �� $ Name_�5   +   5   #   5      5       �� 5!      -   5        $��Index_TabItem��5!   1   $��Index��6"   .��5"      � .+�5#   "   R� 5%   #   5&      5'      �� 5(      -   5        $��
IR_TabItem��5(   .   $��IR��6"   .��5)      � .+�5*   "   R� 5,   #   5-      5.      5/      �� 50      $ 
Horizontal=�6!   .+�51      �� -   5        $	��Add��51   !   6/   �� 52      -   5        $��History��52   !   63   53      R� 54      56      57      �� 58      $ Vertical=�6   .+�59      �� $ 
Horizontal=�6!   .+�5:      �� $�� - Data��6    �� 5;      -	   5         ��Name$ IsDataLoadCheckBox_��5;   #   $��
IsDataLoad��6@   5<        5=      5>      �� 5?      $ 
Horizontal=�6!   .+�5@      �� $��	Status : ��6    �� 5A      5B      5C      �� 5D      $ Vertical=�6   5F      5G      �� 5H      $ 
Horizontal=�6   .+�5I      �� $��Confirm��6   �� 5J      $��Cancel��6   5K      5M      5P      5Q      