using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ReferenceEntityViewModel : IXmlData
    {
        #region View_
        private Control view_;
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
    
        public ReferenceEntityViewModel() { }
        
        #region EntityName_
        private string entityName_;
        public string EntityName_
        {
            get { return this.entityName_; }
            set
            {
                if (this.entityName_ != value)
                {
                    this.entityName_ = value;
                    this.NotifyPropertyChanged("EntityName_");
                }
            }
        }
        #endregion
        
        #region EntityId_
        private string entityId_;
        public string EntityId_
        {
            get { return this.entityId_; }
            set
            {
                if (this.entityId_ != value)
                {
                    this.entityId_ = value;
                    this.NotifyPropertyChanged("EntityId_");
                }
            }
        }
        #endregion
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReferenceEntity serial_ReferenceEntity = serial_Class as FpmlSerializedCSharp.ReferenceEntity;
        
            this.entityName_ = serial_ReferenceEntity.EntityName_.ValueStr;
            
            this.entityId_ = serial_ReferenceEntity.EntityId_.ValueStr;
            
        }
    
    }
    
}

