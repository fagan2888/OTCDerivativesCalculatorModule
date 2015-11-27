using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_cashFlowsResultViewModel : IXmlData
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
        
        public Excel_cashFlowsResultViewModel()
        {
            this.excel_cashFlowResultViewModel_ = new ObservableCollection<Excel_cashFlowResultViewModel>();
        }   
        
        #region Excel_cashFlowResultViewModel_
        private ObservableCollection<Excel_cashFlowResultViewModel> excel_cashFlowResultViewModel_;
        public ObservableCollection<Excel_cashFlowResultViewModel> Excel_cashFlowResultViewModel_
        {
            get { return this.excel_cashFlowResultViewModel_; }
            set
            {
                if (this.excel_cashFlowResultViewModel_ != value)
                {
                    this.excel_cashFlowResultViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_cashFlowResultViewModel_");
                }
            }
        }
        #endregion
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
                xmlWriter.WriteStartElement("excel_cashFlowsResult");
                    foreach (var item in excel_cashFlowResultViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_cashFlowsResult serial_Excel_cashFlowsResult = serial_Class as FpmlSerializedCSharp.Excel_cashFlowsResult;
        
            List<FpmlSerializedCSharp.Excel_cashFlowResult> serial_excel_cashFlowResult = serial_Excel_cashFlowsResult.Excel_cashFlowResult_;
            this.excel_cashFlowResultViewModel_ = new ObservableCollection<Excel_cashFlowResultViewModel>();
            foreach (var item in serial_excel_cashFlowResult)
            {
                Excel_cashFlowResultViewModel viewModel = new Excel_cashFlowResultViewModel();
                viewModel.setFromSerial(item);
                this.excel_cashFlowResultViewModel_.Add(viewModel);
            }
            
        }



    
    }
    
}

