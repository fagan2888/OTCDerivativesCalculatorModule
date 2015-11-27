using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class UnderlyingInformationViewModel : IXmlData
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
        
        public UnderlyingInformationViewModel() { }
        
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
        
        #region IndexUnderInfoViewModel_
        private IndexUnderInfoViewModel indexUnderInfoViewModel_;
        public IndexUnderInfoViewModel IndexUnderInfoViewModel_
        {
            get { return this.indexUnderInfoViewModel_; }
            set
            {
                if (this.indexUnderInfoViewModel_ != value)
                {
                    this.indexUnderInfoViewModel_ = value;
                    this.NotifyPropertyChanged("IndexUnderInfoViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_underType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static UnderlyingInformationViewModel CreateUnderlyingInformation(string typeStr)
        {
            if ( typeStr == "indexUnderInfo")
            {
                return new IndexUnderInfoViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

