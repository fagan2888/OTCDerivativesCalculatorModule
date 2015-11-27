using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_constReturnCalViewModel : Excel_returnCalcInfoViewModel
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
        
        public Excel_constReturnCalViewModel() { }
        
        #region ConstReturn_
        private string constReturn_;
        public string ConstReturn_
        {
            get { return this.constReturn_; }
            set
            {
                if (this.constReturn_ != value)
                {
                    this.constReturn_ = value;
                    this.NotifyPropertyChanged("ConstReturn_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_returnCalcInfo");
                xmlWriter.WriteElementString("excel_type" , "excel_constReturnCal");
                xmlWriter.WriteStartElement("excel_constReturnCal");
                    xmlWriter.WriteElementString("constReturn" , this.constReturn_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_constReturnCalView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_returnCalcInfo serial_Excel_returnCalcInfo = serial_Class as FpmlSerializedCSharp.Excel_returnCalcInfo;
            FpmlSerializedCSharp.Excel_constReturnCal serial_Excel_constReturnCal = serial_Excel_returnCalcInfo.Excel_constReturnCal_;
        
            this.constReturn_ = serial_Excel_constReturnCal.ConstReturn_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

