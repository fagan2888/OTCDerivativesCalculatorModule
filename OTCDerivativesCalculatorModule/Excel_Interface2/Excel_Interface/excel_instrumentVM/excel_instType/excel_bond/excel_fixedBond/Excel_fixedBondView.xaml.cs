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
    /// Excel_fixedBondView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_fixedBondView : UserControl
    {
        //#region ParaViewModel_
        //private Excel_standardParaViewModel paraViewModel_;
        //public Excel_standardParaViewModel ParaViewModel_
        //{
        //    get { return this.paraViewModel_; }
        //    set
        //    {
        //        if (this.paraViewModel_ != value)
        //        {
        //            this.paraViewModel_ = value;
        //            //this.NotifyPropertyChanged("ParaViewModel_");
        //        }
        //    }
        //}
        //#endregion

        #region ViewModel_
        private Excel_fixedBondViewModel viewModel_;
        public Excel_fixedBondViewModel ViewModel_
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

        public Excel_fixedBondView(Orientation ori = Orientation.Horizontal)
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
            this.directionViewPanel_.Orientation = ori;
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_fixedBondViewModel;

            this.IssueInfoGrid_.Children.Clear();
            this.IssueInfoGrid_.Children.Add(this.viewModel_.Excel_issueInfoViewModel_.view());

            this.fixedCouponScheduleGrid_.Children.Clear();
            this.fixedCouponScheduleGrid_.Children.Add(this.viewModel_.Excel_fixedCouponScheduleListViewModel_.view());


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

            //w.Content = 

            Excel_fixedBond_subtypeLoaderView e_f_slv = this.ViewModel_.Excel_fixedBond_subtypeViewModel_.loaderView();

            //try { e_h_slv.BaseUnderlyingValue_ = Convert.ToDouble(this.viewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_[0].BasePrice_); }
            //catch (Exception) { }

            //default
            e_f_slv.SelectedViewModel_ = new Excel_fixedBond_constantRateViewModel();
            e_f_slv.SelectedViewModel_.ScheduleGeneratorVM_.InitialDate_ = this.viewModel_.Excel_issueInfoViewModel_.EffectiveDate_;
            e_f_slv.SelectedViewModel_.ScheduleGeneratorVM_.EndDate_ = this.viewModel_.Excel_issueInfoViewModel_.MaturityDate_;

            e_f_slv.SelectedViewModel_.Excel_underlyingCalcInfoViewModel_ = this.ViewModel_.Excel_underlyingCalcInfoViewModel_;

            //e_f_slv.SelectedViewModel_.EffectiveDate_ = this.viewModel_.Excel_issueInfoViewModel_.EffectiveDate_;

            w.Content = e_f_slv;

            if (w.ShowDialog() == true)
            {
                //e_h_slv.SelectedViewModel_.descriptionUpdate();
                e_f_slv.SelectedViewModel_.excel_scheduleListVMBuild();
                this.viewModel_.Excel_fixedCouponScheduleListViewModel_.setScheduleFromClone(
                    e_f_slv.SelectedViewModel_.Excel_fixedCouponScheduleListViewModel_);

                this.viewModel_.Excel_fixedBond_subtypeViewModel_ = e_f_slv.SelectedViewModel_;
                
            }
            else
            {

            }


        }
    }
}
