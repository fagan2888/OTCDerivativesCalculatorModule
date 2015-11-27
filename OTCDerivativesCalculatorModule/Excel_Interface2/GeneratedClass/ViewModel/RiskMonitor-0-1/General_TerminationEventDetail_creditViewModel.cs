using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class General_TerminationEventDetail_creditViewModel : GeneralTerminationEventDetailViewModel
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
        
        public General_TerminationEventDetail_creditViewModel() { }
        
        #region ReferenceEntity_
        private ObservableCollection<string> referenceEntity_;
        public ObservableCollection<string> ReferenceEntity_
        {
            get { return this.referenceEntity_; }
            set
            {
                if (this.referenceEntity_ != value)
                {
                    this.referenceEntity_ = value;
                    this.NotifyPropertyChanged("ReferenceEntity_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("generalTerminationEventDetail");
                xmlWriter.WriteElementString("excel_type" , "general_TerminationEventDetail_credit");
                xmlWriter.WriteStartElement("general_TerminationEventDetail_credit");
                    xmlWriter.WriteElementString("referenceEntity" , this.referenceEntity_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new General_TerminationEventDetail_creditView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.GeneralTerminationEventDetail serial_GeneralTerminationEventDetail = serial_Class as FpmlSerializedCSharp.GeneralTerminationEventDetail;
            FpmlSerializedCSharp.General_TerminationEventDetail_credit serial_General_TerminationEventDetail_credit = serial_GeneralTerminationEventDetail.General_TerminationEventDetail_credit_;
        
            this.referenceEntityViewModel_ = new ObservableCollection<ReferenceEntityViewModel>();
            foreach (var item in serial_General_TerminationEventDetail_credit.ReferenceEntity_)
            {
                this.value_.Add(item.ValueStr);
            }
            
        }
        
        
    
        
    
        
    
    }
    
}

