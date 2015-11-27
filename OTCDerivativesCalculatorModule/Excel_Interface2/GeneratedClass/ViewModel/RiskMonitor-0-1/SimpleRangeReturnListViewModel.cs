using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class SimpleRangeReturnListViewModel : IXmlData
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
        
        public SimpleRangeReturnListViewModel() { }
        
        #region SimpleRangeReturnViewModel_
        private ObservableCollection<SimpleRangeReturnViewModel> simpleRangeReturnViewModel_;
        public ObservableCollection<SimpleRangeReturnViewModel> SimpleRangeReturnViewModel_
        {
            get { return this.simpleRangeReturnViewModel_; }
            set
            {
                if (this.simpleRangeReturnViewModel_ != value)
                {
                    this.simpleRangeReturnViewModel_ = value;
                    this.NotifyPropertyChanged("SimpleRangeReturnViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "simpleRangeReturnList");
                xmlWriter.WriteStartElement("simpleRangeReturnList");
                    foreach (var item in simpleRangeReturnViewModel_)
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
            Control v = new SimpleRangeReturnListView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.SimpleRangeReturnList serial_SimpleRangeReturnList = serial_Class as FpmlSerializedCSharp.SimpleRangeReturnList;
        
            List<FpmlSerializedCSharp.SimpleRangeReturn> serial_simpleRangeReturn = serial_SimpleRangeReturnList.SimpleRangeReturn_;
            this.simpleRangeReturnViewModel_ = new ObservableCollection<SimpleRangeReturnViewModel>();
            foreach (var item in serial_simpleRangeReturn)
            {
                string type = item.Excel_type_.ValueStr;
                SimpleRangeReturnViewModel viewModel = SimpleRangeReturnViewModel.CreateSimpleRangeReturn(type);
                viewModel.setFromSerial(item);
                this.simpleRangeReturnViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

