using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class HistoryViewModel : IXmlData
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
        
        public HistoryViewModel() { }
        
        #region HisoryDataViewModel_
        private HisoryDataViewModel hisoryDataViewModel_;
        public HisoryDataViewModel HisoryDataViewModel_
        {
            get { return this.hisoryDataViewModel_; }
            set
            {
                if (this.hisoryDataViewModel_ != value)
                {
                    this.hisoryDataViewModel_ = value;
                    this.NotifyPropertyChanged("HisoryDataViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "history");
                xmlWriter.WriteStartElement("history");
                    hisoryDataViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new HistoryView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.History serial_History = serial_Class as FpmlSerializedCSharp.History;
        
            FpmlSerializedCSharp.HisoryData serial_hisoryData = serial_History.HisoryData_;
            string hisoryDatatype = serial_hisoryData.Excel_type_.ValueStr;
            this.hisoryDataViewModel_ = HisoryDataViewModel.CreateHisoryData(hisoryDatatype);
            this.hisoryDataViewModel_.setFromSerial(serial_hisoryData);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

