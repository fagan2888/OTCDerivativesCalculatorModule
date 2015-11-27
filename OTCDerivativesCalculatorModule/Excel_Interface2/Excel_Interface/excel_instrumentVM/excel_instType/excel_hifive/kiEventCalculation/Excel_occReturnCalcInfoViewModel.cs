using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;



namespace Excel_Interface
{
    public class Excel_occReturnCalcInfoViewModel : IXmlData , INotifyPropertyChanged
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
        
        public Excel_occReturnCalcInfoViewModel() { }
    
        #region Excel_returnCalcInfoViewModel_
        private Excel_returnCalcInfoViewModel excel_returnCalcInfoViewModel_;
        public Excel_returnCalcInfoViewModel Excel_returnCalcInfoViewModel_
        {
            get { return this.excel_returnCalcInfoViewModel_; }
            set
            {
                if (this.excel_returnCalcInfoViewModel_ != value)
                {
                    this.excel_returnCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_returnCalcInfoViewModel_");
                }
            }
        }
        #endregion
    
        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_occReturnCalcInfo");
                excel_returnCalcInfoViewModel_.buildXml(xmlWriter);
            xmlWriter.WriteEndElement();
        }
        
        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_occReturnCalcInfo serial_Excel_occReturnCalcInfo = serial_Class as FpmlSerializedCSharp.Excel_occReturnCalcInfo;
        
            FpmlSerializedCSharp.Excel_returnCalcInfo serial_excel_returnCalcInfo = serial_Excel_occReturnCalcInfo.Excel_returnCalcInfo_;
            string excel_returnCalcInfotype = serial_excel_returnCalcInfo.Excel_type_.ValueStr;
            this.excel_returnCalcInfoViewModel_ = Excel_returnCalcInfoViewModel.CreateExcel_returnCalcInfo(excel_returnCalcInfotype);
            this.excel_returnCalcInfoViewModel_.setFromSerial(serial_excel_returnCalcInfo);
            
        }

        public Control loaderView()
        {
            return this.excel_returnCalcInfoViewModel_.loaderView();
        }

        public void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_returnCalcInfoViewModel_.setUnderlying(excel_under);
        }

    }
    
}

