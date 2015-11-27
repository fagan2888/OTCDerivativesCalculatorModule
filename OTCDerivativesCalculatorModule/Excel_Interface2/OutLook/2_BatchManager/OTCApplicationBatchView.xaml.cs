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
    /// OTCApplicationBatchView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OTCApplicationBatchView : UserControl
    {
        #region ViewModel_
        private OTCApplicationBatchViewModel viewModel_;
        public OTCApplicationBatchViewModel ViewModel_
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

        public OTCApplicationBatchView()
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
            if (this.DataContext != null)
            {
                this.viewModel_ = this.DataContext as OTCApplicationBatchViewModel;

                this.batchItemDataGrid_.ItemsSource = this.viewModel_.WholeBatchItemViewModel_;
            }
        }

        private void loadBtn__Click(object sender, RoutedEventArgs e)
        {
            this.viewModel_.loadWholeBatchItem(this.viewModel_.ReferenceDate_);

        }

        private void batchItemDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow dgr = sender as DataGridRow;

            //if (dgr != null)
            //{
            //    IndexTickerInfo iti = dgr.Item as IndexTickerInfo;

            //    Excel_referenceInformationViewModel e_rivm = new Excel_referenceInformationViewModel();

            //    //e_rivm.KrCode_ = iti.KrCode_;
            //    //e_rivm.Name_ = iti.Name_;

            //    e_rivm.EntityId_ = "testEntiti_id";
            //    e_rivm.EntityName_ = "testEntiti_name";

            //    //e_sivm.BasePrice_ = "testBasePrice";

            //    this.selectedReferenceVM_ = e_rivm;

            //}

        }

        private void parameterBuildButton_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel_.parameterBuildBatch();

        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel_.calculateBatch();

            this.logTextBox_.Text = "startTime : " + this.viewModel_.CalculationStartTime_.ToString("HH:mm:ss");
            this.logTextBox_.Text = this.logTextBox_.Text + "\n" + "endTime : " + this.viewModel_.CalculationEndTime_.ToString("HH:mm:ss");
            this.logTextBox_.Text = this.logTextBox_.Text + "\n" + "calculation time : " + this.viewModel_.TimeSpan_.Minutes + "분 " + this.viewModel_.TimeSpan_.Seconds + "초";
        }


    }
}
