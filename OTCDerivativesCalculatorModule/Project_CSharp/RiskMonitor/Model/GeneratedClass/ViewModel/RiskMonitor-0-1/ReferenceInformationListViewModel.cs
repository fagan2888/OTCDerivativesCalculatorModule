using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ReferenceInformationListViewModel : IXmlData
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
        
        public ReferenceInformationListViewModel() { }
        
        #region ReferenceInformationViewModel_
        private ObservableCollection<ReferenceInformationViewModel> referenceInformationViewModel_;
        public ObservableCollection<ReferenceInformationViewModel> ReferenceInformationViewModel_
        {
            get { return this.referenceInformationViewModel_; }
            set
            {
                if (this.referenceInformationViewModel_ != value)
                {
                    this.referenceInformationViewModel_ = value;
                    this.NotifyPropertyChanged("ReferenceInformationViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "referenceInformationList");
                xmlWriter.WriteStartElement("referenceInformationList");
                    foreach (var item in referenceInformationViewModel_)
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
            Control v = new ReferenceInformationListView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReferenceInformationList serial_ReferenceInformationList = serial_Class as FpmlSerializedCSharp.ReferenceInformationList;
        
            List<FpmlSerializedCSharp.ReferenceInformation> serial_referenceInformation = serial_ReferenceInformationList.ReferenceInformation_;
            this.referenceInformationViewModel_ = new ObservableCollection<ReferenceInformationViewModel>();
            foreach (var item in serial_referenceInformation)
            {
                string type = item.Excel_type_.ValueStr;
                ReferenceInformationViewModel viewModel = ReferenceInformationViewModel.CreateReferenceInformation(type);
                viewModel.setFromSerial(item);
                this.referenceInformationViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

