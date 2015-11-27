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

namespace RiskMonitor
{
    /// <summary>
    /// BookManagerView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BookManagerView : UserControl
    {

        #region ViewModel_
        private BookManagerViewModel viewModel_;
        public BookManagerViewModel ViewModel_
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

        public BookManagerView()
        {
            InitializeComponent();
            this.viewModel_ = new BookManagerViewModel();
            this.BookListDataGrid_.ItemsSource = this.viewModel_.BookList_;
        }

        private void BookListDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
