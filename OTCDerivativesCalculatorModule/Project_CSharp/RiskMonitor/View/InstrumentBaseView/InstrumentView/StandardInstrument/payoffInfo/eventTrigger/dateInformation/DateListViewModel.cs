using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class DateListViewModel : DateInformationViewModel
    {
    
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
                xmlWriter.WriteElementString("type" , "dateList");
                xmlWriter.WriteStartElement("dateList");

                foreach (var item in this.date_)
                {
                    xmlWriter.WriteElementString("date", item);
                }
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.DateInformation serial_DateInformation = serial_Class as FpmlSerializedCSharp.DateInformation;
            FpmlSerializedCSharp.DateList serial_DateList = serial_DateInformation.DateList_;

            this.date_ = new ObservableCollection<string>();

            foreach (var item in serial_DateList.Date_)
            {
                this.date_.Add(item.ValueStr);
            }
            
            //this.view_ = new DateListView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}

