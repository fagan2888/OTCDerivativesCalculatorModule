   M S B A M L   `   `   `  ����   RiskMonitor'    !RiskMonitor.HedgePositionGridCtrl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .���� $
��Auto=�$��0q�$��0q�.���� -     ��Name$  
LayoutRoot��
�������$��5q�.+��� -   $��50���� -    ��Name$ CountTxb��&   System.Windows.Controls.DataGrid  -     Name$ 	dataGrid1��$	��400��   
IsReadOnly .    RowDetailsTemplate �� .R��� 
��� � �$��5q�
�������._���  �� Orientation$ 
Horizontal=�.+��� .+��� $ 
Horizontal=�.+��� $��16(�
���p�$��0,0,10,0q�$��Bottom=����� *Name+�� $��12(�$��
Due Date: ��$��Bottom=�(  "System.Windows.Controls.DatePicker  $��Bottom=�   SelectedDate �� *	DueDate+ �� Mode$ TwoWay=��� $��12(�$��    Complete:��$��Bottom=��� $��Center=� d� 	IsChecked �� *
Complete+$ TwoWay=��� $��12(�$��Notes: ���� $��12(�$	��420��	 �� TextWrapping$
	 Wrap=����� *Notes+$ TwoWay=�  $	��100��
   AutoGenerateColumns
 .  ����  �� Source$ LinkedInstruments_��