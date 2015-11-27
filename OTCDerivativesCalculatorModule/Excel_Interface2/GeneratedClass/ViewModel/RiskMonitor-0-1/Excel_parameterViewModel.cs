using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_parameterViewModel : IXmlData
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
        
        public Excel_parameterViewModel() { }
        
        #region Excel_type_
        private string excel_type_;
        public string Excel_type_
        {
            get { return this.excel_type_; }
            set
            {
                if (this.excel_type_ != value)
                {
                    this.excel_type_ = value;
                    this.NotifyPropertyChanged("Excel_type_");
                }
            }
        }
        #endregion
        
        #region Excel_resultViewModel_
        private Excel_resultViewModel excel_resultViewModel_;
        public Excel_resultViewModel Excel_resultViewModel_
        {
            get { return this.excel_resultViewModel_; }
            set
            {
                if (this.excel_resultViewModel_ != value)
                {
                    this.excel_resultViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_resultViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_standardParaViewModel_
        private Excel_standardParaViewModel excel_standardParaViewModel_;
        public Excel_standardParaViewModel Excel_standardParaViewModel_
        {
            get { return this.excel_standardParaViewModel_; }
            set
            {
                if (this.excel_standardParaViewModel_ != value)
                {
                    this.excel_standardParaViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_standardParaViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_standardSwapParaViewModel_
        private Excel_standardSwapParaViewModel excel_standardSwapParaViewModel_;
        public Excel_standardSwapParaViewModel Excel_standardSwapParaViewModel_
        {
            get { return this.excel_standardSwapParaViewModel_; }
            set
            {
                if (this.excel_standardSwapParaViewModel_ != value)
                {
                    this.excel_standardSwapParaViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_standardSwapParaViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_standardHifiveParaViewModel_
        private Excel_standardHifiveParaViewModel excel_standardHifiveParaViewModel_;
        public Excel_standardHifiveParaViewModel Excel_standardHifiveParaViewModel_
        {
            get { return this.excel_standardHifiveParaViewModel_; }
            set
            {
                if (this.excel_standardHifiveParaViewModel_ != value)
                {
                    this.excel_standardHifiveParaViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_standardHifiveParaViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_standardCreditParaViewModel_
        private Excel_standardCreditParaViewModel excel_standardCreditParaViewModel_;
        public Excel_standardCreditParaViewModel Excel_standardCreditParaViewModel_
        {
            get { return this.excel_standardCreditParaViewModel_; }
            set
            {
                if (this.excel_standardCreditParaViewModel_ != value)
                {
                    this.excel_standardCreditParaViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_standardCreditParaViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Excel_parameterViewModel CreateExcel_parameter(string typeStr)
        {
            if ( typeStr == "excel_result")
            {
                return new Excel_resultViewModel();
            }
            else if ( typeStr == "excel_standardPara")
            {
                return new Excel_standardParaViewModel();
            }
            else if ( typeStr == "excel_standardSwapPara")
            {
                return new Excel_standardSwapParaViewModel();
            }
            else if ( typeStr == "excel_standardHifivePara")
            {
                return new Excel_standardHifiveParaViewModel();
            }
            else if ( typeStr == "excel_standardCreditPara")
            {
                return new Excel_standardCreditParaViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

