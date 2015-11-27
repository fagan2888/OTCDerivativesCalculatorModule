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
    /// Excel_hifiveView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_hifiveView : UserControl
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
        private Excel_hifiveViewModel viewModel_;
        public Excel_hifiveViewModel ViewModel_
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

        public Excel_hifiveView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_hifiveViewModel;
            
            //this.viewModel_.Excel_hifive_subtypeViewModel_.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(viewModel__PropertyChanged);

            //this.IssueInfoGrid_.Children.Clear();
            this.IssueInfoGrid_.Children.Add(this.viewModel_.Excel_issueInfoViewModel_.view());
            this.UnderlyingInfoGrid_.Children.Add(this.viewModel_.Excel_underlyingCalcInfoViewModel_.view());

            // 여기는 itemsource 에 더해야함 list임
            //this.UnderlyingCalcGrid_.Children.Add(this.viewModel_.Excel_underlyingCalcIDViewModel_.View_);

            // 이건 선택해서 할거임 . default로 뭘 넣나..?
            // 우선은 default로 stepDownki을 넣자

            //this.SubTypeGrid_.Children.Add(this.viewModel_.Excel_hifive_subtypeViewModel_.View_);

            this.ScheduleGrid_.Children.Add(this.viewModel_.Excel_scheduleListViewModel_.view());

            //Excel_kiEventCalculationLoaderView e_keclv = new Excel_kiEventCalculationLoaderView();
            Excel_kiEventCalculationLoaderView e_keclv = this.viewModel_.Excel_kiEventCalculationViewModel_.loaderView() as Excel_kiEventCalculationLoaderView;

            this.kiEventCalculationGrid_.Children.Add(e_keclv);

            //this.KiScheduleGrid_.Children.Add(this.viewModel_.Excel_kiScheduleListViewModel_.view());

            // para가 없으면 만듬
            //this.paraViewModel_ = new Excel_standardParaViewModel();

            //this.viewModel_.Excel_underlyingCalcInfoViewModel_.PropertyChanged += 
            //    new System.ComponentModel.PropertyChangedEventHandler(this.paraViewModel_.T

        }

        //private void viewModel__PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        //{
        //    this.viewModel_ = this.DataContext as Excel_hifiveViewModel;

        //}

        private void SubTypeSet_Button_Click(object sender, RoutedEventArgs e)
        {
            //int underCount = this.viewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_.Count;

            //if (underCount == 0)
            //{
            //    MessageBoxResult msgBox = MessageBox.Show("Some Underlying Need.");
            //    return;
            //}

            Window w = new Window();
            w.Width = 500;
            w.Height = 400;

            Excel_hifive_subtypeLoaderView e_h_slv;

            if (this.ViewModel_.Excel_hifive_subtypeViewModel_ != null)
            {
                e_h_slv = this.ViewModel_.Excel_hifive_subtypeViewModel_.loaderView();
            }
            else
            {
                this.ViewModel_.Excel_hifive_subtypeViewModel_
                    = new Excel_hifive_stepDown_kiViewModel();

                this.ViewModel_.Excel_hifive_subtypeViewModel_.DefaultSetting(this.viewModel_);

                e_h_slv = this.ViewModel_.Excel_hifive_subtypeViewModel_.loaderView();
            }

            //try { e_h_slv.BaseUnderlyingValue_ = Convert.ToDouble(this.viewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_[0].BasePrice_); }
            //catch (Exception) { }

            //default  // -> loaderView 내부로 전부 보냄
            //e_h_slv.SelectedViewModel_ = new Excel_hifive_stepDown_kiViewModel();
            //e_h_slv.SelectedViewModel_.Excel_underlyingCalcInfoViewModel_ = this.ViewModel_.Excel_underlyingCalcInfoViewModel_;

            e_h_slv.SelectedViewModel_.EffectiveDate_ = this.viewModel_.Excel_issueInfoViewModel_.EffectiveDate_;
            e_h_slv.SelectedViewModel_.MaturityDate_ = this.viewModel_.Excel_issueInfoViewModel_.MaturityDate_;

            //e_h_slv.SelectedViewModel_.ProductString_
            //    = @"Type=2 Stock Step Down Double Callable;Underlyings=우리투자증권,하나금융지주;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=11.3;EffectiveDate=2013-07-08;";

            w.Content = e_h_slv;

            if (w.ShowDialog() == true)
            {

                this.viewModel_.updateFromSubType(e_h_slv.SelectedViewModel_);

                //e_h_slv.SelectedViewModel_.excel_scheduleListVMBuild();
                //this.viewModel_.Excel_scheduleListViewModel_.setScheduleFromClone(e_h_slv.SelectedViewModel_.Excel_scheduleListViewModel_);

                //this.viewModel_.Excel_hifive_subtypeViewModel_ = e_h_slv.SelectedViewModel_;

                //e_h_slv.SelectedViewModel_.excel_kiEventCalculationBuild();

                //this.viewModel_.Excel_kiEventCalculationViewModel_ = e_h_slv.SelectedViewModel_.Excel_kiEventCalculationViewModel_;

                //this.kiEventCalculationGrid_.Children.Clear();
                //this.kiEventCalculationGrid_.Children.Add(this.viewModel_.Excel_kiEventCalculationViewModel_.view());


                //// gen된 schedule을 기준으로 maturity를 조정함.
                //int lastCount = this.viewModel_.Excel_scheduleListViewModel_.Excel_scheduleViewModel_.Count;

                //this.viewModel_.Excel_issueInfoViewModel_.EffectiveDate_ =
                //    this.viewModel_.Excel_hifive_subtypeViewModel_.EffectiveDate_;

                //this.viewModel_.Excel_issueInfoViewModel_.MaturityDate_ =
                //    this.viewModel_.Excel_scheduleListViewModel_.Excel_scheduleViewModel_[lastCount - 1].PayoffDate_;

            }
            else
            {

            }


        }



        //private void SubTypeSet_Button_Click(object sender, RoutedEventArgs e)
        //{
        //    // 전달함 
        //    this.viewModel_.Excel_hifive_subtypeViewModel_.EffectiveDate_ =
        //        this.viewModel_.Excel_issueInfoViewModel_.EffectiveDate_;

        //    this.viewModel_.Excel_hifive_subtypeViewModel_.Excel_underlyingCalcInfoViewModel_
        //        = this.viewModel_.Excel_underlyingCalcInfoViewModel_;

        //    // underlying 이 추가 되거나 하면 excel_sub_에서 underlying을 사용해서 vm이build
        //    // 되었기때문에 다시 빌드함.
        //    this.viewModel_.Excel_underlyingCalcInfoViewModel_.PropertyChanged +=
        //        new System.ComponentModel.PropertyChangedEventHandler(this.viewModel_.Excel_hifive_subtypeViewModel_.underlyingPropertyChangeObserver);

        //    Window w = new Window();
        //    w.Width = 600;
        //    w.Height = 400;
        //    w.Content = this.viewModel_.Excel_hifive_subtypeViewModel_.view();

        //    if (w.ShowDialog() == true)
        //    {
        //        //this.viewModel_.Excel_hifive_subtypeViewModel_.buildProduct();

        //        this.viewModel_.Excel_scheduleListViewModel_ = this.viewModel_.Excel_hifive_subtypeViewModel_.Excel_scheduleListViewModel_;

        //        this.ScheduleGrid_.Children.Clear();
        //        this.ScheduleGrid_.Children.Add(this.viewModel_.Excel_scheduleListViewModel_.view());

        //        //this.KiScheduleGrid_.Children.Clear();
        //        //this.KiScheduleGrid_.Children.Add(this.viewModel_.Excel_hifive_subtypeViewModel_.Excel_kiScheduleListViewModel_.view());
        //    }
        //    else 
        //    {
            
        //    }

        //    // 버튼 누른거에 따라 작업 안할수도 있음

            

        //}

    }
}
