using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_interpolationViewModel : IXmlData
    {
        //#region View_
        //protected Control view_;
        //public Control View_
        //{
        //    get { return this.view_; }
        //    set
        //    {
        //        if (this.view_ != value)
        //        {
        //            this.view_ = value;
        //            this.NotifyPropertyChanged("View_");
        //        }
        //    }
        //}
        //#endregion

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
    
        public Excel_interpolationViewModel() 
        {
            this.defaultSetting();

            //this.view_ = new Excel_interpolationView();
            //this.view_.DataContext = this;
        }

        // default 비어있는거 방지용
        private void defaultSetting()
        {
            this.interpolation_ = "LINEAR";
            this.daycounter_ = "ACT360";
            this.calendar_ = "KOR";
            this.businessDayConvention_ = "FOLLOWING";
        }
    
        #region Interpolation_
        private string interpolation_;
        public string Interpolation_
        {
            get { return this.interpolation_; }
            set
            {
                if (this.interpolation_ != value)
                {
                    this.interpolation_ = value;
                    this.NotifyPropertyChanged("Interpolation_");
                }
            }
        }
        #endregion
        
        #region Daycounter_
        private string daycounter_;
        public string Daycounter_
        {
            get { return this.daycounter_; }
            set
            {
                if (this.daycounter_ != value)
                {
                    this.daycounter_ = value;
                    this.NotifyPropertyChanged("Daycounter_");
                }
            }
        }
        #endregion
        
        #region Calendar_
        private string calendar_;
        public string Calendar_
        {
            get { return this.calendar_; }
            set
            {
                if (this.calendar_ != value)
                {
                    this.calendar_ = value;
                    this.NotifyPropertyChanged("Calendar_");
                }
            }
        }
        #endregion
        
        #region BusinessDayConvention_
        private string businessDayConvention_;
        public string BusinessDayConvention_
        {
            get { return this.businessDayConvention_; }
            set
            {
                if (this.businessDayConvention_ != value)
                {
                    this.businessDayConvention_ = value;
                    this.NotifyPropertyChanged("BusinessDayConvention_");
                }
            }
        }
        #endregion
        
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_interpolation");
                xmlWriter.WriteElementString("interpolation" , this.interpolation_);
                    
                xmlWriter.WriteElementString("daycounter" , this.daycounter_);
                    
                xmlWriter.WriteElementString("calendar" , this.calendar_);
                    
                xmlWriter.WriteElementString("businessDayConvention" , this.businessDayConvention_);
                    
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            //FpmlSerializedCSharp.Excel_interpolation serial_Excel_interpolation = serial_Class as FpmlSerializedCSharp.Excel_interpolation;
        
            //this.interpolation_ = serial_Excel_interpolation.Interpolation_.ValueStr;
            
            //this.daycounter_ = serial_Excel_interpolation.Daycounter_.ValueStr;
            
            //this.calendar_ = serial_Excel_interpolation.Calendar_.ValueStr;
            
            //this.businessDayConvention_ = serial_Excel_interpolation.BusinessDayConvention_.ValueStr;
            
            //this.view_ = new Excel_interpolationView();
            //this.view_.DataContext = this;
        }

        public Excel_interpolationViewModel clone()
        {
            Excel_interpolationViewModel cloneVM = new Excel_interpolationViewModel();

            cloneVM.interpolation_ = this.interpolation_;
            cloneVM.daycounter_ = this.daycounter_;
            cloneVM.calendar_ = this.calendar_;
            cloneVM.businessDayConvention_ = this.businessDayConvention_;

            return cloneVM;
        }

        public Control view()
        {
            System.Windows.Controls.Control v = new Excel_interpolationView();

            v.DataContext = this;

            return v;
        }
    }
    
}

