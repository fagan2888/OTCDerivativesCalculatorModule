using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_forwardModelViewModel : Excel_underlyingModel_paraViewModel
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
        
        public Excel_forwardModelViewModel() { }
        
        #region CurrentValue_
        private string currentValue_;
        public string CurrentValue_
        {
            get { return this.currentValue_; }
            set
            {
                if (this.currentValue_ != value)
                {
                    this.currentValue_ = value;
                    this.NotifyPropertyChanged("CurrentValue_");
                }
            }
        }
        #endregion
        
        #region Tenor_
        private string tenor_;
        public string Tenor_
        {
            get { return this.tenor_; }
            set
            {
                if (this.tenor_ != value)
                {
                    this.tenor_ = value;
                    this.NotifyPropertyChanged("Tenor_");
                }
            }
        }
        #endregion
        
        #region FittingYieldCurveName_
        private string fittingYieldCurveName_;
        public string FittingYieldCurveName_
        {
            get { return this.fittingYieldCurveName_; }
            set
            {
                if (this.fittingYieldCurveName_ != value)
                {
                    this.fittingYieldCurveName_ = value;
                    this.NotifyPropertyChanged("FittingYieldCurveName_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_underlyingModel_para");
                xmlWriter.WriteElementString("type" , "excel_forwardModel");
                xmlWriter.WriteStartElement("excel_forwardModel");
                    xmlWriter.WriteElementString("currentValue" , this.currentValue_);
                    
                    xmlWriter.WriteElementString("tenor" , this.tenor_);
                    
                    xmlWriter.WriteElementString("fittingYieldCurveName" , this.fittingYieldCurveName_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_forwardModelView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingModel_para serial_Excel_underlyingModel_para = serial_Class as FpmlSerializedCSharp.Excel_underlyingModel_para;
            FpmlSerializedCSharp.Excel_forwardModel serial_Excel_forwardModel = serial_Excel_underlyingModel_para.Excel_forwardModel_;
        
            this.currentValue_ = serial_Excel_forwardModel.CurrentValue_.ValueStr;
            
            this.tenor_ = serial_Excel_forwardModel.Tenor_.ValueStr;
            
            this.fittingYieldCurveName_ = serial_Excel_forwardModel.FittingYieldCurveName_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

