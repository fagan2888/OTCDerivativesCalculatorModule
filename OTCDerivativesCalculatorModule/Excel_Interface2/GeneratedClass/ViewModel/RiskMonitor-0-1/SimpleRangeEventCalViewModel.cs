using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class SimpleRangeEventCalViewModel : EventCalculationViewModel
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
        
        public SimpleRangeEventCalViewModel() { }
        
        #region Range1DViewModel_
        private Range1DViewModel range1DViewModel_;
        public Range1DViewModel Range1DViewModel_
        {
            get { return this.range1DViewModel_; }
            set
            {
                if (this.range1DViewModel_ != value)
                {
                    this.range1DViewModel_ = value;
                    this.NotifyPropertyChanged("Range1DViewModel_");
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
        
        #region DateInformationViewModel_
        private DateInformationViewModel dateInformationViewModel_;
        public DateInformationViewModel DateInformationViewModel_
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
                xmlWriter.WriteElementString("excel_type" , "simpleRangeEventCal");
                xmlWriter.WriteStartElement("simpleRangeEventCal");
                    range1DViewModel_.buildXml(xmlWriter);
                    
                    referenceCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                    dateInformationViewModel_.buildXml(xmlWriter);
                    
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
            Control v = new SimpleRangeEventCalView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventCalculation serial_EventCalculation = serial_Class as FpmlSerializedCSharp.EventCalculation;
            FpmlSerializedCSharp.SimpleRangeEventCal serial_SimpleRangeEventCal = serial_EventCalculation.SimpleRangeEventCal_;
        
            FpmlSerializedCSharp.Range1D serial_range1D = serial_SimpleRangeEventCal.Range1D_;
            string range1Dtype = serial_range1D.Excel_type_.ValueStr;
            this.range1DViewModel_ = Range1DViewModel.CreateRange1D(range1Dtype);
            this.range1DViewModel_.setFromSerial(serial_range1D);
            
            FpmlSerializedCSharp.ReferenceCalculationInfo serial_referenceCalculationInfo = serial_SimpleRangeEventCal.ReferenceCalculationInfo_;
            string referenceCalculationInfotype = serial_referenceCalculationInfo.Excel_type_.ValueStr;
            this.referenceCalculationInfoViewModel_ = ReferenceCalculationInfoViewModel.CreateReferenceCalculationInfo(referenceCalculationInfotype);
            this.referenceCalculationInfoViewModel_.setFromSerial(serial_referenceCalculationInfo);
            
            FpmlSerializedCSharp.DateInformation serial_dateInformation = serial_SimpleRangeEventCal.DateInformation_;
            string dateInformationtype = serial_dateInformation.Excel_type_.ValueStr;
            this.dateInformationViewModel_ = DateInformationViewModel.CreateDateInformation(dateInformationtype);
            this.dateInformationViewModel_.setFromSerial(serial_dateInformation);
            
            FpmlSerializedCSharp.JointSimpleCalculation serial_jointSimpleCalculation = serial_SimpleRangeEventCal.JointSimpleCalculation_;
            string jointSimpleCalculationtype = serial_jointSimpleCalculation.Excel_type_.ValueStr;
            this.jointSimpleCalculationViewModel_ = JointSimpleCalculationViewModel.CreateJointSimpleCalculation(jointSimpleCalculationtype);
            this.jointSimpleCalculationViewModel_.setFromSerial(serial_jointSimpleCalculation);
            
        }
        
        
    
            
            
            
            
            
            
            
            
        
    
        
    
    }
    
}

