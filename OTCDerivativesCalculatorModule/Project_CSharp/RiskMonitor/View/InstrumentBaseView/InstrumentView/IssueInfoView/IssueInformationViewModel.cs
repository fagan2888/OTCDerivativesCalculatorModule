using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class IssueInformationViewModel : IXmlData
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
    
        public IssueInformationViewModel() { }
    
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
        
        #region SwapInfoViewModel_
        private SwapInfoViewModel swapInfoViewModel_;
        public SwapInfoViewModel SwapInfoViewModel_
        {
            get { return this.swapInfoViewModel_; }
            set
            {
                if (this.swapInfoViewModel_ != value)
                {
                    this.swapInfoViewModel_ = value;
                    this.NotifyPropertyChanged("SwapInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region NoteInfoViewModel_
        private NoteInfoViewModel noteInfoViewModel_;
        public NoteInfoViewModel NoteInfoViewModel_
        {
            get { return this.noteInfoViewModel_; }
            set
            {
                if (this.noteInfoViewModel_ != value)
                {
                    this.noteInfoViewModel_ = value;
                    this.NotifyPropertyChanged("NoteInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region SecuritiesInfoViewModel_
        private SecuritiesInfoViewModel securitiesInfoViewModel_;
        public SecuritiesInfoViewModel SecuritiesInfoViewModel_
        {
            get { return this.securitiesInfoViewModel_; }
            set
            {
                if (this.securitiesInfoViewModel_ != value)
                {
                    this.securitiesInfoViewModel_ = value;
                    this.NotifyPropertyChanged("SecuritiesInfoViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_issueType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static IssueInformationViewModel CreateIssueInformation(string typeStr)
        {
            if ( typeStr == "swapInfo")
            {
                return new SwapInfoViewModel();
            }
            else if ( typeStr == "noteInfo")
            {
                return new NoteInfoViewModel();
            }
            else if ( typeStr == "securitiesInfo")
            {
                return new SecuritiesInfoViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static IssueInformationViewModel CreateIssueInformation(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.IssueInformation serial_IssueInformation = serial_Class as FpmlSerializedCSharp.IssueInformation;
            string typeStr = serial_IssueInformation.Type_.ValueStr;
            return IssueInformationViewModel.CreateIssueInformation(typeStr);
        }
        
    
    }
    
}

