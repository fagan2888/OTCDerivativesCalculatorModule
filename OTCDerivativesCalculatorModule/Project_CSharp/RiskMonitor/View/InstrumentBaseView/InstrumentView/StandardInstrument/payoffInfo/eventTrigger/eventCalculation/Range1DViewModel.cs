using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class Range1DViewModel : IXmlData
    {

        #region View_
        protected Control view_;
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
        
    
        public Range1DViewModel() { }
    
        #region LowerBound_
        private string lowerBound_;
        public string LowerBound_
        {
            get { return this.lowerBound_; }
            set
            {
                if (this.lowerBound_ != value)
                {
                    this.lowerBound_ = value;
                    this.NotifyPropertyChanged("LowerBound_");
                }
            }
        }
        #endregion
        
        #region UpperBound_
        private string upperBound_;
        public string UpperBound_
        {
            get { return this.upperBound_; }
            set
            {
                if (this.upperBound_ != value)
                {
                    this.upperBound_ = value;
                    this.NotifyPropertyChanged("UpperBound_");
                }
            }
        }
        #endregion
        
        #region LowerBoundEquality_
        private string lowerBoundEquality_;
        public string LowerBoundEquality_
        {
            get { return this.lowerBoundEquality_; }
            set
            {
                if (this.lowerBoundEquality_ != value)
                {
                    this.lowerBoundEquality_ = value;
                    this.NotifyPropertyChanged("LowerBoundEquality_");
                }
            }
        }
        #endregion
        
        #region UpperBoundEquality_
        private string upperBoundEquality_;
        public string UpperBoundEquality_
        {
            get { return this.upperBoundEquality_; }
            set
            {
                if (this.upperBoundEquality_ != value)
                {
                    this.upperBoundEquality_ = value;
                    this.NotifyPropertyChanged("UpperBoundEquality_");
                }
            }
        }
        #endregion
        
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("range1D");
                xmlWriter.WriteElementString("lowerBound" , this.lowerBound_);
                    
                xmlWriter.WriteElementString("upperBound" , this.upperBound_);
                    
                xmlWriter.WriteElementString("lowerBoundEquality" , this.lowerBoundEquality_);
                    
                xmlWriter.WriteElementString("upperBoundEquality" , this.upperBoundEquality_);
                    
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Range1D serial_Range1D = serial_Class as FpmlSerializedCSharp.Range1D;
        
            this.lowerBound_ = serial_Range1D.LowerBound_.ValueStr;
            
            this.upperBound_ = serial_Range1D.UpperBound_.ValueStr;
            
            this.lowerBoundEquality_ = serial_Range1D.LowerBoundEquality_.ValueStr;
            
            this.upperBoundEquality_ = serial_Range1D.UpperBoundEquality_.ValueStr;
            
           //this.view_ = new Range1DView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}

