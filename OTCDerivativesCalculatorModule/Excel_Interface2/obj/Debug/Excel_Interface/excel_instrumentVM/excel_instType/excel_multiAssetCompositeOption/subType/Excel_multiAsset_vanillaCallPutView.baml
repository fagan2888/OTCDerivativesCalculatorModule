   M S B A M L   `   `   `  ����  Excel_Interface29    3Excel_Interface.Excel_multiAsset_vanillaCallPutView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � .+�5   
   ��   �� Orientation$  Vertical=�6   .+�5	      �� $+��%multi Asset vanilla Call / Put Option��6   �� 5
      -   5        $��
bindPanel_��5
      $  
Horizontal=�6+   .+�5      �� $��Call / Put : ��6   �� 5      -   5        $��callPutComboBox_��5      $��80��6[    �� SelectedItem 64   ��  �� Path$ CallPut_�6[   5      �� 5      $  
Horizontal=�6   .+�5      �� $��PartiRate : ��6   �� 5      $��60��6   ��6%   �� $ 
PartiRate_��� 5      $��%��6   �� 5      $��BaseCoupon : ��6   �� 5      $��60��6   ��6%   �� $ BaseCoupon_��� 5      $��%��6   5      �� 5      $  Vertical=�6   .+�5      �� $  
Horizontal=�6   .+�5      �� $��Return Check Calculation��6   �� 5      -   5        $��30��5      $	��Set��6(   66   5      �� 5      -   5        $$��returnUnderCalcDescriptionTxb_��5   ^   $	��200��6�   $
��Left=�6�   ��6   �� $3 -Excel_underlyingCalcIDViewModel_.Description_�6�   5!      �� 5#      $  
Horizontal=�6   .+�5$      �� $��	Strike : ��6   �� 5%      $��60��6   ��6%   �� $ Strike_��� 5&      $��%��6   �� 5'      $
��Atm ��6   �� 5(      $��Center=�6   5*      52      53      54      