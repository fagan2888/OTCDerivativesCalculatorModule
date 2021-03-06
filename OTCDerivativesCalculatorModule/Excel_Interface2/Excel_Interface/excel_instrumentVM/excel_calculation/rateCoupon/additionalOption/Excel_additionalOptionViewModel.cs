using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Excel_additionalOptionViewModel : IXmlData
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
        
        public Excel_additionalOptionViewModel() { }

        #region OptionType_
        protected string optionType_;
        public string OptionType_
        {
            get { return this.optionType_; }
            set
            {
                if (this.optionType_ != value)
                {
                    this.optionType_ = value;
                    this.NotifyPropertyChanged("OptionType_");
                }
            }
        }
        #endregion

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

        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);

        public static Excel_additionalOptionViewModel CreateExcel_additionalOption(string typeStr)
        {
            if (typeStr.ToUpper() == "EXCEL_NONEOPTION" || typeStr.ToUpper() == "NONEOPTION")
            {
                return new Excel_noneOptionViewModel();
            }
            else if (typeStr.ToUpper() == "EXCEL_CALLABLEOPTION" || typeStr.ToUpper() == "CALLABLEOPTION")
            {
                return new Excel_callableOptionViewModel();
            }
            else if (typeStr == "EXCEL_PUTTABLEOPTION" || typeStr == "PUTTABLEOPTION")
            {
                return new Excel_puttableOptionViewModel();
            }
            else
            {
                throw new NotImplementedException("unknown additionalOption Type : " + typeStr);
            }
        }

        public string vba_desciption(int scheduleNum)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("optionType=" + this.optionType_ + ";");

            return sb.ToString();
        }
        
    
    }
    
}

