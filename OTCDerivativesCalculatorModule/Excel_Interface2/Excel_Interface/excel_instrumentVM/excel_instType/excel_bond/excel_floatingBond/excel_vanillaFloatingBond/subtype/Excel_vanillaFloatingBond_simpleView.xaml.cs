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
    /// Excel_vanillaFloatingBond_simpleView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_vanillaFloatingBond_simpleView : UserControl
    {
        #region ViewModel_
        private Excel_vanillaFloatingBond_simpleViewModel viewModel_;
        public Excel_vanillaFloatingBond_simpleViewModel ViewModel_
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

        public Excel_vanillaFloatingBond_simpleView()
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
            this.viewModel_ = this.DataContext as Excel_vanillaFloatingBond_simpleViewModel;

            this.subScheduleDataGrid_.ItemsSource = this.viewModel_.Excel_vanillaFloatingBond_subScheduleViewModel_;

            this.scheduleGenGrid_.Children.Clear();
            this.scheduleGenGrid_.Children.Add(this.viewModel_.ScheduleGeneratorVM_.view());

            //this.viewModel_.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(viewModel_PropertyChanged);

            //this.ScheduleDataGrid_.ItemsSource = viewModel_.SubScheduleDataList_;

            //GenInformationPanel_.DataContext = this.viewModel_;

            //EffectiveDatePicker_.DataContext = this.viewModel_;

        }

        private void productStringSetButton_Click(object sender, RoutedEventArgs e)
        {
            this.ViewModel_.scheduleDataGenerate();
        }
    }
}
