using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class RangeCondition1DViewModel : IXmlData
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
        
        public RangeCondition1DViewModel() { }
        
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
        
        #region ConstValue_
        private string constValue_;
        public string ConstValue_
        {
            get { return this.constValue_; }
            set
            {
                if (this.constValue_ != value)
                {
                    this.constValue_ = value;
                    this.NotifyPropertyChanged("ConstValue_");
                }
            }
        }
        #endregion
        
        #region RefName_
        private string refName_;
        public string RefName_
        {
            get { return this.refName_; }
            set
            {
                if (this.refName_ != value)
                {
                    this.refName_ = value;
                    this.NotifyPropertyChanged("RefName_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "rangeCondition1D");
                xmlWriter.WriteStartElement("rangeCondition1D");
                    range1DViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("constValue" , this.constValue_);
                    
                    xmlWriter.WriteElementString("refName" , this.refName_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new RangeCondition1DView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.RangeCondition1D serial_RangeCondition1D = serial_Class as FpmlSerializedCSharp.RangeCondition1D;
        
            FpmlSerializedCSharp.Range1D serial_range1D = serial_RangeCondition1D.Range1D_;
            string range1Dtype = serial_range1D.Excel_type_.ValueStr;
            this.range1DViewModel_ = Range1DViewModel.CreateRange1D(range1Dtype);
            this.range1DViewModel_.setFromSerial(serial_range1D);
            
            this.constValue_ = serial_RangeCondition1D.ConstValue_.ValueStr;
            
            this.refName_ = serial_RangeCondition1D.RefName_.ValueStr;
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

