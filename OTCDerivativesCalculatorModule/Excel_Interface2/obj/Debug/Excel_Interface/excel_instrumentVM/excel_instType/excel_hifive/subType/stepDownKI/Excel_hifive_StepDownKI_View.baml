   M S B A M L   `   `   `  ����  Excel_Interface22    ,Excel_Interface.Excel_hifive_StepDownKI_View   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � .+�5   
   ��   �� Orientation$  Vertical=�6   .+�5      �� $  
Horizontal=�6   .+�5      �� $  Vertical=�6   .+�5      �� -   5        $��GenInformationPanel_��5   !   $  
Horizontal=�6=   5      �� 5      $  
Horizontal=�6!   .+�5      �� $��
Maturity :��6    �� 5      $��30��6"   ��6-   ��  �� Path$ 	Maturity_�5      �� 5      $  
Horizontal=�6!   .+�5      �� $��
Calendar :��6    �� 5       -   5        $��calendarStr_��5    "   $	��100��66   �� 5!      -   5        $
��Edit��5!   !   60   5"      �� 5#      $  
Horizontal=�6!   .+�5$      �� $��Tenor :��6    �� 5%      $��30��6"   ��6-   �� $ CouponTenor_�5(      �� 5)      $  
Horizontal=�6!   .+�5*      �� $��Coupon :��6    �� 5+      $��30��6"   ��6-   �� $ Coupon_��� 5,      $��%��6    5-      �� 5.      $  
Horizontal=�6!   .+�5/      �� $
��KI :��6    �� 50      $��30��6"   ��6-   �� $	 Ki_��� 51      $��%��6    52      �� 53      $  
Horizontal=�6!   .+�54      �� $��	Observe :��6    (  "System.Windows.Controls.DatePicker  55      -   5        $��KiObStartDatePicker_��55   %   $	��100��6A      SelectedDate 6M   �� $ KiObStartDate_� �� Mode$ TwoWay=�   DisplayDate 56   1   �� $ KiObStartDate_�$ TwoWay=��� 57      $��~��6      58      -   5        $��KiObEndDatePicker_��58   %   $	��100��6?    6K   �� $ KiObEndDate_�$ TwoWay=� 59   1   �� $ KiObEndDate_�$ TwoWay=�5:      �� 5<      $  
Horizontal=�6!   .+�5=      �� $��Settlement Days :��6    �� 5>      $��30��6"   ��6-   �� $ SettlementDays_��� 5?      $��D��6    5@      5[      �� 5\      $  Vertical=�6   .+�5]      �� $  
Horizontal=�6!   .+�5^      �� $��Schedule��6    �� 5_      -   5        $��Setting��5_   !   $��50��63   6>   �� 5`      -   5        $��40��5`   !   $��build��6,   6<   5b      &   System.Windows.Controls.DataGrid  5d      -   5        $��ScheduleDataGrid_��5d         AutoGenerateColumns .  ��. $
��Auto=�5g   7   $
��Auto=�5h   7      Columns 5i      0  *System.Windows.Controls.DataGridTextColumn  5j      ,  &System.Windows.Controls.DataGridColumn   Header$
 Type��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� $ Type_�4  .System.Windows.Controls.DataGridTemplateColumn  5k      $ 	EventDate��65   	   CellTemplate	 5l   "   �� 5m   &   .R�5n   *   �� ��62   �� $ 
EventDate_�
 �� StringFormat$
 
yyyy-MM-dd��5o   '   5t        5u      $ 
Trigger(%)��61    6E   �� $ Trigger_�  5v      $ 	Coupon(%)��61    6D   �� $ Coupon_�5x      5y      5z      5|      5}      5~      