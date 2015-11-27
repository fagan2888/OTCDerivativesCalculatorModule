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
    /// ScheduleGeneratorView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ScheduleGeneratorView : UserControl
    {
        #region ViewModel_
        private ScheduleGeneratorViewModel viewModel_;
        public ScheduleGeneratorViewModel ViewModel_
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

        public ScheduleGeneratorView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as ScheduleGeneratorViewModel;

            this.frequencyCombo_.ItemsSource = Enum.GetValues(typeof(QLNet.Frequency));
            this.businessDayConvCombo_.ItemsSource = Enum.GetValues(typeof(QLNet.BusinessDayConvention));
            this.dateGenerationConv_.ItemsSource = Enum.GetValues(typeof(QLNet.DateGeneration.Rule));

            this.bindingPanel_.DataContext = this.viewModel_;

            //this.ScheduleDataGrid_.ItemsSource = this.viewModel_.Dates_;
        }

        private void DataGrid_LoadingRow_(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void DateGen_Button_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel_.genDates();
            //this.ScheduleDataGrid_.Items.Refresh();
        }

        private void CalendarButton_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            Excel_calendarLoaderViewModel e_clvm = new Excel_calendarLoaderViewModel();

            w.Content = e_clvm.view();

            if (w.ShowDialog() == true)
            {
                this.viewModel_.Excel_calendarViewModel_  = e_clvm.getCalendar();
                this.calendarStr_.Text = this.viewModel_.Excel_calendarViewModel_.description();
            }
            else
            {

            }
        }

        //private void SurmitButton_Click(object sender, RoutedEventArgs e)
        //{
        //    ((Window)this.Parent).DialogResult = true;
        //    ((Window)this.Parent).Close();
        //}

        //private void CancelButton_Click(object sender, RoutedEventArgs e)
        //{
        //    ((Window)this.Parent).DialogResult = false;
        //    ((Window)this.Parent).Close();
        //}

    }
}
