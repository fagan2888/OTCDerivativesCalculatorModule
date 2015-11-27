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
using System.Data.SQLite;

namespace SimpleCalculator
{
    /// <summary>
    /// SimplePositionView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SimplePositionView : UserControl
    {

        #region ViewModel_
        private RiskMonitor.PositionMasterViewModel viewModel_;
        public RiskMonitor.PositionMasterViewModel ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                }
            }
        }
        #endregion

        public SimplePositionView()
        {
            InitializeComponent();

            this.viewModel_ = RiskMonitor.PositionSingletonManger.positionMasterVM();
            this.viewModel_.ReferenceDate_ = new DateTime(2013, 10, 26);
            this.referenceDatePicker_.DataContext = this.viewModel_;

        }

        private void makeDB()
        {
            try
            {
                string dbConnectionStr = "Data Source=D:\\Project File\\OTCDerivativesCalculatorModule\\SimpleCalculator\\bin\\Debug\\Data\\Data_Interface\\otcDB.db";
                SQLiteConnection cnn = new SQLiteConnection(dbConnectionStr);
                cnn.Open();
                cnn.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        private void LoadDBButton_Click(object sender, RoutedEventArgs e)
        {
            this.makeDB();
            this.viewModel_.loadDBPosition("");
            this.positionListDataGrid_.ItemsSource = this.viewModel_.InstPositionWrapperVMList_;

        }

        private void positionListDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //RiskMonitor.InstPositionWrapperVM selectedVM = sender as RiskMonitor.InstPositionWrapperVM;

            RiskMonitor.InstPositionWrapperVM selectedVM = this.positionListDataGrid_.SelectedItem as RiskMonitor.InstPositionWrapperVM;

            selectedVM.InstBaseVM_.loadAll();

            var newWindow = new Window();
            newWindow.Content = selectedVM.view();
            newWindow.Width = 300;
            newWindow.Height = 300;
            newWindow.Show();
            
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            RiskMonitor.InstrumentSelectorViewModel vm = new RiskMonitor.InstrumentSelectorViewModel();
            RiskMonitor.InstrumentSelectorView view = new RiskMonitor.InstrumentSelectorView();
            
            view.DataContext = vm;

            view.Width = 300;
            view.Height = 300;
            view.ShowDialog();

            var newWindow = new Window();
            newWindow.Width = 300;
            newWindow.Height = 300;
            newWindow.Content = view.SelectedInstBaseVM_.View_;
            newWindow.Show();

        }

        private void BatchButton_Click(object sender, RoutedEventArgs e)
        {
            RiskMonitor.BatchManagerViewModel vm = new RiskMonitor.BatchManagerViewModel();
            RiskMonitor.BatchManagerView view = new RiskMonitor.BatchManagerView();
            view.DataContext = vm;

            var newWindow = new Window();
            newWindow.Content = view;

            newWindow.Width = 300;
            newWindow.Height = 300;
            newWindow.ShowDialog();

        }

        private void positionListDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }


    }
}
