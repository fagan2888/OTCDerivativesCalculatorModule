﻿#pragma checksum "..\..\..\..\..\View\InstrumentBaseView\StandardInstBaseView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F36C93FA08AF7E2D0D1440D4C7CA32FA"
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


namespace RiskMonitor {
    
    
    /// <summary>
    /// StandardInstBaseView
    /// </summary>
    public partial class StandardInstBaseView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\..\View\InstrumentBaseView\StandardInstBaseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker ReferenceDatePicker_;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\View\InstrumentBaseView\StandardInstBaseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadBtn_;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\View\InstrumentBaseView\StandardInstBaseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBtn_;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\View\InstrumentBaseView\StandardInstBaseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CalculateBtn_;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\View\InstrumentBaseView\StandardInstBaseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PositionInfoGrid_;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\View\InstrumentBaseView\StandardInstBaseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid InformationGrid_;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\View\InstrumentBaseView\StandardInstBaseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ResultGrid_;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\..\View\InstrumentBaseView\StandardInstBaseView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ParameterGrid_;
        
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
            System.Uri resourceLocater = new System.Uri("/RiskMonitor;component/view/instrumentbaseview/standardinstbaseview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\InstrumentBaseView\StandardInstBaseView.xaml"
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
            this.ReferenceDatePicker_ = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.LoadBtn_ = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.SaveBtn_ = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\..\View\InstrumentBaseView\StandardInstBaseView.xaml"
            this.SaveBtn_.Click += new System.Windows.RoutedEventHandler(this.SaveBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CalculateBtn_ = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\..\View\InstrumentBaseView\StandardInstBaseView.xaml"
            this.CalculateBtn_.Click += new System.Windows.RoutedEventHandler(this.CalculateBtn__Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PositionInfoGrid_ = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.InformationGrid_ = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.ResultGrid_ = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.ParameterGrid_ = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

