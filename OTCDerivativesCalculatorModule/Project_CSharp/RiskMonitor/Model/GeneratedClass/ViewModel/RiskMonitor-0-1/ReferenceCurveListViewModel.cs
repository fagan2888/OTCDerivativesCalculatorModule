using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ReferenceCurveListViewModel : IXmlData
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
        
        public ReferenceCurveListViewModel() { }
        
        #region ReferenceCurveViewModel_
        private ObservableCollection<ReferenceCurveViewModel> referenceCurveViewModel_;
        public ObservableCollection<ReferenceCurveViewModel> ReferenceCurveViewModel_
        {
            get { return this.referenceCurveViewModel_; }
            set
            {
                if (this.referenceCurveViewModel_ != value)
                {
                    this.referenceCurveViewModel_ = value;
                    this.NotifyPropertyChanged("ReferenceCurveViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "referenceCurveList");
                xmlWriter.WriteStartElement("referenceCurveList");
                    foreach (var item in referenceCurveViewModel_)
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
            Control v = new ReferenceCurveListView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ReferenceCurveList serial_ReferenceCurveList = serial_Class as FpmlSerializedCSharp.ReferenceCurveList;
        
            List<FpmlSerializedCSharp.ReferenceCurve> serial_referenceCurve = serial_ReferenceCurveList.ReferenceCurve_;
            this.referenceCurveViewModel_ = new ObservableCollection<ReferenceCurveViewModel>();
            foreach (var item in serial_referenceCurve)
            {
                string type = item.Excel_type_.ValueStr;
                ReferenceCurveViewModel viewModel = ReferenceCurveViewModel.CreateReferenceCurve(type);
                viewModel.setFromSerial(item);
                this.referenceCurveViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

