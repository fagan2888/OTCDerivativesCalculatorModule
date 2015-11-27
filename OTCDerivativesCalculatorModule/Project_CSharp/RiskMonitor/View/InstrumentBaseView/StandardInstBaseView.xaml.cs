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
    /// StandardInstBaseView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class StandardInstBaseView : UserControl
    {
        #region ViewModel_
        private StandardInstBaseViewModel viewModel_;
        public StandardInstBaseViewModel ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    this.viewModel_.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(viewModel_PropertyChanged);
                    //this.NotifyPropertyChanged("ViewModel_");
                }
            }
        }
        #endregion

        public StandardInstBaseView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel_.buildInstrument();
            //this.viewModel_.buildParaResult();
            
            bool success = PositionSingletonManger.positionMasterVM().addInstrument(this.viewModel_);

            if (success)
            {
                this.viewModel_.saveInstrument();
            }
            
            //message 저장함.

        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.ViewModel_ = this.DataContext as StandardInstBaseViewModel;
            this.ReferenceDatePicker_.DataContext = this.viewModel_;
            this.PositionInfoGrid_.DataContext = this.viewModel_.InstPositionInfoViewModel_;
        }

        void viewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "InstrumentViewModel_")
            {
                this.InformationGrid_.Children.Clear();
                this.InformationGrid_.Children.Add(this.viewModel_.InstrumentViewModel_.View_);
            }
            //else if (e.PropertyName == "InstPositionInfoViewModel_")
            //{
            //    this.instPositionInfoGrid_.Children.Clear();
            //    this.instPositionInfoGrid_.Children.Add(this.viewModel_.InstPositionInfoViewModel_.View_);
            //}
            else if (e.PropertyName == "PricingParameterViewModel_")
            {
                this.ParameterGrid_.Children.Clear();
                this.ParameterGrid_.Children.Add(this.viewModel_.PricingParameterViewModel_.View_);
            }
            else if (e.PropertyName == "PricingResultViewModel_")
            {
                this.ResultGrid_.Children.Clear();
                this.ResultGrid_.Children.Add(this.viewModel_.PricingResultViewModel_.View_);
            }
            else 
            {
            
            }

        }

        private void CalculateBtn__Click(object sender, RoutedEventArgs e)
        {
            this.viewModel_.calculate();
        }

    }
}
