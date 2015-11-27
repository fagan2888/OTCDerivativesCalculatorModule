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

namespace Excel_Interface
{
    /// <summary>
    /// Excel_fixedBond_constantRateView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_fixedBond_constantRateView : UserControl
    {
        #region ViewModel_
        private Excel_fixedBond_constantRateViewModel viewModel_;
        public Excel_fixedBond_constantRateViewModel ViewModel_
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

        public Excel_fixedBond_constantRateView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void DataGrid_LoadingRow_(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_fixedBond_constantRateViewModel;

            this.viewModel_.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(viewModel_PropertyChanged);
            
            this.subScheduleDataGrid_.ItemsSource = this.viewModel_.Excel_fixedBond_subScheduleViewModel_;
            
            this.scheduleGenGrid_.Children.Clear();
            this.scheduleGenGrid_.Children.Add(this.viewModel_.ScheduleGeneratorVM_.view());

            //this.ScheduleDataGrid_.ItemsSource = viewModel_.SubScheduleDataList_;

            //GenInformationPanel_.DataContext = this.viewModel_;

            //EffectiveDatePicker_.DataContext = this.viewModel_;

        }

        private void viewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            //DateTime d = this.viewModel_.EffectiveDate_;
            //EffectiveDatePicker_.SelectedDate = d;

        }

        private void productStringSetButton_Click(object sender, RoutedEventArgs e)
        {
            this.ViewModel_.scheduleDataGenerate();
        }
    }
}
