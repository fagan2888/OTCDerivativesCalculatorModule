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
    /// MarketDataManagerView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MarketDataManagerView : UserControl
    {
        #region ViewModel_
        private MarketDataManagerViewModel viewModel_;
        public MarketDataManagerViewModel ViewModel_
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
        private IndexTickerInfo selectedViewModel_;
        public IndexTickerInfo SelectedViewModel_
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

        public MarketDataManagerView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as MarketDataManagerViewModel;
            this.definedIndexList_.ItemsSource = this.viewModel_.DefinedIndexSymbolList_;
        }


        private void AddIndexButton_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel_.addDefinedIndex(this.selectedViewModel_);
            int result = this.viewModel_.historyDataDownload(this.selectedViewModel_);

            //this.selectedViewModel_.
            //string symbol = this.indexSymbolTextBox_.Text;

            if (result == 0)
            {
                this.viewModel_.DefinedIndexSymbolList_.Add(this.selectedViewModel_);

                MessageBoxResult msgBox = MessageBox.Show("success!");
            }
            else
            {
                MessageBoxResult msgBox = MessageBox.Show("fail!");
            }

        }

        private void downLoadButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            IndexTickerInfoEditorView itiev = new IndexTickerInfoEditorView();

            w.Content = itiev;

            if (w.ShowDialog() == true)
            {
                this.selectedViewModel_ = itiev.ViewModel_;
                this.indexSymbolTextBox_.Text = this.selectedViewModel_.Name_;
            }
            else
            {

            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            IndexTickerInfo item = this.definedIndexList_.SelectedItem as IndexTickerInfo;

            this.viewModel_.deleteDefinedIndex(item.Name_);

            this.viewModel_.DefinedIndexSymbolList_.Remove(item);

        }

        private void IndexName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            IndexTickerInfoEditorView itiev = new IndexTickerInfoEditorView();

            // data load
            IndexTickerInfo iti = this.definedIndexList_.SelectedItem as IndexTickerInfo;

            itiev.ViewModel_ = this.viewModel_.loadDefinedIndex(iti.Name_);

            w.Content = itiev;

            if (w.ShowDialog() == true)
            {
                this.selectedViewModel_ = itiev.ViewModel_;
                this.viewModel_.updateDefinedIndex(itiev.ViewModel_);
                //this.indexSymbolTextBox_.Text = this.selectedViewModel_.Name_;
            }
            else
            {

            }
        }

        private void loadButton_Click(object sender, RoutedEventArgs e)
        {
            IndexTickerInfo item = this.definedIndexList_.SelectedItem as IndexTickerInfo;

            IndexHistoryMarketData ihmd = new IndexHistoryMarketData(item);

            DateTime sd = new DateTime(2014, 1, 1);
            DateTime ed = DateTime.Now;
            QLNet.TimeSeries<string> series = ihmd.historySeries(sd, ed);

            this.historyDataGrid_.ItemsSource = series;

        }

        private void redownloadButton_Click(object sender, RoutedEventArgs e)
        {
            IndexTickerInfo selected_ITI = this.definedIndexList_.SelectedItem as IndexTickerInfo;

            int result = this.viewModel_.historyDataDownload(selected_ITI);

            if (result == 0)
            {
                MessageBoxResult msgBox = MessageBox.Show("redownload success!");

                this.loadButton_Click(sender, e);
            }
            else
            {
                MessageBoxResult msgBox = MessageBox.Show("fail!");
            }
        }
    }
}
