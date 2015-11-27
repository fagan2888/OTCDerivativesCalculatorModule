using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class OperatorNDViewModel : IXmlData
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
        
        public OperatorNDViewModel() { }
        
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
        
        #region AdditionOperNDViewModel_
        private AdditionOperNDViewModel additionOperNDViewModel_;
        public AdditionOperNDViewModel AdditionOperNDViewModel_
        {
            get { return this.additionOperNDViewModel_; }
            set
            {
                if (this.additionOperNDViewModel_ != value)
                {
                    this.additionOperNDViewModel_ = value;
                    this.NotifyPropertyChanged("AdditionOperNDViewModel_");
                }
            }
        }
        #endregion
        
        #region MultipleOperNDViewModel_
        private MultipleOperNDViewModel multipleOperNDViewModel_;
        public MultipleOperNDViewModel MultipleOperNDViewModel_
        {
            get { return this.multipleOperNDViewModel_; }
            set
            {
                if (this.multipleOperNDViewModel_ != value)
                {
                    this.multipleOperNDViewModel_ = value;
                    this.NotifyPropertyChanged("MultipleOperNDViewModel_");
                }
            }
        }
        #endregion
        
        #region DivisionOperNDViewModel_
        private DivisionOperNDViewModel divisionOperNDViewModel_;
        public DivisionOperNDViewModel DivisionOperNDViewModel_
        {
            get { return this.divisionOperNDViewModel_; }
            set
            {
                if (this.divisionOperNDViewModel_ != value)
                {
                    this.divisionOperNDViewModel_ = value;
                    this.NotifyPropertyChanged("DivisionOperNDViewModel_");
                }
            }
        }
        #endregion
        
        #region MaximumOperNDViewModel_
        private MaximumOperNDViewModel maximumOperNDViewModel_;
        public MaximumOperNDViewModel MaximumOperNDViewModel_
        {
            get { return this.maximumOperNDViewModel_; }
            set
            {
                if (this.maximumOperNDViewModel_ != value)
                {
                    this.maximumOperNDViewModel_ = value;
                    this.NotifyPropertyChanged("MaximumOperNDViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_operatorNDType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static OperatorNDViewModel CreateOperatorND(string typeStr)
        {
            if ( typeStr == "additionOperND")
            {
                return new AdditionOperNDViewModel();
            }
            else if ( typeStr == "multipleOperND")
            {
                return new MultipleOperNDViewModel();
            }
            else if ( typeStr == "divisionOperND")
            {
                return new DivisionOperNDViewModel();
            }
            else if ( typeStr == "maximumOperND")
            {
                return new MaximumOperNDViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

