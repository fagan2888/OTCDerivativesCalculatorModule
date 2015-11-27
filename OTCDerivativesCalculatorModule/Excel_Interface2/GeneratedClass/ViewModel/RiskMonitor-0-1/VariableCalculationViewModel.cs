using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class VariableCalculationViewModel : IXmlData
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
        
        public VariableCalculationViewModel() { }
        
        #region ReferenceCalculationInfoViewModel_
        private ReferenceCalculationInfoViewModel referenceCalculationInfoViewModel_;
        public ReferenceCalculationInfoViewModel ReferenceCalculationInfoViewModel_
        {
            get { return this.referenceCalculationInfoViewModel_; }
            set
            {
                if (this.referenceCalculationInfoViewModel_ != value)
                {
                    this.referenceCalculationInfoViewModel_ = value;
                    this.NotifyPropertyChanged("ReferenceCalculationInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region Operator1DListViewModel_
        private Operator1DListViewModel operator1DListViewModel_;
        public Operator1DListViewModel Operator1DListViewModel_
        {
            get { return this.operator1DListViewModel_; }
            set
            {
                if (this.operator1DListViewModel_ != value)
                {
                    this.operator1DListViewModel_ = value;
                    this.NotifyPropertyChanged("Operator1DListViewModel_");
                }
            }
        }
        #endregion
        
        #region ConditionOperatorViewModel_
        private ConditionOperatorViewModel conditionOperatorViewModel_;
        public ConditionOperatorViewModel ConditionOperatorViewModel_
        {
            get { return this.conditionOperatorViewModel_; }
            set
            {
                if (this.conditionOperatorViewModel_ != value)
                {
                    this.conditionOperatorViewModel_ = value;
                    this.NotifyPropertyChanged("ConditionOperatorViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "variableCalculation");
                xmlWriter.WriteStartElement("variableCalculation");
                    referenceCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                    operator1DListViewModel_.buildXml(xmlWriter);
                    
                    conditionOperatorViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new VariableCalculationView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.VariableCalculation serial_VariableCalculation = serial_Class as FpmlSerializedCSharp.VariableCalculation;
        
            FpmlSerializedCSharp.ReferenceCalculationInfo serial_referenceCalculationInfo = serial_VariableCalculation.ReferenceCalculationInfo_;
            string referenceCalculationInfotype = serial_referenceCalculationInfo.Excel_type_.ValueStr;
            this.referenceCalculationInfoViewModel_ = ReferenceCalculationInfoViewModel.CreateReferenceCalculationInfo(referenceCalculationInfotype);
            this.referenceCalculationInfoViewModel_.setFromSerial(serial_referenceCalculationInfo);
            
            FpmlSerializedCSharp.Operator1DList serial_operator1DList = serial_VariableCalculation.Operator1DList_;
            string operator1DListtype = serial_operator1DList.Excel_type_.ValueStr;
            this.operator1DListViewModel_ = Operator1DListViewModel.CreateOperator1DList(operator1DListtype);
            this.operator1DListViewModel_.setFromSerial(serial_operator1DList);
            
            FpmlSerializedCSharp.ConditionOperator serial_conditionOperator = serial_VariableCalculation.ConditionOperator_;
            string conditionOperatortype = serial_conditionOperator.Excel_type_.ValueStr;
            this.conditionOperatorViewModel_ = ConditionOperatorViewModel.CreateConditionOperator(conditionOperatortype);
            this.conditionOperatorViewModel_.setFromSerial(serial_conditionOperator);
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}

