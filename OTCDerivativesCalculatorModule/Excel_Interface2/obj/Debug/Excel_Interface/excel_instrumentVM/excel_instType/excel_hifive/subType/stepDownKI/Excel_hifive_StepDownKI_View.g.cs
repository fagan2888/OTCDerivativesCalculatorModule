﻿#pragma checksum "..\..\..\..\..\..\..\..\Excel_Interface\excel_instrumentVM\excel_instType\excel_hifive\subType\stepDownKI\Excel_hifive_StepDownKI_View.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D2399C3F13E4DFD53A6250767E15369E"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.18444
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Excel_Interface {
    
    
    /// <summary>
    /// Excel_hifive_StepDownKI_View
    /// </summary>
    public partial class Excel_hifive_StepDownKI_View : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\..\..\..\..\Excel_Interface\excel_instrumentVM\excel_instType\excel_hifive\subType\stepDownKI\Excel_hifive_StepDownKI_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel GenInformationPanel_;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\..\..\..\Excel_Interface\excel_instrumentVM\excel_instType\excel_hifive\subType\stepDownKI\Excel_hifive_StepDownKI_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox calendarStr_;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\..\..\..\Excel_Interface\excel_instrumentVM\excel_instType\excel_hifive\subType\stepDownKI\Excel_hifive_StepDownKI_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker KiObStartDatePicker_;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\..\..\..\Excel_Interface\excel_instrumentVM\excel_instType\excel_hifive\subType\stepDownKI\Excel_hifive_StepDownKI_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker KiObEndDatePicker_;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\..\..\..\..\Excel_Interface\excel_instrumentVM\excel_instType\excel_hifive\subType\stepDownKI\Excel_hifive_StepDownKI_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ScheduleDataGrid_;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Excel_Interface2;component/excel_interface/excel_instrumentvm/excel_insttype/exc" +
                    "el_hifive/subtype/stepdownki/excel_hifive_stepdownki_view.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\..\Excel_Interface\excel_instrumentVM\excel_instType\excel_hifive\subType\stepDownKI\Excel_hifive_StepDownKI_View.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.GenInformationPanel_ = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.calendarStr_ = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 33 "..\..\..\..\..\..\..\..\Excel_Interface\excel_instrumentVM\excel_instType\excel_hifive\subType\stepDownKI\Excel_hifive_StepDownKI_View.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CalendarButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.KiObStartDatePicker_ = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.KiObEndDatePicker_ = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            
            #line 95 "..\..\..\..\..\..\..\..\Excel_Interface\excel_instrumentVM\excel_instType\excel_hifive\subType\stepDownKI\Excel_hifive_StepDownKI_View.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ScheduleSettingButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 96 "..\..\..\..\..\..\..\..\Excel_Interface\excel_instrumentVM\excel_instType\excel_hifive\subType\stepDownKI\Excel_hifive_StepDownKI_View.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.productStringSetButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ScheduleDataGrid_ = ((System.Windows.Controls.DataGrid)(target));
            
            #line 100 "..\..\..\..\..\..\..\..\Excel_Interface\excel_instrumentVM\excel_instType\excel_hifive\subType\stepDownKI\Excel_hifive_StepDownKI_View.xaml"
            this.ScheduleDataGrid_.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.DataGrid_LoadingRow_);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

