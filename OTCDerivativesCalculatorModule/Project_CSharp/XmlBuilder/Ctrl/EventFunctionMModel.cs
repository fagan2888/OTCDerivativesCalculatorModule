using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;
using XmlBuilder.Views.StructuredProduct.View.CheckFunctionCtrl;
using XmlBuilder.Views.StructuredProduct.ViewModel;


namespace XmlBuilder.Ctrl
{
    public class EventFunctionMModel : IXmlBuild
    {
        private FpmlSerializedCSharp.EventFunctionM serial_efm_;

        public EventFunctionMModel(FpmlSerializedCSharp.EventFunctionM serial_efm)
        {
            // TODO: Complete member initialization
            this.serial_efm_ = serial_efm;
            this.buildFromSerialClass();
        }

        private void buildFromSerialClass()
        {
            this.eventName_ = serial_efm_.Name_.StringValue();
            this.indexSymbol_ = serial_efm_.IndexSymbol_.StringValue();

            if (serial_efm_.DownEventCheck_  != null || serial_efm_.downEventCheckIDRef_ != null)
            {
                this.eventType_ = "Down";
                this.low_ = serial_efm_.DownEventCheck_.CheckValue_.StringValue();
                this.high_ = "-";
                this.tf_ = true;

            }
            else if (serial_efm_.UpEventCheck_ != null || serial_efm_.upEventCheckIDRef_ != null)
            {
                this.eventType_ = "Up";
                this.low_ = "-";
                this.high_ = serial_efm_.UpEventCheck_.CheckValue_.StringValue(); 
                this.tf_ = true;
            }
            else if (serial_efm_.UpdownEventCheck_ != null || serial_efm_.updownEventCheckIDRef_ != null)
            {
                //this.eventType_ = "Down";
                //this.low_ = serial_efm_.UpdownEventCheck_.CheckValue_.StringValue();
                //this.high_ = "-";
                //this.tf_ = true;
            }
            else if (serial_efm_.RangeEventCheck_ != null || serial_efm_.rangeEventCheckIDRef_ != null)
            {
                this.eventType_ = "Range";
                this.low_ = serial_efm_.RangeEventCheck_.LowCheckValue_.StringValue();
                this.high_ = serial_efm_.RangeEventCheck_.HighCheckValue_.StringValue();
                this.tf_ = true;
            }
            else 
            {
                throw new Exception();
            }
            

        }

        public void buildXml(XmlWriter xmlWriter)
        {

            xmlWriter.WriteStartElement("eventFunctionM");
                xmlWriter.WriteStartElement("name");
                    xmlWriter.WriteStartElement("indexSymbol");
                    xmlWriter.WriteEndElement();

                    //xmlWriter.WriteRaw(this.checkFunctionModel_.buildXml().ToString());
                    //
                    if (this.eventType_ == "Down") 
                    {
                        xmlWriter.WriteStartElement("downEventCheck");
                        
                            xmlWriter.WriteStartElement("checkValue");
                                xmlWriter.WriteValue(low_);
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteStartElement("equality");
                                xmlWriter.WriteValue(false);
                            xmlWriter.WriteEndElement();

                        xmlWriter.WriteEndElement();
                    }
                    else if (this.eventType_ == "Up")
                    {
                        xmlWriter.WriteStartElement("upEventCheck");

                            xmlWriter.WriteStartElement("checkValue");
                                xmlWriter.WriteValue(high_);
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteStartElement("equality");
                                xmlWriter.WriteValue(false);
                            xmlWriter.WriteEndElement();

                        xmlWriter.WriteEndElement();
                    }
                    else if (this.eventType_ == "UpDown")
                    {
                        xmlWriter.WriteStartElement("upDownEventCheck");

                            xmlWriter.WriteStartElement("lowCheckValue");
                                xmlWriter.WriteValue(high_);
                            xmlWriter.WriteEndElement();

                            xmlWriter.WriteStartElement("equality");
                                xmlWriter.WriteValue(false);
                            xmlWriter.WriteEndElement();

                            xmlWriter.WriteStartElement("highCheckValue");
                                xmlWriter.WriteValue(high_);
                            xmlWriter.WriteEndElement();

                            xmlWriter.WriteStartElement("equality");
                                xmlWriter.WriteValue(false);
                            xmlWriter.WriteEndElement();

                        xmlWriter.WriteEndElement();
                    }
                    else if (this.eventType_ == "Range")
                    {
                        xmlWriter.WriteStartElement("rangeEventCheck");

                            xmlWriter.WriteStartElement("lowCheckValue");
                                xmlWriter.WriteValue(high_);
                            xmlWriter.WriteEndElement();

                            xmlWriter.WriteStartElement("equality");
                                xmlWriter.WriteValue(false);
                            xmlWriter.WriteEndElement();

                            xmlWriter.WriteStartElement("highCheckValue");
                                xmlWriter.WriteValue(high_);
                            xmlWriter.WriteEndElement();

                            xmlWriter.WriteStartElement("equality");
                                xmlWriter.WriteValue(false);
                            xmlWriter.WriteEndElement();

                        xmlWriter.WriteEndElement();
                    }
                    else 
                    {
                        throw new Exception();   
                    }

                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

        }


        #region EventName_
        private string eventName_;
        public string EventName_
        {
            get { return this.eventName_; }
            set
            {
                if (this.eventName_ != value)
                {
                    this.eventName_ = value;
                    this.NotifyPropertyChanged("EventName_");
                }
            }
        }
        #endregion

        #region IndexSymbol_
        private string indexSymbol_;
        public string IndexSymbol_
        {
            get { return this.indexSymbol_; }
            set
            {
                if (this.indexSymbol_ != value)
                {
                    this.indexSymbol_ = value;
                    this.NotifyPropertyChanged("IndexSymbol_");
                }
            }
        }
        #endregion

        #region EventType_
        private string eventType_;
        public string EventType_
        {
            get { return this.eventType_; }
            set
            {
                if (this.eventType_ != value)
                {
                    this.eventType_ = value;
                    this.NotifyPropertyChanged("EventType_");
                }
            }
        }
        #endregion

        #region Low_
        private string low_;
        public string Low_
        {
            get { return this.low_; }
            set
            {
                if (this.low_ != value)
                {
                    this.low_ = value;
                    this.NotifyPropertyChanged("Low_");
                }
            }
        }
        #endregion

        #region Value_
        private string value_;
        public string Value_
        {
            get { return this.value_; }
            set
            {
                if (this.value_ != value)
                {
                    this.value_ = value;
                    this.NotifyPropertyChanged("Value_");
                }
            }
        }
        #endregion

        #region High_
        private string high_;
        public string High_
        {
            get { return this.high_; }
            set
            {
                if (this.high_ != value)
                {
                    this.high_ = value;
                    this.NotifyPropertyChanged("High_");
                }
            }
        }
        #endregion

        #region TF_
        private bool tf_;
        public bool TF_
        {
            get { return this.tf_; }
            set
            {
                if (this.tf_ != value)
                {
                    this.tf_ = value;
                    this.NotifyPropertyChanged("TF_");
                }
            }
        }
        #endregion

        #region CheckFunctionModel_
        private CheckFunctionModel checkFunctionModel_;
        public CheckFunctionModel CheckFunctionModel_
        {
            get { return this.checkFunctionModel_; }
            set
            {
                if (this.checkFunctionModel_ != value)
                {
                    this.checkFunctionModel_ = value;
                    this.NotifyPropertyChanged("CheckFunctionModel_");
                }
            }
        }
        #endregion

        public System.Windows.Controls.UserControl FEventDetailCtrl_ { get; set; }

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
