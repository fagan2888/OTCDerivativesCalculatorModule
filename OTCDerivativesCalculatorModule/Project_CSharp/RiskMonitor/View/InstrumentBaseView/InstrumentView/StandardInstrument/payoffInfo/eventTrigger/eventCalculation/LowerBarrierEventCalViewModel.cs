using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class LowerBarrierEventCalViewModel : EventCalculationViewModel
    {
    
        public LowerBarrierEventCalViewModel() 
        {
            this.referenceCalculationInfoViewModel_ = new ReferenceCalculationInfoViewModel();
        }
        
    
        #region DateInformationViewModel_
        private ObservableCollection<DateInformationViewModel> dateInformationViewModel_;
        public ObservableCollection<DateInformationViewModel> DateInformationViewModel_
        {
            get { return this.dateInformationViewModel_; }
            set
            {
                if (this.dateInformationViewModel_ != value)
                {
                    this.dateInformationViewModel_ = value;
                    this.NotifyPropertyChanged("DateInformationViewModel_");
                }
            }
        }
        #endregion
        
        #region LowerTrigger_
        private ObservableCollection<string> lowerTrigger_;
        public ObservableCollection<string> LowerTrigger_
        {
            get { return this.lowerTrigger_; }
            set
            {
                if (this.lowerTrigger_ != value)
                {
                    this.lowerTrigger_ = value;
                    this.NotifyPropertyChanged("LowerTrigger_");
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
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("eventCalculation");
                xmlWriter.WriteElementString("type" , "lowerBarrierEventCal");
                xmlWriter.WriteStartElement("lowerBarrierEventCal");

                foreach (var item in dateInformationViewModel_)
                {
                    item.buildXml(xmlWriter);
                }

                foreach (var item in this.lowerTrigger_)
                {
                    xmlWriter.WriteElementString("lowerTrigger", item);
                }
                    
                    referenceCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventCalculation serial_EventCalculation = serial_Class as FpmlSerializedCSharp.EventCalculation;
            FpmlSerializedCSharp.LowerBarrierEventCal serial_LowerBarrierEventCal = serial_EventCalculation.LowerBarrierEventCal_;
        
            List<FpmlSerializedCSharp.DateInformation> serial_dateInformation = serial_LowerBarrierEventCal.DateInformation_;
            this.dateInformationViewModel_ = new ObservableCollection<DateInformationViewModel>();
            foreach (var item in serial_dateInformation)
            {
                string type = item.Type_.ValueStr;
                DateInformationViewModel viewModel = DateInformationViewModel.CreateDateInformation(type);
                viewModel.setFromSerial(item);
                this.dateInformationViewModel_.Add(viewModel);
            }

            this.lowerTrigger_ = new ObservableCollection<string>();
            foreach (var item in serial_LowerBarrierEventCal.LowerTrigger_)
            {
                this.lowerTrigger_.Add(item.ValueStr);
            }
            
            FpmlSerializedCSharp.ReferenceCalculationInfo serial_referenceCalculationInfo = serial_LowerBarrierEventCal.ReferenceCalculationInfo_;
            this.referenceCalculationInfoViewModel_.setFromSerial(serial_referenceCalculationInfo);
            
           //this.view_ = new LowerBarrierEventCalView();
            this.view_.DataContext = this;
        }
        
        
    
            //#region SelectDateInformationInfo_
            //private string selectDateInformationInfo_;
            //public string SelectDateInformationInfo_
            //{
            //    get { return this.selectDateInformationInfo_; }
            //    set
            //    {
            //        if (this.selectDateInformationInfo_ != value)
            //        {
            //            this.selectDateInformationInfo_ = value;
            //            this.NotifyPropertyChanged("SelectDateInformationInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectDateInformationInfo(string typeStr)
            //{
            //    this.dateInformationViewModel_ = DateInformationViewModel.CreateDateInformation(typeStr);
            //    this.view_.DataContext = this;
            //}
            
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
            
        
    
        
    
    }
    
}

