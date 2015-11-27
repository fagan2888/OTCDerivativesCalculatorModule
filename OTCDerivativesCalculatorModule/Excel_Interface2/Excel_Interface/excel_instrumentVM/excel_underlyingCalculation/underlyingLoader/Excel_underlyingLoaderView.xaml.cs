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
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    /// <summary>
    /// Excel_underlyingLoaderView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_underlyingLoaderView : UserControl
    {
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region ViewModel_
        private Excel_underlyingLoaderViewModel viewModel_;
        public Excel_underlyingLoaderViewModel ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    this.NotifyPropertyChanged("ViewModel_");
                }
            }
        }
        #endregion

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

        //#region SelectedUnderlyingVM_
        //private Excel_underlyingInfoViewModel selectedUnderlyingVM_;
        //public Excel_underlyingInfoViewModel SelectedUnderlyingVM_
        //{
        //    get { return this.selectedUnderlyingVM_; }
        //    set
        //    {
        //        if (this.selectedUnderlyingVM_ != value)
        //        {
        //            this.selectedUnderlyingVM_ = value;
        //            //this.NotifyPropertyChanged("SelectedUnderlyingVM_");
        //        }
        //    }
        //}
        //#endregion

        public Excel_underlyingLoaderView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

            this.loadUnderlying();
        }

        private void DataGrid_LoadingRow_(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void loadUnderlying()
        {
            this.marketDataManagerViewModel_ = new MarketDataManagerViewModel();
            this.marketDataManagerViewModel_.loadDefinedIndexSymbolFromDB();

            this.UnderlyingDataGrid_.ItemsSource = this.marketDataManagerViewModel_.DefinedIndexSymbolList_;

        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_underlyingLoaderViewModel;

            this.equityTabGrid_.Children.Clear();
            this.equityTabGrid_.Children.Add(this.viewModel_.Excel_equityLoaderViewModel_.view());

            this.indexTabGrid_.Children.Clear();
            this.indexTabGrid_.Children.Add(this.viewModel_.Excel_indexLoaderViewModel_.view());

            this.fxCurveTabGrid_.Children.Clear();
            this.fxCurveTabGrid_.Children.Add(this.viewModel_.Excel_fxLoaderViewModel_.view());

            this.irTabGrid_.Children.Clear();
            this.irTabGrid_.Children.Add(this.viewModel_.Excel_irLoaderViewModel_.view());

            this.irCurveTabGrid_.Children.Clear();
            this.irCurveTabGrid_.Children.Add(this.viewModel_.Excel_irCurveLoaderViewModel_.view());

            this.creditCurveTabGrid_.Children.Clear();
            this.creditCurveTabGrid_.Children.Add(this.viewModel_.Excel_creditCurveLoaderViewModel_.view());

            this.commTabGrid_.Children.Clear();
            this.commTabGrid_.Children.Add(this.viewModel_.Excel_commLoaderViewModel_.view());


            //this.ScheduleDataGrid_.ItemsSource = this.viewModel_.Excel_scheduleViewModel_;
        }

        private void resultDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow dgr = sender as DataGridRow;

            //if (dgr != null)
            //{
            //    IndexTickerInfo iti = dgr.Item as IndexTickerInfo;

            //    if ( iti.Index_type_.ToUpper() == "STOCK" )
            //    {
                    Excel_stockIndexViewModel e_sivm = new Excel_stockIndexViewModel();

            //        e_sivm.KrCode_ = iti.KrCode_;
            //        e_sivm.Name_ = iti.Name_;
            //        //e_sivm.BasePrice_ = "testBasePrice";

            //        this.selectedUnderlyingVM_ = e_sivm;
            //    }
            //    else if ( iti.Index_type_ == "CURRENCY" )
            //    {
            //        throw new NotImplementedException();
            //    }
            //    else if (iti.Index_type_ == "INTERESTRATE")
            //    {
            //        throw new NotImplementedException();
            //    }
            //    else if (iti.Index_type_ == "SWAPRATE")
            //    {
            //        throw new NotImplementedException();
            //    }
            //    else 
            //    {
            //        throw new NotImplementedException();
            //    }

            //    ((Window)this.Parent).DialogResult = true;
            //    ((Window)this.Parent).Close();
            //}

        }

        private void SurmitButton_Click(object sender, RoutedEventArgs e)
        {

            if (this.UnderlyingDataGrid_.SelectedItem == null)
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

        private void tabControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.viewModel_.SelectedUnderlyingVM_ != null)
            {
                ((Window)this.Parent).DialogResult = true;
                ((Window)this.Parent).Close();
            }
        }

        private void symbolButton_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();

            Excel_marketDataSymbolViewModel e_mdsvm = new Excel_marketDataSymbolViewModel();

            e_mdsvm.loadMarketDataSymbolFromDB();

            w.Width = 200;
            w.Height = 200;
            w.Content = e_mdsvm.view();

            if (w.ShowDialog() == true)
            {
                //this.viewModel_.addUnderlyingInfoVM(e_ulvm.SelectedUnderlyingVM_);


            }
            else
            {

            }

            this.viewModel_.reload();

        }

    }
}
