using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class GroupViewModel : IXmlData
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
        
        public GroupViewModel() { }
        
        #region HeaderViewModel_
        private HeaderViewModel headerViewModel_;
        public HeaderViewModel HeaderViewModel_
        {
            get { return this.headerViewModel_; }
            set
            {
                if (this.headerViewModel_ != value)
                {
                    this.headerViewModel_ = value;
                    this.NotifyPropertyChanged("HeaderViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "group");
                xmlWriter.WriteStartElement("group");
                    headerViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new GroupView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Group serial_Group = serial_Class as FpmlSerializedCSharp.Group;
        
            FpmlSerializedCSharp.Header serial_header = serial_Group.Header_;
            string headertype = serial_header.Excel_type_.ValueStr;
            this.headerViewModel_ = HeaderViewModel.CreateHeader(headertype);
            this.headerViewModel_.setFromSerial(serial_header);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

