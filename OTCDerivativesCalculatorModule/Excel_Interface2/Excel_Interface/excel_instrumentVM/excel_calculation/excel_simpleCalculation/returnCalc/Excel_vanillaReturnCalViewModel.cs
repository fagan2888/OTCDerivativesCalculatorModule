using System;
using System.Windows.Controls;


namespace Excel_Interface
{
    public class Excel_vanillaReturnCalViewModel : Excel_returnCalcInfoViewModel
    {
        public Excel_vanillaReturnCalViewModel() 
        {
            this.Excel_type_ = "excel_vanillaReturnCal";
        }
        
        #region Gearing_
        private string gearing_;
        public string Gearing_
        {
            get { return this.gearing_; }
            set
            {
                if (this.gearing_ != value)
                {
                    this.gearing_ = value;
                    this.NotifyPropertyChanged("Gearing_");
                }
            }
        }
        #endregion
        
        #region Spread_
        private string spread_;
        public string Spread_
        {
            get { return this.spread_; }
            set
            {
                if (this.spread_ != value)
                {
                    this.spread_ = value;
                    this.NotifyPropertyChanged("Spread_");
                }
            }
        }
        #endregion

        #region ReturnUnderlyingCalcIDViewModel_
        private Excel_underlyingCalcIDViewModel returnUnderlyingCalcIDViewModel_;
        public Excel_underlyingCalcIDViewModel ReturnUnderlyingCalcIDViewModel_
        {
            get { return this.returnUnderlyingCalcIDViewModel_; }
            set
            {
                if (this.returnUnderlyingCalcIDViewModel_ != value)
                {
                    this.returnUnderlyingCalcIDViewModel_ = value;
                    this.NotifyPropertyChanged("ReturnUnderlyingCalcIDViewModel_");
                }
            }
        }
        #endregion

        public override void attributeSetXml(System.Xml.XmlWriter xmlWriter)
        {
            if (this.attributeValue_ != "")
            {
                xmlWriter.WriteAttributeString("usingType", this.attributeValue_);
            }
        }

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_returnCalcInfo");

                this.attributeSetXml(xmlWriter);

                xmlWriter.WriteElementString("excel_type", "excel_vanillaReturnCal");
                xmlWriter.WriteStartElement("excel_vanillaReturnCal");
                    xmlWriter.WriteElementString("gearing" , this.gearing_);
                    xmlWriter.WriteElementString("spread" , this.spread_);
                    
                    this.returnUnderlyingCalcIDViewModel_.AttributeValue_ = "returnCalc";
                    this.returnUnderlyingCalcIDViewModel_.buildXml(xmlWriter);

                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_returnCalcInfo serial_Excel_returnCalcInfo = serial_Class as FpmlSerializedCSharp.Excel_returnCalcInfo;
            FpmlSerializedCSharp.Excel_vanillaReturnCal serial_Excel_vanillaReturnCal = serial_Excel_returnCalcInfo.Excel_vanillaReturnCal_;

            this.gearing_ = serial_Excel_vanillaReturnCal.Gearing_.ValueStr;

            this.spread_ = serial_Excel_vanillaReturnCal.Spread_.ValueStr;

            FpmlSerializedCSharp.Excel_underlyingCalcID serial_excel_underlyingCalcID = serial_Excel_vanillaReturnCal.Excel_underlyingCalcID_;
            string excel_underlyingCalcIDtype = serial_excel_underlyingCalcID.Excel_type_.ValueStr;
            this.returnUnderlyingCalcIDViewModel_ = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(excel_underlyingCalcIDtype);
            this.returnUnderlyingCalcIDViewModel_.setFromSerial(serial_excel_underlyingCalcID);

        }

        //public override ReturnCalculationInfoViewModel returnCalcInfoVM()
        //{
        //    ReturnCalculationInfoViewModel rcivm = new ReturnCalculationInfoViewModel();

        //    VanillaReturnCalViewModel vrcvm = new VanillaReturnCalViewModel();

        //    vrcvm.Gearing_ = this.gearing_;
        //    vrcvm.Spread_ = this.spread_;

        //    //referenceCal

        //    vrcvm.ReferenceCalculationInfoViewModel_ = this.returnUnderlyingCalcIDViewModel_.referenceCalcInfoVM();

        //    foreach (var item in vrcvm.ReferenceCalculationInfoViewModel_.ReferenceCalculationViewModel_)
        //    {
        //        FixedFixingDateInfoViewModel ffdivm = new FixedFixingDateInfoViewModel();
        //        ffdivm.Date_ = this.referenceFixingDate_.ToString("yyyy-MM-dd");

        //        item.FixingDateInfoViewModel_ = ffdivm;
        //    }

        //    rcivm.ReturnCalculationViewModel_.Add(vrcvm);

        //    return rcivm;

        //}

        public override Control view()
        {
            Excel_vanillaReturnCalView v = new Excel_vanillaReturnCalView();

            //int underCount = this.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_.Count;

            v.setReturnUnderCalcView(this.Excel_underlyingCalcInfoViewModel_);

            v.DataContext = this;

            return v;
        }

        public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;

            int underCount = excel_under.Excel_underlyingInfoViewModel_.Count;

            if (underCount > 1)
            {
                if (this.returnUnderlyingCalcIDViewModel_ == null)
                {
                    this.returnUnderlyingCalcIDViewModel_ = new Excel_maximumUnderlyingCalcIDViewModel();
                }

                this.returnUnderlyingCalcIDViewModel_.setUnderlying(excel_under);
            }
            
        }

        public override void defaultSetting()
        {
            this.gearing_ = "1.0";
            this.spread_ = "0.0";
            this.returnUnderlyingCalcIDViewModel_ = new Excel_maximumUnderlyingCalcIDViewModel();
        }


    }
    
}

