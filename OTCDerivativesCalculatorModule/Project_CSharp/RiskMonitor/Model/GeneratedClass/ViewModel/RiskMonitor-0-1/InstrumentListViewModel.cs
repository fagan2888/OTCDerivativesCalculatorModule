using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class InstrumentListViewModel : IXmlData
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
        
        public InstrumentListViewModel() { }
        
        #region InstHirachyInfoViewModel_
        private ObservableCollection<InstHirachyInfoViewModel> instHirachyInfoViewModel_;
        public ObservableCollection<InstHirachyInfoViewModel> InstHirachyInfoViewModel_
        {
            get { return this.instHirachyInfoViewModel_; }
            set
            {
                if (this.instHirachyInfoViewModel_ != value)
                {
                    this.instHirachyInfoViewModel_ = value;
                    this.NotifyPropertyChanged("InstHirachyInfoViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "instrumentList");
                xmlWriter.WriteStartElement("instrumentList");
                    foreach (var item in instHirachyInfoViewModel_)
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
            Control v = new InstrumentListView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.InstrumentList serial_InstrumentList = serial_Class as FpmlSerializedCSharp.InstrumentList;
        
            List<FpmlSerializedCSharp.InstHirachyInfo> serial_instHirachyInfo = serial_InstrumentList.InstHirachyInfo_;
            this.instHirachyInfoViewModel_ = new ObservableCollection<InstHirachyInfoViewModel>();
            foreach (var item in serial_instHirachyInfo)
            {
                string type = item.Excel_type_.ValueStr;
                InstHirachyInfoViewModel viewModel = InstHirachyInfoViewModel.CreateInstHirachyInfo(type);
                viewModel.setFromSerial(item);
                this.instHirachyInfoViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

