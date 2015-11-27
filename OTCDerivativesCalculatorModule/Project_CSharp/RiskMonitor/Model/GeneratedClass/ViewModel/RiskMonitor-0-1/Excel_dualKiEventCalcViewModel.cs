using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_dualKiEventCalcViewModel : Excel_kiEventCalculationViewModel
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
        
        public Excel_dualKiEventCalcViewModel() { }
        
        #region Excel_eventCalcInfoViewModel_
        private ObservableCollection<Excel_eventCalcInfoViewModel> excel_eventCalcInfoViewModel_;
        public ObservableCollection<Excel_eventCalcInfoViewModel> Excel_eventCalcInfoViewModel_
        {
            get { return this.excel_eventCalcInfoViewModel_; }
            set
            {
                if (this.excel_eventCalcInfoViewModel_ != value)
                {
                    this.excel_eventCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_eventCalcInfoViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_kiEventCalculation");
                xmlWriter.WriteElementString("type" , "excel_dualKiEventCalc");
                xmlWriter.WriteStartElement("excel_dualKiEventCalc");
                    foreach (var item in excel_eventCalcInfoViewModel_)
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
            Control v = new Excel_dualKiEventCalcView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_kiEventCalculation serial_Excel_kiEventCalculation = serial_Class as FpmlSerializedCSharp.Excel_kiEventCalculation;
            FpmlSerializedCSharp.Excel_dualKiEventCalc serial_Excel_dualKiEventCalc = serial_Excel_kiEventCalculation.Excel_dualKiEventCalc_;
        
            List<FpmlSerializedCSharp.Excel_eventCalcInfo> serial_excel_eventCalcInfo = serial_Excel_dualKiEventCalc.Excel_eventCalcInfo_;
            this.excel_eventCalcInfoViewModel_ = new ObservableCollection<Excel_eventCalcInfoViewModel>();
            foreach (var item in serial_excel_eventCalcInfo)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_eventCalcInfoViewModel viewModel = Excel_eventCalcInfoViewModel.CreateExcel_eventCalcInfo(type);
                viewModel.setFromSerial(item);
                this.excel_eventCalcInfoViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

