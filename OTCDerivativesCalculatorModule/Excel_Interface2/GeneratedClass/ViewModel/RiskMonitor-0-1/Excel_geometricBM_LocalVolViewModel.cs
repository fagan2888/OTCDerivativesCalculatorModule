using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_geometricBM_LocalVolViewModel : Excel_underlyingModel_paraViewModel
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
        
        public Excel_geometricBM_LocalVolViewModel() { }
        
        #region CurrentValue_
        private string currentValue_;
        public string CurrentValue_
        {
            get { return this.currentValue_; }
            set
            {
                if (this.currentValue_ != value)
                {
                    this.currentValue_ = value;
                    this.NotifyPropertyChanged("CurrentValue_");
                }
            }
        }
        #endregion
        
        #region Drift_
        private string drift_;
        public string Drift_
        {
            get { return this.drift_; }
            set
            {
                if (this.drift_ != value)
                {
                    this.drift_ = value;
                    this.NotifyPropertyChanged("Drift_");
                }
            }
        }
        #endregion
        
        #region Dividend_
        private string dividend_;
        public string Dividend_
        {
            get { return this.dividend_; }
            set
            {
                if (this.dividend_ != value)
                {
                    this.dividend_ = value;
                    this.NotifyPropertyChanged("Dividend_");
                }
            }
        }
        #endregion
        
        #region LinkedSurfaceCode_
        private string linkedSurfaceCode_;
        public string LinkedSurfaceCode_
        {
            get { return this.linkedSurfaceCode_; }
            set
            {
                if (this.linkedSurfaceCode_ != value)
                {
                    this.linkedSurfaceCode_ = value;
                    this.NotifyPropertyChanged("LinkedSurfaceCode_");
                }
            }
        }
        #endregion
        
        #region Excel_volSurfaceViewModel_
        private Excel_volSurfaceViewModel excel_volSurfaceViewModel_;
        public Excel_volSurfaceViewModel Excel_volSurfaceViewModel_
        {
            get { return this.excel_volSurfaceViewModel_; }
            set
            {
                if (this.excel_volSurfaceViewModel_ != value)
                {
                    this.excel_volSurfaceViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_volSurfaceViewModel_");
                }
            }
        }
        #endregion
        
        #region Vba_description_
        private string vba_description_;
        public string Vba_description_
        {
            get { return this.vba_description_; }
            set
            {
                if (this.vba_description_ != value)
                {
                    this.vba_description_ = value;
                    this.NotifyPropertyChanged("Vba_description_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_underlyingModel_para");
                xmlWriter.WriteElementString("excel_type" , "excel_geometricBM_LocalVol");
                xmlWriter.WriteStartElement("excel_geometricBM_LocalVol");
                    xmlWriter.WriteElementString("currentValue" , this.currentValue_);
                    
                    xmlWriter.WriteElementString("drift" , this.drift_);
                    
                    xmlWriter.WriteElementString("dividend" , this.dividend_);
                    
                    xmlWriter.WriteElementString("linkedSurfaceCode" , this.linkedSurfaceCode_);
                    
                    excel_volSurfaceViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("vba_description" , this.vba_description_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_geometricBM_LocalVolView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingModel_para serial_Excel_underlyingModel_para = serial_Class as FpmlSerializedCSharp.Excel_underlyingModel_para;
            FpmlSerializedCSharp.Excel_geometricBM_LocalVol serial_Excel_geometricBM_LocalVol = serial_Excel_underlyingModel_para.Excel_geometricBM_LocalVol_;
        
            this.currentValue_ = serial_Excel_geometricBM_LocalVol.CurrentValue_.ValueStr;
            
            this.drift_ = serial_Excel_geometricBM_LocalVol.Drift_.ValueStr;
            
            this.dividend_ = serial_Excel_geometricBM_LocalVol.Dividend_.ValueStr;
            
            this.linkedSurfaceCode_ = serial_Excel_geometricBM_LocalVol.LinkedSurfaceCode_.ValueStr;
            
            FpmlSerializedCSharp.Excel_volSurface serial_excel_volSurface = serial_Excel_geometricBM_LocalVol.Excel_volSurface_;
            string excel_volSurfacetype = serial_excel_volSurface.Excel_type_.ValueStr;
            this.excel_volSurfaceViewModel_ = Excel_volSurfaceViewModel.CreateExcel_volSurface(excel_volSurfacetype);
            this.excel_volSurfaceViewModel_.setFromSerial(serial_excel_volSurface);
            
            this.vba_description_ = serial_Excel_geometricBM_LocalVol.Vba_description_.ValueStr;
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

