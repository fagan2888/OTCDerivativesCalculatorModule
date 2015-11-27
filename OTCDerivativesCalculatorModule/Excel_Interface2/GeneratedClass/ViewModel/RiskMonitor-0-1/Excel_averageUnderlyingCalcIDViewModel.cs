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
        
        public Excel_averageUnderlyingCalcIDViewModel() { }
        
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
                xmlWriter.WriteElementString("excel_type" , "excel_averageUnderlyingCalcID");
                xmlWriter.WriteStartElement("excel_averageUnderlyingCalcID");
                    foreach (var item in excel_selectedUnderlyingViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    xmlWriter.WriteElementString("eventDate" , StringConverter.xmlDateTimeToDateString(this.eventDate_));
                    
                    xmlWriter.WriteElementString("weight" , this.weight_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_averageUnderlyingCalcIDView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingCalcID serial_Excel_underlyingCalcID = serial_Class as FpmlSerializedCSharp.Excel_underlyingCalcID;
            FpmlSerializedCSharp.Excel_averageUnderlyingCalcID serial_Excel_averageUnderlyingCalcID = serial_Excel_underlyingCalcID.Excel_averageUnderlyingCalcID_;
        
            List<FpmlSerializedCSharp.Excel_selectedUnderlying> serial_excel_selectedUnderlying = serial_Excel_averageUnderlyingCalcID.Excel_selectedUnderlying_;
            this.excel_selectedUnderlyingViewModel_ = new ObservableCollection<Excel_selectedUnderlyingViewModel>();
            foreach (var item in serial_excel_selectedUnderlying)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_selectedUnderlyingViewModel viewModel = Excel_selectedUnderlyingViewModel.CreateExcel_selectedUnderlying(type);
                viewModel.setFromSerial(item);
                this.excel_selectedUnderlyingViewModel_.Add(viewModel);
            }
            
            this.eventDate_ = StringConverter.xmlDateToDateTime(serial_Excel_averageUnderlyingCalcID.EventDate_.ValueStr);
            
            this.weightViewModel_ = new ObservableCollection<WeightViewModel>();
            foreach (var item in serial_Excel_averageUnderlyingCalcID.Weight_)
            {
                this.value_.Add(item.ValueStr);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

