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
    /// InstrumentInformationView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class InstrumentInformationView : UserControl
    {
        #region ViewModel_
        private InstrumentInformationViewModel viewModel_;
        public InstrumentInformationViewModel ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    this.InformationGrid_.DataContext = value;
                    //this.NotifyPropertyChanged("ViewModel_");
                }
            }
        }
        #endregion

        public InstrumentInformationView() 
        {
            InitializeComponent();
            //this.InformationGrid_.DataContext = this.ViewModel_;
        }

        public InstrumentInformationView(InstrumentInformationViewModel ViewModel)
        {
            InitializeComponent();
            this.ViewModel_ = ViewModel;
            //this.DataContext = this.ViewModel_;
            this.InformationGrid_.DataContext = this.ViewModel_;
        }
    }
}
