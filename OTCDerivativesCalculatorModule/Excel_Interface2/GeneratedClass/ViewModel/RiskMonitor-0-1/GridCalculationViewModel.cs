using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class GridCalculationViewModel : MessageBodyViewModel
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
        
        public GridCalculationViewModel() { }
        
        #region Inst_code_
        private string inst_code_;
        public string Inst_code_
        {
            get { return this.inst_code_; }
            set
            {
                if (this.inst_code_ != value)
                {
                    this.inst_code_ = value;
                    this.NotifyPropertyChanged("Inst_code_");
                }
            }
        }
        #endregion
        
        #region Inst_name_
        private string inst_name_;
        public string Inst_name_
        {
            get { return this.inst_name_; }
            set
            {
                if (this.inst_name_ != value)
                {
                    this.inst_name_ = value;
                    this.NotifyPropertyChanged("Inst_name_");
                }
            }
        }
        #endregion
        
        #region Inst_type_
        private string inst_type_;
        public string Inst_type_
        {
            get { return this.inst_type_; }
            set
            {
                if (this.inst_type_ != value)
                {
                    this.inst_type_ = value;
                    this.NotifyPropertyChanged("Inst_type_");
                }
            }
        }
        #endregion
        
        #region Para_refDate_
        private DateTime para_refDate_;
        public DateTime Para_refDate_
        {
            get { return this.para_refDate_; }
            set
            {
                if (this.para_refDate_ != value)
                {
                    this.para_refDate_ = value;
                    this.NotifyPropertyChanged("Para_refDate_");
                }
            }
        }
        #endregion
        
        #region ProductInnerXmlViewModel_
        private ProductInnerXmlViewModel productInnerXmlViewModel_;
        public ProductInnerXmlViewModel ProductInnerXmlViewModel_
        {
            get { return this.productInnerXmlViewModel_; }
            set
            {
                if (this.productInnerXmlViewModel_ != value)
                {
                    this.productInnerXmlViewModel_ = value;
                    this.NotifyPropertyChanged("ProductInnerXmlViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("messageBody");
                xmlWriter.WriteElementString("excel_type" , "gridCalculation");
                xmlWriter.WriteStartElement("gridCalculation");
                    xmlWriter.WriteElementString("inst_code" , this.inst_code_);
                    
                    xmlWriter.WriteElementString("inst_name" , this.inst_name_);
                    
                    xmlWriter.WriteElementString("inst_type" , this.inst_type_);
                    
                    xmlWriter.WriteElementString("para_refDate" , StringConverter.xmlDateTimeToDateString(this.para_refDate_));
                    
                    productInnerXmlViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new GridCalculationView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.MessageBody serial_MessageBody = serial_Class as FpmlSerializedCSharp.MessageBody;
            FpmlSerializedCSharp.GridCalculation serial_GridCalculation = serial_MessageBody.GridCalculation_;
        
            this.inst_code_ = serial_GridCalculation.Inst_code_.ValueStr;
            
            this.inst_name_ = serial_GridCalculation.Inst_name_.ValueStr;
            
            this.inst_type_ = serial_GridCalculation.Inst_type_.ValueStr;
            
            this.para_refDate_ = StringConverter.xmlDateToDateTime(serial_GridCalculation.Para_refDate_.ValueStr);
            
            FpmlSerializedCSharp.ProductInnerXml serial_productInnerXml = serial_GridCalculation.ProductInnerXml_;
            string productInnerXmltype = serial_productInnerXml.Excel_type_.ValueStr;
            this.productInnerXmlViewModel_ = ProductInnerXmlViewModel.CreateProductInnerXml(productInnerXmltype);
            this.productInnerXmlViewModel_.setFromSerial(serial_productInnerXml);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

