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
    /// Excel_underlyingCalcInfoView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_underlyingCalcInfoView : UserControl
    {
        #region ViewModel_
        private Excel_underlyingCalcInfoViewModel viewModel_;
        public Excel_underlyingCalcInfoViewModel ViewModel_
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
        private Excel_underlyingInfoViewModel selectedViewModel_;
        public Excel_underlyingInfoViewModel SelectedViewModel_
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

        public Excel_underlyingCalcInfoView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_underlyingCalcInfoViewModel;
            //this.UnderlyingDataGrid_.ItemsSource = this.viewModel_.Excel_underlyingInfoViewModel_;

            //Binding b = new Binding() { Source = this.viewModel_.Excel_underlyingInfoViewModel_ ;
            //                            isas}

            //this.UnderlyingDataGrid_.SetBinding(
            
        }

        private void DataGrid_LoadingRow_(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void UnderlyingAdd_Button_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();

            //Excel_underlyingLoaderView e_ulv = new Excel_underlyingLoaderView();

            Excel_underlyingLoaderViewModel e_ulvm = new Excel_underlyingLoaderViewModel();

            w.Width = 600;
            w.Height = 400;
            w.Content = e_ulvm.view();

            if (w.ShowDialog() == true)
            {
                string underType = e_ulvm.SelectedUnderlyingVM_.Excel_type_;
                string code = e_ulvm.SelectedUnderlyingVM_.KrCode_;

                // default로 basePrice effective일로 함.
                e_ulvm.SelectedUnderlyingVM_.BasePrice_ 
                    = Excel_loaderViewModel.loadMarketData(this.viewModel_.EffectiveDate_, underType, code);

                this.viewModel_.addUnderlyingInfoVM(e_ulvm.SelectedUnderlyingVM_);
            }
            else 
            {
            
            }

            //this.viewModel_.Excel_underlyingInfoViewModel_.Add();
        }

        private void basePriceEditBtn_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            Excel_underlyingBasePriceEditorView e_ubpev = new Excel_underlyingBasePriceEditorView();

            e_ubpev.BasePrice_ = this.selectedViewModel_.BasePrice_;

            w.Content = e_ubpev;

            if (w.ShowDialog() == true)
            {
                this.selectedViewModel_.BasePrice_ = e_ubpev.BasePrice_;
                this.selectedViewModel_.descriptionUpdate();
                this.UnderlyingDataGrid_.Items.Refresh();
                
            }
            else
            {

            }

        }

        private void UnderlyingDataGrid__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.selectedViewModel_ = this.UnderlyingDataGrid_.SelectedItem as Excel_underlyingInfoViewModel;
        }

        private void UnderlyingDataGrid__PreviewKeyDown(object sender, KeyEventArgs e)
        {

            Excel_underlyingInfoViewModel e_ivm = ((DataGrid)sender).SelectedItem as Excel_underlyingInfoViewModel;

            if (Key.Delete == e.Key)
            {
                this.viewModel_.Excel_underlyingInfoViewModel_.Remove(e_ivm);
                //this.UnderlyingDataGrid_.Items.Refresh();
            }
        }

    }
}
