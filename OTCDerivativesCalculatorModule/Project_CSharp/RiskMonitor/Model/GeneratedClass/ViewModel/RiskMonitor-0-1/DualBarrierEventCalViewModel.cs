using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class DualBarrierEventCalViewModel : EventCalculationViewModel
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
        
        public DualBarrierEventCalViewModel() { }
        
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
                    
                    xmlWriter.WriteElementString("upperTrigger" , this.upperTrigger_);
                    
                    xmlWriter.WriteElementString("lowerTrigger" , this.lowerTrigger_);
                    
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
        
        public override Control view()
        {
            Control v = new DualBarrierEventCalView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventCalculation serial_EventCalculation = serial_Class as FpmlSerializedCSharp.EventCalculation;
            FpmlSerializedCSharp.DualBarrierEventCal serial_DualBarrierEventCal = serial_EventCalculation.DualBarrierEventCal_;
        
            List<FpmlSerializedCSharp.DateInformation> serial_dateInformation = serial_DualBarrierEventCal.DateInformation_;
            this.dateInformationViewModel_ = new ObservableCollection<DateInformationViewModel>();
            foreach (var item in serial_dateInformation)
            {
                string type = item.Excel_type_.ValueStr;
                DateInformationViewModel viewModel = DateInformationViewModel.CreateDateInformation(type);
                viewModel.setFromSerial(item);
                this.dateInformationViewModel_.Add(viewModel);
            }
            
            this.upperTriggerViewModel_ = new ObservableCollection<UpperTriggerViewModel>();
            foreach (var item in serial_DualBarrierEventCal.UpperTrigger_)
            {
                this.value_.Add(item.ValueStr);
            }
            
            this.lowerTriggerViewModel_ = new ObservableCollection<LowerTriggerViewModel>();
            foreach (var item in serial_DualBarrierEventCal.LowerTrigger_)
            {
                this.value_.Add(item.ValueStr);
            }
            
            List<FpmlSerializedCSharp.ReferenceCalculationInfo> serial_referenceCalculationInfo = serial_DualBarrierEventCal.ReferenceCalculationInfo_;
            this.referenceCalculationInfoViewModel_ = new ObservableCollection<ReferenceCalculationInfoViewModel>();
            foreach (var item in serial_referenceCalculationInfo)
            {
                string type = item.Excel_type_.ValueStr;
                ReferenceCalculationInfoViewModel viewModel = ReferenceCalculationInfoViewModel.CreateReferenceCalculationInfo(type);
                viewModel.setFromSerial(item);
                this.referenceCalculationInfoViewModel_.Add(viewModel);
            }
            
            FpmlSerializedCSharp.JointSimpleCalculation serial_jointSimpleCalculation = serial_DualBarrierEventCal.JointSimpleCalculation_;
            string jointSimpleCalculationtype = serial_jointSimpleCalculation.Excel_type_.ValueStr;
            this.jointSimpleCalculationViewModel_ = JointSimpleCalculationViewModel.CreateJointSimpleCalculation(jointSimpleCalculationtype);
            this.jointSimpleCalculationViewModel_.setFromSerial(serial_jointSimpleCalculation);
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}

