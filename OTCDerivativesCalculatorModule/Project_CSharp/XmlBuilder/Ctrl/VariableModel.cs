using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.ComponentModel;
using System.Collections.ObjectModel;
using XmlBuilder.Views.StructuredProduct.ViewModel;

namespace XmlBuilder.Ctrl
{
    public class VariableModel : IXmlBuild
    {
        public VariableModel(FpmlSerializedCSharp.VariableValue serial_vv)
        {
            this.serial_vv_ = serial_vv;
            this.buildFromSerialClass();
        }

        private void buildFromSerialClass() 
        {
            if (serial_vv_.IndexRef_ != null || serial_vv_.indexRefIDRef_ != null)
            {

                this.type_ = "IndexRef";
                this.value_ = serial_vv_.IndexRef_.ID_;
                this.fixingDate_ = serial_vv_.IndexRef_.EventDateRef_.DateSingle_.StringValue();
                
                //우선 Day만
                this.fixingAdjustDays_ = serial_vv_.IndexRef_.FixingDays_.Days_.StringValue() + " D";

            }
            else if (serial_vv_.IndexTimeRef_ != null || serial_vv_.indexTimeRefIDRef_ != null)
            {

                this.type_ = "IndexTimeRef";
                this.value_ = serial_vv_.IndexTimeRef_.ID_;
                this.fixingDate_ = "-";

                //우선 Day만
                this.fixingAdjustDays_ = serial_vv_.IndexTimeRef_.FixingDays_.Days_.StringValue() + " D";
            }
            else if (serial_vv_.SymbolName_ != null || serial_vv_.symbolNameIDRef_ != null)
            {

                this.type_ = "Sym";
                this.value_ = serial_vv_.SymbolName_.StringValue();
                this.fixingDate_ = "-";
                this.fixingAdjustDays_ = "-";
            }
            else if (serial_vv_.ConstValue_ != null || serial_vv_.constValueIDRef_ != null)
            {

                this.type_ = "Const";
                this.value_ = serial_vv_.ConstValue_.StringValue();
                this.fixingDate_ = "-";
                this.fixingAdjustDays_ = "-";
            }
            else
            {
                throw new NotImplementedException();
            }
            
        }

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

        #region Vaule_
        private string value_;
        public string Vaule_
        {
            get { return this.value_; }
            set
            {
                if (this.value_ != value)
                {
                    this.value_ = value;
                    this.NotifyPropertyChanged("Vaule_");
                }
            }
        }
        #endregion

        #region FixingDate_
        private string fixingDate_;
        public string FixingDate_
        {
            get { return this.fixingDate_; }
            set
            {
                if (this.fixingDate_ != value)
                {
                    this.fixingDate_ = value;
                    this.NotifyPropertyChanged("FixingDate_");
                }
            }
        }
        #endregion

        #region FixingAdjustDays_
        private string fixingAdjustDays_;
        public string FixingAdjustDays_
        {
            get { return this.fixingAdjustDays_; }
            set
            {
                if (this.fixingAdjustDays_ != value)
                {
                    this.fixingAdjustDays_ = value;
                    this.NotifyPropertyChanged("FixingAdjustDays_");
                }
            }
        }
        #endregion

        #region FixedValue_
        private string fixedValue_;
        public string FixedValue_
        {
            get { return this.fixedValue_; }
            set
            {
                if (this.fixedValue_ != value)
                {
                    this.fixedValue_ = value;
                    this.NotifyPropertyChanged("FixedValue_");
                }
            }
        }
        #endregion

        #region Description_
        private string description;
        public string Description_
        {
            get { return this.description; }
            set
            {
                if (this.description != value)
                {
                    this.description = value;
                    this.NotifyPropertyChanged("Description_");
                }
            }
        }
        #endregion

        private FpmlSerializedCSharp.VariableValue serial_vv_;

        public string SymbolName_;

        public void buildXml(XmlWriter xmlWriter)
        {

            if (type_ == "IndexRef") 
            {
                xmlWriter.WriteStartElement("underlyingIndexRef");
                    xmlWriter.WriteAttributeString("href", this.value_);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("eventDateRef");
                    xmlWriter.WriteAttributeString("href", this.fixingDate_);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("fixingDays");
                    xmlWriter.WriteStartElement("days");
                        xmlWriter.WriteValue(this.fixingAdjustDays_);
                    xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();

            }
            else if (type_ == "IndexTimeRef")
            {
                xmlWriter.WriteStartElement("underlyingIndexRef");
                    xmlWriter.WriteAttributeString("href", this.value_);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("fixingDays");
                    xmlWriter.WriteStartElement("days");
                        xmlWriter.WriteValue(this.fixingAdjustDays_);
                    xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            }
            else if (type_ == "Sym") 
            {
                xmlWriter.WriteStartElement("symbolName");
                    xmlWriter.WriteValue(this.value_);
                xmlWriter.WriteEndElement();
            }
            else if (type_ == "Const")
            {
                xmlWriter.WriteStartElement("constValue");
                    xmlWriter.WriteValue(this.value_);
                xmlWriter.WriteEndElement();
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
