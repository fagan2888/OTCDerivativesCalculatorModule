﻿#pragma checksum "..\..\..\..\..\View\AddNewInstrument\AddNewProductManagerView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F0778BEAEDAA5852717D74B39C0E9A2C"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.18052
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


namespace RiskMonitor {
    
    
    /// <summary>
    /// AddNewProductManagerView
    /// </summary>
    public partial class AddNewProductManagerView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\View\AddNewInstrument\AddNewProductManagerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView LocalTemplateListView_;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\View\AddNewInstrument\AddNewProductManagerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ContentListView_;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\View\AddNewInstrument\AddNewProductManagerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FileNameTb_;
        
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
            System.Uri resourceLocater = new System.Uri("/RiskMonitor;component/view/addnewinstrument/addnewproductmanagerview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\AddNewInstrument\AddNewProductManagerView.xaml"
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
            this.LocalTemplateListView_ = ((System.Windows.Controls.TreeView)(target));
            
            #line 10 "..\..\..\..\..\View\AddNewInstrument\AddNewProductManagerView.xaml"
            this.LocalTemplateListView_.SelectedItemChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.LocalTemplateListView_SelectedItemChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ContentListView_ = ((System.Windows.Controls.ListView)(target));
            
            #line 31 "..\..\..\..\..\View\AddNewInstrument\AddNewProductManagerView.xaml"
            this.ContentListView_.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ContentListView_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 31 "..\..\..\..\..\View\AddNewInstrument\AddNewProductManagerView.xaml"
            this.ContentListView_.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ContentListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FileNameTb_ = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 47 "..\..\..\..\..\View\AddNewInstrument\AddNewProductManagerView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

