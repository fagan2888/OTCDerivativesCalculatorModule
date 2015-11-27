using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class PricingViewModel : IXmlData
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
        
        public PricingViewModel() { }
        
        #region EvaluationTime_
        private string evaluationTime_;
        public string EvaluationTime_
        {
            get { return this.evaluationTime_; }
            set
            {
                if (this.evaluationTime_ != value)
                {
                    this.evaluationTime_ = value;
                    this.NotifyPropertyChanged("EvaluationTime_");
                }
            }
        }
        #endregion
        
        #region Excel_parameterViewModel_
        private Excel_parameterViewModel excel_parameterViewModel_;
        public Excel_parameterViewModel Excel_parameterViewModel_
        {
            get { return this.excel_parameterViewModel_; }
            set
            {
                if (this.excel_parameterViewModel_ != value)
                {
                    this.excel_parameterViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_parameterViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "pricing");
                xmlWriter.WriteStartElement("pricing");
                    xmlWriter.WriteElementString("evaluationTime" , this.evaluationTime_);
                    
                    excel_parameterViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new PricingView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Pricing serial_Pricing = serial_Class as FpmlSerializedCSharp.Pricing;
        
            this.evaluationTime_ = serial_Pricing.EvaluationTime_.ValueStr;
            
            FpmlSerializedCSharp.Excel_parameter serial_excel_parameter = serial_Pricing.Excel_parameter_;
            string excel_parametertype = serial_excel_parameter.Excel_type_.ValueStr;
            this.excel_parameterViewModel_ = Excel_parameterViewModel.CreateExcel_parameter(excel_parametertype);
            this.excel_parameterViewModel_.setFromSerial(serial_excel_parameter);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

