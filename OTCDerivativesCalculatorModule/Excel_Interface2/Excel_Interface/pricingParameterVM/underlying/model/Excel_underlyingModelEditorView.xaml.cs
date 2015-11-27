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

namespace Excel_Interface
{
    /// <summary>
    /// Excel_underlyingModelEditorView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Excel_underlyingModelEditorView : UserControl
    {
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {


            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region InitializedModelVM_
        private Excel_underlyingModel_paraViewModel initializedModelVM_;
        public Excel_underlyingModel_paraViewModel InitializedModelVM_
        {
            get { return this.initializedModelVM_; }
            set
            {
                if (this.initializedModelVM_ != value)
                {
                    this.initializedModelVM_ = value;
                    this.NotifyPropertyChanged("InitializedModelVM_");
                }
            }
        }
        #endregion

        #region SelectedUnderlyingModelVM_
        private Excel_underlyingModel_paraViewModel selectedUnderlyingModelVM_;
        public Excel_underlyingModel_paraViewModel SelectedUnderlyingModelVM_
        {
            get { return this.selectedUnderlyingModelVM_; }
            set
            {
                if (this.selectedUnderlyingModelVM_ != value)
                {
                    this.selectedUnderlyingModelVM_ = value;
                    this.NotifyPropertyChanged("SelectedUnderlyingModelVM_");
                    
                }
            }
        }
        #endregion

        public Excel_underlyingModelEditorView()
        {
            InitializeComponent();
            //this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

            #region ComboBox Initialize

            this.modelCombo_.ItemsSource = Excel_underlyingModel_paraViewModel.UnderlyingModelComboDisplayStrList_;

            #endregion
        }

        public void initializedModelVM(Excel_underlyingModel_paraViewModel excel_underlyingModel_paraViewModel)
        {
            this.initializedModelVM_ = excel_underlyingModel_paraViewModel.Clone();
            this.selectedUnderlyingModelVM_ = excel_underlyingModel_paraViewModel.Clone();

            this.modelCombo_.DataContext = this.selectedUnderlyingModelVM_;

            this.SelectedModelGrid_.Children.Clear();
            this.SelectedModelGrid_.Children.Add(this.selectedUnderlyingModelVM_.view());

        }

        //public Excel_underlyingModelEditorView(Excel_underlyingModel_paraViewModel excel_underlyingModel_paraViewModel)
        //{
        //    // TODO: Complete member initialization
        //    this.selectedUnderlyingModelVM_ = excel_underlyingModel_paraViewModel;

        //    InitializeComponent();
        //    //this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);

        //    #region ComboBox Initialize

        //    this.modelCombo_.ItemsSource = Excel_underlyingModel_paraViewModel.UnderlyingModelComboDisplayStrList_;
        //    this.modelCombo_.DataContext = this.selectedUnderlyingModelVM_;

        //    #endregion

        //    this.modelCombo_.SelectionChanged += new SelectionChangedEventHandler(modelCombo__SelectionChanged);
        //}

        //private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        //{
            
        //    this.modelCombo_.SelectedIndex = this.selectedUnderlyingModelVM_.SelectedIndex_;

        //    //this.viewModel_ = this.DataContext as Excel_scheduleListViewModel;
        //    //this.ScheduleDataGrid_.ItemsSource = this.viewModel_.Excel_scheduleViewModel_;
        //}

        private void modelCombo__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Excel_underlyingModel_paraViewModel item = this.modelCombo_.SelectedItem as Excel_underlyingModel_paraViewModel;

            if (this.initializedModelVM_.SelectedIndex_ != item.SelectedIndex_)
            {
                this.SelectedUnderlyingModelVM_ = item;

                this.modelCombo_.DataContext = this.selectedUnderlyingModelVM_;

                this.SelectedModelGrid_.Children.Clear();
                this.SelectedModelGrid_.Children.Add(this.selectedUnderlyingModelVM_.view());
            }
            else
            {
                this.SelectedUnderlyingModelVM_ = this.initializedModelVM_.Clone();
                this.modelCombo_.DataContext = this.SelectedUnderlyingModelVM_;

                this.SelectedModelGrid_.Children.Clear();
                this.SelectedModelGrid_.Children.Add(this.selectedUnderlyingModelVM_.view());

            }

            //if (this.selectedUnderlyingModelVM_.SelectedIndex_ != item.SelectedIndex_)
            //{

                
            //}

            
            //string modelType = item.Content.ToString();

            //if (modelType == "GBM")
            //{
            //    this.selectedUnderlyingModelVM_ = new Excel_geometricBMViewModel();
            //}
            //else if (modelType == "HullWhite_1")
            //{
            //    this.selectedUnderlyingModelVM_ = new Excel_hullWhiteOneFactorViewModel();
            //}
            //else
            //{
            //    throw new NotImplementedException();
            //}

            //this.SelectedModelGrid_.Children.Clear();
            //this.SelectedModelGrid_.Children.Add(item.view());

        }

        private void SurmitButton_Click(object sender, RoutedEventArgs e)
        {
            ((Window)this.Parent).DialogResult = true;
            ((Window)this.Parent).Close();
            
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ((Window)this.Parent).DialogResult = false;
            ((Window)this.Parent).Close();
        }





    }
}
