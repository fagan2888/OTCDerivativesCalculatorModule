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

namespace ExcelOTCManagerAddIn
{
    /// <summary>
    /// newProductView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class NewProductView : UserControl
    {

        #region ViewModel_
        private NewProductVM viewModel_;
        public NewProductVM ViewModel_
        {
            get { return this.viewModel_; }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                    this.NotifyPropertyChanged("ViewModel_");
                }
            }
        }
        #endregion

        public NewProductView()
        {
            InitializeComponent();



        }

        private void TreeViewItem_DoubleClick(object sender, RoutedEventArgs e)
        {
            ProductExcelWB peWB = (ProductExcelWB)sender;
            peWB.openWB();
        }

        //double click 으로 바꿔야함
        private void TreeViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //ProductExcelWB peWB = this.viewModel_

            peWB.openWB();

        }
    }
}


//// North America 
//treeItem = new TreeViewItem();
//treeItem.Header = "hifive";

//treeItem.Items.Add(new TreeViewItem() { Header = "hifive-ki" });
//treeItem.Items.Add(new TreeViewItem() { Header = "hifive-nonki" });

//this.productTreeView_.Items.Add(treeItem);
