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
    /// Excel_vanillFloatingBondView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_vanillaFloatingBondView : UserControl
    {
        #region ViewModel_
        private Excel_vanillaFloatingBondViewModel viewModel_;
        public Excel_vanillaFloatingBondViewModel ViewModel_
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

        public Excel_vanillaFloatingBondView(Orientation ori = Orientation.Horizontal)
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
            this.directionViewPanel_.Orientation = ori;
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_vanillaFloatingBondViewModel;

            this.IssueInfoGrid_.Children.Clear();
            this.IssueInfoGrid_.Children.Add(this.viewModel_.Excel_issueInfoViewModel_.view());

            this.UnderlyingInfoGrid_.Children.Clear();
            this.UnderlyingInfoGrid_.Children.Add(this.viewModel_.Excel_underlyingCalcInfoViewModel_.view());

            this.couponScheduleGrid_.Children.Clear();
            this.couponScheduleGrid_.Children.Add(this.viewModel_.Excel_vanillaFloatingCouponScheduleListViewModel_.view());
        }

        private void SubTypeSet_Button_Click(object sender, RoutedEventArgs e)
        {
            int underCount = this.viewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_.Count;

            //if (underCount == 0)
            //{
            //    MessageBoxResult msgBox = MessageBox.Show("Some Underlying Need.");
            //    return;
            //}

            Window w = new Window();
            w.Width = 500;
            w.Height = 300;

            Excel_vanillaFloatingBond_subtypeLoaderView e_vfb_slv = this.ViewModel_.Excel_vanillaFloatingBond_subtypeViewModel_.loaderView();

            //default
            e_vfb_slv.SelectedViewModel_ = new Excel_vanillaFloatingBond_simpleViewModel();
            e_vfb_slv.SelectedViewModel_.ScheduleGeneratorVM_.InitialDate_ = this.viewModel_.Excel_issueInfoViewModel_.EffectiveDate_;
            e_vfb_slv.SelectedViewModel_.ScheduleGeneratorVM_.EndDate_ = this.viewModel_.Excel_issueInfoViewModel_.MaturityDate_;
            e_vfb_slv.SelectedViewModel_.Excel_underlyingCalcInfoViewModel_ = this.ViewModel_.Excel_underlyingCalcInfoViewModel_;

            //e_f_slv.SelectedViewModel_.EffectiveDate_ = this.viewModel_.Excel_issueInfoViewModel_.EffectiveDate_;

            w.Content = e_vfb_slv;

            if (w.ShowDialog() == true)
            {
                //e_h_slv.SelectedViewModel_.descriptionUpdate();
                e_vfb_slv.SelectedViewModel_.excel_scheduleListVMBuild();
                this.viewModel_.Excel_vanillaFloatingCouponScheduleListViewModel_.setScheduleFromClone(
                    e_vfb_slv.SelectedViewModel_.Excel_vanillaFloatingCouponScheduleListViewModel_);

                this.viewModel_.Excel_vanillaFloatingBond_subtypeViewModel_ = e_vfb_slv.SelectedViewModel_;

            }
            else
            {

            }


        }

        private void scheduleDataGrid__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void couponCalEditBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
