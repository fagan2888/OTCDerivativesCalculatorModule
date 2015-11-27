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

namespace ExcelAddInRibbonTest
{
    /// <summary>
    /// OptionViewManager.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OptionViewManager : UserControl
    {
        #region ViewModel_
        private OptionManagerViewModel viewModel_;
        public OptionManagerViewModel ViewModel_
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

        public OptionViewManager()
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
            this.viewModel_ = this.DataContext as OptionManagerViewModel;

            this.bindingPanel_.DataContext = this.viewModel_.GBMParaViewModel_;
            this.OPTION_POSITIONCallDataGrid_.ItemsSource = this.viewModel_.CallOptionViewModelList_;
            
            this.OPTION_POSITIONPutDataGrid_.ItemsSource = this.viewModel_.PutOptionViewModelList_;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel_.calculate();

            this.OPTION_POSITIONCallDataGrid_.Items.Refresh();
            this.OPTION_POSITIONPutDataGrid_.Items.Refresh();
        }

        private void OPTION_POSITIONCallDataGrid__PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            //List<OptionViewModel> call_optionList
            //    = this.OPTION_POSITIONCallDataGrid_.SelectedItems.OfType<OptionViewModel>().ToList();

            //OptionViewModel callSumOvm = OptionViewModel.Sum(call_optionList);

            //foreach (var item in call_optionList)
            //{
                
            //}

        }


    }
}
