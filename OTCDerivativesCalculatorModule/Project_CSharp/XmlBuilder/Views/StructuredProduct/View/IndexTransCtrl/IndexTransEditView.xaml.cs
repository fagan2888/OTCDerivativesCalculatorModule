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
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;
using XmlBuilder.Views.StructuredProduct.ViewModel;

namespace XmlBuilder.Views.StructuredProduct.View.IndexTransCtrl
{
    /// <summary>
    /// IndexTransEditView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class IndexTransEditView : Window
    {
        public IndexTransEditView()
        {
            InitializeComponent();

            loadTransList();
            
        }

        private void loadTransList() 
        {
            // load xml template files

            // loop and add

            TreeViewItem newChild = new TreeViewItem();

            newChild.Header = "Return";

            trans_TreeView_.Items.Add(newChild);

            TreeViewItem newChild2 = new TreeViewItem();

            newChild2.Header = "Minimum";

            trans_TreeView_.Items.Add(newChild2);

            
        }

        #region EITFVM_
        private EventIndexTransformationViewModel eitfVM_;
        public EventIndexTransformationViewModel EITFVM_
        {
            get { return this.eitfVM_; }
            set
            {
                if (this.eitfVM_ != value)
                {
                    this.eitfVM_ = value;
                    this.NotifyPropertyChanged("EITFVM_");
                }
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void IndexTrans_DataGrid__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IndexTransViewModel itvm = IndexTrans_DataGrid_.SelectedItem as IndexTransViewModel;

            detailCtrl_.Children.Clear();
            if (itvm != null)
            {
                detailCtrl_.Children.Add(itvm.indexDetailCtrl_);
            }

            //txtBox_.Text = detailCtrl_.CtrlName_;
        }

    }
}
