using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class HisoryDataViewModel : IXmlData
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
        
        public HisoryDataViewModel() { }
        
        #region MarketDataViewModel_
        private ObservableCollection<MarketDataViewModel> marketDataViewModel_;
        public ObservableCollection<MarketDataViewModel> MarketDataViewModel_
        {
            get { return this.marketDataViewModel_; }
            set
            {
                if (this.marketDataViewModel_ != value)
                {
                    this.marketDataViewModel_ = value;
                    this.NotifyPropertyChanged("MarketDataViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "hisoryData");
                xmlWriter.WriteStartElement("hisoryData");
                    foreach (var item in marketDataViewModel_)
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
            Control v = new HisoryDataView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.HisoryData serial_HisoryData = serial_Class as FpmlSerializedCSharp.HisoryData;
        
            List<FpmlSerializedCSharp.MarketData> serial_marketData = serial_HisoryData.MarketData_;
            this.marketDataViewModel_ = new ObservableCollection<MarketDataViewModel>();
            foreach (var item in serial_marketData)
            {
                string type = item.Excel_type_.ValueStr;
                MarketDataViewModel viewModel = MarketDataViewModel.CreateMarketData(type);
                viewModel.setFromSerial(item);
                this.marketDataViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

