using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_averageUnderlyingCalcIDViewModel : Excel_underlyingCalcIDViewModel
    {
    
        public Excel_averageUnderlyingCalcIDViewModel() 
        {
            this.Excel_type_ = "excel_averageUnderlyingCalcID";
        }

        #region Weight_
        private ObservableCollection<string> weight_;
        public ObservableCollection<string> Weight_
        {
            get { return this.weight_; }
            set
            {
                if (this.weight_ != value)
                {
                    this.weight_ = value;
                    this.NotifyPropertyChanged("Weight_");
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

                xmlWriter.WriteElementString("excel_type" , "excel_averageUnderlyingCalcID");
                xmlWriter.WriteStartElement("excel_averageUnderlyingCalcID");

                    xmlWriter.WriteElementString("eventDate", this.eventDate_.ToString(StringFormat.XmlDateFormat_));
                    foreach (var item in this.excel_selectedUnderlyingViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }    

                    foreach (var item in this.weight_)
                    {
                        xmlWriter.WriteElementString("weight", item);
                    }
                    
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
            FpmlSerializedCSharp.Excel_averageUnderlyingCalcID serial_Excel_averageUnderlyingCalcID = serial_Excel_underlyingCalcID.Excel_averageUnderlyingCalcID_;

            List<FpmlSerializedCSharp.Excel_selectedUnderlying> serial_excel_selectedUnderlying = serial_Excel_averageUnderlyingCalcID.Excel_selectedUnderlying_;
            this.excel_selectedUnderlyingViewModel_ = new ObservableCollection<Excel_selectedUnderlyingViewModel>();
            foreach (var item in serial_excel_selectedUnderlying)
            {
                Excel_selectedUnderlyingViewModel viewModel = new Excel_selectedUnderlyingViewModel();
                viewModel.setFromSerial(item);
                this.excel_selectedUnderlyingViewModel_.Add(viewModel);
            }

            this.eventDate_ = serial_Excel_averageUnderlyingCalcID.EventDate_.DateTimeValue();

            this.weight_ = new ObservableCollection<string>();
            foreach (var item in serial_Excel_averageUnderlyingCalcID.Weight_)
            {
                this.weight_.Add(item.ValueStr);
            }


        }

        public override Control view()
        {
            Control v = new Excel_averageUnderlyingCalcIDView();

            v.DataContext = this;

            return v;
        }

        public override void descriptionUpdate()
        {
            string des = "Aver of ";

            if (this.defaultUnderlyingSettingFlag_)
            {
                des = des + "All";

            }
            else
            {
                foreach (var item in this.excel_selectedUnderlyingViewModel_)
                {
                    des = des + item.NameTrans_.trans() + " ";
                }
            }
            
            this.Description_ = des;
        }

        public override Excel_underlyingCalcIDViewModel Clone()
        {
            Excel_averageUnderlyingCalcIDViewModel clone = new Excel_averageUnderlyingCalcIDViewModel();

            foreach (var item in this.excel_selectedUnderlyingViewModel_)
            {
                clone.excel_selectedUnderlyingViewModel_ = new ObservableCollection<Excel_selectedUnderlyingViewModel>();
                clone.excel_selectedUnderlyingViewModel_.Add(item.Clone());
            }

            clone.EventDate_ = this.eventDate_;
            clone.Weight_ = this.weight_;

            return clone;
        }

        //public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        //{
        //    throw new NotImplementedException();
        //}

        public override void defaultSetting()
        {
            //this.weight_ = "Equ";
        }
    }
    
}

