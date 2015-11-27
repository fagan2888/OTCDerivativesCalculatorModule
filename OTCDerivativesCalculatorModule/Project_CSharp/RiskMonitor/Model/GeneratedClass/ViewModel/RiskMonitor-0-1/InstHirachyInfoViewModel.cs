using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class InstHirachyInfoViewModel : IXmlData
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
        
        public InstHirachyInfoViewModel() { }
        
        #region Code_
        private string code_;
        public string Code_
        {
            get { return this.code_; }
            set
            {
                if (this.code_ != value)
                {
                    this.code_ = value;
                    this.NotifyPropertyChanged("Code_");
                }
            }
        }
        #endregion
        
        #region Type_
        private string type_;
        public string Type_
        {
            get { return this.type_; }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                    this.NotifyPropertyChanged("Type_");
                }
            }
        }
        #endregion
        
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
                xmlWriter.WriteElementString("type" , "instHirachyInfo");
                xmlWriter.WriteStartElement("instHirachyInfo");
                    xmlWriter.WriteElementString("code" , this.code_);
                    
                    xmlWriter.WriteElementString("type" , this.type_);
                    
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
            Control v = new InstHirachyInfoView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.InstHirachyInfo serial_InstHirachyInfo = serial_Class as FpmlSerializedCSharp.InstHirachyInfo;
        
            this.code_ = serial_InstHirachyInfo.Code_.ValueStr;
            
            this.type_ = serial_InstHirachyInfo.Type_.ValueStr;
            
            List<FpmlSerializedCSharp.InstHirachyInfo> serial_instHirachyInfo = serial_InstHirachyInfo.InstHirachyInfo_;
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

