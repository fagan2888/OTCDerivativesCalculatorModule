   M S B A M L   `   `   `  ����  Excel_Interface2/    )Excel_Interface.Excel_referenceLoaderView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � .+�5   
   ��   �� Orientation$  Vertical=�6   .+�5	      �� $��- Reference��6   &   System.Windows.Controls.DataGrid  5
      -   5        $��ReferenceDataGrid_��5
         AutoGenerateColumns .  ��. $
��Auto=�5         
IsReadOnly . $
��Auto=�5         RowStyle 5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5      -   5        5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ EntityId��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   ��  �� Path$ 	EntityId_�  5      $ 
EntityName��6)    6=   �� $ EntityName_�5      �� 5      $  
Horizontal=�6   .+�5      �� -   5        $��Surmit��5      6*   �� 5      -   5        $��Cancel��5      6*   5      5       5!      5"      