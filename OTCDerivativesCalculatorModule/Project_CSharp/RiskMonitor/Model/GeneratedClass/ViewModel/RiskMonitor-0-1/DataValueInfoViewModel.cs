using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class DataValueInfoViewModel : IXmlData
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
        
        public DataValueInfoViewModel() { }
        
        #region DataValueViewModel_
        private ObservableCollection<DataValueViewModel> dataValueViewModel_;
        public ObservableCollection<DataValueViewModel> DataValueViewModel_
        {
            get { return this.dataValueViewModel_; }
            set
            {
                if (this.dataValueViewModel_ != value)
                {
                    this.dataValueViewModel_ = value;
                    this.NotifyPropertyChanged("DataValueViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "dataValueInfo");
                xmlWriter.WriteStartElement("dataValueInfo");
                    foreach (var item in dataValueViewModel_)
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
            Control v = new DataValueInfoView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.DataValueInfo serial_DataValueInfo = serial_Class as FpmlSerializedCSharp.DataValueInfo;
        
            List<FpmlSerializedCSharp.DataValue> serial_dataValue = serial_DataValueInfo.DataValue_;
            this.dataValueViewModel_ = new ObservableCollection<DataValueViewModel>();
            foreach (var item in serial_dataValue)
            {
                string type = item.Excel_type_.ValueStr;
                DataValueViewModel viewModel = DataValueViewModel.CreateDataValue(type);
                viewModel.setFromSerial(item);
                this.dataValueViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

