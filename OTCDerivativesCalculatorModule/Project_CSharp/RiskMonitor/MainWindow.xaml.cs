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
using System.ComponentModel;
using System.Collections.ObjectModel;
using Fluent;
using AvalonDock.Layout;

namespace RiskMonitor
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>

    public partial class MainWindow : RibbonWindow
    {

        #region ViewModel_
        private MainWindowViewModel viewModel_;
        public MainWindowViewModel ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    //this.NotifyPropertyChanged("ViewModel_");
                }
            }
        }
        #endregion

        //public InstrumentExplorerViewCtrl instExView_ { get; set;}
        //public OutputLogViewModel outputLogVM_ { get; set; }

        //public string PortfolioPath_ = @"D:\Project File\OTCDerivativesCalculatorModule\Project_CSharp\RiskMonitor\XmlFile\";
        
        public MainWindow()
        {
            InitializeComponent();
            
            //this.initialize();
            //LayoutAnchorable layoutAnch = new LayoutAnchorable();
            //layoutAnch.Content = new OutputLogView();
            //OutputLogPane_.Children.Add(layoutAnch);
        }

        private void BookListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //argument 변환
            BookManagerView bookManagerView = sender as BookManagerView;

            if (bookManagerView != null)
            {
                BookInfoViewModel selectedBookVM = bookManagerView.BookListDataGrid_.SelectedItem as BookInfoViewModel;

                if (selectedBookVM != null)
                { 

                    //this.viewModel_ = new MainWindowViewModel(selectedBookVM);

                    //ExplorerPortfolio_.Children.Add(layoutAnch);

                    this.initialize(selectedBookVM);
                    this.DocumentPane_.Children.Clear();
                    //this.StartDocument_.Close();

                }
            }

            //if (this.instExView_ == null)
            //{
                
                
            //}
            //else
            //{
            //    this.instExView_.IsVisible = true;
            //}

        }

        private void initialize(BookInfoViewModel bookInfoVM)
        {
            //instExView_ = new ExplorerBookInstView(this, bookInfoVM);
            this.viewModel_ = new MainWindowViewModel(this,bookInfoVM);
            LayoutAnchorable layoutAnch = new LayoutAnchorable();
            layoutAnch.Content = this.viewModel_.ExplorerBookInstVM_.View_;

            ExplorerPortfolio_.Children.Add(layoutAnch);

            

        }

        public void loadBook()
        {

        }

        public void addBook()
        {
            //this.instExView_ = new InstrumentExplorerViewCtrl(this);
            //ExplorerPortfolio_.Children.Add(this.instExView_);
        }

        public void AddToLayoutDocumentOnMainWindow(LayoutDocument layoutDoc,
                                                    RiskMonitor.Activate activate = RiskMonitor.Activate.Hide ) 
        {
            this.DocumentPane_.Children.Add(layoutDoc);
        }

        public void AddToLayoutDocumentOnMainWindow(FrameworkElement ctrl,
                                                    RiskMonitor.Activate activate = RiskMonitor.Activate.Hide ) 
        {
            LayoutDocument layoutDoc = new LayoutDocument();
            layoutDoc.Content = ctrl;

            this.DocumentPane_.Children.Add(layoutDoc);
        }

        private void bookLoadButton_Click(object sender, RoutedEventArgs e)
        {
            LayoutAnchorable layoutDoc = new LayoutAnchorable();
            this.ExplorerPortfolio_.Children.Add(layoutDoc);
        }

        private void buttonSetting_Click(object sender, RoutedEventArgs e)
        {
            //ELSHedgeMonitorView view = new ELSHedgeMonitorView();

            //ELSStepDownLoader loader = new ELSStepDownLoader();
            //StepDownELSInformation info = loader.stepDownload();

            //ELSHedgeMonitorViewModel viewModel = new ELSHedgeMonitorViewModel();
            //ELSStepDownDeltaHedgeViewModel elsViewModel = new ELSStepDownDeltaHedgeViewModel(info);
            //viewModel.add(elsViewModel);
            //viewModel.add(elsViewModel);

            //view.ELSHedgeMonitorViewCtrl_.setViewModel(viewModel);


            //DocumentPane_.Children.Add(view);

            CorrelationLoader loader = new CorrelationLoader();
            //loader.ReferenceDate_ = DateTime.Now.AddDays(-1);
            loader.ReferenceDate_ = new DateTime(2013, 9, 2);
            loader.loadData();
            loader.corr("KR7069960003", "KR7060980000");
        }

        private void explorerLoad_Click(object sender, RoutedEventArgs e)
        {
            //if (this.instExView_ == null)
            //{
            //    //this.instExView_ = new InstrumentExplorerViewCtrl(this);
            //    ExplorerPortfolio_.Children.Add(this.instExView_);
            //}
            //else
            //{
            //    this.instExView_.IsVisible = true;
            //}
            

            //OutputLogPane_.Children.Add(new OutputLogView());
        }

        private void AddNewInstBtn__Click(object sender, RoutedEventArgs e)
        {
            //var addNewInstView = new AddNewProductManagerView(this);
            //addNewInstView.Show();
        }

        private void BatchControlBtn_Click(object sender, RoutedEventArgs e)
        {
            LayoutDocument layoutDoc = new LayoutDocument();
            BatchControlView ctrl = new BatchControlView();
            BatchControlViewModel viewModel = new BatchControlViewModel(this.viewModel_.BookInfoVM_);
            //viewModel.InstHierarchyList_ = this.instExView_.instExViewModel_.InstHierarchyList_;
            ctrl.ViewModel_ = viewModel;
            layoutDoc.Content = ctrl;
            layoutDoc.Title = "BatchControl";
            this.DocumentPane_.Children.Add(layoutDoc);
        }

        private void MROPositionLoadBtn_Click(object sender, RoutedEventArgs e)
        {
            //MROPositionDataLoader loader = new MROPositionDataLoader();
            //loader.makePosition();
        }

        private void DeltaHedgeMonitorBtn_Click(object sender, RoutedEventArgs e)
        {
            LayoutDocument layoutDoc = new LayoutDocument();
            DeltaHedgeMonitorView ctrl = new DeltaHedgeMonitorView();
            DeltaHedgeMonitorViewModel viewModel = new DeltaHedgeMonitorViewModel();
            
            ctrl.ViewModel_ = viewModel;
            layoutDoc.Content = ctrl;
            layoutDoc.Title = "DeltaHedge";
            this.DocumentPane_.Children.Add(layoutDoc);
        }

    }
}
