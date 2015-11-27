﻿#pragma checksum "..\..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EC1F600F1BD504140790AAD4C4E03339"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.18052
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using AvalonDock;
using AvalonDock.Controls;
using AvalonDock.Converters;
using AvalonDock.Layout;
using AvalonDock.Themes;
using DataGridFilterLibrary;
using Fluent;
using RiskMonitor;
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : Fluent.RibbonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.RibbonContextualTabGroup toolsGroup;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button buttonLoad;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button buttonSetting;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button explorerLoad;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button AddNewInstBtn_;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BatchControlBtn_;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button MROPositionLoadBtn_;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button DeltaHedgeMonitorBtn_;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AvalonDock.DockingManager ResualtDocking;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AvalonDock.Layout.LayoutDocumentPaneGroup DocumentPaneGroup_;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AvalonDock.Layout.LayoutDocumentPane DocumentPane_;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AvalonDock.Layout.LayoutDocument StartDocument_;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AvalonDock.Layout.LayoutDocumentPane ouputPane_;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AvalonDock.Layout.LayoutAnchorablePaneGroup ExplorerPaneGroup;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AvalonDock.Layout.LayoutAnchorablePane ExplorerPortfolio_;
        
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
            System.Uri resourceLocater = new System.Uri("/RiskMonitor;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.toolsGroup = ((Fluent.RibbonContextualTabGroup)(target));
            return;
            case 2:
            this.buttonLoad = ((Fluent.Button)(target));
            
            #line 20 "..\..\..\MainWindow.xaml"
            this.buttonLoad.Click += new System.Windows.RoutedEventHandler(this.bookLoadButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonSetting = ((Fluent.Button)(target));
            
            #line 22 "..\..\..\MainWindow.xaml"
            this.buttonSetting.Click += new System.Windows.RoutedEventHandler(this.buttonSetting_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.explorerLoad = ((Fluent.Button)(target));
            
            #line 23 "..\..\..\MainWindow.xaml"
            this.explorerLoad.Click += new System.Windows.RoutedEventHandler(this.explorerLoad_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddNewInstBtn_ = ((Fluent.Button)(target));
            
            #line 24 "..\..\..\MainWindow.xaml"
            this.AddNewInstBtn_.Click += new System.Windows.RoutedEventHandler(this.AddNewInstBtn__Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BatchControlBtn_ = ((Fluent.Button)(target));
            
            #line 25 "..\..\..\MainWindow.xaml"
            this.BatchControlBtn_.Click += new System.Windows.RoutedEventHandler(this.BatchControlBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MROPositionLoadBtn_ = ((Fluent.Button)(target));
            
            #line 26 "..\..\..\MainWindow.xaml"
            this.MROPositionLoadBtn_.Click += new System.Windows.RoutedEventHandler(this.MROPositionLoadBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DeltaHedgeMonitorBtn_ = ((Fluent.Button)(target));
            
            #line 27 "..\..\..\MainWindow.xaml"
            this.DeltaHedgeMonitorBtn_.Click += new System.Windows.RoutedEventHandler(this.DeltaHedgeMonitorBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ResualtDocking = ((AvalonDock.DockingManager)(target));
            return;
            case 10:
            this.DocumentPaneGroup_ = ((AvalonDock.Layout.LayoutDocumentPaneGroup)(target));
            return;
            case 11:
            this.DocumentPane_ = ((AvalonDock.Layout.LayoutDocumentPane)(target));
            return;
            case 12:
            this.StartDocument_ = ((AvalonDock.Layout.LayoutDocument)(target));
            return;
            case 13:
            this.ouputPane_ = ((AvalonDock.Layout.LayoutDocumentPane)(target));
            return;
            case 14:
            this.ExplorerPaneGroup = ((AvalonDock.Layout.LayoutAnchorablePaneGroup)(target));
            return;
            case 15:
            this.ExplorerPortfolio_ = ((AvalonDock.Layout.LayoutAnchorablePane)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

