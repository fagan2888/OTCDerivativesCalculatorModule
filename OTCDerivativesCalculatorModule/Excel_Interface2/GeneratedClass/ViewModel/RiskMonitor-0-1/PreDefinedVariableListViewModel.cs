using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class PreDefinedVariableListViewModel : IXmlData
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
        
        public PreDefinedVariableListViewModel() { }
        
        #region PreDefinedVariableInfoViewModel_
        private ObservableCollection<PreDefinedVariableInfoViewModel> preDefinedVariableInfoViewModel_;
        public ObservableCollection<PreDefinedVariableInfoViewModel> PreDefinedVariableInfoViewModel_
        {
            get { return this.preDefinedVariableInfoViewModel_; }
            set
            {
                if (this.preDefinedVariableInfoViewModel_ != value)
                {
                    this.preDefinedVariableInfoViewModel_ = value;
                    this.NotifyPropertyChanged("PreDefinedVariableInfoViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "preDefinedVariableList");
                xmlWriter.WriteStartElement("preDefinedVariableList");
                    foreach (var item in preDefinedVariableInfoViewModel_)
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
            Control v = new PreDefinedVariableListView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PreDefinedVariableList serial_PreDefinedVariableList = serial_Class as FpmlSerializedCSharp.PreDefinedVariableList;
        
            List<FpmlSerializedCSharp.PreDefinedVariableInfo> serial_preDefinedVariableInfo = serial_PreDefinedVariableList.PreDefinedVariableInfo_;
            this.preDefinedVariableInfoViewModel_ = new ObservableCollection<PreDefinedVariableInfoViewModel>();
            foreach (var item in serial_preDefinedVariableInfo)
            {
                string type = item.Excel_type_.ValueStr;
                PreDefinedVariableInfoViewModel viewModel = PreDefinedVariableInfoViewModel.CreatePreDefinedVariableInfo(type);
                viewModel.setFromSerial(item);
                this.preDefinedVariableInfoViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

