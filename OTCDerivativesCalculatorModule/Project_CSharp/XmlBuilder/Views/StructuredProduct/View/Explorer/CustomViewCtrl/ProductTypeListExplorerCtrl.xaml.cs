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
using XmlBuilder.DataLoader;
using XmlBuilder.InstrumentModel;
using XmlBuilder.Views.StructuredProduct.View.AddNewProduct;

namespace XmlBuilder.Views.StructuredProduct.View.Explorer
{
    /// <summary>
    /// ProductTypeListExplorerCtrl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ProductTypeListExplorerCtrl : UserControl
    {
        public List<Instrument> instrumentList_ {get; set;}

        public ProductTypeListExplorerCtrl()
        {
            InitializeComponent();
            this.loadInstrument();

            
        }

        private void loadInstrument()
        {
            this.InstrumentList_ListView_.ItemsSource = instrumentList_;
        }

        private void InstrumentList_ListView__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //instrumentList_.Add(new Instrument("New Product"));
            AddNewProductManagerView anpmv = new AddNewProductManagerView();
            anpmv.Show();

        }

    }
}
