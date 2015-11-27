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
    /// Excel_vanillaCallPutView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_vanillaCallPutView : UserControl
    {
        #region ViewModel_
        private Excel_vanillaCallPutViewModel viewModel_;
        public Excel_vanillaCallPutViewModel ViewModel_
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
        
        public Excel_vanillaCallPutView()
        {
            InitializeComponent();
            callPutComboBox_.ItemsSource = Enum.GetValues(typeof(Excel_vanillaCallPutViewModel.CallPutEnum));

            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_vanillaCallPutViewModel;
            this.bindPanel_.DataContext = this.viewModel_;

        }

        private void StrikeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            
        }

    }
}
