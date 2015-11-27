using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class CallPutCompositeReturnCalViewModel : ReturnCalculationViewModel
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
                    xmlWriter.WriteElementString("weight" , this.weight_);
                    
                    referenceCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                    foreach (var item in optionPayoffFunctionViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new CallPutCompositeReturnCalView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReturnCalculation serial_ReturnCalculation = serial_Class as FpmlSerializedCSharp.ReturnCalculation;
            FpmlSerializedCSharp.CallPutCompositeReturnCal serial_CallPutCompositeReturnCal = serial_ReturnCalculation.CallPutCompositeReturnCal_;
        
            this.weightViewModel_ = new ObservableCollection<WeightViewModel>();
            foreach (var item in serial_CallPutCompositeReturnCal.Weight_)
            {
                this.value_.Add(item.ValueStr);
            }
            
            FpmlSerializedCSharp.ReferenceCalculationInfo serial_referenceCalculationInfo = serial_CallPutCompositeReturnCal.ReferenceCalculationInfo_;
            string referenceCalculationInfotype = serial_referenceCalculationInfo.Excel_type_.ValueStr;
            this.referenceCalculationInfoViewModel_ = ReferenceCalculationInfoViewModel.CreateReferenceCalculationInfo(referenceCalculationInfotype);
            this.referenceCalculationInfoViewModel_.setFromSerial(serial_referenceCalculationInfo);
            
            List<FpmlSerializedCSharp.OptionPayoffFunction> serial_optionPayoffFunction = serial_CallPutCompositeReturnCal.OptionPayoffFunction_;
            this.optionPayoffFunctionViewModel_ = new ObservableCollection<OptionPayoffFunctionViewModel>();
            foreach (var item in serial_optionPayoffFunction)
            {
                string type = item.Excel_type_.ValueStr;
                OptionPayoffFunctionViewModel viewModel = OptionPayoffFunctionViewModel.CreateOptionPayoffFunction(type);
                viewModel.setFromSerial(item);
                this.optionPayoffFunctionViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

