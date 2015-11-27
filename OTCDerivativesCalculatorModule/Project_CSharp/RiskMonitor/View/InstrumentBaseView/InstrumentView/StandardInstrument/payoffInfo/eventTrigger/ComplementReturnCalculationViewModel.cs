using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ComplementReturnCalculationViewModel : IXmlData
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
    
        public ComplementReturnCalculationViewModel() { }
        
        #region ReturnCalculationInfoViewModel_
        private ReturnCalculationInfoViewModel returnCalculationInfoViewModel_;
        public ReturnCalculationInfoViewModel ReturnCalculationInfoViewModel_
        {
            get { return this.returnCalculationInfoViewModel_; }
            set
            {
                if (this.returnCalculationInfoViewModel_ != value)
                {
                    this.returnCalculationInfoViewModel_ = value;
                    this.NotifyPropertyChanged("ReturnCalculationInfoViewModel_");
                }
            }
        }
        #endregion
        
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
                xmlWriter.WriteStartElement("complementReturnCalculation");
                    returnCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ComplementReturnCalculation serial_ComplementReturnCalculation = serial_Class as FpmlSerializedCSharp.ComplementReturnCalculation;
        
            FpmlSerializedCSharp.ReturnCalculationInfo serial_returnCalculationInfo = serial_ComplementReturnCalculation.ReturnCalculationInfo_;
            this.returnCalculationInfoViewModel_.setFromSerial(serial_returnCalculationInfo);
            
            //this.view_ = new ComplementReturnCalculationView();
            this.view_.DataContext = this;
        }
        
        
    
            //#region SelectReturnCalculationInfoInfo_
            //private string selectReturnCalculationInfoInfo_;
            //public string SelectReturnCalculationInfoInfo_
            //{
            //    get { return this.selectReturnCalculationInfoInfo_; }
            //    set
            //    {
            //        if (this.selectReturnCalculationInfoInfo_ != value)
            //        {
            //            this.selectReturnCalculationInfoInfo_ = value;
            //            this.NotifyPropertyChanged("SelectReturnCalculationInfoInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectReturnCalculationInfoInfo(string typeStr)
            //{
            //    this.returnCalculationInfoViewModel_ = ReturnCalculationInfoViewModel.CreateReturnCalculationInfo(typeStr);
            //    this.view_.DataContext = this;
            //}
            
        
    
        
    
    }
    
}

