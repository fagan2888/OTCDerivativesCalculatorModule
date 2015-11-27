using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_discountCurve_paraViewModel : IXmlData , INotifyPropertyChanged
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
    
        public Excel_discountCurve_paraViewModel() 
        {
            this.excel_yieldCurveViewModel_ = new ObservableCollection<Excel_yieldCurveViewModel>();

        }

        #region Excel_yieldCurveViewModel_
        private ObservableCollection<Excel_yieldCurveViewModel> excel_yieldCurveViewModel_;
        public ObservableCollection<Excel_yieldCurveViewModel> Excel_yieldCurveViewModel_
        {
            get { return this.excel_yieldCurveViewModel_; }
            set
            {
                if (this.excel_yieldCurveViewModel_ != value)
                {
                    this.excel_yieldCurveViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_yieldCurveViewModel_");
                }
            }
        }
        #endregion
    
        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_discountCurve_para");

            foreach (var item in excel_yieldCurveViewModel_)
            {
                item.buildXml(xmlWriter);
            }
                    
            xmlWriter.WriteEndElement();
        }

        public void buildPricingXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("discountCurve_para");

                foreach (var item in excel_yieldCurveViewModel_)
                {
                    item.buildXml(xmlWriter);
                }

            xmlWriter.WriteEndElement();
        }
        
        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_discountCurve_para serial_Excel_discountCurve_para = serial_Class as FpmlSerializedCSharp.Excel_discountCurve_para;

            List<FpmlSerializedCSharp.Excel_yieldCurve> serial_excel_yieldCurve = serial_Excel_discountCurve_para.Excel_yieldCurve_;
            this.excel_yieldCurveViewModel_ = new ObservableCollection<Excel_yieldCurveViewModel>();
            foreach (var item in serial_excel_yieldCurve)
            {
                //string type = item.Type_.ValueStr;
                Excel_yieldCurveViewModel viewModel = new Excel_yieldCurveViewModel();
                viewModel.setFromSerial(item);
                this.excel_yieldCurveViewModel_.Add(viewModel);
            }
            
        }

        public System.Windows.Controls.Control view()
        {
            Control v = new Excel_discountCurve_paraView();

            v.DataContext = this;

            return v;
        }

        public Excel_yieldCurveViewModel discountYieldCurve(string currencyStr)
        {
            Excel_yieldCurveViewModel e_ycvm = new Excel_yieldCurveViewModel();

            foreach (var item in this.excel_yieldCurveViewModel_)
            {
                if (item.Currency_ == currencyStr)
                {
                    e_ycvm = item;
                }
            }

            if (e_ycvm.Code_ == "")
            {
                OutputLogViewModel.addResult("unknown currency");
            }

            return e_ycvm;

        }

        public void updateDiscountCurve(List<CurrencyViewModel> currencyList)
        {


        }

        public void loadMarketData(DateTime referenceDate)
        {
            foreach (var item in this.excel_yieldCurveViewModel_)
            {
                item.loadMarketData(referenceDate);
            }
        }

        public void buildParaSetting(ParameterSettingManager paraSettingManager)
        {
            this.excel_yieldCurveViewModel_.Clear();

            Excel_interfaceViewModel e_ivm = paraSettingManager.Excel_InstrumentViewModel_.Excel_interfaceViewModel_;

            List<CurrencyViewModel> currencyList = e_ivm.currencyList();

            List<CurrencyViewModel> removedCurrencyList = new List<CurrencyViewModel>();

            foreach (var item in currencyList)
            {
                bool exist = false;

                foreach (var item2 in removedCurrencyList)
	            {
                    if (item2.CurrencyCode_ == item.CurrencyCode_)
                    {
                        exist = true;
                        break;
                    }
	            }

                if (!exist)
                {
                    removedCurrencyList.Add(item);
                }

            }

            foreach (var item in removedCurrencyList)
            {
                Excel_yieldCurveViewModel e_ycvm =
                    paraSettingManager.DiscountCurveParaSetting_.discountCurve(paraSettingManager.ReferenceDate_, item);

                this.excel_yieldCurveViewModel_.Add(e_ycvm);
            }

        }

        public int hasCurrencysYieldCurve(string currency)
        {
            for (int i = 0; i < this.excel_yieldCurveViewModel_.Count; i++)
            {
                if (this.excel_yieldCurveViewModel_[i].Currency_ == currency)
                {
                    return i;
                }
            }

            return -1;
        }
    }
    
}

