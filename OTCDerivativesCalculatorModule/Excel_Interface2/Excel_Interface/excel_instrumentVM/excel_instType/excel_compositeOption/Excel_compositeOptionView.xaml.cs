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
using System.Globalization;

namespace Excel_Interface
{
    /// <summary>
    /// Excel_compositeOptionView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_compositeOptionView : UserControl
    {
        #region ViewModel_
        private Excel_compositeOptionViewModel viewModel_;
        public Excel_compositeOptionViewModel ViewModel_
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

        public Excel_compositeOptionView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

            notionalPaymentCheckBox_.IsChecked = true;

        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_compositeOptionViewModel;

            this.IssueInfoGrid_.Children.Clear();
            this.IssueInfoGrid_.Children.Add(this.viewModel_.Excel_issueInfoViewModel_.view());

            this.UnderlyingInfoGrid_.Children.Clear();
            this.UnderlyingInfoGrid_.Children.Add(this.viewModel_.Excel_underlyingCalcInfoViewModel_.view());

            this.optionSubTypeListView_.ItemsSource = this.viewModel_.Excel_compositeOption_subtypeViewModelList_;

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //Excel_compositeOption_subtypeViewModel subTypeOptionVM = new 
            //this.viewModel_.Excel_compositeOption_subtypeViewModelList_.Add(subTypeOptionVM);

            if (this.viewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_.Count < 1)
            {
                MessageBox.Show("underlying Asset need.");
            }

            Window w = new Window();
            w.Width = 500;
            w.Height = 300;

            Excel_compositeOptionLoaderView e_colv;// = new Excel_compositeOptionLoaderView();

            //default
            //e_colv.SelectedOptionTypeViewModel_ = new Excel_vanillaCallPutViewModel();

            //e_colv.initialize(new Excel_vanillaCallPutViewModel());

            e_colv = this.viewModel_.defaultLoaderView();
            w.Content = e_colv;

            if (w.ShowDialog() == true)
            {
                e_colv.SelectedOptionTypeViewModel_.descriptionUpdate();

                this.viewModel_.Excel_compositeOption_subtypeViewModelList_.Add
                    (e_colv.SelectedOptionTypeViewModel_);
            }
            else
            {

            }

        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel_.Excel_compositeOption_subtypeViewModelList_.Clear();
            this.optionSubTypeListView_.Items.Refresh();
        }

        private void optionSubTypeListView_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            ;// = new Excel_compositeOptionLoaderView();

            //e_colv.InterfaceViewModel_ = this.viewModel_;

            Excel_compositeOption_subtypeViewModel selectedItem 
                = this.optionSubTypeListView_.SelectedItem as Excel_compositeOption_subtypeViewModel;

            Excel_compositeOptionLoaderView e_colv = selectedItem.Clone().loaderView(this.viewModel_); 

            //e_colv.SelectedOptionTypeViewModel_ = selectedItem.Clone();

            //e_colv.SelectedOptionTypeViewModel_.loaderView(this.viewModel_);

            w.Content = e_colv;

            int selectionIndex = this.optionSubTypeListView_.SelectedIndex;

            if (w.ShowDialog() == true)
            {

                this.viewModel_.Excel_compositeOption_subtypeViewModelList_[selectionIndex] 
                    = e_colv.SelectedOptionTypeViewModel_;

                e_colv.SelectedOptionTypeViewModel_.descriptionUpdate();
            }
            else
            {

            }

        }

        private void notionalPaymentCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.IsChecked == true)
            {
                notionalPaymentTB_.Text = "100";
                notionalPaymentTB_.IsReadOnly = false;
                notionalPaymentTB_.Foreground = Brushes.Black;
            }
            else 
            {
                notionalPaymentTB_.Text = "0.0";
                notionalPaymentTB_.IsReadOnly = true;
                notionalPaymentTB_.Foreground = Brushes.Gray;
            }


        }

    
    }


    
}
