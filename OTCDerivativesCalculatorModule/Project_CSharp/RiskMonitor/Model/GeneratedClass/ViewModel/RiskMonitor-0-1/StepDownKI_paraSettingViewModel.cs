using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class StepDownKI_paraSettingViewModel : IXmlData
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
        
        public StepDownKI_paraSettingViewModel() { }
        
        #region GeometricBM_paraSettingViewModel_
        private GeometricBM_paraSettingViewModel geometricBM_paraSettingViewModel_;
        public GeometricBM_paraSettingViewModel GeometricBM_paraSettingViewModel_
        {
            get { return this.geometricBM_paraSettingViewModel_; }
            set
            {
                if (this.geometricBM_paraSettingViewModel_ != value)
                {
                    this.geometricBM_paraSettingViewModel_ = value;
                    this.NotifyPropertyChanged("GeometricBM_paraSettingViewModel_");
                }
            }
        }
        #endregion
        
        #region HullWhite_paraSettingViewModel_
        private HullWhite_paraSettingViewModel hullWhite_paraSettingViewModel_;
        public HullWhite_paraSettingViewModel HullWhite_paraSettingViewModel_
        {
            get { return this.hullWhite_paraSettingViewModel_; }
            set
            {
                if (this.hullWhite_paraSettingViewModel_ != value)
                {
                    this.hullWhite_paraSettingViewModel_ = value;
                    this.NotifyPropertyChanged("HullWhite_paraSettingViewModel_");
                }
            }
        }
        #endregion
        
        #region DiscountCurve_paraSettingViewModel_
        private DiscountCurve_paraSettingViewModel discountCurve_paraSettingViewModel_;
        public DiscountCurve_paraSettingViewModel DiscountCurve_paraSettingViewModel_
        {
            get { return this.discountCurve_paraSettingViewModel_; }
            set
            {
                if (this.discountCurve_paraSettingViewModel_ != value)
                {
                    this.discountCurve_paraSettingViewModel_ = value;
                    this.NotifyPropertyChanged("DiscountCurve_paraSettingViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "stepDownKI_paraSetting");
                xmlWriter.WriteStartElement("stepDownKI_paraSetting");
                    geometricBM_paraSettingViewModel_.buildXml(xmlWriter);
                    
                    hullWhite_paraSettingViewModel_.buildXml(xmlWriter);
                    
                    discountCurve_paraSettingViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new StepDownKI_paraSettingView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.StepDownKI_paraSetting serial_StepDownKI_paraSetting = serial_Class as FpmlSerializedCSharp.StepDownKI_paraSetting;
        
            FpmlSerializedCSharp.GeometricBM_paraSetting serial_geometricBM_paraSetting = serial_StepDownKI_paraSetting.GeometricBM_paraSetting_;
            string geometricBM_paraSettingtype = serial_geometricBM_paraSetting.Excel_type_.ValueStr;
            this.geometricBM_paraSettingViewModel_ = GeometricBM_paraSettingViewModel.CreateGeometricBM_paraSetting(geometricBM_paraSettingtype);
            this.geometricBM_paraSettingViewModel_.setFromSerial(serial_geometricBM_paraSetting);
            
            FpmlSerializedCSharp.HullWhite_paraSetting serial_hullWhite_paraSetting = serial_StepDownKI_paraSetting.HullWhite_paraSetting_;
            string hullWhite_paraSettingtype = serial_hullWhite_paraSetting.Excel_type_.ValueStr;
            this.hullWhite_paraSettingViewModel_ = HullWhite_paraSettingViewModel.CreateHullWhite_paraSetting(hullWhite_paraSettingtype);
            this.hullWhite_paraSettingViewModel_.setFromSerial(serial_hullWhite_paraSetting);
            
            FpmlSerializedCSharp.DiscountCurve_paraSetting serial_discountCurve_paraSetting = serial_StepDownKI_paraSetting.DiscountCurve_paraSetting_;
            string discountCurve_paraSettingtype = serial_discountCurve_paraSetting.Excel_type_.ValueStr;
            this.discountCurve_paraSettingViewModel_ = DiscountCurve_paraSettingViewModel.CreateDiscountCurve_paraSetting(discountCurve_paraSettingtype);
            this.discountCurve_paraSettingViewModel_.setFromSerial(serial_discountCurve_paraSetting);
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}

