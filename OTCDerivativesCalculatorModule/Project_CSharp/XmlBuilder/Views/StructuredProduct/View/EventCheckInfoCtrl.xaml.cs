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
using System.Xml;
using XmlBuilder.Views.StructuredProduct.ViewModel;
using XmlBuilder.Views.StructuredProduct.View.PayoffCtrl;
using XmlBuilder.ViewModel;

using FpmlSerializedCSharp;

namespace XmlBuilder.Views.StructuredProduct.View
{
    /// <summary>
    /// EventCheckViewCtrl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EventCheckInfoCtrl : UserControl
    {
        //private EventCheckInfoCtrlViewModel ecivm;
        private EventCheckViewModel ecvm_;
        private XmlBuilderViewModel xmlBuilderViewModel_;
        private XmlNode thisXml_;
        //private IndexTransCtrl.IndexTransEditView itev_ = new IndexTransCtrl.IndexTransEditView();
        //private Control detailCtrl_;

        public EventCheckInfoCtrl()
        {
            InitializeComponent();
        }

        public void loadXml()
        {
            //thisXml_ = new XmlElement();
        }

        //public void buildProduct() 
        //{
        //    ecivm = new EventCheckInfoCtrlViewModel(new FpmlSerializedCSharp.StructuredProduct(thisXml_));
        //}

        private void EventCheck_DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 셀렉션으로 설정함.
            EventCheck_DetailGrid.DataContext = EventCheck_DataGrid.SelectedItem;
            this.ecvm_ = EventCheck_DataGrid.SelectedItem as EventCheckViewModel;

        }

        internal void setViewModel(XmlBuilderViewModel xmlBuilderViewModel)
        {
            xmlBuilderViewModel_ = xmlBuilderViewModel;
            this.DataContext = xmlBuilderViewModel;
            //this.baseInformationCtrl_.DataContext = xmlBuilderViewModel.BaseInformationViewModel_;
            //this.baseInformationCtrl_.bivm_ = xmlBuilderViewModel.BaseInformationViewModel_;
            //this.baseInformationCtrl_.variableGrid_Ctrl.DataContext = xmlBuilderViewModel.BaseInformationViewModel_;
            //this.baseInformationCtrl_.variableGrid_Ctrl.Detail_DataGrid.ItemsSource = xmlBuilderViewModel.BaseInformationViewModel_.InitialFixedValueList_;

            EventCheck_DetailGrid.DataContext = xmlBuilderViewModel.EventCheckViewModel_[0];
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            IndexTransViewModel itvm = IndexTrans_DataGrid.SelectedItem as IndexTransViewModel;

            detailCtrl_.Children.Clear();
            if (itvm != null)
            {
                detailCtrl_.Children.Add(itvm.indexDetailCtrl_);
            }

            //txtBox_.Text = detailCtrl_.CtrlName_;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ecvm_ != null)
            {
                IndexTransCtrl.IndexTransEditView itev = new IndexTransCtrl.IndexTransEditView();
                itev.IndexTrans_DataGrid_.DataContext = ecvm_.EITFVM_;
                itev.Show();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ecvm_ != null)
            {
                PayoffCtrl.PayoffEditView pev = new PayoffCtrl.PayoffEditView();
                pev.Payoff_DataGrid_.DataContext = ecvm_.PayoffListVM_;
                pev.Show();
            }
        }





        
    }
}
