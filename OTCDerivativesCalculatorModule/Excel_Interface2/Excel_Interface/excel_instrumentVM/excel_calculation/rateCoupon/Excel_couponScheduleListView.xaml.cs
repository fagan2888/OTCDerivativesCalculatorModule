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
    /// Excel_couponScheduleListView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_couponScheduleListView : UserControl
    {
        #region ViewModel_
        private Excel_couponScheduleListViewModel viewModel_;
        public Excel_couponScheduleListViewModel ViewModel_
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

        public Excel_couponScheduleListView()
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
            this.viewModel_ = this.DataContext as Excel_couponScheduleListViewModel;
            this.CouponScheduleDataGrid_.ItemsSource = this.viewModel_.Excel_couponScheduleViewModel_;
        }

        private void typeEditBtn_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            // 우선 loader 말고 그냥 박음.. listVM class 에서 refresh해야하는데 복잡허네..

            //Excel_scheduleLoaderView e_slv = new Excel_scheduleLoaderView();

            //e_slv.Excel_underlyingCalcInfoViewModel_ = this.viewModel_.Excel_underlyingCalcInfoViewModel_;

            Excel_couponScheduleViewModel selectedVM = this.CouponScheduleDataGrid_.SelectedItem as Excel_couponScheduleViewModel;

            // 그냥 우선은 수정 불가로 해놓자으

            //e_slv.SelectedScheduleTypeViewModel_ = selectedVM;
            
            w.Content = selectedVM.loaderView();

            if (w.ShowDialog() == true)
            {
                //this.viewModel_.Excel_scheduleViewModel_[selectedIndex] = selectedVM;

                selectedVM.descriptionUpdate();

            }
            else
            {

            }
        }


    }
}
