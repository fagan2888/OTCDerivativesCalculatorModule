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
using XmlBuilder.InstrumentModel;
using XmlBuilder.DataLoader;

namespace XmlBuilder.Views.StructuredProduct.View.Explorer
{
    /// <summary>
    /// ProductListExplorerView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ProductListExplorerView : Window
    {
        public List<Instrument> instrumentList_ { get; set; }
        
        public ProductListExplorerView()
        {
            InitializeComponent();
            this.loadInstrument();

            this.InstrumentList_ListView_.DataContext = instrumentList_;
        }

        private void loadInstrument()
        {
            InstrumentDataLoader idl = new InstrumentDataLoader();

            this.instrumentList_ = idl.loadInstrument();
                        

        }


    }
}
