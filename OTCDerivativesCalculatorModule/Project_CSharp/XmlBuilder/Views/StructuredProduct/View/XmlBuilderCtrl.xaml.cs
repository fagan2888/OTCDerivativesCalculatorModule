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
using System.Xml;
using XmlBuilder.ViewModel;

namespace XmlBuilder.Views.StructuredProduct.View
{
    /// <summary>
    /// XmlBuilderCtrl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class XmlBuilderCtrl : UserControl
    {
        private XmlBuilderViewModel xmlBuilderViewModel_;

        public XmlBuilderCtrl()
        {

            InitializeComponent();
        }

        // Load함.
        private void build(XmlNode node)
        {
            //xmlBuilderViewModel_.build(node);
            XmlBuilderCtrl_.DataContext = xmlBuilderViewModel_;
        }

        public void setViewModel(XmlBuilderViewModel xmlBuilderViewModel)
        {
            this.xmlBuilderViewModel_ = xmlBuilderViewModel;
            this.XmlBuilderCtrl_.setViewModel(xmlBuilderViewModel);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            
            XmlWriterSettings setting = new XmlWriterSettings();
            setting.Indent = true;

            //XmlWriter xmlWriter = XmlWriter.Create(sb, setting);
            XmlWriter xmlWriter = XmlWriter.Create("testGenXml.xml", setting);

            xmlWriter.WriteStartElement("eventCheckSchedule");

            this.xmlBuilderViewModel_.buildXml(xmlWriter);

            xmlWriter.WriteEndElement();

            xmlWriter.Close();

            //MessageBoxResult result = MessageBox.Show(sb.ToString());  
        }


        

    }
}
