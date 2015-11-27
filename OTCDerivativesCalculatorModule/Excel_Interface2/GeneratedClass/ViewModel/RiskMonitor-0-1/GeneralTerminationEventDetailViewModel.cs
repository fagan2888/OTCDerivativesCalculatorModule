using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class GeneralTerminationEventDetailViewModel : IXmlData
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
        
        public GeneralTerminationEventDetailViewModel() { }
        
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
        
        #region General_TerminationEventDetail_creditViewModel_
        private General_TerminationEventDetail_creditViewModel general_TerminationEventDetail_creditViewModel_;
        public General_TerminationEventDetail_creditViewModel General_TerminationEventDetail_creditViewModel_
        {
            get { return this.general_TerminationEventDetail_creditViewModel_; }
            set
            {
                if (this.general_TerminationEventDetail_creditViewModel_ != value)
                {
                    this.general_TerminationEventDetail_creditViewModel_ = value;
                    this.NotifyPropertyChanged("General_TerminationEventDetail_creditViewModel_");
                }
            }
        }
        #endregion
        
        #region General_TerminationEventDetail_targetViewModel_
        private General_TerminationEventDetail_targetViewModel general_TerminationEventDetail_targetViewModel_;
        public General_TerminationEventDetail_targetViewModel General_TerminationEventDetail_targetViewModel_
        {
            get { return this.general_TerminationEventDetail_targetViewModel_; }
            set
            {
                if (this.general_TerminationEventDetail_targetViewModel_ != value)
                {
                    this.general_TerminationEventDetail_targetViewModel_ = value;
                    this.NotifyPropertyChanged("General_TerminationEventDetail_targetViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static GeneralTerminationEventDetailViewModel CreateGeneralTerminationEventDetail(string typeStr)
        {
            if ( typeStr == "general_TerminationEventDetail_credit")
            {
                return new General_TerminationEventDetail_creditViewModel();
            }
            else if ( typeStr == "general_TerminationEventDetail_target")
            {
                return new General_TerminationEventDetail_targetViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

