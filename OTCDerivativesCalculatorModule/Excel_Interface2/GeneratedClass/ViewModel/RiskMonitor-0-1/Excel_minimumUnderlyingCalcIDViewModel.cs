using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_minimumUnderlyingCalcIDViewModel : Excel_underlyingCalcIDViewModel
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
        
        public Excel_minimumUnderlyingCalcIDViewModel() { }
        
        #region Excel_selectedUnderlyingViewModel_
        private ObservableCollection<Excel_selectedUnderlyingViewModel> excel_selectedUnderlyingViewModel_;
        public ObservableCollection<Excel_selectedUnderlyingViewModel> Excel_selectedUnderlyingViewModel_
        {
            get { return this.excel_selectedUnderlyingViewModel_; }
            set
            {
                if (this.excel_selectedUnderlyingViewModel_ != value)
                {
                    this.excel_selectedUnderlyingViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_selectedUnderlyingViewModel_");
                }
            }
        }
        #endregion
        
        #region EventDate_
        private DateTime eventDate_;
        public DateTime EventDate_
        {
            get { return this.eventDate_; }
            set
            {
                if (this.eventDate_ != value)
                {
                    this.eventDate_ = value;
                    this.NotifyPropertyChanged("EventDate_");
                }
            }
        }
        #endregion
        
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
                xmlWriter.WriteElementString("excel_type" , "excel_minimumUnderlyingCalcID");
                xmlWriter.WriteStartElement("excel_minimumUnderlyingCalcID");
                    foreach (var item in excel_selectedUnderlyingViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    xmlWriter.WriteElementString("eventDate" , StringConverter.xmlDateTimeToDateString(this.eventDate_));
                    
                    xmlWriter.WriteElementString("averageDays" , this.averageDays_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_minimumUnderlyingCalcIDView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingCalcID serial_Excel_underlyingCalcID = serial_Class as FpmlSerializedCSharp.Excel_underlyingCalcID;
            FpmlSerializedCSharp.Excel_minimumUnderlyingCalcID serial_Excel_minimumUnderlyingCalcID = serial_Excel_underlyingCalcID.Excel_minimumUnderlyingCalcID_;
        
            List<FpmlSerializedCSharp.Excel_selectedUnderlying> serial_excel_selectedUnderlying = serial_Excel_minimumUnderlyingCalcID.Excel_selectedUnderlying_;
            this.excel_selectedUnderlyingViewModel_ = new ObservableCollection<Excel_selectedUnderlyingViewModel>();
            foreach (var item in serial_excel_selectedUnderlying)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_selectedUnderlyingViewModel viewModel = Excel_selectedUnderlyingViewModel.CreateExcel_selectedUnderlying(type);
                viewModel.setFromSerial(item);
                this.excel_selectedUnderlyingViewModel_.Add(viewModel);
            }
            
            this.eventDate_ = StringConverter.xmlDateToDateTime(serial_Excel_minimumUnderlyingCalcID.EventDate_.ValueStr);
            
            this.averageDays_ = serial_Excel_minimumUnderlyingCalcID.AverageDays_.ValueStr;
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

