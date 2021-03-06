using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class VariableInfoViewModel : IXmlData
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
        
        public VariableInfoViewModel() { }
        
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
        
        #region NullVariableInfoViewModel_
        private NullVariableInfoViewModel nullVariableInfoViewModel_;
        public NullVariableInfoViewModel NullVariableInfoViewModel_
        {
            get { return this.nullVariableInfoViewModel_; }
            set
            {
                if (this.nullVariableInfoViewModel_ != value)
                {
                    this.nullVariableInfoViewModel_ = value;
                    this.NotifyPropertyChanged("NullVariableInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region OverWriteVariableInfoViewModel_
        private OverWriteVariableInfoViewModel overWriteVariableInfoViewModel_;
        public OverWriteVariableInfoViewModel OverWriteVariableInfoViewModel_
        {
            get { return this.overWriteVariableInfoViewModel_; }
            set
            {
                if (this.overWriteVariableInfoViewModel_ != value)
                {
                    this.overWriteVariableInfoViewModel_ = value;
                    this.NotifyPropertyChanged("OverWriteVariableInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region AdditionVariableInfoViewModel_
        private AdditionVariableInfoViewModel additionVariableInfoViewModel_;
        public AdditionVariableInfoViewModel AdditionVariableInfoViewModel_
        {
            get { return this.additionVariableInfoViewModel_; }
            set
            {
                if (this.additionVariableInfoViewModel_ != value)
                {
                    this.additionVariableInfoViewModel_ = value;
                    this.NotifyPropertyChanged("AdditionVariableInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region PreDefinedVariableInfoViewModel_
        private PreDefinedVariableInfoViewModel preDefinedVariableInfoViewModel_;
        public PreDefinedVariableInfoViewModel PreDefinedVariableInfoViewModel_
        {
            get { return this.preDefinedVariableInfoViewModel_; }
            set
            {
                if (this.preDefinedVariableInfoViewModel_ != value)
                {
                    this.preDefinedVariableInfoViewModel_ = value;
                    this.NotifyPropertyChanged("PreDefinedVariableInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region DefinedVariableInfoViewModel_
        private DefinedVariableInfoViewModel definedVariableInfoViewModel_;
        public DefinedVariableInfoViewModel DefinedVariableInfoViewModel_
        {
            get { return this.definedVariableInfoViewModel_; }
            set
            {
                if (this.definedVariableInfoViewModel_ != value)
                {
                    this.definedVariableInfoViewModel_ = value;
                    this.NotifyPropertyChanged("DefinedVariableInfoViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_variableInfoType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static VariableInfoViewModel CreateVariableInfo(string typeStr)
        {
            if ( typeStr == "nullVariableInfo")
            {
                return new NullVariableInfoViewModel();
            }
            else if ( typeStr == "overWriteVariableInfo")
            {
                return new OverWriteVariableInfoViewModel();
            }
            else if ( typeStr == "additionVariableInfo")
            {
                return new AdditionVariableInfoViewModel();
            }
            else if ( typeStr == "preDefinedVariableInfo")
            {
                return new PreDefinedVariableInfoViewModel();
            }
            else if ( typeStr == "definedVariableInfo")
            {
                return new DefinedVariableInfoViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

