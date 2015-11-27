using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class Excel_underlyingCalcIDViewModel : IXmlData
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
        
    
        public Excel_underlyingCalcIDViewModel() { }
        
    
        #region CalcID_
        private string calcID_;
        public string CalcID_
        {
            get { return this.calcID_; }
            set
            {
                if (this.calcID_ != value)
                {
                    this.calcID_ = value;
                    this.NotifyPropertyChanged("CalcID_");
                }
            }
        }
        #endregion
        
        #region CalcType_
        private string calcType_;
        public string CalcType_
        {
            get { return this.calcType_; }
            set
            {
                if (this.calcType_ != value)
                {
                    this.calcType_ = value;
                    this.NotifyPropertyChanged("CalcType_");
                }
            }
        }
        #endregion
        
        #region ReferenceType_
        private string referenceType_;
        public string ReferenceType_
        {
            get { return this.referenceType_; }
            set
            {
                if (this.referenceType_ != value)
                {
                    this.referenceType_ = value;
                    this.NotifyPropertyChanged("ReferenceType_");
                }
            }
        }
        #endregion
        
        #region SelectedUnderlyingName_
        private ObservableCollection<string> selectedUnderlyingName_;
        public ObservableCollection<string> SelectedUnderlyingName_
        {
            get { return this.selectedUnderlyingName_; }
            set
            {
                if (this.selectedUnderlyingName_ != value)
                {
                    this.selectedUnderlyingName_ = value;
                    this.NotifyPropertyChanged("SelectedUnderlyingName_");
                }
            }
        }
        #endregion
        
        #region Nth_
        private string nth_;
        public string Nth_
        {
            get { return this.nth_; }
            set
            {
                if (this.nth_ != value)
                {
                    this.nth_ = value;
                    this.NotifyPropertyChanged("Nth_");
                }
            }
        }
        #endregion
        
        #region AverageDays_
        private string averageDays_;
        public string AverageDays_
        {
            get { return this.averageDays_; }
            set
            {
                if (this.averageDays_ != value)
                {
                    this.averageDays_ = value;
                    this.NotifyPropertyChanged("AverageDays_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "excel_underlyingCalcID");
                xmlWriter.WriteStartElement("excel_underlyingCalcID");
                    xmlWriter.WriteElementString("calcID" , this.calcID_);
                    
                    xmlWriter.WriteElementString("calcType" , this.calcType_);
                    
                    xmlWriter.WriteElementString("referenceType" , this.referenceType_);
                    
                    xmlWriter.WriteElementString("selectedUnderlyingName" , this.selectedUnderlyingName_);
                    
                    xmlWriter.WriteElementString("nth" , this.nth_);
                    
                    xmlWriter.WriteElementString("averageDays" , this.averageDays_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingCalcID serial_Excel_underlyingCalcID = serial_Class as FpmlSerializedCSharp.Excel_underlyingCalcID;
        
            this.calcID_ = serial_Excel_underlyingCalcID.CalcID_.ValueStr;
            
            this.calcType_ = serial_Excel_underlyingCalcID.CalcType_.ValueStr;
            
            this.referenceType_ = serial_Excel_underlyingCalcID.ReferenceType_.ValueStr;
            
            this.selectedUnderlyingNameViewModel_ = new ObservableCollection<SelectedUnderlyingNameViewModel>();
            foreach (var item in serial_Excel_underlyingCalcID.SelectedUnderlyingName_)
            {
                this.value_.Add(item.ValueStr);
            }
            
            this.nth_ = serial_Excel_underlyingCalcID.Nth_.ValueStr;
            
            this.averageDays_ = serial_Excel_underlyingCalcID.AverageDays_.ValueStr;
            
            this.view_ = new Excel_underlyingCalcIDView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}

