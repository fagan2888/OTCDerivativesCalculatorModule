using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class UnderylingInfoResultViewModel : IXmlData
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
        
        public UnderylingInfoResultViewModel() { }
        
        #region UnderylingResultViewModel_
        private ObservableCollection<UnderylingResultViewModel> underylingResultViewModel_;
        public ObservableCollection<UnderylingResultViewModel> UnderylingResultViewModel_
        {
            get { return this.underylingResultViewModel_; }
            set
            {
                if (this.underylingResultViewModel_ != value)
                {
                    this.underylingResultViewModel_ = value;
                    this.NotifyPropertyChanged("UnderylingResultViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "underylingInfoResult");
                xmlWriter.WriteStartElement("underylingInfoResult");
                    foreach (var item in underylingResultViewModel_)
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
            Control v = new UnderylingInfoResultView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.UnderylingInfoResult serial_UnderylingInfoResult = serial_Class as FpmlSerializedCSharp.UnderylingInfoResult;
        
            List<FpmlSerializedCSharp.UnderylingResult> serial_underylingResult = serial_UnderylingInfoResult.UnderylingResult_;
            this.underylingResultViewModel_ = new ObservableCollection<UnderylingResultViewModel>();
            foreach (var item in serial_underylingResult)
            {
                string type = item.Excel_type_.ValueStr;
                UnderylingResultViewModel viewModel = UnderylingResultViewModel.CreateUnderylingResult(type);
                viewModel.setFromSerial(item);
                this.underylingResultViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

