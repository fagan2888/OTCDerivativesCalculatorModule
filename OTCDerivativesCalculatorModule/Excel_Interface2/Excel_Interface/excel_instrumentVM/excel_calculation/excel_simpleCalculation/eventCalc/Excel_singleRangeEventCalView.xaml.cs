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
    /// Excel_singleRangeEventCalView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_singleRangeEventCalView : UserControl
    {
        #region ViewModel_
        private Excel_singleRangeEventCalViewModel viewModel_;
        public Excel_singleRangeEventCalViewModel ViewModel_
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

        public Excel_singleRangeEventCalView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_singleRangeEventCalViewModel;

        }

        private void eventUnderCalcIDBtn_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            Excel_underlyingCalcIDLoaderView e_ucIDlv = this.ViewModel_.Excel_underlyingCalcIDViewModel_.loaderView() as Excel_underlyingCalcIDLoaderView;

            w.Content = e_ucIDlv;

            if (w.ShowDialog() == true)
            {

                this.viewModel_.Excel_underlyingCalcIDViewModel_ = e_ucIDlv.SelectedUnderCalcIDTypeViewModel_;

                this.viewModel_.Excel_underlyingCalcIDViewModel_.descriptionUpdate();

                this.eventUnderCalcDescriptionTxb_.Text = this.viewModel_.Excel_underlyingCalcIDViewModel_.Description_;
            }
            else
            {

            }
        }
    }
}
