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
    /// OTCApplcationBookView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OTCApplcationBookView : UserControl
    {
        #region ViewModel_
        private OTCApplicationBookViewModel viewModel_;
        public OTCApplicationBookViewModel ViewModel_
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

        public OTCApplcationBookView()
        {
            InitializeComponent();
        }
    }
}
