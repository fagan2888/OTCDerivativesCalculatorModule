   M S B A M L   `   `   `  ����  Excel_Interface2-    'Excel_Interface.OTCApplicationBatchView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � .+�5   
   ��   �� Orientation$  Vertical=�6   .+�5	      �� $  
Horizontal=�6   .+�5
      �� $��referenceDate :��6   (  "System.Windows.Controls.DatePicker  5      -   5        $��refDatePicker_��5         SelectedDate 63   ��  �� Path$ ReferenceDate_� �� Mode$ TwoWay=��� 5      -   5        $��loadBtn_��5      $
��load��6)   68   c� 5      .@�5      o� .@�5      m� $��_Execute��6#   .@�5      m� -   5        $��_parameter Build��5   '   6A   m� 5      -   5        $��
_calculate��5   '   6;   5      5      5      5      �� 5      $  
Horizontal=�6   .+�5      �� $  Vertical=�6   .+�5      	� $��Parameter exist��6"   5      �� 5      $  Vertical=�6   .+�5      �� $��Right=�6!   $  
Horizontal=�6=   .+�5      �� $��instrument List��6    �� 5       $��Center=�6#   $��Parellel excute ��6g    d� 	IsChecked 6>   �� $ ParallelFlag_�6g   �� 5!      $��- core Num :��6    �� 5"      $��30��6"    �� 
IsReadOnly . ��6?   �� $ AvailableCore_�5#      &   System.Windows.Controls.DataGrid  5&      -   5        $��batchItemDataGrid_��5&      $	��500��5'         AutoGenerateColumns .     
IsReadOnly . ��. $
��Auto=�5+      $
��Auto=�5,         RowStyle 5.      �� 5/      	 �� 
TargetType)  #System.Windows.Controls.DataGridRow"	  6$   .�50   "   -   5        51      
   Columns
 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$
 Code��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� $ 	ItemCode_�  55      $
 Name��61    6?   �� $ Name_�  56      $ 	Parameter��61    6D   �� $ ParameterStatus_�  57      $ Calculation��61    6F   �� $ CalculationStatus_�  58      $ Result��61    6A   �� $ ResultPrice_�5;      5<      5=      �� 5>      $  Vertical=�6   .+�5?      �� $	��Log��6   �� 5@      -   5        $��logTextBox_��5@      5A      5B      5C      5D      