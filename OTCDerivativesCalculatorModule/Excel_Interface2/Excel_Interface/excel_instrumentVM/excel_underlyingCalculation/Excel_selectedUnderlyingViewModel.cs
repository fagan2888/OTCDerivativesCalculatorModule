using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_selectedUnderlyingViewModel : IXmlData , INotifyPropertyChanged
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
    
        public Excel_selectedUnderlyingViewModel() { }
        
        #region Code_
        private string code_;
        public string Code_
        {
            get { return this.code_; }
            set
            {
                if (this.code_ != value)
                {
                    this.code_ = value;
                    this.NotifyPropertyChanged("Code_");
                }
            }
        }
        #endregion
        
        #region NameTrans_
        private NameTrans nameTrans_;
        public NameTrans NameTrans_
        {
            get { return this.nameTrans_; }
            set
            {
                if (this.nameTrans_ != value)
                {
                    this.nameTrans_ = value;
                    this.NotifyPropertyChanged("NameTrans_");
                }
            }
        }
        #endregion
        
        #region Checked_
        private bool checked_;
        public bool Checked_
        {
            get { return this.checked_; }
            set
            {
                if (this.checked_ != value)
                {
                    this.checked_ = value;
                    this.NotifyPropertyChanged("Checked_");
                }
            }
        }
        #endregion
        
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_selectedUnderlying");

                xmlWriter.WriteElementString("code" , this.code_);
                xmlWriter.WriteElementString("name", this.nameTrans_.Value_);
                xmlWriter.WriteElementString("checked" , this.checked_.ToString());
                    
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_selectedUnderlying serial_Excel_selectedUnderlying = serial_Class as FpmlSerializedCSharp.Excel_selectedUnderlying;
        
            this.code_ = serial_Excel_selectedUnderlying.Code_.ValueStr;
            this.nameTrans_ = new NameTrans(serial_Excel_selectedUnderlying.Name_.ValueStr);
            this.checked_ = serial_Excel_selectedUnderlying.Checked_.BooleanValue();

        }

        public Excel_selectedUnderlyingViewModel Clone()
        {
            Excel_selectedUnderlyingViewModel clone = new Excel_selectedUnderlyingViewModel();

            clone.Code_ = this.code_;
            clone.NameTrans_= this.nameTrans_;
            clone.Checked_= this.checked_;

            return clone;
        }
    }
    
}

