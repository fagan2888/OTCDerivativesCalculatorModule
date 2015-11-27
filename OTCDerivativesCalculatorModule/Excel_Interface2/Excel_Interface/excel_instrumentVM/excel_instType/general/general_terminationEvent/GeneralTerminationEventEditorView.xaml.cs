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
    /// GeneralTerminationEventEditorView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GeneralTerminationEventEditorView : UserControl
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

        #region SelectedDetailTerminationVM_
        private GeneralTerminationEventDetailViewModel selectedDetailTerminationVM_;
        public GeneralTerminationEventDetailViewModel SelectedDetailTerminationVM_
        {
            get { return this.selectedDetailTerminationVM_; }
            set
            {
                if (this.selectedDetailTerminationVM_ != value)
                {
                    this.selectedDetailTerminationVM_ = value;
                    this.NotifyPropertyChanged("SelectedDetailTerminationVM_");
                }
            }
        }
        #endregion

        public GeneralTerminationEventEditorView()
        {
            InitializeComponent();
            this.DataContextChanged += new DependencyPropertyChangedEventHandler(ViewModelChanged);
        }

        private void ViewModelChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    ComboBoxItem item = this.modelTypeCombBox_.SelectedItem as ComboBoxItem;
        //    string modelType = item.Content.ToString();

        //    if (modelType == "GBM")
        //    {
        //        this.selectedUnderlyingModelVM_ = new Excel_geometricBMViewModel();
        //    }
        //    else if (modelType == "HullWhite_1")
        //    {
        //        this.selectedUnderlyingModelVM_ = new Excel_hullWhiteOneFactorViewModel();
        //    }
        //    else
        //    {
        //        throw new NotImplementedException();
        //    }

        //    this.SelectedModelGrid_.Children.Clear();
        //    this.SelectedModelGrid_.Children.Add(this.selectedUnderlyingModelVM_.View_);

        //}

        private void SurmitButton_Click(object sender, RoutedEventArgs e)
        {
            //this.selectedUnderlyingModelVM_ = this.detail_VM_;
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
