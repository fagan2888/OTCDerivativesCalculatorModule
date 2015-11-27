using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_choiceUnderlyingCalcIDViewModel : Excel_underlyingCalcIDViewModel
    {
        public Excel_choiceUnderlyingCalcIDViewModel() 
        {
            this.Excel_type_ = "excel_choiceUnderlyingCalcID";
        }

        #region AverageDays_
        private string averageDays_;
        public string AverageDays_
        {
            get { return this.averageDays_; }
            set
            {
                if (this.averageDays_ != value)
                {
                    this.averageDays_ = value;
                    this.NotifyPropertyChanged("AverageDays_");
                }
            }
        }
        #endregion
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_underlyingCalcID");

                if (this.attributeValue_ != "")
                {
                    xmlWriter.WriteAttributeString("usingType", this.attributeValue_);
                }

                xmlWriter.WriteElementString("excel_type" , "excel_choiceUnderlyingCalcID");
                
                xmlWriter.WriteStartElement("excel_choiceUnderlyingCalcID");

                    xmlWriter.WriteElementString("eventDate", this.eventDate_.ToString(StringFormat.XmlDateFormat_));
                    foreach (var item in this.excel_selectedUnderlyingViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    xmlWriter.WriteElementString("averageDays" , this.averageDays_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingCalcID serial_Excel_underlyingCalcID = serial_Class as FpmlSerializedCSharp.Excel_underlyingCalcID;
            FpmlSerializedCSharp.Excel_choiceUnderlyingCalcID serial_Excel_choiceUnderlyingCalcID = serial_Excel_underlyingCalcID.Excel_choiceUnderlyingCalcID_;

            List<FpmlSerializedCSharp.Excel_selectedUnderlying> serial_excel_selectedUnderlying = serial_Excel_choiceUnderlyingCalcID.Excel_selectedUnderlying_;
            this.excel_selectedUnderlyingViewModel_ = new ObservableCollection<Excel_selectedUnderlyingViewModel>();
            foreach (var item in serial_excel_selectedUnderlying)
            {
                Excel_selectedUnderlyingViewModel viewModel = new Excel_selectedUnderlyingViewModel();
                viewModel.setFromSerial(item);
                this.excel_selectedUnderlyingViewModel_.Add(viewModel);
            }

            this.eventDate_ = serial_Excel_choiceUnderlyingCalcID.EventDate_.DateTimeValue();
            this.averageDays_ = serial_Excel_choiceUnderlyingCalcID.AverageDays_.ValueStr;
            
        }

        public override Control view()
        {
            Control v = new Excel_choiceUnderlyingCalcIDView();

            v.DataContext = this;

            return v;
        }

        public override void descriptionUpdate()
        {
            string des = "chosen ";

            foreach (var item in this.excel_selectedUnderlyingViewModel_)
            {
                des = des + item.NameTrans_.trans() + " ";
            }

            if (Convert.ToInt32(this.averageDays_) > 1)
            {
                des = des + " AverageDays : " + this.averageDays_;
            }

            this.Description_ = des;
        }

        public override Excel_underlyingCalcIDViewModel Clone()
        {
            Excel_choiceUnderlyingCalcIDViewModel clone = new Excel_choiceUnderlyingCalcIDViewModel();

            foreach (var item in this.excel_selectedUnderlyingViewModel_)
            {
                clone.excel_selectedUnderlyingViewModel_ = new ObservableCollection<Excel_selectedUnderlyingViewModel>();
                clone.excel_selectedUnderlyingViewModel_.Add(item.Clone());
            }

            clone.EventDate_ = this.eventDate_;
            clone.AverageDays_ = this.averageDays_;

            return clone;
            
        }

        //public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        //{
        //    throw new NotImplementedException();
        //}

        public override void defaultSetting()
        {
            this.averageDays_ = "1";
        }
    }
    
}

