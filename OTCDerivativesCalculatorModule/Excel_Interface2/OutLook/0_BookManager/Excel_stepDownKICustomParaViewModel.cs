using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Controls;

namespace Excel_Interface
{
    public class Excel_stepDownKICustomParaViewModel : Excel_parameterViewModel
    {
        #region Excel_underlyingCalcInfo_paraViewModel_
        private Excel_underlyingCalcInfo_paraViewModel excel_underlyingCalcInfo_paraViewModel_;
        public Excel_underlyingCalcInfo_paraViewModel Excel_underlyingCalcInfo_paraViewModel_
        {
            get { return this.excel_underlyingCalcInfo_paraViewModel_; }
            set
            {
                if (this.excel_underlyingCalcInfo_paraViewModel_ != value)
                {
                    this.excel_underlyingCalcInfo_paraViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingCalcInfo_paraViewModel_");
                }
            }
        }
        #endregion

        #region Excel_discountCurve_paraViewModel_
        private Excel_discountCurve_paraViewModel excel_discountCurve_paraViewModel_;
        public Excel_discountCurve_paraViewModel Excel_discountCurve_paraViewModel_
        {
            get { return this.excel_discountCurve_paraViewModel_; }
            set
            {
                if (this.excel_discountCurve_paraViewModel_ != value)
                {
                    this.excel_discountCurve_paraViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_discountCurve_paraViewModel_");
                }
            }
        }
        #endregion

        public Excel_stepDownKICustomParaViewModel()
        {
            this.excel_underlyingCalcInfo_paraViewModel_ = new Excel_underlyingCalcInfo_paraViewModel();
            this.excel_discountCurve_paraViewModel_ = new Excel_discountCurve_paraViewModel();

            this.Excel_resultViewModel_ = new Excel_resultViewModel();

            //this.view_ = new Excel_stepDownKICustomParaView();
            //this.view_.DataContext = this;
        }

        public override void instrumentEventObserver(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Excel_underlyingCalcInfoViewModel e_ucivm = sender as Excel_underlyingCalcInfoViewModel;

            UnderlyingModelSetting ums = new UnderlyingModelSetting();

            foreach (Excel_underlyingInfoViewModel item in e_ucivm.Excel_underlyingInfoViewModel_)
	        {
                this.excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_
                    .Add(ums.getUnderlyingParameterModel(item));
	        }
            
            // 다른건..? ex) corr
        }

        public override void masterEventObserver(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public override void buildPricingXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            // 아직 아무일 안함
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            throw new NotImplementedException();
        }



        public override Control view()
        {
            Control v = new Excel_stepDownKICustomParaView();

            v.DataContext = this;

            return v;
        }

        public override void dicountCurveEventObserver(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void loadMarketData(DateTime referenceDate)
        {
            throw new NotImplementedException();
        }

        public override void buildParaSetting(ParameterSettingManager paraSettingManager)
        {
            throw new NotImplementedException();
        }
    }
}
