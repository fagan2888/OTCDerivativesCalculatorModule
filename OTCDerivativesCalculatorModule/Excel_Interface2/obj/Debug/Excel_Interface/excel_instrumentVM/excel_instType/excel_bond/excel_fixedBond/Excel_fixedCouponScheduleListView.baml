   M S B A M L   `   `   `  ����  Excel_Interface27    1Excel_Interface.Excel_fixedCouponScheduleListView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � .+�5   
   ��   �� Orientation$  Vertical=�6   .+�5	      �� $  
Horizontal=�6   .+�5
      �� $��Fixed Rate :��6   �� 5      $��40��6    �� 
IsReadOnly . 6%   �� 5      $��%��6   5      &   System.Windows.Controls.DataGrid  5      -   5        $��fixedScheduleDataGrid_��5         AutoGenerateColumns .  ��.    
IsReadOnly . $
��Auto=�5      $
��Auto=�5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	EventDate��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   ��  �� Path$ 
EventDate_� �� StringFormat$ 
yyyy-MM-dd��4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Start��6-   	   CellTemplate	 5      �� 5      .R�5   "   (  "System.Windows.Controls.DatePicker  $��Start��6-   
   SelectedDate
 6:   �� $ CalculationStartDate_� �� Mode$ TwoWay=�5      5         5"      $	 End��6-   	 5#      �� 5$      .R�5%   "     $	��End��6-   
 68   �� $ CalculationEndDate_�$ TwoWay=�5&      5(        5*      $ PaymentDate��6-   	 5+      �� 5,      .R�5-   "     $��PaymentDate��6-   
 6@   �� $ PaymentDate_�$ TwoWay=�5.      50        52      $ FixedCoupon��6)    6>   �� $ Description_�56      57      58      59      