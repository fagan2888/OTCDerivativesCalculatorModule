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
    /// GeneralScheduleInfoView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GeneralScheduleInfoView : UserControl
    {
        #region ViewModel_
        private GeneralScheduleInfoViewModel viewModel_;
        public GeneralScheduleInfoViewModel ViewModel_
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
        private GeneralScheduleViewModel selectedViewModel_;
        public GeneralScheduleViewModel SelectedViewModel_
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

        public GeneralScheduleInfoView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as GeneralScheduleInfoViewModel;
            this.scheduleDataGrid_.ItemsSource = this.viewModel_.GeneralScheduleVMList_;
        }

        private void DataGrid_LoadingRow_(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        public void refreshDataContext()
        {

        }

        private void addSchedule_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel_.GeneralScheduleVMList_.Add(new GeneralScheduleViewModel());
            this.scheduleDataGrid_.Items.Refresh();

            // stepMonth 를 재조정함..처음에는 발행일이랑 계산함..
        }

        private void deleteSchedule_Click(object sender, RoutedEventArgs e)
        {

        }

        private void modelEditBtn_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            GeneralScheduleEditorView gsev = new GeneralScheduleEditorView();

            gsev.SelectedDetailScheduleVM_ =
                this.selectedViewModel_.GeneralScheduleDeatilViewModel_.Clone();

            w.Content = gsev;

            if (w.ShowDialog() == true)
            {
                this.selectedViewModel_.GeneralScheduleDeatilViewModel_
                    = gsev.SelectedDetailScheduleVM_;

                this.selectedViewModel_.descriptionUpdate();
            }
            else
            {

            }

        }

        private void scheduleDataGrid__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.selectedViewModel_ = this.scheduleDataGrid_.SelectedItem as GeneralScheduleViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.viewModel_.GeneralScheduleVMList_.Count > 0)
            {
                // 마지막꺼를 가져옴.
                string lastEventDate = this.viewModel_.GeneralScheduleVMList_[this.viewModel_.GeneralScheduleVMList_.Count - 1].EventDate_;

                // 더해서 넣음.. 

                this.viewModel_.GeneralScheduleVMList_.Add(GeneralScheduleViewModel.Create(lastEventDate));
            }
            else
            {
                this.viewModel_.GeneralScheduleVMList_.Add(GeneralScheduleViewModel.Create(this.viewModel_.ScheduleInitialDate_.ToString("yyyyMMdd")));
            }

        }


    }
}
