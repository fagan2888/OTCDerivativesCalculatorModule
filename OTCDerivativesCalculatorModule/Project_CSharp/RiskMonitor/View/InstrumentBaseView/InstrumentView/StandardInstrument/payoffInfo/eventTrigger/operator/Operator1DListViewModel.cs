using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class Operator1DListViewModel : IXmlData
    {
        #region View_
        protected Control view_;
        public Control View_
        {
            get { return this.view_; }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
                }
            }
        }
        #endregion
    
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
        
    
        public Operator1DListViewModel() { }
        
    
        #region Operator1DViewModel_
        private ObservableCollection<Operator1DViewModel> operator1DViewModel_;
        public ObservableCollection<Operator1DViewModel> Operator1DViewModel_
        {
            get { return this.operator1DViewModel_; }
            set
            {
                if (this.operator1DViewModel_ != value)
                {
                    this.operator1DViewModel_ = value;
                    this.NotifyPropertyChanged("Operator1DViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "operator1DList");
                xmlWriter.WriteStartElement("operator1DList");

                foreach (var item in operator1DViewModel_)
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
            FpmlSerializedCSharp.Operator1DList serial_Operator1DList = serial_Class as FpmlSerializedCSharp.Operator1DList;
        
            List<FpmlSerializedCSharp.Operator1D> serial_operator1D = serial_Operator1DList.Operator1D_;
            this.operator1DViewModel_ = new ObservableCollection<Operator1DViewModel>();
            foreach (var item in serial_operator1D)
            {
                string type = item.Type_.ValueStr;
                Operator1DViewModel viewModel = Operator1DViewModel.CreateOperator1D(type);
                viewModel.setFromSerial(item);
                this.operator1DViewModel_.Add(viewModel);
            }
            
           //this.view_ = new Operator1DListView();
            this.view_.DataContext = this;
        }
        
        
    
            //#region SelectOperator1DInfo_
            //private string selectOperator1DInfo_;
            //public string SelectOperator1DInfo_
            //{
            //    get { return this.selectOperator1DInfo_; }
            //    set
            //    {
            //        if (this.selectOperator1DInfo_ != value)
            //        {
            //            this.selectOperator1DInfo_ = value;
            //            this.NotifyPropertyChanged("SelectOperator1DInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectOperator1DInfo(string typeStr)
            //{
            //    this.operator1DViewModel_ = Operator1DViewModel.CreateOperator1D(typeStr);
            //    this.view_.DataContext = this;
            //}
            
        
    
        
    
    }
    
}

