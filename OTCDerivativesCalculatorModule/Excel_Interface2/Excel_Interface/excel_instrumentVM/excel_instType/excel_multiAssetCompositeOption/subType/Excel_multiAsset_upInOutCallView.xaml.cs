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
    /// Excel_multiAsset_upInOutCallView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_multiAsset_upInOutCallView : UserControl
    {
        #region ViewModel_
        private Excel_multiAsset_upInOutCallViewModel viewModel_;
        public Excel_multiAsset_upInOutCallViewModel ViewModel_
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

        public Excel_multiAsset_upInOutCallView()
        {
            InitializeComponent();
            inOutComboBox_.ItemsSource = Enum.GetValues(typeof(Excel_multiAsset_upInOutCallViewModel.InOutEnum));
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_multiAsset_upInOutCallViewModel;

            this.bindPanel_.DataContext = this.viewModel_;


        }

        private void AtmCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (this.atmCheckBox_.IsChecked == true)
            {
                this.strikeTxtBox_.Text = "100";
                this.strikeTxtBox_.IsReadOnly = true;
            }
            else
            {
                this.strikeTxtBox_.IsReadOnly = false;
            }

        }

        private void barrierTxtBox__TextChanged(object sender, TextChangedEventArgs e)
        {
            //double barrier = Convert.ToDouble(this.barrierTxtBox_.Text);
            //double baseUnderlyingValue =  Convert.ToDouble(this.baseUnderlyingValueTxtBox_);

            //this.barrierValueTxtBox_.Text = (barrier * baseUnderlyingValue).ToString();

        }

        private void returnUnderCalcIDBtn_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            Excel_underlyingCalcIDLoaderView e_ucIDlv = this.viewModel_.ReturnUnderlyingCalcIDViewModel_.loaderView();

            w.Content = e_ucIDlv;

            if (w.ShowDialog() == true)
            {

                this.viewModel_.ReturnUnderlyingCalcIDViewModel_
                    = e_ucIDlv.SelectedUnderCalcIDTypeViewModel_;

                this.viewModel_.ReturnUnderlyingCalcIDViewModel_.descriptionUpdate();

                this.returnUnderCalcDescriptionTxb_.Text = this.viewModel_.ReturnUnderlyingCalcIDViewModel_.Description_;
            }
            else
            {

            }
        }

        private void barrierUnderCalcBtn_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            Excel_underlyingCalcIDLoaderView e_ucIDlv = this.viewModel_.BarrierUnderlyingCalcIDViewModel_.loaderView();

            w.Content = e_ucIDlv;

            if (w.ShowDialog() == true)
            {

                this.viewModel_.BarrierUnderlyingCalcIDViewModel_
                    = e_ucIDlv.SelectedUnderCalcIDTypeViewModel_;

                this.viewModel_.BarrierUnderlyingCalcIDViewModel_.descriptionUpdate();

                this.barrierUnderCalcDescriptionTxb_.Text = this.viewModel_.BarrierUnderlyingCalcIDViewModel_.Description_;
            }
            else
            {

            }
        }
    }
}
