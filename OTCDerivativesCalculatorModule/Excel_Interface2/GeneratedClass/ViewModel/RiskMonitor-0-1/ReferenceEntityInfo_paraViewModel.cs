using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ReferenceEntityInfo_paraViewModel : IXmlData
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
                xmlWriter.WriteElementString("excel_type" , "referenceEntityInfo_para");
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
        
        public  Control view()
        {
            Control v = new ReferenceEntityInfo_paraView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReferenceEntityInfo_para serial_ReferenceEntityInfo_para = serial_Class as FpmlSerializedCSharp.ReferenceEntityInfo_para;
        
            FpmlSerializedCSharp.ReferenceCurveList serial_referenceCurveList = serial_ReferenceEntityInfo_para.ReferenceCurveList_;
            string referenceCurveListtype = serial_referenceCurveList.Excel_type_.ValueStr;
            this.referenceCurveListViewModel_ = ReferenceCurveListViewModel.CreateReferenceCurveList(referenceCurveListtype);
            this.referenceCurveListViewModel_.setFromSerial(serial_referenceCurveList);
            
            FpmlSerializedCSharp.JointProbabilityTrait serial_jointProbabilityTrait = serial_ReferenceEntityInfo_para.JointProbabilityTrait_;
            string jointProbabilityTraittype = serial_jointProbabilityTrait.Excel_type_.ValueStr;
            this.jointProbabilityTraitViewModel_ = JointProbabilityTraitViewModel.CreateJointProbabilityTrait(jointProbabilityTraittype);
            this.jointProbabilityTraitViewModel_.setFromSerial(serial_jointProbabilityTrait);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

