using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;
using System.Xml;
using XmlBuilder.Views.StructuredProduct.ViewModel;

namespace XmlBuilder.Views.StructuredProduct.View.PayoffCtrl
{
    public class ConstPayoffCtrlModel : IXmlBuild
    {
        private FpmlSerializedCSharp.ConstPayoff serial_cp_;

        public ConstPayoffCtrlModel(FpmlSerializedCSharp.ConstPayoff serial_cp)
        {
            // TODO: Complete member initialization
            this.serial_cp_ = serial_cp;
        }

        private void buildFromSerialClass() 
        {
            this.serial_cp_.ConstValue_.StringValue();
        }

        public void buildXml(XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("constPayoff");
                
                xmlWriter.WriteStartElement("constValue");
                    xmlWriter.WriteValue(constValue_);
                xmlWriter.WriteEndElement();

            xmlWriter.WriteEndElement();

        }

        #region ConstValue_
        private string constValue_;
        public string ConstValue_
        {
            get { return this.constValue_; }
            set
            {
                if (this.constValue_ != value)
                {
                    this.constValue_ = value;
                    this.NotifyPropertyChanged("ConstValue_");
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

    }
}
