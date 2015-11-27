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
    /// Excel_fixedCouponScheduleListView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_fixedCouponScheduleListView : UserControl
    {
        #region ViewModel_
        private Excel_fixedCouponScheduleListViewModel viewModel_;
        public Excel_fixedCouponScheduleListViewModel ViewModel_
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

        public Excel_fixedCouponScheduleListView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_fixedCouponScheduleListViewModel;
            this.fixedScheduleDataGrid_.ItemsSource = this.viewModel_.Excel_fixedCouponScheduleViewModel_;
        }

        //private void scheduleEditBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    Window w = new Window();

        //    ScheduleGeneratorViewModel genVM = new ScheduleGeneratorViewModel();

        //    //setting
        //    genVM.InitialDate_ = this.viewModel_.ScheduleInitialDate_;

        //    w.Width = 300;
        //    w.Height = 200;
        //    w.Content = genVM.view();

        //    if (w.ShowDialog() == true)
        //    {
        //        this.viewModel_.FixedCouponScheduleViewModel_.Clear();

        //        for (int i = 0; i < genVM.Dates_.Count; i++)
        //        {
        //            FixedCouponScheduleViewModel fcsvm = new FixedCouponScheduleViewModel();
        //            this.viewModel_.FixedCouponScheduleViewModel_.Add(fcsvm);
        //        }

        //        this.fixedScheduleDataGrid_.Items.Refresh();

        //    }
        //    else
        //    {

        //    }


        //}
    }
}
