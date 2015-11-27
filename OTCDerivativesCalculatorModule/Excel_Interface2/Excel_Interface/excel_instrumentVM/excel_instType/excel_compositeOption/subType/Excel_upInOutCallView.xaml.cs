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
    /// Excel_upInOutCallView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_upInOutCallView : UserControl
    {
        #region ViewModel_
        private Excel_upInOutCallViewModel viewModel_;
        public Excel_upInOutCallViewModel ViewModel_
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

        public Excel_upInOutCallView()
        {
            InitializeComponent();
            inOutComboBox_.ItemsSource = Enum.GetValues(typeof(Excel_multiAsset_upInOutCallViewModel.InOutEnum));
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_upInOutCallViewModel;

            this.bindPanel_.DataContext = this.viewModel_;

        }

        private void AtmCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (this.atmCheckBox_.IsChecked == true)
            {
                this.strikeTxtBox_.Text = "100";
                this.strikeTxtBox_.IsReadOnly = true;
            }
            else
            {
                this.strikeTxtBox_.IsReadOnly = false;
            }

        }

        private void barrierTxtBox__TextChanged(object sender, TextChangedEventArgs e)
        {
            //double barrier = Convert.ToDouble(this.barrierTxtBox_.Text);
            //double baseUnderlyingValue =  Convert.ToDouble(this.baseUnderlyingValueTxtBox_);

            //this.barrierValueTxtBox_.Text = (barrier * baseUnderlyingValue).ToString();
                
        }

    }
}
