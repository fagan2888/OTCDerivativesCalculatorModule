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
    /// Excel_referenceInformationListView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_referenceInformationListView : UserControl
    {
        #region ViewModel_
        private Excel_referenceInformationListViewModel viewModel_;
        public Excel_referenceInformationListViewModel ViewModel_
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
        private Excel_referenceInformationViewModel selectedViewModel_;
        public Excel_referenceInformationViewModel SelectedViewModel_
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

        public Excel_referenceInformationListView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_referenceInformationListViewModel;
        }

        private void DataGrid_LoadingRow_(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void ReferenceAdd_Button_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();

            Excel_referenceLoaderView e_ulv = new Excel_referenceLoaderView();
            w.Width = 200;
            w.Height = 200;
            w.Content = e_ulv;

            if (w.ShowDialog() == true)
            {
                this.viewModel_.addReferenceInfoVM(e_ulv.SelectedReferenceVM_);

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

            //Excel_referenceBasePriceEditorView e_ubpev = new Excel_referenceBasePriceEditorView();

            //e_ubpev.BasePrice_ = this.selectedViewModel_.BasePrice_;

            //w.Content = e_ubpev;

            //if (w.ShowDialog() == true)
            //{
            //    this.selectedViewModel_.BasePrice_ = e_ubpev.BasePrice_;
            //    this.selectedViewModel_.descriptionUpdate();
            //    this.ReferenceDataGrid_.Items.Refresh();

            //}
            //else
            //{

            //}

        }

        private void ReferenceDataGrid__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.selectedViewModel_ = this.ReferenceDataGrid_.SelectedItem as Excel_referenceInformationViewModel;
        }
    }
}
