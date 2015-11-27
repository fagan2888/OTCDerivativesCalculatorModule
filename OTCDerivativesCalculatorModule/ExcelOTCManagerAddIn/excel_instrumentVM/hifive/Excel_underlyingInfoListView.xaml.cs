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
using RiskMonitor;

namespace ExcelOTCManagerAddIn
{
    /// <summary>
    /// Excel_underlyingInfoListView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_underlyingInfoListView : UserControl
    {

        #region ViewModel_
        private Excel_underlyingInfoListViewModel viewModel_;
        public Excel_underlyingInfoListViewModel ViewModel_
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

        public Excel_underlyingInfoListView()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            // 새창을 띄움.
            // underlying Info를 받아서 
            // 
            // Excel_underlyingInfoListViewModel 를 생성하고, 추가함

            // 이거하고 연결됨놈이 있음 set에도 Update

        }

    }
}
