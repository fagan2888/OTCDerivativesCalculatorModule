using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class DateListViewModel : DateInformationViewModel
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
        
        public DateListViewModel() { }
        
        #region Date_
        private ObservableCollection<string> date_;
        public ObservableCollection<string> Date_
        {
            get { return this.date_; }
            set
            {
                if (this.date_ != value)
                {
                    this.date_ = value;
                    this.NotifyPropertyChanged("Date_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("dateInformation");
                xmlWriter.WriteElementString("excel_type" , "dateList");
                xmlWriter.WriteStartElement("dateList");
                    xmlWriter.WriteElementString("date" , this.date_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new DateListView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.DateInformation serial_DateInformation = serial_Class as FpmlSerializedCSharp.DateInformation;
            FpmlSerializedCSharp.DateList serial_DateList = serial_DateInformation.DateList_;
        
            this.dateViewModel_ = new ObservableCollection<DateViewModel>();
            foreach (var item in serial_DateList.Date_)
            {
                this.value_.Add(item.ValueStr);
            }
            
        }
        
        
    
        
    
        
    
    }
    
}

