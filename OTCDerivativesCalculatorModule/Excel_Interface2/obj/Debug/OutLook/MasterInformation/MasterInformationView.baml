   M S B A M L   `   `   `  ����K  GExcel_Interface2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Excel_InterfaceExcel_Interface  5      +    %Excel_Interface.MasterInformationView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,myclr-namespace:Excel_Interface     5      .��5      � .+�5	   
   ��   �� Orientation$  Vertical=�6   .+�5      �� $  
Horizontal=�6   .+�5      �� -   5        $��bindingPanel_��5      $  
Horizontal=�62   .+�5      �� $��Item_code : ��6   �� 5      $	��100��6?    �� 
IsReadOnly . 
���������6   ��  �� Path$ 
Item_code_�6]   5      �� 5      $  
Horizontal=�6   .+�5      �� $��Item_name : ��6   �� 5      -   5        $��item_nameTxb_��5      $	��100��6T   ��63   �� $ 
Item_name_�6T   5      �� 5      $  
Horizontal=�6   .+�5      �� $��
Booking : ��6   �� 5      $	��100��6B    . 
���������6   �� $ Booking_type_�6`   5      5      �� 5      $  
Horizontal=�6   .+�5      �� $  
Horizontal=�6   .+�5      �� $��Trade_ID : ��6   �� 5      $	��100��6>    . 
���������6   �� $ 	Trade_id_�6\   5      �� 5      $  
Horizontal=�6   .+�5      �� $��Trade_Status : ��6   �� 5       $	��100��6B    . 
���������6   �� $ Trade_status_�6`   5!      �� 5"      $  
Horizontal=�6   .+�5#      �� $��Instrument : ��6   �� 5$      $��Derivatives��6   $	��100��61    . 
�������6O   5%      5&      �� 5'      $  
Horizontal=�6   .+�5(      �� $  
Horizontal=�6   .+�5)      �� $��Notional : ��6   �� 5*      -   5        $��notionalTxb_��5*      $	��100��6R   ��62   �� $ 	Notional_�6^   �� 5+      -   5        $��currencyCombo_��5+       �� DisplayMemberPath$ CurrencyString_��5-      $��60��5.       �� SelectedIndex 5,      �� $ SelectedIndex_�5.   *   5/      �� 50      $  
Horizontal=�6   .+�51      �� $��Remain_notional : ��6   �� 52      -   5        $��remainNotionalTxb_��52      $	��100��6_   ��68   �� $ Remain_notional_�6_   53      54      �� 56      $  
Horizontal=�6   .+�58      �� $  
Horizontal=�6   .+�59      �� $��Trade_date : ��6   (  "System.Windows.Controls.DatePicker  5:      -   5        $��trade_datePicker_��5:   !      SelectedDate 6:   �� $ Trade_date_� �� Mode$ TwoWay=�5;      �� 5<      $  
Horizontal=�6   .+�5=      �� $��Maturity_date :��6     5>      -   5        $��maturityDatePicker_��5>   !   $	��100��6<    6H   �� $ Maturity_date_�$ TwoWay=�   DisplayDate 5?   -   �� $ MaturityDate_�$ TwoWay=��� 5@      -   5        $��
ymTextBox_��5@      $��30��60   6;   	� 5A      -	   5        $��M��5A   D   $��Center=�6P   $��Center=�6l   	� 5B      -
   5        $��Y��5B   D   $��Center=�6P   $��Center=�6l   5C      5E      �� 5G      $  
Horizontal=�6   .+�5J      �� $  
Horizontal=�6   .+�5K      �� $��Underlying : ��6   �� 5L      -   5        $��underlyingCombo_��5L      $ UnderlyingComboString_��5N      $��60��5O       5M      �� $ SelectedIndex_�5O      5Q      5V      �� 5W      $  
Horizontal=�6   .+�5X      �� $  
Horizontal=�6   .+�5Y      �� $��Contract : ��6   �� 5Z      -   5        $��contractCombo_��5Z      $ ContractComboString_��5\      $��60��5]       5[      �� $ SelectedIndex_�5]      5^      �� 5_      $  
Horizontal=�6   .+�5`      �� $��Contract_Sub : ��6   �� 5a      -   5        $��contractSubCombo_��5a      $ ContractSubComboString_��5c      $��60��5d       5b      �� $ SelectedIndex_�5d      5e      �� 5f      $  
Horizontal=�6   .+�5g      �� $��Contract_Detail : ��6   �� 5h      $	��100��6   �� 5i      -   5        $	��set��5i      6+   5j      5k      �� 5q      $  
Horizontal=�6   .+�5r      �� $  
Horizontal=�6   .+�5s      �� $��Counterparty : ��6   �� 5t      $	��100��6B   ��6   �� $ Counterparty_�6B   �� 5u      -   5        $
��edit��5u      6,   5v      �� 5w      $  
Horizontal=�6   .+�5x      �� $��Export_itemcode : ��6   �� 5y      $	��100��6E   ��6   �� $ Export_itemcode_�6E   �� 5z      -   5        $	��set��5z      6+   5{      5}      5�      5�      5�      