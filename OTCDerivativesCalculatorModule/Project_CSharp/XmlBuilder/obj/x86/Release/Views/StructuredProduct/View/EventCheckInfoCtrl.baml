   M S B A M L   `   `   `  ���� E  AXmlBuilder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:XmlBuilder.Views.StructuredProduct.View'XmlBuilder.Views.StructuredProduct.View  @    :XmlBuilder.Views.StructuredProduct.View.EventCheckInfoCtrl   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Dmy5clr-namespace:XmlBuilder.Views.StructuredProduct.View     .��� .+���   �� Orientation$  Vertical=�.+��� $  
Horizontal=�.+�� -    �Name$ EventCheck_Grid��.+��� $  Vertical=�.+��� $��- EventCheck List��&   System.Windows.Controls.DataGrid  -     Name$ EventCheck_DataGrid��   AutoGenerateColumns .  ����  �� Path$ EventCheckViewModel_�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 Sym��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� $
 Num_�  $	 Sym�� �� $ Symbol_�  $
 Name�� �� $ Name_�  $
 Type�� �� $ Type_�  $
 Date�� �� $ Date_�  $ Expired�� �� $ Expired_��� � -   $ EventCheck_DetailGrid��.+��� $  Vertical=�.+�� -   $# EventIndexTransformation_Grid�� � DataContext �� $ EITFVM_�.+��� $  Vertical=�.+��� $  
Horizontal=�.+��� $ ��- EventIndexTransformation���� -   $
��Edit��  -   $ IndexTrans_DataGrid�� .  ���� $ IndexTransVMList_�   $	 Sym�� �� $ Symbol_�  $
 Type�� �� $ Type_�  $ Description�� �� $ Description_�� -   $ FunctionEventGrid�� �� $ FunctionEventVM_�.+��� $  Vertical=�.+��� $  
Horizontal=�.+��� $��- FunctionEvent���� $��- JointType : ���� ���� $ 
JointType_�   .  ���� $ EventFunctionMList_�   $ 	EventName�� �� $ 
EventName_�  $ 	EventType�� �� $ 
EventType_�  $	 Low�� �� $
 Low_�  $ IndexSymbol�� �� $ IndexSymbol_�  $
 High�� �� $ High_�  $ TF�� �� $	 TF_�� -   $ EventDateGrid�� �� $ EventDateVM_�.+��� $  Vertical=�.+��� $  
Horizontal=�.+��� $��- EventDate���� $��	- Type : ���� 	 �� Text$
	 qwqd��   .  ���� $ EventDates_�   $
 Date�� �� $
 Date�  $ 	DayOfWeek�� �� $ 	DayOfWeek�  $ Remain�� �� $ 	DayOfYear�� -	   $ 
PayoffGrid�� �� $ PayoffListVM_�.+��� $  Vertical=�.+��� $  
Horizontal=�.+��� $��- Payoff���� -
   $
��Edit��   .  ���� $ PayoffVMList_�   $
 Type�� �� $ Type_�  $
 Date�� �� $ Date_�  $ Value�� �� $ Value_�  $ Description�� �� $ Description_�� -   $ DetailInfomation_Grid��.+��� $  Vertical=�.+��� $��-Details���� -   
 ��Name$
 txtBox_��$��Detail txtBox��� -   $ detailCtrl_��