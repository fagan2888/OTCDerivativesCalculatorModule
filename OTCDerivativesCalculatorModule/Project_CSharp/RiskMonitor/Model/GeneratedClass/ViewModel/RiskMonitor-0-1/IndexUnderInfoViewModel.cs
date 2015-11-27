using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class IndexUnderInfoViewModel : IXmlData
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
        
        public IndexUnderInfoViewModel() { }
        
        #region IndexViewModel_
        private ObservableCollection<IndexViewModel> indexViewModel_;
        public ObservableCollection<IndexViewModel> IndexViewModel_
        {
            get { return this.indexViewModel_; }
            set
            {
                if (this.indexViewModel_ != value)
                {
                    this.indexViewModel_ = value;
                    this.NotifyPropertyChanged("IndexViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "indexUnderInfo");
                xmlWriter.WriteStartElement("indexUnderInfo");
                    foreach (var item in indexViewModel_)
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
            Control v = new IndexUnderInfoView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.IndexUnderInfo serial_IndexUnderInfo = serial_Class as FpmlSerializedCSharp.IndexUnderInfo;
        
            List<FpmlSerializedCSharp.Index> serial_index = serial_IndexUnderInfo.Index_;
            this.indexViewModel_ = new ObservableCollection<IndexViewModel>();
            foreach (var item in serial_index)
            {
                string type = item.Excel_type_.ValueStr;
                IndexViewModel viewModel = IndexViewModel.CreateIndex(type);
                viewModel.setFromSerial(item);
                this.indexViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

