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
    /// Excel_multiAsset_vanillaCallPutView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_multiAsset_vanillaCallPutView : UserControl
    {
        #region ViewModel_
        private Excel_multiAsset_vanillaCallPutViewModel viewModel_;
        public Excel_multiAsset_vanillaCallPutViewModel ViewModel_
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

        public Excel_multiAsset_vanillaCallPutView()
        {
            InitializeComponent();
            callPutComboBox_.ItemsSource = Enum.GetValues(typeof(Excel_multiAsset_vanillaCallPutViewModel.CallPutEnum));

            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_multiAsset_vanillaCallPutViewModel;
            this.bindPanel_.DataContext = this.viewModel_;

        }

        private void returnUnderlyingCalcSetBtn_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            Excel_underlyingCalcIDLoaderView e_ucIDlv = this.viewModel_.Excel_underlyingCalcIDViewModel_.loaderView();

            //e_ucIDlv.Excel_underlyingCalcInfoViewModel_ = this.viewModel_.Excel_underlyingCalcInfoViewModel_;

            //e_ucIDlv.SelectedUnderCalcIDTypeViewModel_ = this.viewModel_.Excel_underlyingCalcIDViewModel_.Clone();

            w.Content = e_ucIDlv;

            if (w.ShowDialog() == true)
            {

                this.viewModel_.Excel_underlyingCalcIDViewModel_
                    = e_ucIDlv.SelectedUnderCalcIDTypeViewModel_;

                this.viewModel_.Excel_underlyingCalcIDViewModel_.descriptionUpdate();

                this.returnUnderCalcDescriptionTxb_.Text = this.viewModel_.Excel_underlyingCalcIDViewModel_.Description_;
            }
            else
            {

            }

        }
    }
}
