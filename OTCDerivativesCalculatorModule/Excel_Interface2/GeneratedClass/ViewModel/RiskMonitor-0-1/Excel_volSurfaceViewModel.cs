using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_volSurfaceViewModel : IXmlData
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
        
        public Excel_volSurfaceViewModel() { }
        
        #region RefDate_
        private DateTime refDate_;
        public DateTime RefDate_
        {
            get { return this.refDate_; }
            set
            {
                if (this.refDate_ != value)
                {
                    this.refDate_ = value;
                    this.NotifyPropertyChanged("RefDate_");
                }
            }
        }
        #endregion
        
        #region Code_
        private string code_;
        public string Code_
        {
            get { return this.code_; }
            set
            {
                if (this.code_ != value)
                {
                    this.code_ = value;
                    this.NotifyPropertyChanged("Code_");
                }
            }
        }
        #endregion
        
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
        
        #region Tenor_
        private ObservableCollection<string> tenor_;
        public ObservableCollection<string> Tenor_
        {
            get { return this.tenor_; }
            set
            {
                if (this.tenor_ != value)
                {
                    this.tenor_ = value;
                    this.NotifyPropertyChanged("Tenor_");
                }
            }
        }
        #endregion
        
        #region Strike_
        private ObservableCollection<string> strike_;
        public ObservableCollection<string> Strike_
        {
            get { return this.strike_; }
            set
            {
                if (this.strike_ != value)
                {
                    this.strike_ = value;
                    this.NotifyPropertyChanged("Strike_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_volSurface");
                xmlWriter.WriteStartElement("excel_volSurface");
                    xmlWriter.WriteElementString("refDate" , StringConverter.xmlDateTimeToDateString(this.refDate_));
                    
                    xmlWriter.WriteElementString("code" , this.code_);
                    
                    xmlWriter.WriteElementString("name" , this.name_);
                    
                    xmlWriter.WriteElementString("tenor" , this.tenor_);
                    
                    xmlWriter.WriteElementString("strike" , this.strike_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_volSurfaceView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_volSurface serial_Excel_volSurface = serial_Class as FpmlSerializedCSharp.Excel_volSurface;
        
            this.refDate_ = StringConverter.xmlDateToDateTime(serial_Excel_volSurface.RefDate_.ValueStr);
            
            this.code_ = serial_Excel_volSurface.Code_.ValueStr;
            
            this.name_ = serial_Excel_volSurface.Name_.ValueStr;
            
            this.tenorViewModel_ = new ObservableCollection<TenorViewModel>();
            foreach (var item in serial_Excel_volSurface.Tenor_)
            {
                this.value_.Add(item.ValueStr);
            }
            
            this.strikeViewModel_ = new ObservableCollection<StrikeViewModel>();
            foreach (var item in serial_Excel_volSurface.Strike_)
            {
                this.value_.Add(item.ValueStr);
            }
            
        }
        
        
    
        
    
        
    
    }
    
}

