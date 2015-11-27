using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class CallPutCompositeReturnCalViewModel : ReturnCalculationViewModel
    {
        public CallPutCompositeReturnCalViewModel() { }
        
    
        #region Weight_
        private ObservableCollection<string> weight_;
        public ObservableCollection<string> Weight_
        {
            get { return this.weight_; }
            set
            {
                if (this.weight_ != value)
                {
                    this.weight_ = value;
                    this.NotifyPropertyChanged("Weight_");
                }
            }
        }
        #endregion
        
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
        
        #region OptionPayoffFunctionViewModel_
        private ObservableCollection<OptionPayoffFunctionViewModel> optionPayoffFunctionViewModel_;
        public ObservableCollection<OptionPayoffFunctionViewModel> OptionPayoffFunctionViewModel_
        {
            get { return this.optionPayoffFunctionViewModel_; }
            set
            {
                if (this.optionPayoffFunctionViewModel_ != value)
                {
                    this.optionPayoffFunctionViewModel_ = value;
                    this.NotifyPropertyChanged("OptionPayoffFunctionViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("returnCalculation");
                xmlWriter.WriteElementString("type" , "callPutCompositeReturnCal");
                xmlWriter.WriteStartElement("callPutCompositeReturnCal");

                referenceCalculationInfoViewModel_.buildXml(xmlWriter);

                foreach (var item in optionPayoffFunctionViewModel_)
                {
                    item.buildXml(xmlWriter);
                }

                foreach (var item in this.weight_)
                {
                    xmlWriter.WriteElementString("weight", item);
                }
                    
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
            FpmlSerializedCSharp.CallPutCompositeReturnCal serial_CallPutCompositeReturnCal = serial_ReturnCalculation.CallPutCompositeReturnCal_;
        
            this.weight_ = new ObservableCollection<string>();

            foreach (var item in serial_CallPutCompositeReturnCal.Weight_)
            {
                this.weight_.Add(item.ValueStr);
            }
            
            FpmlSerializedCSharp.ReferenceCalculationInfo serial_referenceCalculationInfo = serial_CallPutCompositeReturnCal.ReferenceCalculationInfo_;
            this.referenceCalculationInfoViewModel_.setFromSerial(serial_referenceCalculationInfo);
            
            List<FpmlSerializedCSharp.OptionPayoffFunction> serial_optionPayoffFunction = serial_CallPutCompositeReturnCal.OptionPayoffFunction_;
            this.optionPayoffFunctionViewModel_ = new ObservableCollection<OptionPayoffFunctionViewModel>();
            foreach (var item in serial_optionPayoffFunction)
            {
                string type = item.Type_.ValueStr;
                OptionPayoffFunctionViewModel viewModel = OptionPayoffFunctionViewModel.CreateOptionPayoffFunction(type);
                viewModel.setFromSerial(item);
                this.optionPayoffFunctionViewModel_.Add(viewModel);
            }
            
            //this.view_ = new CallPutCompositeReturnCalView();
            //this.view_.DataContext = this;
        }
        
        
    
            //#region SelectReferenceCalculationInfoInfo_
            //private string selectReferenceCalculationInfoInfo_;
            //public string SelectReferenceCalculationInfoInfo_
            //{
            //    get { return this.selectReferenceCalculationInfoInfo_; }
            //    set
            //    {
            //        if (this.selectReferenceCalculationInfoInfo_ != value)
            //        {
            //            this.selectReferenceCalculationInfoInfo_ = value;
            //            this.NotifyPropertyChanged("SelectReferenceCalculationInfoInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectReferenceCalculationInfoInfo(string typeStr)
            //{
            //    this.referenceCalculationInfoViewModel_ = ReferenceCalculationInfoViewModel.CreateReferenceCalculationInfo(typeStr);
            //    this.view_.DataContext = this;
            //}
            
            //#region SelectOptionPayoffFunctionInfo_
            //private string selectOptionPayoffFunctionInfo_;
            //public string SelectOptionPayoffFunctionInfo_
            //{
            //    get { return this.selectOptionPayoffFunctionInfo_; }
            //    set
            //    {
            //        if (this.selectOptionPayoffFunctionInfo_ != value)
            //        {
            //            this.selectOptionPayoffFunctionInfo_ = value;
            //            this.NotifyPropertyChanged("SelectOptionPayoffFunctionInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectOptionPayoffFunctionInfo(string typeStr)
            //{
            //    this.optionPayoffFunctionViewModel_ = OptionPayoffFunctionViewModel.CreateOptionPayoffFunction(typeStr);
            //    this.view_.DataContext = this;
            //}
            
        
    
        
    
    }
    
}

