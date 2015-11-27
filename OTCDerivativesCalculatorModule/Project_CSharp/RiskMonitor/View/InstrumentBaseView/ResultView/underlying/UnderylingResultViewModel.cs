using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class UnderylingResultViewModel : IXmlData
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
    
        public UnderylingResultViewModel() { }
    
        #region Type_
        protected string type_;
        public string Type_
        {
            get { return this.type_; }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                    this.NotifyPropertyChanged("Type_");
                }
            }
        }
        #endregion
        
        public string choiceStr_underylingGreekType;
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static UnderylingResultViewModel CreateUnderylingResult(string typeStr)
        {
            if ( typeStr == "gbmGreekInfoResult")
            {
                return new GbmGreekInfoResultViewModel();
            }
            else if ( typeStr == "hullWhiteGreekInfoResult")
            {
                return new HullWhiteGreekInfoResultViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static UnderylingResultViewModel CreateUnderylingResult(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.UnderylingResult serial_UnderylingResult = serial_Class as FpmlSerializedCSharp.UnderylingResult;
            string typeStr = serial_UnderylingResult.Type_.ValueStr;
            return UnderylingResultViewModel.CreateUnderylingResult(typeStr);
        }
        
    
    }
    
}

