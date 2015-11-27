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
    /// Excel_vanillaReturnCalView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_vanillaReturnCalView : UserControl
    {
        #region ViewModel_
        private Excel_vanillaReturnCalViewModel viewModel_;
        public Excel_vanillaReturnCalViewModel ViewModel_
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

        public Excel_vanillaReturnCalView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_vanillaReturnCalViewModel;

            //this.viewModel_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.PropertyChanged +=
            //    this.viewModel_.Excel_parameterViewModel_.instrumentEventObserver;
        }

        private void returnUnderCalcIDBtn_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            //Excel_underlyingCalcIDLoaderView e_ucIDlv = new Excel_underlyingCalcIDLoaderView();
            Excel_underlyingCalcIDLoaderView e_ucIDlv = this.ViewModel_.ReturnUnderlyingCalcIDViewModel_.loaderView() as Excel_underlyingCalcIDLoaderView;
            //e_ucIDlv.Excel_underlyingCalcInfoViewModel_ = this.viewModel_.Excel_underlyingCalcInfoViewModel_;

            //Excel_underlyingCalcIDViewModel selectedItem = this.selectedUnderCalcIDGrid_.SelectedItem as Excel_underlyingCalcIDViewModel;

            //e_ucIDlv.SelectedUnderCalcIDTypeViewModel_ = this.viewModel_.ReturnUnderlyingCalcIDViewModel_.Clone();

            w.Content = e_ucIDlv;

            if (w.ShowDialog() == true)
            {

                this.viewModel_.ReturnUnderlyingCalcIDViewModel_
                    = e_ucIDlv.SelectedUnderCalcIDTypeViewModel_;

                //this.viewModel_.ReturnUnderlyingCalcIDViewModel_.descriptionUpdate();

                this.returnUnderCalcDescriptionTxb_.Text = this.viewModel_.ReturnUnderlyingCalcIDViewModel_.Description_;
            }
            else
            {

            }
        }

        //public void setReturnUnderCalcView(int underCount)
        //{

        //}

        public void setReturnUnderCalcView(Excel_underlyingCalcInfoViewModel excel_under)
        {
            if (excel_under == null || excel_under.Excel_underlyingInfoViewModel_.Count == 1)
            {
                this.ReturnUnderCalcPanel_.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                this.ReturnUnderCalcPanel_.Visibility = System.Windows.Visibility.Visible;
            }

            
        }
    }
}
