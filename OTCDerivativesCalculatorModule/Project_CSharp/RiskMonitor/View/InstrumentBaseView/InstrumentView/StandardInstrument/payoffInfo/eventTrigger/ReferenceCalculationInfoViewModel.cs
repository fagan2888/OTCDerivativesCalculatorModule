using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
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
    
        public ReferenceCalculationInfoViewModel() 
        {
            this.referenceCalculationViewModel_ = new ObservableCollection<ReferenceCalculationViewModel>();
        }
        
    
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
            xmlWriter.WriteStartElement("referenceCalculationInfo");

                if ( fixingInformationViewModel_ != null )
                    fixingInformationViewModel_.buildXml(xmlWriter);

                foreach (var item in referenceCalculationViewModel_)
                {
                    item.buildXml(xmlWriter);    
                }

                if ( operatorNDViewModel_ != null)
                    operatorNDViewModel_.buildXml(xmlWriter);

                if (postCalculationViewModel_ != null)
                    postCalculationViewModel_.buildXml(xmlWriter);

                if (refVariable_referenceValueViewModel_ != null)
                    refVariable_referenceValueViewModel_.buildXml(xmlWriter);
                    
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReferenceCalculationInfo serial_ReferenceCalculationInfo = serial_Class as FpmlSerializedCSharp.ReferenceCalculationInfo;
        
            FpmlSerializedCSharp.FixingInformation serial_fixingInformation = serial_ReferenceCalculationInfo.FixingInformation_;
            this.fixingInformationViewModel_.setFromSerial(serial_fixingInformation);
            
            List<FpmlSerializedCSharp.ReferenceCalculation> serial_referenceCalculation = serial_ReferenceCalculationInfo.ReferenceCalculation_;
            this.referenceCalculationViewModel_ = new ObservableCollection<ReferenceCalculationViewModel>();
            foreach (var item in serial_referenceCalculation)
            {
                string type = item.Type_.ValueStr;
                ReferenceCalculationViewModel viewModel = ReferenceCalculationViewModel.CreateReferenceCalculation(type);
                viewModel.setFromSerial(item);
                this.referenceCalculationViewModel_.Add(viewModel);
            }
            
            FpmlSerializedCSharp.OperatorND serial_operatorND = serial_ReferenceCalculationInfo.OperatorND_;
            string operatorNDtype = serial_operatorND.Type_.ValueStr;
            this.operatorNDViewModel_ = OperatorNDViewModel.CreateOperatorND(operatorNDtype);
            this.operatorNDViewModel_.setFromSerial(serial_operatorND);
            
            FpmlSerializedCSharp.PostCalculation serial_postCalculation = serial_ReferenceCalculationInfo.PostCalculation_;
            this.postCalculationViewModel_.setFromSerial(serial_postCalculation);
            
            FpmlSerializedCSharp.RefVariable_referenceValue serial_refVariable_referenceValue = serial_ReferenceCalculationInfo.RefVariable_referenceValue_;
            this.refVariable_referenceValueViewModel_.setFromSerial(serial_refVariable_referenceValue);
            
            //this.view_ = new ReferenceCalculationInfoView();
            //this.view_.DataContext = this;
        }
        
        
    
            //#region SelectFixingInformationInfo_
            //private string selectFixingInformationInfo_;
            //public string SelectFixingInformationInfo_
            //{
            //    get { return this.selectFixingInformationInfo_; }
            //    set
            //    {
            //        if (this.selectFixingInformationInfo_ != value)
            //        {
            //            this.selectFixingInformationInfo_ = value;
            //            this.NotifyPropertyChanged("SelectFixingInformationInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectFixingInformationInfo(string typeStr)
            //{
            //    this.fixingInformationViewModel_ = FixingInformationViewModel.CreateFixingInformation(typeStr);
            //    this.view_.DataContext = this;
            //}
            
            //#region SelectReferenceCalculationInfo_
            //private string selectReferenceCalculationInfo_;
            //public string SelectReferenceCalculationInfo_
            //{
            //    get { return this.selectReferenceCalculationInfo_; }
            //    set
            //    {
            //        if (this.selectReferenceCalculationInfo_ != value)
            //        {
            //            this.selectReferenceCalculationInfo_ = value;
            //            this.NotifyPropertyChanged("SelectReferenceCalculationInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectReferenceCalculationInfo(string typeStr)
            //{
            //    this.referenceCalculationViewModel_ = ReferenceCalculationViewModel.CreateReferenceCalculation(typeStr);
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
            
            //#region SelectPostCalculationInfo_
            //private string selectPostCalculationInfo_;
            //public string SelectPostCalculationInfo_
            //{
            //    get { return this.selectPostCalculationInfo_; }
            //    set
            //    {
            //        if (this.selectPostCalculationInfo_ != value)
            //        {
            //            this.selectPostCalculationInfo_ = value;
            //            this.NotifyPropertyChanged("SelectPostCalculationInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectPostCalculationInfo(string typeStr)
            //{
            //    this.postCalculationViewModel_ = PostCalculationViewModel.CreatePostCalculation(typeStr);
            //    this.view_.DataContext = this;
            //}
            
            //#region SelectRefVariable_referenceValueInfo_
            //private string selectRefVariable_referenceValueInfo_;
            //public string SelectRefVariable_referenceValueInfo_
            //{
            //    get { return this.selectRefVariable_referenceValueInfo_; }
            //    set
            //    {
            //        if (this.selectRefVariable_referenceValueInfo_ != value)
            //        {
            //            this.selectRefVariable_referenceValueInfo_ = value;
            //            this.NotifyPropertyChanged("SelectRefVariable_referenceValueInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectRefVariable_referenceValueInfo(string typeStr)
            //{
            //    this.refVariable_referenceValueViewModel_ = RefVariable_referenceValueViewModel.CreateRefVariable_referenceValue(typeStr);
            //    this.view_.DataContext = this;
            //}
            
        
    
        
    
    }
    
}

