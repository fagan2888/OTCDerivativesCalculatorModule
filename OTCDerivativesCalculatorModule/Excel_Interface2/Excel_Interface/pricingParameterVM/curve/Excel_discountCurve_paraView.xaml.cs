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
    /// Excel_discountCurve_paraView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_discountCurve_paraView : UserControl
    {
        #region ViewModel_
        private Excel_discountCurve_paraViewModel viewModel_;
        public Excel_discountCurve_paraViewModel ViewModel_
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

        #region SelectedViewModel_
        private Excel_yieldCurveViewModel selectedViewModel_;
        public Excel_yieldCurveViewModel SelectedViewModel_
        {
            get { return this.selectedViewModel_; }
            set
            {
                if (this.selectedViewModel_ != value)
                {
                    this.selectedViewModel_ = value;
                    //this.NotifyPropertyChanged("SelectedViewModel_");
                }
            }
        }
        #endregion

        public Excel_discountCurve_paraView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_discountCurve_paraViewModel;
            this.DiscountCurveDataGrid_.ItemsSource = this.viewModel_.Excel_yieldCurveViewModel_;
        }

        

        private void DataGrid_LoadingRow_(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        

        private void curveEditBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        // curve para( ex. KRW , USD , VIRTUAL BOND)가 들어와서 박혀 있음. 
        // ( data만 수정 할거임 )
        private void dataEditBtn_Click(object sender, RoutedEventArgs e)
        {

            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            Excel_yieldCurveViewModel e_ycvm = this.DiscountCurveDataGrid_.SelectedItem as Excel_yieldCurveViewModel;

            Excel_interestRateCurveLoaderViewModel e_irclvm = new Excel_interestRateCurveLoaderViewModel();

            e_irclvm.loadCurveHeaderList(ProgramVariable.ReferenceDate_);

            e_irclvm.Excel_yieldCurveViewModel_ = e_ycvm;

            // selected vm 에 적용시켜줌

            w.Content = e_irclvm.view();

            if (w.ShowDialog() == true)
            {
                //e_ycvm.Excel_interpolationViewModel_ = e_irclvm.Excel_interpolationViewModel_;
                e_ycvm.Excel_rateDataViewModel_ = e_irclvm.RateDataViewModel_;

                //clone 복사

                //e_ycvm = 
                
            }
            else
            {

            }


            //this.SelectedViewModel_.Excel_rateDataViewModel_
            //    = e_irclv.RateDataViewModel_;

            //e_irclvm.RateDataGrid_.ItemsSource = this.viewModel_.Excel_CurveViewModel_.Excel_rateDataViewModel_;
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel_.Excel_yieldCurveViewModel_.Clear();

            Excel_yieldCurveViewModel e_ycvm = new Excel_yieldCurveViewModel();

            e_ycvm.Code_ = "testCode";
            e_ycvm.Currency_ = "KRW";
            e_ycvm.Description_ = "testDiscription";
            e_ycvm.Name_ = "KRWBONDCurve";

            e_ycvm.Excel_interpolationViewModel_ = new Excel_interpolationViewModel();

            e_ycvm.loadCurve();

            this.viewModel_.Excel_yieldCurveViewModel_.Add(e_ycvm);


        }

        //private void LoadButton_Click(object sender, RoutedEventArgs e)
        //{
        //    Window w = new Window();
        //    w.Width = 500;
        //    w.Height = 200;

        //    Excel_interestRateCurveLoaderViewModel e_irclvm = new Excel_interestRateCurveLoaderViewModel();

        //    w.Content = e_irclvm.view();

        //    w.ShowDialog();

        //    this.viewModel_.Excel_yieldCurveViewModel_.Excel_rateDataViewModel_
        //        = e_irclvm.RateDataViewModel_;

        //    this.RateDataGrid_.ItemsSource = this.viewModel_.Excel_CurveViewModel_.Excel_rateDataViewModel_;

        //}

        //private void EditButton_Click(object sender, RoutedEventArgs e)
        //{
        //    //Window w = new Window();

        //    //Excel_interpolationViewModel e_ivm 
        //    //    = this.viewModel_.Excel_yieldCurveViewModel_.Excel_interpolationViewModel_.clone();

        //    //w.Width = 200;
        //    //w.Height = 200;
        //    //w.Content = e_ivm.view();

        //    //if (w.ShowDialog() == true)
        //    //{
        //    //    this.viewModel_.Excel_CurveViewModel_.Excel_interpolationViewModel_
        //    //        = e_ivm;
        //    //}
        //    //else
        //    //{

        //    //}
        //}
    }
}
