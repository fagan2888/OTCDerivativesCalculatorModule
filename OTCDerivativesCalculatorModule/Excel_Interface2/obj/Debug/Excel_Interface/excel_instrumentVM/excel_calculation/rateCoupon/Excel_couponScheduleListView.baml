   M S B A M L   `   `   `  ����  Excel_Interface22    ,Excel_Interface.Excel_couponScheduleListView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � .+�5   
   ��   �� Orientation$  Vertical=�6   .+�5	      �� $  
Horizontal=�6   .+�5
      �� $��
- Schedule��6   �� 5      -   5        $��frequencyComboBox_��5   &   $��80��6   6&   �� 5      $	��Add��6   �� 5      $
��edit��6   5      &   System.Windows.Controls.DataGrid  5      -   5        $��CouponScheduleDataGrid_��5         AutoGenerateColumns .  ��. $
��Auto=�5      $
��Auto=�5         
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	EventDate��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   ��  �� Path$ 
EventDate_� �� StringFormat$ 
yyyy-MM-dd��4  .System.Windows.Controls.DataGridTemplateColumn  5      $ CalStartDate��6-      CellTemplate 5      �� 5      .R�5   "   (  "System.Windows.Controls.DatePicker  $��CalStartDate��6-   	   SelectedDate	 6A   �� $ CalculationStartDate_�
 �� Mode$
 TwoWay=�5      5        5       $ 
CalEndDate��6-    5!      �� 5"      .R�5#   "     $��
CalEndDate��6-   	 6?   �� $ CalculationEndDate_�$
 TwoWay=�5$      5&        5(      $ 
PayoffDate��6)    6=   �� $ PayoffDate_�$ 
yyyy-MM-dd��  5*      $
 Type��6-    5+      �� 5,      .R�5-   "   �� -   5        ��5-   )   �� $ Type_�6H   5.      50        51      $ Description��6)    6>   �� $ Description_�53      54      55      56      