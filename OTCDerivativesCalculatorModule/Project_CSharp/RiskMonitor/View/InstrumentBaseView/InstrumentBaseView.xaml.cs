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
    /// InstrumentBaseView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class InstrumentBaseView : UserControl
    {

        //InstrumentBaseViewModel
        #region ViewModel_
        private InstrumentBaseViewModel viewModel_;
        public InstrumentBaseViewModel ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    this.initializeView();
                }
            }
        }
        #endregion

        public InstrumentBaseView()
        {
            InitializeComponent();
        }

        private void initializeView()
        {
            this.InformationGrid_.Children.Add(viewModel_.View_);
            //this.ResultGrid_.Children.Add(viewModel_.ResultView_);
            //this.ParameterGrid_.Children.Add(viewModel_.ParameterView_);
        }

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            PositionSingletonManger.positionMasterVM().addInstrument(viewModel_);
        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
