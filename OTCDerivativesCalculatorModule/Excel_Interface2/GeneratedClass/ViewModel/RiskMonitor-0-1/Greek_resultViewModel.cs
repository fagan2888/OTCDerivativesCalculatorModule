using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Greek_resultViewModel : IXmlData
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
        
        public Greek_resultViewModel() { }
        
        #region Greek_underlyingViewModel_
        private ObservableCollection<Greek_underlyingViewModel> greek_underlyingViewModel_;
        public ObservableCollection<Greek_underlyingViewModel> Greek_underlyingViewModel_
        {
            get { return this.greek_underlyingViewModel_; }
            set
            {
                if (this.greek_underlyingViewModel_ != value)
                {
                    this.greek_underlyingViewModel_ = value;
                    this.NotifyPropertyChanged("Greek_underlyingViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "greek_result");
                xmlWriter.WriteStartElement("greek_result");
                    foreach (var item in greek_underlyingViewModel_)
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
            Control v = new Greek_resultView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Greek_result serial_Greek_result = serial_Class as FpmlSerializedCSharp.Greek_result;
        
            List<FpmlSerializedCSharp.Greek_underlying> serial_greek_underlying = serial_Greek_result.Greek_underlying_;
            this.greek_underlyingViewModel_ = new ObservableCollection<Greek_underlyingViewModel>();
            foreach (var item in serial_greek_underlying)
            {
                string type = item.Excel_type_.ValueStr;
                Greek_underlyingViewModel viewModel = Greek_underlyingViewModel.CreateGreek_underlying(type);
                viewModel.setFromSerial(item);
                this.greek_underlyingViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

