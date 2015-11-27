using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class BookInformationViewModel : IXmlData
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
        
        public BookInformationViewModel() { }
        
        #region Name_
        private string name_;
        public string Name_
        {
            get { return this.name_; }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                    this.NotifyPropertyChanged("Name_");
                }
            }
        }
        #endregion
        
        #region PathInfoViewModel_
        private PathInfoViewModel pathInfoViewModel_;
        public PathInfoViewModel PathInfoViewModel_
        {
            get { return this.pathInfoViewModel_; }
            set
            {
                if (this.pathInfoViewModel_ != value)
                {
                    this.pathInfoViewModel_ = value;
                    this.NotifyPropertyChanged("PathInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region InstrumentListViewModel_
        private InstrumentListViewModel instrumentListViewModel_;
        public InstrumentListViewModel InstrumentListViewModel_
        {
            get { return this.instrumentListViewModel_; }
            set
            {
                if (this.instrumentListViewModel_ != value)
                {
                    this.instrumentListViewModel_ = value;
                    this.NotifyPropertyChanged("InstrumentListViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "bookInformation");
                xmlWriter.WriteStartElement("bookInformation");
                    xmlWriter.WriteElementString("name" , this.name_);
                    
                    pathInfoViewModel_.buildXml(xmlWriter);
                    
                    instrumentListViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new BookInformationView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.BookInformation serial_BookInformation = serial_Class as FpmlSerializedCSharp.BookInformation;
        
            this.name_ = serial_BookInformation.Name_.ValueStr;
            
            FpmlSerializedCSharp.PathInfo serial_pathInfo = serial_BookInformation.PathInfo_;
            string pathInfotype = serial_pathInfo.Excel_type_.ValueStr;
            this.pathInfoViewModel_ = PathInfoViewModel.CreatePathInfo(pathInfotype);
            this.pathInfoViewModel_.setFromSerial(serial_pathInfo);
            
            FpmlSerializedCSharp.InstrumentList serial_instrumentList = serial_BookInformation.InstrumentList_;
            string instrumentListtype = serial_instrumentList.Excel_type_.ValueStr;
            this.instrumentListViewModel_ = InstrumentListViewModel.CreateInstrumentList(instrumentListtype);
            this.instrumentListViewModel_.setFromSerial(serial_instrumentList);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

