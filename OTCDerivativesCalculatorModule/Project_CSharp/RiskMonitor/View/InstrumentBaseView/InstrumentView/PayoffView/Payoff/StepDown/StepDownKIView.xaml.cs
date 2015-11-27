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

namespace RiskMonitor
{
    /// <summary>
    /// StepDownELSInstrumentView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class StepDownKIView : UserControl
    {
        #region ViewModel_
        private StepDownKIViewModel viewModel_;
        public StepDownKIViewModel ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    //this.scheduleDataGrid_.ItemsSource = viewModel_.RedemtionEvents_.RedemptionEvents_;
                    ////this.UnderlyingListView_.ItemsSource = viewModel_.UnderlyingInfo_.Underlyings_;
                    //this.kiStackPanel_.DataContext = viewModel_.KIPayoff_;
                }
            }
        }
        #endregion

        public StepDownKIView() 
        {
            InitializeComponent();
            this.DataContextChanged +=new DependencyPropertyChangedEventHandler(ViewModelChanged);

        }

        //public StepDownKIPayoffView(StepDownKIViewModel payoffViewModel)
        //{
        //    InitializeComponent();
        //    this.ViewModel_ = payoffViewModel;
        //    //this.scheduleDataGrid_.ItemsSource = viewModel_.RedemtionEvents_.RedemptionEvents_;
            
        //}

        //redem Combo box change 필요

        private void KI_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            // detail view 가 set 됨
            // 
            //string kiType = "";
            //this.viewModel_.KIPayoff_.setDetailCtrl(type);

            KiStackPanel_.Children.Clear();
            //this.viewModel_.setKIEventVM(kiType);
            KiStackPanel_.Children.Add(this.viewModel_.KiEventInfoViewModel_.View_);

        }

        private void NonKI_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string nonKIType = "";

            NonkiStackPanel_.Children.Clear();
            //this.viewModel_.setNonKIEventVM(nonKIType);
            NonkiStackPanel_.Children.Add(this.viewModel_.NonKiEventInfoViewModel_.View_);

        }

        private void Redem_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string redemType = "";
            RedemStackPanel_.Children.Clear();
            //this.viewModel_.setRedemEventVM(redemType);
            RedemStackPanel_.Children.Add(this.viewModel_.RedemptionInfoViewModel_.View_);

        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as StepDownKIViewModel;

            this.RedemStackPanel_.Children.Add(this.viewModel_.RedemptionInfoViewModel_.View_);
            this.KiStackPanel_.Children.Add(this.viewModel_.KiEventInfoViewModel_.View_);
            this.NonkiStackPanel_.Children.Add(this.viewModel_.NonKiEventInfoViewModel_.View_);

            //scheduleDataGrid_.ItemsSource = this.viewModel_.RedemptionEvents_;
            //this.PayoffStackPanel_.Children.Add(this.viewModel_.ReturnCalculationViewModel_.ReturnCalculationView_);
        }
        
    }
}
