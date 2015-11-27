using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class FixingInformationViewModel : IXmlData
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
        
    
        public FixingInformationViewModel() { }
        
    
        #region InitialValue_
        private string initialValue_;
        public string InitialValue_
        {
            get { return this.initialValue_; }
            set
            {
                if (this.initialValue_ != value)
                {
                    this.initialValue_ = value;
                    this.NotifyPropertyChanged("InitialValue_");
                }
            }
        }
        #endregion
        
        #region FixingViewModel_
        private ObservableCollection<FixingViewModel> fixingViewModel_;
        public ObservableCollection<FixingViewModel> FixingViewModel_
        {
            get { return this.fixingViewModel_; }
            set
            {
                if (this.fixingViewModel_ != value)
                {
                    this.fixingViewModel_ = value;
                    this.NotifyPropertyChanged("FixingViewModel_");
                }
            }
        }
        #endregion
        
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "fixingInformation");
                xmlWriter.WriteStartElement("fixingInformation");
                    xmlWriter.WriteElementString("initialValue" , this.initialValue_);
            
                    foreach (var item in fixingViewModel_)
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
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.FixingInformation serial_FixingInformation = serial_Class as FpmlSerializedCSharp.FixingInformation;
        
            this.initialValue_ = serial_FixingInformation.InitialValue_.ValueStr;
            
            List<FpmlSerializedCSharp.Fixing> serial_fixing = serial_FixingInformation.Fixing_;
            this.fixingViewModel_ = new ObservableCollection<FixingViewModel>();
            foreach (var item in serial_fixing)
            {
                //string type = item.Type_.ValueStr;
                FixingViewModel viewModel = new FixingViewModel();
                viewModel.setFromSerial(item);
                this.fixingViewModel_.Add(viewModel);
            }
            
            //this.view_ = new FixingInformationView();
            //this.view_.DataContext = this;
        }
        
        
    
            //#region SelectFixingInfo_
            //private string selectFixingInfo_;
            //public string SelectFixingInfo_
            //{
            //    get { return this.selectFixingInfo_; }
            //    set
            //    {
            //        if (this.selectFixingInfo_ != value)
            //        {
            //            this.selectFixingInfo_ = value;
            //            this.NotifyPropertyChanged("SelectFixingInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectFixingInfo(string typeStr)
            //{
            //    this.fixingViewModel_ = FixingViewModel.CreateFixing(typeStr);
            //    this.view_.DataContext = this;
            //}
            
        
    
        
    
    }
    
}

