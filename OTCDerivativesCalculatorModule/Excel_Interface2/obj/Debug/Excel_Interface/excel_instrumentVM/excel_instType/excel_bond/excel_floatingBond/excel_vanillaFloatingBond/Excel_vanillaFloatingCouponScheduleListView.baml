   M S B A M L   `   `   `  ����  Excel_Interface2A    ;Excel_Interface.Excel_vanillaFloatingCouponScheduleListView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � .+�5   
   ��   �� Orientation$  Vertical=�6   .+�5	      �� $  
Horizontal=�6   .+�5
      �� $��schedule��6   �� 5      $
��Edit��6   5      &   System.Windows.Controls.DataGrid  5      -   5        $&�� vanillaFloatingScheduleDataGrid_��5         AutoGenerateColumns .  ��.    
IsReadOnly . $
��Auto=�5      $
��Auto=�5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   ��  �� Path$ 
EventDate_� �� StringFormat$ 
yyyy-MM-dd��  5      $
 Type��6)    67   �� $ DetailScheduleType_�4  .System.Windows.Controls.DataGridTemplateColumn  5      $ PaymentDate��6-      CellTemplate 5      �� 5      .R�5   "   (  "System.Windows.Controls.DatePicker  $��PaymentDate��6-   	   SelectedDate	 6@   �� $ PaymentDate_�
 �� Mode$
 TwoWay=�5      5        5      $ FloatingCoupon��6)    6A   �� $ Description_�  5       $ Description��6)    6>   �� $ Description_�5#      5$      5%      5&      