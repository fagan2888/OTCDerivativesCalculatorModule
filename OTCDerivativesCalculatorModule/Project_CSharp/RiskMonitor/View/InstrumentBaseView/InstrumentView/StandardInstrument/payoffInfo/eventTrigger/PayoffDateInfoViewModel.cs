using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class PayoffDateInfoViewModel : IXmlData
    {
        #region View_
        protected Control view_;
        public Control View_
        {
            get { return this.view_; }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
                }
            }
        }
        #endregion
    
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
        
    
        public PayoffDateInfoViewModel() { }
    
        #region FixingDateInfoViewModel_
        private FixingDateInfoViewModel fixingDateInfoViewModel_;
        public FixingDateInfoViewModel FixingDateInfoViewModel_
        {
            get { return this.fixingDateInfoViewModel_; }
            set
            {
                if (this.fixingDateInfoViewModel_ != value)
                {
                    this.fixingDateInfoViewModel_ = value;
                    this.NotifyPropertyChanged("FixingDateInfoViewModel_");
                }
            }
        }
        #endregion
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
                xmlWriter.WriteStartElement("payoffDateInfo");
                    fixingDateInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PayoffDateInfo serial_PayoffDateInfo = serial_Class as FpmlSerializedCSharp.PayoffDateInfo;
        
            FpmlSerializedCSharp.FixingDateInfo serial_fixingDateInfo = serial_PayoffDateInfo.FixingDateInfo_;
            string fixingDateInfotype = serial_fixingDateInfo.Type_.ValueStr;
            this.fixingDateInfoViewModel_ = FixingDateInfoViewModel.CreateFixingDateInfo(fixingDateInfotype);
            this.fixingDateInfoViewModel_.setFromSerial(serial_fixingDateInfo);
            
           //this.view_ = new PayoffDateInfoView();
            this.view_.DataContext = this;
        }
        
        
    
            //#region SelectFixingDateInfoInfo_
            //private string selectFixingDateInfoInfo_;
            //public string SelectFixingDateInfoInfo_
            //{
            //    get { return this.selectFixingDateInfoInfo_; }
            //    set
            //    {
            //        if (this.selectFixingDateInfoInfo_ != value)
            //        {
            //            this.selectFixingDateInfoInfo_ = value;
            //            this.NotifyPropertyChanged("SelectFixingDateInfoInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectFixingDateInfoInfo(string typeStr)
            //{
            //    this.fixingDateInfoViewModel_ = FixingDateInfoViewModel.CreateFixingDateInfo(typeStr);
            //    this.view_.DataContext = this;
            //}
            
        
    
        
    
    }
    
}

