using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class Operator1DViewModel : IXmlData
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
        
        public Operator1DViewModel() { }
        
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
        
        #region AdditionOper1DViewModel_
        private AdditionOper1DViewModel additionOper1DViewModel_;
        public AdditionOper1DViewModel AdditionOper1DViewModel_
        {
            get { return this.additionOper1DViewModel_; }
            set
            {
                if (this.additionOper1DViewModel_ != value)
                {
                    this.additionOper1DViewModel_ = value;
                    this.NotifyPropertyChanged("AdditionOper1DViewModel_");
                }
            }
        }
        #endregion
        
        #region MultipleOper1DViewModel_
        private MultipleOper1DViewModel multipleOper1DViewModel_;
        public MultipleOper1DViewModel MultipleOper1DViewModel_
        {
            get { return this.multipleOper1DViewModel_; }
            set
            {
                if (this.multipleOper1DViewModel_ != value)
                {
                    this.multipleOper1DViewModel_ = value;
                    this.NotifyPropertyChanged("MultipleOper1DViewModel_");
                }
            }
        }
        #endregion
        
        #region MaximumOper1DViewModel_
        private MaximumOper1DViewModel maximumOper1DViewModel_;
        public MaximumOper1DViewModel MaximumOper1DViewModel_
        {
            get { return this.maximumOper1DViewModel_; }
            set
            {
                if (this.maximumOper1DViewModel_ != value)
                {
                    this.maximumOper1DViewModel_ = value;
                    this.NotifyPropertyChanged("MaximumOper1DViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_operator1DType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static Operator1DViewModel CreateOperator1D(string typeStr)
        {
            if ( typeStr == "additionOper1D")
            {
                return new AdditionOper1DViewModel();
            }
            else if ( typeStr == "multipleOper1D")
            {
                return new MultipleOper1DViewModel();
            }
            else if ( typeStr == "maximumOper1D")
            {
                return new MaximumOper1DViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

