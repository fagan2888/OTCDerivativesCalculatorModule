using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ReferenceCalculationInfoViewModel : IXmlData
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
        
        public ReferenceCalculationInfoViewModel() { }
        
        #region FixingInformationViewModel_
        private FixingInformationViewModel fixingInformationViewModel_;
        public FixingInformationViewModel FixingInformationViewModel_
        {
            get { return this.fixingInformationViewModel_; }
            set
            {
                if (this.fixingInformationViewModel_ != value)
                {
                    this.fixingInformationViewModel_ = value;
                    this.NotifyPropertyChanged("FixingInformationViewModel_");
                }
            }
        }
        #endregion
        
        #region ReferenceCalculationViewModel_
        private ObservableCollection<ReferenceCalculationViewModel> referenceCalculationViewModel_;
        public ObservableCollection<ReferenceCalculationViewModel> ReferenceCalculationViewModel_
        {
            get { return this.referenceCalculationViewModel_; }
            set
            {
                if (this.referenceCalculationViewModel_ != value)
                {
                    this.referenceCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("ReferenceCalculationViewModel_");
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
        
        #region PostCalculationViewModel_
        private PostCalculationViewModel postCalculationViewModel_;
        public PostCalculationViewModel PostCalculationViewModel_
        {
            get { return this.postCalculationViewModel_; }
            set
            {
                if (this.postCalculationViewModel_ != value)
                {
                    this.postCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("PostCalculationViewModel_");
                }
            }
        }
        #endregion
        
        #region RefVariable_referenceValueViewModel_
        private RefVariable_referenceValueViewModel refVariable_referenceValueViewModel_;
        public RefVariable_referenceValueViewModel RefVariable_referenceValueViewModel_
        {
            get { return this.refVariable_referenceValueViewModel_; }
            set
            {
                if (this.refVariable_referenceValueViewModel_ != value)
                {
                    this.refVariable_referenceValueViewModel_ = value;
                    this.NotifyPropertyChanged("RefVariable_referenceValueViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "referenceCalculationInfo");
                xmlWriter.WriteStartElement("referenceCalculationInfo");
                    fixingInformationViewModel_.buildXml(xmlWriter);
                    
                    foreach (var item in referenceCalculationViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    operatorNDViewModel_.buildXml(xmlWriter);
                    
                    postCalculationViewModel_.buildXml(xmlWriter);
                    
                    refVariable_referenceValueViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new ReferenceCalculationInfoView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReferenceCalculationInfo serial_ReferenceCalculationInfo = serial_Class as FpmlSerializedCSharp.ReferenceCalculationInfo;
        
            FpmlSerializedCSharp.FixingInformation serial_fixingInformation = serial_ReferenceCalculationInfo.FixingInformation_;
            string fixingInformationtype = serial_fixingInformation.Excel_type_.ValueStr;
            this.fixingInformationViewModel_ = FixingInformationViewModel.CreateFixingInformation(fixingInformationtype);
            this.fixingInformationViewModel_.setFromSerial(serial_fixingInformation);
            
            List<FpmlSerializedCSharp.ReferenceCalculation> serial_referenceCalculation = serial_ReferenceCalculationInfo.ReferenceCalculation_;
            this.referenceCalculationViewModel_ = new ObservableCollection<ReferenceCalculationViewModel>();
            foreach (var item in serial_referenceCalculation)
            {
                string type = item.Excel_type_.ValueStr;
                ReferenceCalculationViewModel viewModel = ReferenceCalculationViewModel.CreateReferenceCalculation(type);
                viewModel.setFromSerial(item);
                this.referenceCalculationViewModel_.Add(viewModel);
            }
            
            FpmlSerializedCSharp.OperatorND serial_operatorND = serial_ReferenceCalculationInfo.OperatorND_;
            string operatorNDtype = serial_operatorND.Excel_type_.ValueStr;
            this.operatorNDViewModel_ = OperatorNDViewModel.CreateOperatorND(operatorNDtype);
            this.operatorNDViewModel_.setFromSerial(serial_operatorND);
            
            FpmlSerializedCSharp.PostCalculation serial_postCalculation = serial_ReferenceCalculationInfo.PostCalculation_;
            string postCalculationtype = serial_postCalculation.Excel_type_.ValueStr;
            this.postCalculationViewModel_ = PostCalculationViewModel.CreatePostCalculation(postCalculationtype);
            this.postCalculationViewModel_.setFromSerial(serial_postCalculation);
            
            FpmlSerializedCSharp.RefVariable_referenceValue serial_refVariable_referenceValue = serial_ReferenceCalculationInfo.RefVariable_referenceValue_;
            string refVariable_referenceValuetype = serial_refVariable_referenceValue.Excel_type_.ValueStr;
            this.refVariable_referenceValueViewModel_ = RefVariable_referenceValueViewModel.CreateRefVariable_referenceValue(refVariable_referenceValuetype);
            this.refVariable_referenceValueViewModel_.setFromSerial(serial_refVariable_referenceValue);
            
        }
        
        
    
            
            
            
            
            
            
            
            
            
            
        
    
        
    
    }
    
}

