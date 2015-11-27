using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_generalViewModel : Excel_interfaceViewModel
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
        
        public Excel_generalViewModel() { }
        
        #region Excel_issueInfoViewModel_
        private Excel_issueInfoViewModel excel_issueInfoViewModel_;
        public Excel_issueInfoViewModel Excel_issueInfoViewModel_
        {
            get { return this.excel_issueInfoViewModel_; }
            set
            {
                if (this.excel_issueInfoViewModel_ != value)
                {
                    this.excel_issueInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_issueInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region GeneralScheduleViewModel_
        private ObservableCollection<GeneralScheduleViewModel> generalScheduleViewModel_;
        public ObservableCollection<GeneralScheduleViewModel> GeneralScheduleViewModel_
        {
            get { return this.generalScheduleViewModel_; }
            set
            {
                if (this.generalScheduleViewModel_ != value)
                {
                    this.generalScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("GeneralScheduleViewModel_");
                }
            }
        }
        #endregion
        
        #region GeneralTerminationEventViewModel_
        private ObservableCollection<GeneralTerminationEventViewModel> generalTerminationEventViewModel_;
        public ObservableCollection<GeneralTerminationEventViewModel> GeneralTerminationEventViewModel_
        {
            get { return this.generalTerminationEventViewModel_; }
            set
            {
                if (this.generalTerminationEventViewModel_ != value)
                {
                    this.generalTerminationEventViewModel_ = value;
                    this.NotifyPropertyChanged("GeneralTerminationEventViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_interface");
                xmlWriter.WriteElementString("excel_type" , "excel_general");
                xmlWriter.WriteStartElement("excel_general");
                    excel_issueInfoViewModel_.buildXml(xmlWriter);
                    
                    foreach (var item in generalScheduleViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    foreach (var item in generalTerminationEventViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_generalView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
            FpmlSerializedCSharp.Excel_general serial_Excel_general = serial_Excel_interface.Excel_general_;
        
            FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_general.Excel_issueInfo_;
            string excel_issueInfotype = serial_excel_issueInfo.Excel_type_.ValueStr;
            this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);
            
            List<FpmlSerializedCSharp.GeneralSchedule> serial_generalSchedule = serial_Excel_general.GeneralSchedule_;
            this.generalScheduleViewModel_ = new ObservableCollection<GeneralScheduleViewModel>();
            foreach (var item in serial_generalSchedule)
            {
                string type = item.Excel_type_.ValueStr;
                GeneralScheduleViewModel viewModel = GeneralScheduleViewModel.CreateGeneralSchedule(type);
                viewModel.setFromSerial(item);
                this.generalScheduleViewModel_.Add(viewModel);
            }
            
            List<FpmlSerializedCSharp.GeneralTerminationEvent> serial_generalTerminationEvent = serial_Excel_general.GeneralTerminationEvent_;
            this.generalTerminationEventViewModel_ = new ObservableCollection<GeneralTerminationEventViewModel>();
            foreach (var item in serial_generalTerminationEvent)
            {
                string type = item.Excel_type_.ValueStr;
                GeneralTerminationEventViewModel viewModel = GeneralTerminationEventViewModel.CreateGeneralTerminationEvent(type);
                viewModel.setFromSerial(item);
                this.generalTerminationEventViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}

