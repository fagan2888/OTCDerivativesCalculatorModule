using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class DualBarrierEventCalViewModel : EventCalculationViewModel
    {
        
    
        public DualBarrierEventCalViewModel() 
        {
            this.referenceCalculationInfoViewModel_ = new ObservableCollection<ReferenceCalculationInfoViewModel>();

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
        
        #region UpperTrigger_
        private ObservableCollection<string> upperTrigger_;
        public ObservableCollection<string> UpperTrigger_
        {
            get { return this.upperTrigger_; }
            set
            {
                if (this.upperTrigger_ != value)
                {
                    this.upperTrigger_ = value;
                    this.NotifyPropertyChanged("UpperTrigger_");
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
        private ObservableCollection<ReferenceCalculationInfoViewModel> referenceCalculationInfoViewModel_;
        public ObservableCollection<ReferenceCalculationInfoViewModel> ReferenceCalculationInfoViewModel_
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
        
        #region JointSimpleCalculationViewModel_
        private JointSimpleCalculationViewModel jointSimpleCalculationViewModel_;
        public JointSimpleCalculationViewModel JointSimpleCalculationViewModel_
        {
            get { return this.jointSimpleCalculationViewModel_; }
            set
            {
                if (this.jointSimpleCalculationViewModel_ != value)
                {
                    this.jointSimpleCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("JointSimpleCalculationViewModel_");
                }
            }
        }
        #endregion
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("eventCalculation");
                xmlWriter.WriteElementString("type" , "dualBarrierEventCal");
                xmlWriter.WriteStartElement("dualBarrierEventCal");

                    foreach (var item in dateInformationViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }

                    foreach (var item in this.upperTrigger_)
                    {
                        xmlWriter.WriteElementString("upperTrigger", item);    
                    }

                    foreach (var item in this.lowerTrigger_)
                    {
                        xmlWriter.WriteElementString("lowerTrigger", item);
                    }

                    foreach (var item in referenceCalculationInfoViewModel_)
                    {
                        item.buildXml(xmlWriter);    
                    }
                    
                    jointSimpleCalculationViewModel_.buildXml(xmlWriter);
                    
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
            FpmlSerializedCSharp.DualBarrierEventCal serial_DualBarrierEventCal = serial_EventCalculation.DualBarrierEventCal_;
        
            List<FpmlSerializedCSharp.DateInformation> serial_dateInformation = serial_DualBarrierEventCal.DateInformation_;
            this.dateInformationViewModel_ = new ObservableCollection<DateInformationViewModel>();
            foreach (var item in serial_dateInformation)
            {
                string type = item.Type_.ValueStr;
                DateInformationViewModel viewModel = DateInformationViewModel.CreateDateInformation(type);
                viewModel.setFromSerial(item);
                this.dateInformationViewModel_.Add(viewModel);
            }
            
            this.upperTrigger_ = new ObservableCollection<string>();
            foreach (var item in serial_DualBarrierEventCal.UpperTrigger_)
            {
                this.upperTrigger_.Add(item.ValueStr);
            }

            this.lowerTrigger_ = new ObservableCollection<string>();
            foreach (var item in serial_DualBarrierEventCal.LowerTrigger_)
            {
                this.lowerTrigger_.Add(item.ValueStr);
            }
            
            List<FpmlSerializedCSharp.ReferenceCalculationInfo> serial_referenceCalculationInfo = serial_DualBarrierEventCal.ReferenceCalculationInfo_;
            this.referenceCalculationInfoViewModel_ = new ObservableCollection<ReferenceCalculationInfoViewModel>();
            foreach (var item in serial_referenceCalculationInfo)
            {
                //string type = item.Type_.ValueStr;
                ReferenceCalculationInfoViewModel viewModel = new ReferenceCalculationInfoViewModel();
                viewModel.setFromSerial(item);
                this.referenceCalculationInfoViewModel_.Add(viewModel);
            }
            
            FpmlSerializedCSharp.JointSimpleCalculation serial_jointSimpleCalculation = serial_DualBarrierEventCal.JointSimpleCalculation_;
            string jointSimpleCalculationtype = serial_jointSimpleCalculation.Type_.ValueStr;
            this.jointSimpleCalculationViewModel_ = JointSimpleCalculationViewModel.CreateJointSimpleCalculation(jointSimpleCalculationtype);
            this.jointSimpleCalculationViewModel_.setFromSerial(serial_jointSimpleCalculation);
            
            //this.view_ = new DualBarrierEventCalView();
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
            
            //#region SelectJointSimpleCalculationInfo_
            //private string selectJointSimpleCalculationInfo_;
            //public string SelectJointSimpleCalculationInfo_
            //{
            //    get { return this.selectJointSimpleCalculationInfo_; }
            //    set
            //    {
            //        if (this.selectJointSimpleCalculationInfo_ != value)
            //        {
            //            this.selectJointSimpleCalculationInfo_ = value;
            //            this.NotifyPropertyChanged("SelectJointSimpleCalculationInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectJointSimpleCalculationInfo(string typeStr)
            //{
            //    this.jointSimpleCalculationViewModel_ = JointSimpleCalculationViewModel.CreateJointSimpleCalculation(typeStr);
            //    this.view_.DataContext = this;
            //}
            
        
    
        
    
    }
    
}

