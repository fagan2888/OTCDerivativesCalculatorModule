using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class PreCalculationViewModel : IXmlData
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
        
    
        public PreCalculationViewModel() { }
        
    
        #region VariableCalListViewModel_
        private VariableCalListViewModel variableCalListViewModel_;
        public VariableCalListViewModel VariableCalListViewModel_
        {
            get { return this.variableCalListViewModel_; }
            set
            {
                if (this.variableCalListViewModel_ != value)
                {
                    this.variableCalListViewModel_ = value;
                    this.NotifyPropertyChanged("VariableCalListViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "preCalculation");
                xmlWriter.WriteStartElement("preCalculation");
                    variableCalListViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PreCalculation serial_PreCalculation = serial_Class as FpmlSerializedCSharp.PreCalculation;
        
            FpmlSerializedCSharp.VariableCalList serial_variableCalList = serial_PreCalculation.VariableCalList_;
            this.variableCalListViewModel_.setFromSerial(serial_variableCalList);
            
           //this.view_ = new PreCalculationView();
            this.view_.DataContext = this;
        }
        
        
    
            //#region SelectVariableCalListInfo_
            //private string selectVariableCalListInfo_;
            //public string SelectVariableCalListInfo_
            //{
            //    get { return this.selectVariableCalListInfo_; }
            //    set
            //    {
            //        if (this.selectVariableCalListInfo_ != value)
            //        {
            //            this.selectVariableCalListInfo_ = value;
            //            this.NotifyPropertyChanged("SelectVariableCalListInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectVariableCalListInfo(string typeStr)
            //{
            //    this.variableCalListViewModel_ = VariableCalListViewModel.CreateVariableCalList(typeStr);
            //    this.view_.DataContext = this;
            //}
            
        
    
        
    
    }
    
}

