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

namespace Excel_Interface
{
    /// <summary>
    /// Excel_fxLoaderView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_fxLoaderView : UserControl
    {
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region ViewModel_
        private Excel_fxLoaderViewModel viewModel_;
        public Excel_fxLoaderViewModel ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    this.NotifyPropertyChanged("ViewModel_");
                }
            }
        }
        #endregion

        public Excel_fxLoaderView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void DataGrid_LoadingRow_(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void resultDataGrid_MouseDoubleClick2(object sender, MouseButtonEventArgs e)
        {
            Excel_fxSymbolViewModel selectedItem = this.symbolDataGrid_.SelectedItem as Excel_fxSymbolViewModel;

            if (selectedItem != null)
            {
                Excel_underlyingLoaderViewModel e_ulvm = ((Grid)this.Parent).DataContext as Excel_underlyingLoaderViewModel;

                e_ulvm.SelectedUnderlyingVM_ = selectedItem.underlyingInfoVM();
            }
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_fxLoaderViewModel;

            this.viewModel_.loadDefinedSymbolFromDB();

            //MarketDataManagerViewModel mvm = new MarketDataManagerViewModel();
            //mvm.loadDefinedIndexSymbolFromDB();

            this.symbolDataGrid_.ItemsSource = this.viewModel_.DefinedFxSymbolList_;

            //this.ScheduleDataGrid_.ItemsSource = this.viewModel_.Excel_scheduleViewModel_;
        }
    }
}
