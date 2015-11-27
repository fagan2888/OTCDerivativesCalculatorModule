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
    /// UnderlyingParameterView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UnderlyingInfoParameterView : UserControl
    {

        #region UnderlyingInfoParaViewModel_
        private UnderlyingInfoParameterViewModel underlyingInfoParaViewModel_;
        public UnderlyingInfoParameterViewModel UnderlyingInfoParaViewModel_
        {
            get { return this.underlyingInfoParaViewModel_; }
            set
            {
                if (this.underlyingInfoParaViewModel_ != value)
                {
                    this.underlyingInfoParaViewModel_ = value;
                    this.NotifyPropertyChanged("UnderlyingInfoParaViewModel_");
                }
            }
        }
        #endregion

        public UnderlyingInfoParameterView()
        {
            InitializeComponent();
        }

        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

    }
}
