using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class SimpleRangeEventCalViewModel : EventCalculationViewModel
    {
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

        // 여러날에 걸쳐서 조사하기위한것
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
                xmlWriter.WriteElementString("type" , "simpleRangeEventCal");
                xmlWriter.WriteStartElement("simpleRangeEventCal");
                    range1DViewModel_.buildXml(xmlWriter);
                    
                    referenceCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                    if ( dateInformationViewModel_ != null )
                        dateInformationViewModel_.buildXml(xmlWriter);

                    if ( jointSimpleCalculationViewModel_ != null)
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
            FpmlSerializedCSharp.SimpleRangeEventCal serial_SimpleRangeEventCal = serial_EventCalculation.SimpleRangeEventCal_;
        
            FpmlSerializedCSharp.Range1D serial_range1D = serial_SimpleRangeEventCal.Range1D_;
            this.range1DViewModel_.setFromSerial(serial_range1D);
            
            FpmlSerializedCSharp.ReferenceCalculationInfo serial_referenceCalculationInfo = serial_SimpleRangeEventCal.ReferenceCalculationInfo_;
            this.referenceCalculationInfoViewModel_.setFromSerial(serial_referenceCalculationInfo);
            
            FpmlSerializedCSharp.DateInformation serial_dateInformation = serial_SimpleRangeEventCal.DateInformation_;
            string dateInformationtype = serial_dateInformation.Type_.ValueStr;
            this.dateInformationViewModel_ = DateInformationViewModel.CreateDateInformation(dateInformationtype);
            this.dateInformationViewModel_.setFromSerial(serial_dateInformation);
            
            FpmlSerializedCSharp.JointSimpleCalculation serial_jointSimpleCalculation = serial_SimpleRangeEventCal.JointSimpleCalculation_;
            string jointSimpleCalculationtype = serial_jointSimpleCalculation.Type_.ValueStr;
            this.jointSimpleCalculationViewModel_ = JointSimpleCalculationViewModel.CreateJointSimpleCalculation(jointSimpleCalculationtype);
            this.jointSimpleCalculationViewModel_.setFromSerial(serial_jointSimpleCalculation);
            
            //this.view_ = new SimpleRangeEventCalView();
            this.view_.DataContext = this;
        }
    
            //#region SelectRange1DInfo_
            //private string selectRange1DInfo_;
            //public string SelectRange1DInfo_
            //{
            //    get { return this.selectRange1DInfo_; }
            //    set
            //    {
            //        if (this.selectRange1DInfo_ != value)
            //        {
            //            this.selectRange1DInfo_ = value;
            //            this.NotifyPropertyChanged("SelectRange1DInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectRange1DInfo(string typeStr)
            //{
            //    this.range1DViewModel_ = Range1DViewModel.CreateRange1D(typeStr);
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

