using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class SimpleRangeEventListViewModel : IXmlData
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
        
        public SimpleRangeEventListViewModel() { }
        
        #region SimpleRangeEventCalViewModel_
        private ObservableCollection<SimpleRangeEventCalViewModel> simpleRangeEventCalViewModel_;
        public ObservableCollection<SimpleRangeEventCalViewModel> SimpleRangeEventCalViewModel_
        {
            get { return this.simpleRangeEventCalViewModel_; }
            set
            {
                if (this.simpleRangeEventCalViewModel_ != value)
                {
                    this.simpleRangeEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("SimpleRangeEventCalViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "simpleRangeEventList");
                xmlWriter.WriteStartElement("simpleRangeEventList");
                    foreach (var item in simpleRangeEventCalViewModel_)
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
            Control v = new SimpleRangeEventListView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.SimpleRangeEventList serial_SimpleRangeEventList = serial_Class as FpmlSerializedCSharp.SimpleRangeEventList;
        
            List<FpmlSerializedCSharp.SimpleRangeEventCal> serial_simpleRangeEventCal = serial_SimpleRangeEventList.SimpleRangeEventCal_;
            this.simpleRangeEventCalViewModel_ = new ObservableCollection<SimpleRangeEventCalViewModel>();
            foreach (var item in serial_simpleRangeEventCal)
            {
                string type = item.Excel_type_.ValueStr;
                SimpleRangeEventCalViewModel viewModel = SimpleRangeEventCalViewModel.CreateSimpleRangeEventCal(type);
                viewModel.setFromSerial(item);
                this.simpleRangeEventCalViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

