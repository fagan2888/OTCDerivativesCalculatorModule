using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class SwapStreamViewModel : IXmlData
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
        
    
        public SwapStreamViewModel() { }
        
    
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
        
        #region StandardStreamViewModel_
        private StandardStreamViewModel standardStreamViewModel_;
        public StandardStreamViewModel StandardStreamViewModel_
        {
            get { return this.standardStreamViewModel_; }
            set
            {
                if (this.standardStreamViewModel_ != value)
                {
                    this.standardStreamViewModel_ = value;
                    this.NotifyPropertyChanged("StandardStreamViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_swapStreamType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static SwapStreamViewModel CreateSwapStream(string typeStr)
        {
            if ( typeStr == "standardStream")
            {
                return new StandardStreamViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static SwapStreamViewModel CreateSwapStream(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.SwapStream serial_SwapStream = serial_Class as FpmlSerializedCSharp.SwapStream;
            string typeStr = serial_SwapStream.Type_.ValueStr;
            return SwapStreamViewModel.CreateSwapStream(typeStr);
        }
        
    
    }
    
}

