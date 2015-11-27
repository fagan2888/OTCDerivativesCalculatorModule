using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class SingeSimpleCalViewModel : JointSimpleCalculationViewModel
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
        
        public SingeSimpleCalViewModel() { }
        
        #region PastOcc_
        private string pastOcc_;
        public string PastOcc_
        {
            get { return this.pastOcc_; }
            set
            {
                if (this.pastOcc_ != value)
                {
                    this.pastOcc_ = value;
                    this.NotifyPropertyChanged("PastOcc_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("jointSimpleCalculation");
                xmlWriter.WriteElementString("type" , "singeSimpleCal");
                xmlWriter.WriteStartElement("singeSimpleCal");
                    xmlWriter.WriteElementString("pastOcc" , this.pastOcc_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new SingeSimpleCalView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.JointSimpleCalculation serial_JointSimpleCalculation = serial_Class as FpmlSerializedCSharp.JointSimpleCalculation;
            FpmlSerializedCSharp.SingeSimpleCal serial_SingeSimpleCal = serial_JointSimpleCalculation.SingeSimpleCal_;
        
            this.pastOcc_ = serial_SingeSimpleCal.PastOcc_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}
