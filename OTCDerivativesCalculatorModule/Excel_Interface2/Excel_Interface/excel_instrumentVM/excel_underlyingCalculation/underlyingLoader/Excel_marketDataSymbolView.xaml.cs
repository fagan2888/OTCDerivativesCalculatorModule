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
    /// Excel_marketDataSymbolView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_marketDataSymbolView : UserControl
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
        private Excel_marketDataSymbolViewModel viewModel_;
        public Excel_marketDataSymbolViewModel ViewModel_
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

        #region SelectedSymbol_
        private Excel_marketDataSymbol selectedSymbol_;
        public Excel_marketDataSymbol SelectedSymbol_
        {
            get { return this.selectedSymbol_; }
            set
            {
                if (this.selectedSymbol_ != value)
                {
                    this.selectedSymbol_ = value;
                    this.NotifyPropertyChanged("SelectedSymbol_");
                }
            }
        }
        #endregion

        public Excel_marketDataSymbolView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_marketDataSymbolViewModel;

            this.symbolDataListView_.ItemsSource = this.viewModel_.SymbolDAOList_;

            this.selectedSymbol_ = new Excel_marketDataSymbol();
            //this.bindingPanel_.DataContext = this.SelectedSymbol_;
            //this.ScheduleDataGrid_.ItemsSource = this.viewModel_.Excel_scheduleViewModel_;
        }

        private void AddSymbolButton_Click(object sender, RoutedEventArgs e)
        {
            MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

            dao.DESCRIPTION_ = descriptionTb_.Text;
            dao.NAME_ENG_ = name_engTb_.Text;
            dao.NAME_KOR_ = name_korTb_.Text;
            dao.PROVIDER_ = providerTb_.Text;
            dao.SYMBOL_TYPE_ = symbol_typeTb_.Text;
            dao.SYMBOL_ = symbolTb_.Text;

            dao.insert(DataBaseConnectManager.ConnectionFactory("myDB"));
            this.viewModel_.loadMarketDataSymbolFromDB();

        }

        private void symbolDataListView__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MARKETDATA_SYMBOL_INFO_Table_DAO dao = this.symbolDataListView_.SelectedItem as MARKETDATA_SYMBOL_INFO_Table_DAO;

            if (dao != null)
            {
                this.SelectedSymbol_.setFromDAO(dao);

                descriptionTb_.Text = dao.DESCRIPTION_;
                name_engTb_.Text = dao.NAME_ENG_;
                name_korTb_.Text = dao.NAME_KOR_;
                providerTb_.Text = dao.PROVIDER_;
                symbol_typeTb_.Text = dao.SYMBOL_TYPE_;
                symbolTb_.Text = dao.SYMBOL_;
            }
            //this.bindingPanel_.DataContext = this.SelectedSymbol_;
            //this.bindingPanel_.Text = this.SelectedSymbol_.Symbol_;

        }

        private void deleteSymbolButton_Click(object sender, RoutedEventArgs e)
        {
            // symbol 같은거 수정되면 delete 비활성화

            MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

            dao.DESCRIPTION_ = descriptionTb_.Text;
            dao.NAME_ENG_ = name_engTb_.Text;
            dao.NAME_KOR_ = name_korTb_.Text;
            dao.PROVIDER_ = providerTb_.Text;
            dao.SYMBOL_TYPE_ = symbol_typeTb_.Text;
            dao.SYMBOL_ = symbolTb_.Text;

            dao.delete(DataBaseConnectManager.ConnectionFactory("myDB"));
            this.viewModel_.loadMarketDataSymbolFromDB();

            //MARKETDATA_SYMBOL_INFO_Table_DAO dao = this.symbolDataListView_.SelectedItem as MARKETDATA_SYMBOL_INFO_Table_DAO;

            //this.viewModel_.deleteDao(this.SelectedSymbol_);
            //this.viewModel_.loadMarketDataSymbolFromDB();
        }
    }
}
