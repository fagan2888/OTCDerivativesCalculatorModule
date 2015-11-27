using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class InstPositionInfoViewModel : IXmlData
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
        
        public InstPositionInfoViewModel() { }
        
        #region KrCode_
        private string krCode_;
        public string KrCode_
        {
            get { return this.krCode_; }
            set
            {
                if (this.krCode_ != value)
                {
                    this.krCode_ = value;
                    this.NotifyPropertyChanged("KrCode_");
                }
            }
        }
        #endregion
        
        #region InstName_
        private string instName_;
        public string InstName_
        {
            get { return this.instName_; }
            set
            {
                if (this.instName_ != value)
                {
                    this.instName_ = value;
                    this.NotifyPropertyChanged("InstName_");
                }
            }
        }
        #endregion
        
        #region InstCode_
        private string instCode_;
        public string InstCode_
        {
            get { return this.instCode_; }
            set
            {
                if (this.instCode_ != value)
                {
                    this.instCode_ = value;
                    this.NotifyPropertyChanged("InstCode_");
                }
            }
        }
        #endregion
        
        #region InstType_
        private string instType_;
        public string InstType_
        {
            get { return this.instType_; }
            set
            {
                if (this.instType_ != value)
                {
                    this.instType_ = value;
                    this.NotifyPropertyChanged("InstType_");
                }
            }
        }
        #endregion
        
        #region BookedDate_
        private DateTime bookedDate_;
        public DateTime BookedDate_
        {
            get { return this.bookedDate_; }
            set
            {
                if (this.bookedDate_ != value)
                {
                    this.bookedDate_ = value;
                    this.NotifyPropertyChanged("BookedDate_");
                }
            }
        }
        #endregion
        
        #region UnBookedDate_
        private DateTime unBookedDate_;
        public DateTime UnBookedDate_
        {
            get { return this.unBookedDate_; }
            set
            {
                if (this.unBookedDate_ != value)
                {
                    this.unBookedDate_ = value;
                    this.NotifyPropertyChanged("UnBookedDate_");
                }
            }
        }
        #endregion
        
        #region MaturityDate_
        private DateTime maturityDate_;
        public DateTime MaturityDate_
        {
            get { return this.maturityDate_; }
            set
            {
                if (this.maturityDate_ != value)
                {
                    this.maturityDate_ = value;
                    this.NotifyPropertyChanged("MaturityDate_");
                }
            }
        }
        #endregion
        
        #region FileName_
        private string fileName_;
        public string FileName_
        {
            get { return this.fileName_; }
            set
            {
                if (this.fileName_ != value)
                {
                    this.fileName_ = value;
                    this.NotifyPropertyChanged("FileName_");
                }
            }
        }
        #endregion
        
        #region PositionName_
        private string positionName_;
        public string PositionName_
        {
            get { return this.positionName_; }
            set
            {
                if (this.positionName_ != value)
                {
                    this.positionName_ = value;
                    this.NotifyPropertyChanged("PositionName_");
                }
            }
        }
        #endregion
        
        #region CounterParty_
        private string counterParty_;
        public string CounterParty_
        {
            get { return this.counterParty_; }
            set
            {
                if (this.counterParty_ != value)
                {
                    this.counterParty_ = value;
                    this.NotifyPropertyChanged("CounterParty_");
                }
            }
        }
        #endregion
        
        #region Notional_
        private string notional_;
        public string Notional_
        {
            get { return this.notional_; }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                    this.NotifyPropertyChanged("Notional_");
                }
            }
        }
        #endregion
        
        #region Currency_
        private string currency_;
        public string Currency_
        {
            get { return this.currency_; }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                    this.NotifyPropertyChanged("Currency_");
                }
            }
        }
        #endregion
        
        #region FundCode_
        private string fundCode_;
        public string FundCode_
        {
            get { return this.fundCode_; }
            set
            {
                if (this.fundCode_ != value)
                {
                    this.fundCode_ = value;
                    this.NotifyPropertyChanged("FundCode_");
                }
            }
        }
        #endregion
        
        #region FundName_
        private string fundName_;
        public string FundName_
        {
            get { return this.fundName_; }
            set
            {
                if (this.fundName_ != value)
                {
                    this.fundName_ = value;
                    this.NotifyPropertyChanged("FundName_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "instPositionInfo");
                xmlWriter.WriteStartElement("instPositionInfo");
                    xmlWriter.WriteElementString("krCode" , this.krCode_);
                    
                    xmlWriter.WriteElementString("instName" , this.instName_);
                    
                    xmlWriter.WriteElementString("instCode" , this.instCode_);
                    
                    xmlWriter.WriteElementString("instType" , this.instType_);
                    
                    xmlWriter.WriteElementString("bookedDate" , StringConverter.xmlDateTimeToDateString(this.bookedDate_));
                    
                    xmlWriter.WriteElementString("unBookedDate" , StringConverter.xmlDateTimeToDateString(this.unBookedDate_));
                    
                    xmlWriter.WriteElementString("maturityDate" , StringConverter.xmlDateTimeToDateString(this.maturityDate_));
                    
                    xmlWriter.WriteElementString("fileName" , this.fileName_);
                    
                    xmlWriter.WriteElementString("positionName" , this.positionName_);
                    
                    xmlWriter.WriteElementString("counterParty" , this.counterParty_);
                    
                    xmlWriter.WriteElementString("notional" , this.notional_);
                    
                    xmlWriter.WriteElementString("currency" , this.currency_);
                    
                    xmlWriter.WriteElementString("fundCode" , this.fundCode_);
                    
                    xmlWriter.WriteElementString("fundName" , this.fundName_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new InstPositionInfoView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.InstPositionInfo serial_InstPositionInfo = serial_Class as FpmlSerializedCSharp.InstPositionInfo;
        
            this.krCode_ = serial_InstPositionInfo.KrCode_.ValueStr;
            
            this.instName_ = serial_InstPositionInfo.InstName_.ValueStr;
            
            this.instCode_ = serial_InstPositionInfo.InstCode_.ValueStr;
            
            this.instType_ = serial_InstPositionInfo.InstType_.ValueStr;
            
            this.bookedDate_ = StringConverter.xmlDateToDateTime(serial_InstPositionInfo.BookedDate_.ValueStr);
            
            this.unBookedDate_ = StringConverter.xmlDateToDateTime(serial_InstPositionInfo.UnBookedDate_.ValueStr);
            
            this.maturityDate_ = StringConverter.xmlDateToDateTime(serial_InstPositionInfo.MaturityDate_.ValueStr);
            
            this.fileName_ = serial_InstPositionInfo.FileName_.ValueStr;
            
            this.positionName_ = serial_InstPositionInfo.PositionName_.ValueStr;
            
            this.counterParty_ = serial_InstPositionInfo.CounterParty_.ValueStr;
            
            this.notional_ = serial_InstPositionInfo.Notional_.ValueStr;
            
            this.currency_ = serial_InstPositionInfo.Currency_.ValueStr;
            
            this.fundCode_ = serial_InstPositionInfo.FundCode_.ValueStr;
            
            this.fundName_ = serial_InstPositionInfo.FundName_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

