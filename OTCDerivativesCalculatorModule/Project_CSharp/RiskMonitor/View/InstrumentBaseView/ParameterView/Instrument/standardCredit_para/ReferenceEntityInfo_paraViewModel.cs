using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ReferenceEntityInfo_paraViewModel : IXmlData
    {
        #region View_
        private Control view_;
        public Control View_
        {
            get { return this.view_; }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
                }
            }
        }
        #endregion
    
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
        
    
        public ReferenceEntityInfo_paraViewModel() { }
        
    
        #region ReferenceCurveListViewModel_
        private ReferenceCurveListViewModel referenceCurveListViewModel_;
        public ReferenceCurveListViewModel ReferenceCurveListViewModel_
        {
            get { return this.referenceCurveListViewModel_; }
            set
            {
                if (this.referenceCurveListViewModel_ != value)
                {
                    this.referenceCurveListViewModel_ = value;
                    this.NotifyPropertyChanged("ReferenceCurveListViewModel_");
                }
            }
        }
        #endregion
        
        #region JointProbabilityTraitViewModel_
        private JointProbabilityTraitViewModel jointProbabilityTraitViewModel_;
        public JointProbabilityTraitViewModel JointProbabilityTraitViewModel_
        {
            get { return this.jointProbabilityTraitViewModel_; }
            set
            {
                if (this.jointProbabilityTraitViewModel_ != value)
                {
                    this.jointProbabilityTraitViewModel_ = value;
                    this.NotifyPropertyChanged("JointProbabilityTraitViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "referenceEntityInfo_para");
                xmlWriter.WriteStartElement("referenceEntityInfo_para");
                    referenceCurveListViewModel_.buildXml(xmlWriter);
                    
                    jointProbabilityTraitViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReferenceEntityInfo_para serial_ReferenceEntityInfo_para = serial_Class as FpmlSerializedCSharp.ReferenceEntityInfo_para;
        
            FpmlSerializedCSharp.ReferenceCurveList serial_referenceCurveList = serial_ReferenceEntityInfo_para.ReferenceCurveList_;
            this.referenceCurveListViewModel_ = new ReferenceCurveListViewModel();
            this.referenceCurveListViewModel_.setFromSerial(serial_referenceCurveList);
            
            FpmlSerializedCSharp.JointProbabilityTrait serial_jointProbabilityTrait = serial_ReferenceEntityInfo_para.JointProbabilityTrait_;
            string jointProbabilityTraittype = serial_jointProbabilityTrait.Type_.ValueStr;
            this.jointProbabilityTraitViewModel_ = JointProbabilityTraitViewModel.CreateJointProbabilityTrait(jointProbabilityTraittype);
            this.jointProbabilityTraitViewModel_.setFromSerial(serial_jointProbabilityTrait);
            
            this.view_ = new ReferenceEntityInfo_paraView();
            this.view_.DataContext = this;
        }
            
        #region SelectJointProbabilityTraitInfo_
        private string selectJointProbabilityTraitInfo_;
        public string SelectJointProbabilityTraitInfo_
        {
            get { return this.selectJointProbabilityTraitInfo_; }
            set
            {
                if (this.selectJointProbabilityTraitInfo_ != value)
                {
                    this.selectJointProbabilityTraitInfo_ = value;
                    this.NotifyPropertyChanged("SelectJointProbabilityTraitInfo_");
                }
            }
        }
        #endregion
            
        public void selectJointProbabilityTraitInfo(string typeStr)
        {
            this.jointProbabilityTraitViewModel_ = JointProbabilityTraitViewModel.CreateJointProbabilityTrait(typeStr);
            this.view_.DataContext = this;
        }
            
    }
    
}

