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
    /// Excel_referenceLoaderView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_referenceLoaderView : UserControl
    {
        #region MarketDataManagerViewModel_
        private MarketDataManagerViewModel marketDataManagerViewModel_;
        public MarketDataManagerViewModel MarketDataManagerViewModel_
        {
            get { return this.marketDataManagerViewModel_; }
            set
            {
                if (this.marketDataManagerViewModel_ != value)
                {
                    this.marketDataManagerViewModel_ = value;
                    //this.NotifyPropertyChanged("MarketDataManagerViewModel_");
                }
            }
        }
        #endregion

        #region SelectedReferenceVM_
        private Excel_referenceInformationViewModel selectedReferenceVM_;
        public Excel_referenceInformationViewModel SelectedReferenceVM_
        {
            get { return this.selectedReferenceVM_; }
            set
            {
                if (this.selectedReferenceVM_ != value)
                {
                    this.selectedReferenceVM_ = value;
                    //this.NotifyPropertyChanged("SelectedReferenceVM_");
                }
            }
        }
        #endregion

        public Excel_referenceLoaderView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

            this.loadReference();
        }

        private void DataGrid_LoadingRow_(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void loadReference()
        {
            this.marketDataManagerViewModel_ = new MarketDataManagerViewModel();
            this.marketDataManagerViewModel_.loadDefinedIndexSymbolFromDB();

            //this.ReferenceDataGrid_.ItemsSource = this.marketDataManagerViewModel_.DefinedIndexSymbolList_;

        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //this.viewModel_ = this.DataContext as Excel_scheduleListViewModel;
            //this.ScheduleDataGrid_.ItemsSource = this.viewModel_.Excel_scheduleViewModel_;
        }

        private void resultDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow dgr = sender as DataGridRow;

            if (dgr != null)
            {
                IndexTickerInfo iti = dgr.Item as IndexTickerInfo;

                Excel_referenceInformationViewModel e_rivm = new Excel_referenceInformationViewModel();

                //e_rivm.KrCode_ = iti.KrCode_;
                //e_rivm.Name_ = iti.Name_;

                e_rivm.EntityId_ = "testEntiti_id";
                e_rivm.EntityName_ = "testEntiti_name";

                //e_sivm.BasePrice_ = "testBasePrice";

                this.selectedReferenceVM_ = e_rivm;

                ((Window)this.Parent).DialogResult = true;
                ((Window)this.Parent).Close();
            }

        }


        private void SurmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.ReferenceDataGrid_.SelectedItem == null)
            {
                return;
            }

            ((Window)this.Parent).DialogResult = true;
            ((Window)this.Parent).Close();

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ((Window)this.Parent).DialogResult = false;
            ((Window)this.Parent).Close();
        }
    }
}
