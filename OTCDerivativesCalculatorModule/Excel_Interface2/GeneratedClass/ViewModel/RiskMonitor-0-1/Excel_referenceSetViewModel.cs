using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_referenceSetViewModel : Excel_referenceSetListViewModel
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
        
        public Excel_referenceSetViewModel() { }
        
        #region KrCode_
        private string krCode_;
        public string KrCode_
        {
            get { return this.krCode_; }
            set
            {
                if (this.krCode_ != value)
                {
                    this.krCode_ = value;
                    this.NotifyPropertyChanged("KrCode_");
                }
            }
        }
        #endregion
        
        #region UsingTF_
        private string usingTF_;
        public string UsingTF_
        {
            get { return this.usingTF_; }
            set
            {
                if (this.usingTF_ != value)
                {
                    this.usingTF_ = value;
                    this.NotifyPropertyChanged("UsingTF_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_referenceSetList");
                xmlWriter.WriteElementString("excel_type" , "excel_referenceSet");
                xmlWriter.WriteStartElement("excel_referenceSet");
                    xmlWriter.WriteElementString("krCode" , this.krCode_);
                    
                    xmlWriter.WriteElementString("usingTF" , this.usingTF_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_referenceSetView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_referenceSetList serial_Excel_referenceSetList = serial_Class as FpmlSerializedCSharp.Excel_referenceSetList;
            FpmlSerializedCSharp.Excel_referenceSet serial_Excel_referenceSet = serial_Excel_referenceSetList.Excel_referenceSet_;
        
            this.krCode_ = serial_Excel_referenceSet.KrCode_.ValueStr;
            
            this.usingTF_ = serial_Excel_referenceSet.UsingTF_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

