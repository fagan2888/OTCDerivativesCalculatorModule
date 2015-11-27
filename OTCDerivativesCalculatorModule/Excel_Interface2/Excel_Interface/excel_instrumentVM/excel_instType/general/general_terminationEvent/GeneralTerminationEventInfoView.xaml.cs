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
    /// GeneralTerminationEventView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GeneralTerminationEventInfoView : UserControl
    {
        #region ViewModel_
        private GeneralTerminationEventInfoViewModel viewModel_;
        public GeneralTerminationEventInfoViewModel ViewModel_
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
        private GeneralTerminationEventViewModel selectedViewModel_;
        public GeneralTerminationEventViewModel SelectedViewModel_
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

        public GeneralTerminationEventInfoView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as GeneralTerminationEventInfoViewModel;
            this.terminationDataGrid_.ItemsSource = this.viewModel_.GeneralTerminationEventVMList_;
        }

        private void DataGrid_LoadingRow_(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        public void refreshDataContext()
        { 
            
        }

        private void addTerminationEvent_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel_.GeneralTerminationEventVMList_.Add(new GeneralTerminationEventViewModel());
        }

        private void deleteTerminationEvent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void modelEditBtn_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            GeneralTerminationEventEditorView gteev = new GeneralTerminationEventEditorView();

            gteev.SelectedDetailTerminationVM_=
                this.selectedViewModel_.GeneralTerminationEventDetailViewModel_.Clone();

            w.Content = gteev;

            if (w.ShowDialog() == true)
            {
                this.selectedViewModel_.GeneralTerminationEventDetailViewModel_
                    = gteev.SelectedDetailTerminationVM_;

                this.selectedViewModel_.descriptionUpdate();
            }
            else
            {

            }
        }

        private void terminationDataGrid__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.selectedViewModel_ = this.terminationDataGrid_.SelectedItem as GeneralTerminationEventViewModel;
        }
    }
}
