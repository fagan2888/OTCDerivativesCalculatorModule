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
    /// Excel_multiAssetCompositeOptionView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_multiAssetCompositeOptionView : UserControl
    {
        #region ViewModel_
        private Excel_multiAssetCompositeOptionViewModel viewModel_;
        public Excel_multiAssetCompositeOptionViewModel ViewModel_
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

        public Excel_multiAssetCompositeOptionView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

            notionalPaymentCheckBox_.IsChecked = true;
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel_ = this.DataContext as Excel_multiAssetCompositeOptionViewModel;

            this.IssueInfoGrid_.Children.Clear();
            this.IssueInfoGrid_.Children.Add(this.viewModel_.Excel_issueInfoViewModel_.view());

            this.UnderlyingInfoGrid_.Children.Clear();
            this.UnderlyingInfoGrid_.Children.Add(this.viewModel_.Excel_underlyingCalcInfoViewModel_.view());

            this.optionSubTypeListView_.ItemsSource = this.viewModel_.Excel_multiAsset_compositeOption_subtypeViewModel_;

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.viewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_.Count < 1)
            { 
                MessageBox.Show("underlying Asset need.");
            }


            Window w = new Window();
            w.Width = 500;
            w.Height = 300;

            Excel_multiAssetCompositeOptionLoaderView e_mcolv;// = new Excel_multiAssetCompositeOptionLoaderView();

            //underlyingInfo를 링크 해줘야하나...? ㅡ.ㅡ;;

            e_mcolv = this.viewModel_.defaultLoaderView();

            w.Content = e_mcolv;

            //e_colv.Excel_underlyingCalcInfoViewModel_ = this.viewModel_.Excel_underlyingCalcInfoViewModel_;

            ////default
            //e_colv.SelectedOptionTypeViewModel_ = new Excel_multiAsset_vanillaCallPutViewModel();

            //w.Content = e_colv;

            if (w.ShowDialog() == true)
            {
                e_mcolv.SelectedOptionTypeViewModel_.descriptionUpdate();

                this.viewModel_.Excel_multiAsset_compositeOption_subtypeViewModel_.Add
                    (e_mcolv.SelectedOptionTypeViewModel_);
            }
            else
            {

            }

        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel_.Excel_multiAsset_compositeOption_subtypeViewModel_.Clear();
            this.optionSubTypeListView_.Items.Refresh();
        }

        private void optionSubTypeListView_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window w = new Window();
            w.Width = 500;
            w.Height = 200;

            //Excel_multiAssetCompositeOptionLoaderView e_multi_colv = new Excel_multiAssetCompositeOptionLoaderView();
            //e_multi_colv.Excel_underlyingCalcInfoViewModel_ = this.viewModel_.Excel_underlyingCalcInfoViewModel_;

            //Excel_multiAsset_compositeOption_subtypeViewModel selectedItem = this.optionSubTypeListView_.SelectedItem as Excel_multiAsset_compositeOption_subtypeViewModel;

            //e_multi_colv.SelectedOptionTypeViewModel_ = selectedItem.Clone();

            Excel_multiAsset_compositeOption_subtypeViewModel selectedItem
                = this.optionSubTypeListView_.SelectedItem as Excel_multiAsset_compositeOption_subtypeViewModel;

            Excel_multiAssetCompositeOptionLoaderView e_colv = selectedItem.Clone().loaderView(this.viewModel_);

            w.Content = e_colv;

            int selectionIndex = this.optionSubTypeListView_.SelectedIndex;

            if (w.ShowDialog() == true)
            {

                this.viewModel_.Excel_multiAsset_compositeOption_subtypeViewModel_[selectionIndex]
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
