using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class PostCalculationViewModel : IXmlData
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
        
    
        public PostCalculationViewModel() { }
        
    
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
                xmlWriter.WriteElementString("type" , "postCalculation");
                xmlWriter.WriteStartElement("postCalculation");
                    operator1DListViewModel_.buildXml(xmlWriter);
                    
                    conditionOperatorViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PostCalculation serial_PostCalculation = serial_Class as FpmlSerializedCSharp.PostCalculation;
        
            FpmlSerializedCSharp.Operator1DList serial_operator1DList = serial_PostCalculation.Operator1DList_;
            this.operator1DListViewModel_.setFromSerial(serial_operator1DList);
            
            FpmlSerializedCSharp.ConditionOperator serial_conditionOperator = serial_PostCalculation.ConditionOperator_;
            this.conditionOperatorViewModel_.setFromSerial(serial_conditionOperator);
            
            //this.view_ = new PostCalculationView();
            //this.view_.DataContext = this;
        }
        
        
    
            //#region SelectOperator1DListInfo_
            //private string selectOperator1DListInfo_;
            //public string SelectOperator1DListInfo_
            //{
            //    get { return this.selectOperator1DListInfo_; }
            //    set
            //    {
            //        if (this.selectOperator1DListInfo_ != value)
            //        {
            //            this.selectOperator1DListInfo_ = value;
            //            this.NotifyPropertyChanged("SelectOperator1DListInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectOperator1DListInfo(string typeStr)
            //{
            //    this.operator1DListViewModel_ = Operator1DListViewModel.CreateOperator1DList(typeStr);
            //    this.view_.DataContext = this;
            //}
            
            //#region SelectConditionOperatorInfo_
            //private string selectConditionOperatorInfo_;
            //public string SelectConditionOperatorInfo_
            //{
            //    get { return this.selectConditionOperatorInfo_; }
            //    set
            //    {
            //        if (this.selectConditionOperatorInfo_ != value)
            //        {
            //            this.selectConditionOperatorInfo_ = value;
            //            this.NotifyPropertyChanged("SelectConditionOperatorInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectConditionOperatorInfo(string typeStr)
            //{
            //    this.conditionOperatorViewModel_ = ConditionOperatorViewModel.CreateConditionOperator(typeStr);
            //    this.view_.DataContext = this;
            //}
            
        
    
        
    
    }
    
}

