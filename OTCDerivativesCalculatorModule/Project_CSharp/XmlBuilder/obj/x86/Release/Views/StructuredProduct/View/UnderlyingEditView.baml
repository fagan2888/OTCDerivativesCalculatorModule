   M S B A M L   `   `   `  ����   
XmlBuilder@    :XmlBuilder.Views.StructuredProduct.View.UnderlyingEditView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  UnderlyingEditView��$	��500��$	��500��.��� .+���  �� Orientation$ Vertical=�.+��� $��- Underlying List��&   System.Windows.Controls.DataGrid  -     Name$ Underlying_DataGrid_��   AutoGenerateColumns .  ����  �� Path$ BaseIndexList_�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 Sym��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� $
 Sym_�  $
 Code�� �� $ Code_�  $
 Name�� �� $ Name_�  $
 Type�� �� $ Type_�  $ Description�� �� $ Description_��� $��- Data Information���� $ 
Horizontal=�.+��� $ Vertical=�.+��� -   $��DataTabControl_��$	��100��$	��200��.@��� -   $��Stock_TabItem��$��Stock��.��� .+��� -    ��Name$ stockListView_������ $ StockDataList_�	 �� View	 �� .P��� $
��Name��
 �� DisplayMemberBinding
 �� $ Name_��� -   $��Index_TabItem��$��Index��.��� .+�R� �� -   $��
IR_TabItem��$��IR��.��� .+�R� �� $ 
Horizontal=�.+��� -   $	��Add���� -   $��History��R� �� $ Vertical=�.+��� $ 
Horizontal=�.+��� $�� - Data���� -	    ��Name$ IsDataLoadCheckBox_��$��
IsDataLoad��  �� $ 
Horizontal=�.+��� $��	Status : ���� �� $ Vertical=��� $ 
Horizontal=�.+��� $��Confirm���� $��Cancel��