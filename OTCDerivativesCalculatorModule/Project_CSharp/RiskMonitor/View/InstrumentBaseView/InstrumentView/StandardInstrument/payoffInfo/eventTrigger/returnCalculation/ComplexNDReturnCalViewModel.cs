using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ComplexNDReturnCalViewModel : ReturnCalculationViewModel
    {
        public ComplexNDReturnCalViewModel() { }
        
    
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
        
        #region OperatorNDViewModel_
        private OperatorNDViewModel operatorNDViewModel_;
        public OperatorNDViewModel OperatorNDViewModel_
        {
            get { return this.operatorNDViewModel_; }
            set
            {
                if (this.operatorNDViewModel_ != value)
                {
                    this.operatorNDViewModel_ = value;
                    this.NotifyPropertyChanged("OperatorNDViewModel_");
                }
            }
        }
        #endregion
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("returnCalculation");
                xmlWriter.WriteElementString("type" , "complexNDReturnCal");
                xmlWriter.WriteStartElement("complexNDReturnCal");
                    variableCalListViewModel_.buildXml(xmlWriter);
                    
                    operatorNDViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReturnCalculation serial_ReturnCalculation = serial_Class as FpmlSerializedCSharp.ReturnCalculation;
            FpmlSerializedCSharp.ComplexNDReturnCal serial_ComplexNDReturnCal = serial_ReturnCalculation.ComplexNDReturnCal_;
        
            FpmlSerializedCSharp.VariableCalList serial_variableCalList = serial_ComplexNDReturnCal.VariableCalList_;
            //string variableCalListtype = serial_variableCalList.Type_.ValueStr;
            //this.variableCalListViewModel_ = VariableCalListViewModel.CreateVariableCalList(variableCalListtype);
            this.variableCalListViewModel_.setFromSerial(serial_variableCalList);
            
            FpmlSerializedCSharp.OperatorND serial_operatorND = serial_ComplexNDReturnCal.OperatorND_;
            string operatorNDtype = serial_operatorND.Type_.ValueStr;
            this.operatorNDViewModel_ = OperatorNDViewModel.CreateOperatorND(operatorNDtype);
            this.operatorNDViewModel_.setFromSerial(serial_operatorND);
            
            //this.view_ = new ComplexNDReturnCalView();
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
            
            //#region SelectOperatorNDInfo_
            //private string selectOperatorNDInfo_;
            //public string SelectOperatorNDInfo_
            //{
            //    get { return this.selectOperatorNDInfo_; }
            //    set
            //    {
            //        if (this.selectOperatorNDInfo_ != value)
            //        {
            //            this.selectOperatorNDInfo_ = value;
            //            this.NotifyPropertyChanged("SelectOperatorNDInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectOperatorNDInfo(string typeStr)
            //{
            //    this.operatorNDViewModel_ = OperatorNDViewModel.CreateOperatorND(typeStr);
            //    this.view_.DataContext = this;
            //}
            
        
    
        
    
    }
    
}

