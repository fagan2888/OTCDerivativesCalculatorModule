using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ConditionOperatorViewModel : IXmlData
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
        
        public ConditionOperatorViewModel() { }
        
        #region RangeCondition1DViewModel_
        private ObservableCollection<RangeCondition1DViewModel> rangeCondition1DViewModel_;
        public ObservableCollection<RangeCondition1DViewModel> RangeCondition1DViewModel_
        {
            get { return this.rangeCondition1DViewModel_; }
            set
            {
                if (this.rangeCondition1DViewModel_ != value)
                {
                    this.rangeCondition1DViewModel_ = value;
                    this.NotifyPropertyChanged("RangeCondition1DViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "conditionOperator");
                xmlWriter.WriteStartElement("conditionOperator");
                    foreach (var item in rangeCondition1DViewModel_)
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
            Control v = new ConditionOperatorView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ConditionOperator serial_ConditionOperator = serial_Class as FpmlSerializedCSharp.ConditionOperator;
        
            List<FpmlSerializedCSharp.RangeCondition1D> serial_rangeCondition1D = serial_ConditionOperator.RangeCondition1D_;
            this.rangeCondition1DViewModel_ = new ObservableCollection<RangeCondition1DViewModel>();
            foreach (var item in serial_rangeCondition1D)
            {
                string type = item.Excel_type_.ValueStr;
                RangeCondition1DViewModel viewModel = RangeCondition1DViewModel.CreateRangeCondition1D(type);
                viewModel.setFromSerial(item);
                this.rangeCondition1DViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

