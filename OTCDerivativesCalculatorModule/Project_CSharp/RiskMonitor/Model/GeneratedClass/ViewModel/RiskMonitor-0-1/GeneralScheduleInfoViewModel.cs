using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class GeneralScheduleInfoViewModel : IXmlData
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
        
        public GeneralScheduleInfoViewModel() { }
        
        #region GeneralScheduleViewModel_
        private ObservableCollection<GeneralScheduleViewModel> generalScheduleViewModel_;
        public ObservableCollection<GeneralScheduleViewModel> GeneralScheduleViewModel_
        {
            get { return this.generalScheduleViewModel_; }
            set
            {
                if (this.generalScheduleViewModel_ != value)
                {
                    this.generalScheduleViewModel_ = value;
                    this.NotifyPropertyChanged("GeneralScheduleViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "generalScheduleInfo");
                xmlWriter.WriteStartElement("generalScheduleInfo");
                    foreach (var item in generalScheduleViewModel_)
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
            Control v = new GeneralScheduleInfoView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.GeneralScheduleInfo serial_GeneralScheduleInfo = serial_Class as FpmlSerializedCSharp.GeneralScheduleInfo;
        
            List<FpmlSerializedCSharp.GeneralSchedule> serial_generalSchedule = serial_GeneralScheduleInfo.GeneralSchedule_;
            this.generalScheduleViewModel_ = new ObservableCollection<GeneralScheduleViewModel>();
            foreach (var item in serial_generalSchedule)
            {
                string type = item.Excel_type_.ValueStr;
                GeneralScheduleViewModel viewModel = GeneralScheduleViewModel.CreateGeneralSchedule(type);
                viewModel.setFromSerial(item);
                this.generalScheduleViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

