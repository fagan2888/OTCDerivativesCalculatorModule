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
    /// Excel_CalendarLoaderView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_calendarLoaderView : UserControl
    {
        #region ViewModel_
        private Excel_calendarLoaderViewModel viewModel_;
        public Excel_calendarLoaderViewModel ViewModel_
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

        public Excel_calendarLoaderView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_calendarLoaderViewModel;
        }

        private void SurmitButton_Click(object sender, RoutedEventArgs e)
        {
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
