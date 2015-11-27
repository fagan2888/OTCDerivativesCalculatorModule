using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class UnderylingResultViewModel : IXmlData
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
        
        public UnderylingResultViewModel() { }
        
        #region Type_
        private string type_;
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
        
        #region GbmGreekInfoResultViewModel_
        private GbmGreekInfoResultViewModel gbmGreekInfoResultViewModel_;
        public GbmGreekInfoResultViewModel GbmGreekInfoResultViewModel_
        {
            get { return this.gbmGreekInfoResultViewModel_; }
            set
            {
                if (this.gbmGreekInfoResultViewModel_ != value)
                {
                    this.gbmGreekInfoResultViewModel_ = value;
                    this.NotifyPropertyChanged("GbmGreekInfoResultViewModel_");
                }
            }
        }
        #endregion
        
        #region HullWhiteGreekInfoResultViewModel_
        private HullWhiteGreekInfoResultViewModel hullWhiteGreekInfoResultViewModel_;
        public HullWhiteGreekInfoResultViewModel HullWhiteGreekInfoResultViewModel_
        {
            get { return this.hullWhiteGreekInfoResultViewModel_; }
            set
            {
                if (this.hullWhiteGreekInfoResultViewModel_ != value)
                {
                    this.hullWhiteGreekInfoResultViewModel_ = value;
                    this.NotifyPropertyChanged("HullWhiteGreekInfoResultViewModel_");
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
        
        
    
    }
    
}

