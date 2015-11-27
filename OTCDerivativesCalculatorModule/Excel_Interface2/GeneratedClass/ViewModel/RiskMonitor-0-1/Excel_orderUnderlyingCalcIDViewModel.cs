using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_orderUnderlyingCalcIDViewModel : Excel_underlyingCalcIDViewModel
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
        
        public Excel_orderUnderlyingCalcIDViewModel() { }
        
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
        
        #region Nth_
        private string nth_;
        public string Nth_
        {
            get { return this.nth_; }
            set
            {
                if (this.nth_ != value)
                {
                    this.nth_ = value;
                    this.NotifyPropertyChanged("Nth_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_underlyingCalcID");
                xmlWriter.WriteElementString("excel_type" , "excel_orderUnderlyingCalcID");
                xmlWriter.WriteStartElement("excel_orderUnderlyingCalcID");
                    foreach (var item in excel_selectedUnderlyingViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    xmlWriter.WriteElementString("eventDate" , StringConverter.xmlDateTimeToDateString(this.eventDate_));
                    
                    xmlWriter.WriteElementString("nth" , this.nth_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_orderUnderlyingCalcIDView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingCalcID serial_Excel_underlyingCalcID = serial_Class as FpmlSerializedCSharp.Excel_underlyingCalcID;
            FpmlSerializedCSharp.Excel_orderUnderlyingCalcID serial_Excel_orderUnderlyingCalcID = serial_Excel_underlyingCalcID.Excel_orderUnderlyingCalcID_;
        
            List<FpmlSerializedCSharp.Excel_selectedUnderlying> serial_excel_selectedUnderlying = serial_Excel_orderUnderlyingCalcID.Excel_selectedUnderlying_;
            this.excel_selectedUnderlyingViewModel_ = new ObservableCollection<Excel_selectedUnderlyingViewModel>();
            foreach (var item in serial_excel_selectedUnderlying)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_selectedUnderlyingViewModel viewModel = Excel_selectedUnderlyingViewModel.CreateExcel_selectedUnderlying(type);
                viewModel.setFromSerial(item);
                this.excel_selectedUnderlyingViewModel_.Add(viewModel);
            }
            
            this.eventDate_ = StringConverter.xmlDateToDateTime(serial_Excel_orderUnderlyingCalcID.EventDate_.ValueStr);
            
            this.nth_ = serial_Excel_orderUnderlyingCalcID.Nth_.ValueStr;
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

