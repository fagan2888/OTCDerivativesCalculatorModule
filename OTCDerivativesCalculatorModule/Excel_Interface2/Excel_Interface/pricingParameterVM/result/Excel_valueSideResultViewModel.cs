using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_valueSideResultViewModel : IXmlData
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
        
        public Excel_valueSideResultViewModel() { }
        
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
        
        #region Dirty_
        private string dirty_;
        public string Dirty_
        {
            get { return this.dirty_; }
            set
            {
                if (this.dirty_ != value)
                {
                    this.dirty_ = value;
                    this.NotifyPropertyChanged("Dirty_");
                }
            }
        }
        #endregion
        
        #region Clean_
        private string clean_;
        public string Clean_
        {
            get { return this.clean_; }
            set
            {
                if (this.clean_ != value)
                {
                    this.clean_ = value;
                    this.NotifyPropertyChanged("Clean_");
                }
            }
        }
        #endregion
        
        #region AccrualAmt_
        private string accrualAmt_;
        public string AccrualAmt_
        {
            get { return this.accrualAmt_; }
            set
            {
                if (this.accrualAmt_ != value)
                {
                    this.accrualAmt_ = value;
                    this.NotifyPropertyChanged("AccrualAmt_");
                }
            }
        }
        #endregion
        
        #region Option_
        private string option_;
        public string Option_
        {
            get { return this.option_; }
            set
            {
                if (this.option_ != value)
                {
                    this.option_ = value;
                    this.NotifyPropertyChanged("Option_");
                }
            }
        }
        #endregion
        
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_valueSideResult");
                xmlWriter.WriteElementString("type" , this.type_);
                xmlWriter.WriteElementString("dirty" , this.dirty_);
                xmlWriter.WriteElementString("clean" , this.clean_);
                xmlWriter.WriteElementString("accrualAmt" , this.accrualAmt_);
                xmlWriter.WriteElementString("option" , this.option_);
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_valueSideResult serial_Excel_valueSideResult = serial_Class as FpmlSerializedCSharp.Excel_valueSideResult;
        
            this.type_ = serial_Excel_valueSideResult.Type_.ValueStr;
            this.dirty_ = serial_Excel_valueSideResult.Dirty_.ValueStr;
            this.clean_ = serial_Excel_valueSideResult.Clean_.ValueStr;
            this.accrualAmt_ = serial_Excel_valueSideResult.AccrualAmt_.ValueStr;
            this.option_ = serial_Excel_valueSideResult.Option_.ValueStr;
            
        }

        public string vba_description()
        {
            string str = "";

            str += "type=" + this.type_ + ";";
            str += "dirty=" + this.dirty_ + ";";
            str += "clean=" + this.clean_ + ";";
            str += "accrualAmt=" + this.accrualAmt_ + ";";
            str += "option=" + this.option_ + ";";

            return str;
        }

        public string vba_description_valuePositionCalc(string notionalStr)
        {
            double notional = Convert.ToDouble(notionalStr);

            double dirtyPos = notional * Convert.ToDouble(this.dirty_) ;
            double cleanPos = notional * Convert.ToDouble(this.clean_) ;
            double accrualAmtPos = notional * Convert.ToDouble(this.accrualAmt_) ;
            double optionPos = notional * Convert.ToDouble(this.option_) ;

            string str = "";

            str += "notional=" + notional.ToString() + ";";
            str += "dirtyPos=" + dirtyPos.ToString() + ";";
            str += "cleanPos=" + cleanPos.ToString() + ";";
            str += "accrualAmtPos=" + accrualAmtPos.ToString() + ";";
            str += "optionPos=" + optionPos.ToString() + ";";

            return str;

        }

        
    
        
    
    }
    
}

