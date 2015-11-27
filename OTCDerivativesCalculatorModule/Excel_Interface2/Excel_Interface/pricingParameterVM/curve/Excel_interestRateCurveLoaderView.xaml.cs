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
    /// Excel_interestRateCurveLoaderView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_interestRateCurveLoaderView : UserControl
    {
        #region ViewModel_
        private Excel_interestRateCurveLoaderViewModel viewModel_;
        public Excel_interestRateCurveLoaderViewModel ViewModel_
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

        public Excel_interestRateCurveLoaderView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_interestRateCurveLoaderViewModel;
            this.RateDataGrid_.ItemsSource = this.viewModel_.RateDataViewModel_;

            this.curveListView_.ItemsSource = this.viewModel_.CurveHeaderInfoDataList_;

            //this.viewModel_ = this.DataContext as Excel_scheduleListViewModel;
            //this.ScheduleDataGrid_.ItemsSource = this.viewModel_.Excel_scheduleViewModel_;
        }

        private void DataGrid_LoadingRow_(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void SurmitButton_Click(object sender, RoutedEventArgs e)
        {
            //this.viewModel_.buildProduct();

            ((Window)this.Parent).DialogResult = true;
            ((Window)this.Parent).Close();
        }

        private void CancleButton_Click(object sender, RoutedEventArgs e)
        {
            ((Window)this.Parent).DialogResult = false;
            ((Window)this.Parent).Close();
        }

        private void loadButton_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel_.loadData(new DateTime(), "");
        }

        private void curveListView__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //CurveHeaderInfo_Table_DAO selectedItem = this.curveListView_.SelectedItem as CurveHeaderInfo_Table_DAO;

            //this.viewModel_.loadData(new DateTime(), "");

        }

        private void curveListView__PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            CurveHeaderInfo_Table_DAO selectedItem = this.curveListView_.SelectedItem as CurveHeaderInfo_Table_DAO;

            this.viewModel_.loadData(new DateTime(), "");
        }

    }
}
