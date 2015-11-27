using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class VariableCalListViewModel : IXmlData
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
        
    
        public VariableCalListViewModel() { }
        
    
        #region VariableCalculationViewModel_
        private VariableCalculationViewModel variableCalculationViewModel_;
        public VariableCalculationViewModel VariableCalculationViewModel_
        {
            get { return this.variableCalculationViewModel_; }
            set
            {
                if (this.variableCalculationViewModel_ != value)
                {
                    this.variableCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("VariableCalculationViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "variableCalList");
                xmlWriter.WriteStartElement("variableCalList");
                    variableCalculationViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.VariableCalList serial_VariableCalList = serial_Class as FpmlSerializedCSharp.VariableCalList;
        
            FpmlSerializedCSharp.VariableCalculation serial_variableCalculation = serial_VariableCalList.VariableCalculation_;
            this.variableCalculationViewModel_.setFromSerial(serial_variableCalculation);
            
           //this.view_ = new VariableCalListView();
            this.view_.DataContext = this;
        }
        
        
    
            //#region SelectVariableCalculationInfo_
            //private string selectVariableCalculationInfo_;
            //public string SelectVariableCalculationInfo_
            //{
            //    get { return this.selectVariableCalculationInfo_; }
            //    set
            //    {
            //        if (this.selectVariableCalculationInfo_ != value)
            //        {
            //            this.selectVariableCalculationInfo_ = value;
            //            this.NotifyPropertyChanged("SelectVariableCalculationInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectVariableCalculationInfo(string typeStr)
            //{
            //    this.variableCalculationViewModel_ = VariableCalculationViewModel.CreateVariableCalculation(typeStr);
            //    this.view_.DataContext = this;
            //}
            
        
    
        
    
    }
    
}

