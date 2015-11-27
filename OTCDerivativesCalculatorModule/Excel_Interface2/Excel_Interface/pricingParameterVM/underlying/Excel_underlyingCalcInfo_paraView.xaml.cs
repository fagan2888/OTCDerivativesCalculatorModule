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
    /// Excel_underlyingCalcInfo_paraView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_underlyingCalcInfo_paraView : UserControl
    {
        #region ViewModel_
        private Excel_underlyingCalcInfo_paraViewModel viewModel_;
        public Excel_underlyingCalcInfo_paraViewModel ViewModel_
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
        private Excel_underlyingInfo_paraViewModel selectedViewModel_;
        public Excel_underlyingInfo_paraViewModel SelectedViewModel_
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

        public Excel_underlyingCalcInfo_paraView()
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
            this.viewModel_ = this.DataContext as Excel_underlyingCalcInfo_paraViewModel;

            this.UnderlyingParaGrid_.ItemsSource = this.viewModel_.Excel_underlyingInfo_paraViewModel_;

            this.correlationDataGrid_.ItemsSource = this.viewModel_.Excel_correlationInfo_paraViewModel_.Excel_correlation_paraViewModel_;

            //this.correlationGrid_.Children.Clear();
            //this.correlationGrid_.Children.Add(this.viewModel_.CorrelationInfo_paraViewModel_.View_);

        }

        private void modelEditBtn_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            Excel_underlyingModelEditorView e_umev = new Excel_underlyingModelEditorView();

            //안쪽에서 clone 복사함
            e_umev.initializedModelVM(this.selectedViewModel_.Excel_underlyingModel_paraViewModel_);

            //e_umev.SelectedUnderlyingModelVM_ =
            //    this.selectedViewModel_.Excel_underlyingModel_paraViewModel_.Clone();

            w.Content = e_umev;

            if (w.ShowDialog() == true)
            {
                this.selectedViewModel_.Excel_underlyingModel_paraViewModel_
                    = e_umev.SelectedUnderlyingModelVM_.Clone();

                this.UnderlyingParaGrid_.Items.Refresh();
            }
            else
            { 
            
            }

        }

        private void UnderlyingParaGrid__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.selectedViewModel_ = this.UnderlyingParaGrid_.SelectedItem as Excel_underlyingInfo_paraViewModel;
        }


    }
}
