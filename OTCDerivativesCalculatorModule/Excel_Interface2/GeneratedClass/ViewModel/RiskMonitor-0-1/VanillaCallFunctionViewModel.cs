using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class VanillaCallFunctionViewModel : OptionPayoffFunctionViewModel
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
        
        public VanillaCallFunctionViewModel() { }
        
        #region PartiRate_
        private string partiRate_;
        public string PartiRate_
        {
            get { return this.partiRate_; }
            set
            {
                if (this.partiRate_ != value)
                {
                    this.partiRate_ = value;
                    this.NotifyPropertyChanged("PartiRate_");
                }
            }
        }
        #endregion
        
        #region Strike_
        private string strike_;
        public string Strike_
        {
            get { return this.strike_; }
            set
            {
                if (this.strike_ != value)
                {
                    this.strike_ = value;
                    this.NotifyPropertyChanged("Strike_");
                }
            }
        }
        #endregion
        
        #region Spread_
        private string spread_;
        public string Spread_
        {
            get { return this.spread_; }
            set
            {
                if (this.spread_ != value)
                {
                    this.spread_ = value;
                    this.NotifyPropertyChanged("Spread_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("optionPayoffFunction");
                xmlWriter.WriteElementString("excel_type" , "vanillaCallFunction");
                xmlWriter.WriteStartElement("vanillaCallFunction");
                    xmlWriter.WriteElementString("partiRate" , this.partiRate_);
                    
                    xmlWriter.WriteElementString("strike" , this.strike_);
                    
                    xmlWriter.WriteElementString("spread" , this.spread_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new VanillaCallFunctionView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.OptionPayoffFunction serial_OptionPayoffFunction = serial_Class as FpmlSerializedCSharp.OptionPayoffFunction;
            FpmlSerializedCSharp.VanillaCallFunction serial_VanillaCallFunction = serial_OptionPayoffFunction.VanillaCallFunction_;
        
            this.partiRate_ = serial_VanillaCallFunction.PartiRate_.ValueStr;
            
            this.strike_ = serial_VanillaCallFunction.Strike_.ValueStr;
            
            this.spread_ = serial_VanillaCallFunction.Spread_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

