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

namespace RiskMonitor
{
    /// <summary>
    /// CorrelationInfo_paraView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CorrelationInfo_paraView : UserControl
    {

        #region ViewModel_
        private CorrelationInfo_paraViewModel viewModel_;
        public CorrelationInfo_paraViewModel ViewModel_
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

        public CorrelationInfo_paraView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as CorrelationInfo_paraViewModel;

            //this.viewModel_.PropertyChanged += new PropertyChangedEventHandler(viewModel_PropertyChanged);

            this.correlationTestGrid_.ItemsSource = this.viewModel_.CorrelationDataList_;

        }

        //private void viewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        //{
        //    if (e.PropertyName == "AddUnderlying")
        //    { this.addUnderlying(sender, e); }
        //    else if (e.PropertyName == "")
        //    { }
        //    else { }

        //}

        private void addUnderlying(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            //CorrelationInfo_paraViewModel vm = sender as CorrelationInfo_paraViewModel;
            
            //string underName = vm.UnderlyingList_[vm.UnderlyingList_.Count - 1];
            //var col = new DataGridTextColumn();
            //col.Header = underName;

            //DataGridRow row = new DataGridRow();
            //row.Header = underName;
                        
            //this.correlationGrid_.Columns.Add(col);
            //this.correlationGrid_.Items.Add(new object());
            
            //this.correlationGrid_.Items.
            
        }

        //private void DataGrid_LoadingRow_(object sender, DataGridRowEventArgs e)
        //{
        //    int count = (e.Row.GetIndex() + 1);

        //    e.Row.Header = this.viewModel_.UnderlyingList_[count - 1];
        //}

        //private void removeUnderlying(string under)
        //{
        //    var col = new DataGridTextColumn();
        //    col.Header = "d";
        //    col.Binding = new Binding("RoomNumber");

        //    this.correlationGrid_.Columns.Add(col);
        //}

    }
}
