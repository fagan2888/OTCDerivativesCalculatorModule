using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class MaximumOperNDViewModel : OperatorNDViewModel
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
        
        public MaximumOperNDViewModel() { }
        
        #region Weight_
        private ObservableCollection<string> weight_;
        public ObservableCollection<string> Weight_
        {
            get { return this.weight_; }
            set
            {
                if (this.weight_ != value)
                {
                    this.weight_ = value;
                    this.NotifyPropertyChanged("Weight_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("operatorND");
                xmlWriter.WriteElementString("excel_type" , "maximumOperND");
                xmlWriter.WriteStartElement("maximumOperND");
                    xmlWriter.WriteElementString("weight" , this.weight_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new MaximumOperNDView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.OperatorND serial_OperatorND = serial_Class as FpmlSerializedCSharp.OperatorND;
            FpmlSerializedCSharp.MaximumOperND serial_MaximumOperND = serial_OperatorND.MaximumOperND_;
        
            this.weightViewModel_ = new ObservableCollection<WeightViewModel>();
            foreach (var item in serial_MaximumOperND.Weight_)
            {
                this.value_.Add(item.ValueStr);
            }
            
        }
        
        
    
        
    
        
    
    }
    
}

