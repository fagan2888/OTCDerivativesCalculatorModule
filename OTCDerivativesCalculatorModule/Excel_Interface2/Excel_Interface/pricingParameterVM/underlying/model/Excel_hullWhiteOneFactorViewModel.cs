using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_hullWhiteOneFactorViewModel : Excel_underlyingModel_paraViewModel
    {
        public Excel_hullWhiteOneFactorViewModel() 
        {
            this.Excel_type_ = "excel_hullWhiteOneFactor";
            this.underlyingModelComboString_ = "HullWhite";
            //this.view_ = new Excel_hullWhiteOneFactorView();
            //this.view_.DataContext = this;
        }
        
        #region Alpha_
        private string alpha_;
        public string Alpha_
        {
            get { return this.alpha_; }
            set
            {
                if (this.alpha_ != value)
                {
                    this.alpha_ = value;
                    this.NotifyPropertyChanged("Alpha_");
                }
            }
        }
        #endregion
        
        #region Volatility_
        private string volatility_;
        public string Volatility_
        {
            get { return this.volatility_; }
            set
            {
                if (this.volatility_ != value)
                {
                    this.volatility_ = value;
                    this.NotifyPropertyChanged("Volatility_");
                }
            }
        }
        #endregion

        #region Excel_rateInfoViewModel_
        private Excel_rateInfoViewModel excel_rateInfoViewModel_;
        public Excel_rateInfoViewModel Excel_rateInfoViewModel_
        {
            get { return this.excel_rateInfoViewModel_; }
            set
            {
                if (this.excel_rateInfoViewModel_ != value)
                {
                    this.excel_rateInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_rateInfoViewModel_");
                }
            }
        }
        #endregion

        //#region Tenor_
        //private string tenor_;
        //public string Tenor_
        //{
        //    get { return this.tenor_; }
        //    set
        //    {
        //        if (this.tenor_ != value)
        //        {
        //            this.tenor_ = value;
        //            this.NotifyPropertyChanged("Tenor_");
        //        }
        //    }
        //}
        //#endregion

        #region LinkedCurveCode_
        private string linkedCurveCode_;
        public string LinkedCurveCode_
        {
            get { return this.linkedCurveCode_; }
            set
            {
                if (this.linkedCurveCode_ != value)
                {
                    this.linkedCurveCode_ = value;
                    this.NotifyPropertyChanged("LinkedCurveCode_");
                }
            }
        }
        #endregion

        #region Excel_yieldCurveViewModel_
        private Excel_yieldCurveViewModel excel_yieldCurveViewModel_;
        public Excel_yieldCurveViewModel Excel_yieldCurveViewModel_
        {
            get { return this.excel_yieldCurveViewModel_; }
            set
            {
                if (this.excel_yieldCurveViewModel_ != value)
                {
                    this.excel_yieldCurveViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_yieldCurveViewModel_");
                }
            }
        }
        #endregion
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_underlyingModel_para");
                xmlWriter.WriteElementString("excel_type" , "excel_hullWhiteOneFactor");
                xmlWriter.WriteStartElement("excel_hullWhiteOneFactor");

                    xmlWriter.WriteElementString("currentValue", this.currentValue_);
                    xmlWriter.WriteElementString("alpha" , this.alpha_);
                    xmlWriter.WriteElementString("volatility" , this.volatility_);
                    
                    excel_rateInfoViewModel_.buildXml(xmlWriter);

                    xmlWriter.WriteElementString("linkedCurveCode", this.linkedCurveCode_);
                    //xmlWriter.WriteElementString("tenor" , this.tenor_);

                    if (excel_yieldCurveViewModel_ != null)
                    {
                        excel_yieldCurveViewModel_.buildXml(xmlWriter);
                    }
                    else 
                    {
                        xmlWriter.WriteElementString("excel_yieldCurve", "empty");    
                    }
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingModel_para serial_Excel_underlyingModel_para = serial_Class as FpmlSerializedCSharp.Excel_underlyingModel_para;
            FpmlSerializedCSharp.Excel_hullWhiteOneFactor serial_Excel_hullWhiteOneFactor = serial_Excel_underlyingModel_para.Excel_hullWhiteOneFactor_;

            this.currentValue_ = serial_Excel_hullWhiteOneFactor.CurrentValue_.ValueStr;
            this.alpha_ = serial_Excel_hullWhiteOneFactor.Alpha_.ValueStr;
            this.volatility_ = serial_Excel_hullWhiteOneFactor.Volatility_.ValueStr;
            this.linkedCurveCode_ = serial_Excel_hullWhiteOneFactor.LinkedCurveCode_.ValueStr;

            FpmlSerializedCSharp.Excel_rateInfo serial_excel_rateInfo = serial_Excel_hullWhiteOneFactor.Excel_rateInfo_;
            this.excel_rateInfoViewModel_ = new Excel_rateInfoViewModel();
            this.excel_rateInfoViewModel_.setFromSerial(serial_excel_rateInfo);
            
            FpmlSerializedCSharp.Excel_yieldCurve serial_excel_yieldCurve = serial_Excel_hullWhiteOneFactor.Excel_yieldCurve_;
            this.excel_yieldCurveViewModel_ = new Excel_yieldCurveViewModel();
            this.excel_yieldCurveViewModel_.setFromSerial(serial_excel_yieldCurve);
  
        }

        public override string description()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("alpha : " + this.alpha_ + " , vol : " + this.volatility_ + " , curveName : ");

            return sb.ToString();
        }

        public override Excel_underlyingModel_paraViewModel Clone()
        {
            Excel_hullWhiteOneFactorViewModel clone = new Excel_hullWhiteOneFactorViewModel();

            clone.CurrentValue_ = this.currentValue_;
            clone.Alpha_ = this.alpha_;
            clone.Volatility_ = this.volatility_;
            clone.LinkedCurveCode_ = this.linkedCurveCode_;

            clone.Excel_rateInfoViewModel_ = this.excel_rateInfoViewModel_.Clone();

            clone.Excel_yieldCurveViewModel_ = this.excel_yieldCurveViewModel_;

            return clone;
        }

        public override Control view()
        {
            Control v = new Excel_hullWhiteOneFactorView();

            v.DataContext = this;

            return v;
        }

        public override void parameterLoad(ParameterSettingManager parameterSettingManager)
        {
            //this.alpha_ = parameterSettingManager.hullWhiteSetting_.alpha();
            //this.volatility_ = parameterSettingManager.hullWhiteSetting_.volatility();
            //this.fittingYieldCurveName_ = parameterSettingManager.hullWhiteSetting_.fittingCurve();
        }

        public override string vba_description()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("modelType=hullwhiteOneFactor;");

            sb.Append("currentValue=" + this.CurrentValue_ + ";");
            sb.Append("alpha=" + this.Alpha_ + ";");
            sb.Append("volatility=" + this.Volatility_ + ";");
            //sb.Append("linkedCurveCode=" + this.LinkedCurveCode_ + ";");
            
            return sb.ToString();
        }

        public void setInterestRateInfo(Excel_interestRateViewModel e_irvm)
        {
            Excel_rateInfoViewModel e_rateInfoVM = new Excel_rateInfoViewModel();

            e_rateInfoVM.Tenor_ = e_irvm.Tenor_;
            e_rateInfoVM.LegTenor_ = e_irvm.LegTenor_;
            e_rateInfoVM.IndexType_ = e_irvm.RateType_;
            e_rateInfoVM.Currency_ = e_irvm.Currency_;

            this.Excel_rateInfoViewModel_ = e_rateInfoVM;
        }
    }
    
}

