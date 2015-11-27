using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AvalonDock.Layout;

namespace RiskMonitor
{
    /// <summary>
    /// ExplorerBookInstView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ExplorerBookInstView : UserControl
    {
        private MainWindow mainWindow_;

        public ExplorerBookInstViewModel InstExViewModel_ { get; set; }

        public ExplorerBookInstView(MainWindow mainWindow, BookInfoViewModel bookInfoVM)
        {
            InitializeComponent();
            this.mainWindow_ = mainWindow;

            //InstExViewModel_ = new InstrumentExplorerViewModel(mainWindow,bookInfoVM);

            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

            //ExplorerListView_.Height = mainWindow.DocumentPane_.DockHeight.Value;
            
            OutputLogViewModel.addResult(new MessageOutput("Explore Load Complete"));
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.InstExViewModel_ = this.DataContext as ExplorerBookInstViewModel;

            //ExplorerListView_.DataContext = InstExViewModel_;
            ExplorerListView_.ItemsSource = InstExViewModel_.InstHierarchyList_;
            OutputLogViewModel.addResult(new MessageOutput("ExplorerBookInstView : DataContext Changed"));
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            // load 하고 또는 미리 load 된 것을

            // 속성 창에 반영함.

        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //InstrumentHierarchyViewModel item = sender as InstrumentHierarchyViewModel;
            ExploreHirachyInstrumentVMWrapper item = ExplorerListView_.SelectedItem as ExploreHirachyInstrumentVMWrapper;

            if (item != null)
            {
                LayoutDocument layoutDoc = new LayoutDocument();
                //int count = this.Parent.ChildrenCount;
                //LayoutDocumentPane pane = new LayoutDocumentPane();
                Grid grid = new Grid();
                grid.Children.Add(item.view());
                layoutDoc.Content = grid;

                layoutDoc.Title = item.ItemCode_;

                mainWindow_.DocumentPane_.Children.Add(layoutDoc);
                OutputLogViewModel.addResult(new MessageOutput(item.ItemCode_ + " is loaded"));
                
            }
            
            
            //MainWindow.AddCtrlOnMainWindow(item.View_);
        }

        //private void MROPositionLoadBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    MROPositionDataLoader loader = new MROPositionDataLoader();
        //    loader.makePosition();
        //}

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selected = (ComboBoxItem)ViewComboBox_.SelectedItem;
            string str = Convert.ToString(selected.Content);

            DataTemplate template = new DataTemplate();

            if (str == "FileName")
            {
                ExplorerListView_.ItemTemplate = ExplorerListView_.FindResource("FileNameTemplate") as DataTemplate;
            }
            else if (str == "ProductName")
            {
                ExplorerListView_.ItemTemplate = ExplorerListView_.FindResource("ProductNameTemplate") as DataTemplate;
                
            }
        
        }

        //private void BatchBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    foreach (var item in instExViewModel_.InstHierarchyList_)
        //    {
        //        item.calculate();
        //    }
        //}


    }
}
