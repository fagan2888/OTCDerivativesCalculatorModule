   M S B A M L   `   `   `  ����  RiskMonitor'    !RiskMonitor.HedgePositionGridCtrl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      �� $
��Auto=�6   $��0q�66   $��0q�6J   .��5	   
   �� -   5          ��Name$  
LayoutRoot��5	      
�������$��5q�6<   .+�5
      �� -   5        $��50��5
      6!   �� 5      -   5         ��Name$ CountTxb��5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ 	dataGrid1��5      $	��400��6*      
IsReadOnly .    RowDetailsTemplate 5      �� 5      .R�5      �� 
��� � �$��5q�65   
�������._�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� .+�5   &   �� $ 
Horizontal=�61   .+�5   *   �� $��16(�64   
���p�$��0,0,10,0q�5   ,   $��Bottom=�6>   ��5   \   �� *Name+5   >   �� 5   *   $��12(�64   $��
Due Date: ��6B   $��Bottom=�6T   (  "System.Windows.Controls.DatePicker  5   *   $��Bottom=�6c      SelectedDate 65   �� *	DueDate+ �� Mode$ TwoWay=�6c   �� 5   *   $��12(�64   $��    Complete:��6B   $��Bottom=�6W   �� 5   *   $��Center=�5   /    d� 	IsChecked 5   3   �� *
Complete+$ TwoWay=�5   /   5   '   �� 5   &   $��12(�60   $��Notes: ��6>   �� 5   &   $��12(�6.   $	��420��6`   	 �� TextWrapping$
	 Wrap=�6l   ��6<   �� *Notes+$ TwoWay=�6l     5    &   $	��100��6/   
   AutoGenerateColumns
 .  ��6<   ��  �� Source$ LinkedInstruments_��5!   '   5#   #   5$      5%      5&      5)      5*      5+      5,      