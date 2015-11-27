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

namespace RiskMonitor
{
    /// <summary>
    /// ResultView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ResultView : UserControl
    {
        #region ViewModel_
        private ResultViewModel viewModel_;
        public ResultViewModel ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    this.DetailResult_.DataContext = value.ReferencDateResult_;
                    // history 부분은 load로 하는 부분이며 binding이 아님.
                    //this.HistoryResultDataGrid_.ItemsSource = ViewModel_.HistoryResultViewModel_.HistoryResults_;
                }
            }
        }
        #endregion

        public ResultView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as ResultViewModel;

            this.bindingPanel_.DataContext = this.viewModel_;
        }

        private void HistoryLoadButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime? InitialDate = InitialDatePicker_.SelectedDate;
            DateTime? LastDate = LastlDatePicker_.SelectedDate;

            viewModel_.loadHistory(InitialDate, LastDate);
        }

        //private void SaveButtonClick_Click(object sender, RoutedEventArgs e)
        //{
        //    //filename string 만들기

        //    //xml string 만들기

        //    //중복하고 파일 네임하고 History에 추가하느거 한고.
            
        //    // 저장함.
        //}

        private void ReferenceDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            //DateTime? selectedDate = this.ReferenceDatePicker_.SelectedDate;
            //this.viewModel_.loadResult(selectedDate);
        }

    }
}
