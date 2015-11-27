using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_correlation_paraViewModel : IXmlData
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
        
        public Excel_correlation_paraViewModel() { }
        
        #region First_
        private string first_;
        public string First_
        {
            get { return this.first_; }
            set
            {
                if (this.first_ != value)
                {
                    this.first_ = value;
                    this.NotifyPropertyChanged("First_");
                }
            }
        }
        #endregion
        
        #region Second_
        private string second_;
        public string Second_
        {
            get { return this.second_; }
            set
            {
                if (this.second_ != value)
                {
                    this.second_ = value;
                    this.NotifyPropertyChanged("Second_");
                }
            }
        }
        #endregion
        
        #region Value_
        private string value_;
        public string Value_
        {
            get { return this.value_; }
            set
            {
                if (this.value_ != value)
                {
                    this.value_ = value;
                    this.NotifyPropertyChanged("Value_");
                }
            }
        }
        #endregion
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_correlation_para");
                xmlWriter.WriteElementString("first" , this.first_);
                    
                xmlWriter.WriteElementString("second" , this.second_);
                    
                xmlWriter.WriteElementString("value" , this.value_);
                    
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_correlation_para serial_Excel_correlation_para = serial_Class as FpmlSerializedCSharp.Excel_correlation_para;
        
            this.first_ = serial_Excel_correlation_para.First_.ValueStr;
            
            this.second_ = serial_Excel_correlation_para.Second_.ValueStr;
            
            this.value_ = serial_Excel_correlation_para.Value_.ValueStr;
            
        }

        public string vba_desciption()
        {
            StringBuilder sb = new StringBuilder();

            //sb.Append("type=correlationPara;");

            sb.Append("first=" + this.First_ + ";");
            sb.Append("second=" + this.Second_ + ";");
            sb.Append("value=" + this.Value_ + ";");
            //sb.Append("linkedCurveCode=" + this.LinkedCurveCode_ + ";");

            return sb.ToString();
        }
    }
    
}

