﻿#pragma checksum "..\..\..\..\..\..\..\..\..\Excel_Interface\excel_instrumentVM\excel_instType\excel_bond\excel_floatingBond\excel_vanillaFloatingBond\subtype\Excel_vanillaFloatingBond_simpleView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B6E5ACBE774A0AC0A4A06B819D75DD9E"
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
    /// Excel_vanillaFloatingBond_simpleView
    /// </summary>
    public partial class Excel_vanillaFloatingBond_simpleView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\..\..\..\..\..\Excel_Interface\excel_instrumentVM\excel_instType\excel_bond\excel_floatingBond\excel_vanillaFloatingBond\subtype\Excel_vanillaFloatingBond_simpleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid scheduleGenGrid_;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\..\..\..\..\Excel_Interface\excel_instrumentVM\excel_instType\excel_bond\excel_floatingBond\excel_vanillaFloatingBond\subtype\Excel_vanillaFloatingBond_simpleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid subScheduleDataGrid_;
        
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
                    "el_bond/excel_floatingbond/excel_vanillafloatingbond/subtype/excel_vanillafloati" +
                    "ngbond_simpleview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\..\..\Excel_Interface\excel_instrumentVM\excel_instType\excel_bond\excel_floatingBond\excel_vanillaFloatingBond\subtype\Excel_vanillaFloatingBond_simpleView.xaml"
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
            
            #line 13 "..\..\..\..\..\..\..\..\..\Excel_Interface\excel_instrumentVM\excel_instType\excel_bond\excel_floatingBond\excel_vanillaFloatingBond\subtype\Excel_vanillaFloatingBond_simpleView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.productStringSetButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.scheduleGenGrid_ = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.subScheduleDataGrid_ = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

