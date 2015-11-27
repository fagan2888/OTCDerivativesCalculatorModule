using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class NthDefaultTraitViewModel : JointProbabilityTraitViewModel
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
        
        public NthDefaultTraitViewModel() { }
        
        #region Type_
        private string type_;
        public string Type_
        {
            get { return this.type_; }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                    this.NotifyPropertyChanged("Type_");
                }
            }
        }
        #endregion
        
        #region Nth_
        private string nth_;
        public string Nth_
        {
            get { return this.nth_; }
            set
            {
                if (this.nth_ != value)
                {
                    this.nth_ = value;
                    this.NotifyPropertyChanged("Nth_");
                }
            }
        }
        #endregion
        
        #region Correlation_
        private string correlation_;
        public string Correlation_
        {
            get { return this.correlation_; }
            set
            {
                if (this.correlation_ != value)
                {
                    this.correlation_ = value;
                    this.NotifyPropertyChanged("Correlation_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("jointProbabilityTrait");
                xmlWriter.WriteElementString("type" , "nthDefaultTrait");
                xmlWriter.WriteStartElement("nthDefaultTrait");
                    xmlWriter.WriteElementString("type" , this.type_);
                    
                    xmlWriter.WriteElementString("nth" , this.nth_);
                    
                    xmlWriter.WriteElementString("correlation" , this.correlation_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new NthDefaultTraitView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.JointProbabilityTrait serial_JointProbabilityTrait = serial_Class as FpmlSerializedCSharp.JointProbabilityTrait;
            FpmlSerializedCSharp.NthDefaultTrait serial_NthDefaultTrait = serial_JointProbabilityTrait.NthDefaultTrait_;
        
            this.type_ = serial_NthDefaultTrait.Type_.ValueStr;
            
            this.nth_ = serial_NthDefaultTrait.Nth_.ValueStr;
            
            this.correlation_ = serial_NthDefaultTrait.Correlation_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

