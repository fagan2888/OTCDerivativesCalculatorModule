using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class CashFlows_resultViewModel : IXmlData
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
        
        public CashFlows_resultViewModel() { }
        
        #region CashFlow_resultViewModel_
        private ObservableCollection<CashFlow_resultViewModel> cashFlow_resultViewModel_;
        public ObservableCollection<CashFlow_resultViewModel> CashFlow_resultViewModel_
        {
            get { return this.cashFlow_resultViewModel_; }
            set
            {
                if (this.cashFlow_resultViewModel_ != value)
                {
                    this.cashFlow_resultViewModel_ = value;
                    this.NotifyPropertyChanged("CashFlow_resultViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "cashFlows_result");
                xmlWriter.WriteStartElement("cashFlows_result");
                    foreach (var item in cashFlow_resultViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new CashFlows_resultView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CashFlows_result serial_CashFlows_result = serial_Class as FpmlSerializedCSharp.CashFlows_result;
        
            List<FpmlSerializedCSharp.CashFlow_result> serial_cashFlow_result = serial_CashFlows_result.CashFlow_result_;
            this.cashFlow_resultViewModel_ = new ObservableCollection<CashFlow_resultViewModel>();
            foreach (var item in serial_cashFlow_result)
            {
                string type = item.Excel_type_.ValueStr;
                CashFlow_resultViewModel viewModel = CashFlow_resultViewModel.CreateCashFlow_result(type);
                viewModel.setFromSerial(item);
                this.cashFlow_resultViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

