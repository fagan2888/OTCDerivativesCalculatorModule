using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_multiAsset_vanillaCallPutViewModel : Excel_multiAsset_compositeOption_subtypeViewModel
    {
        public enum CallPutEnum
        {
            Call,
            Put
        };

        public Excel_multiAsset_vanillaCallPutViewModel()
        {
            this.excel_Type_ = "excel_multi_vanillaCallPut";

        }

        #region CallPut_
        private CallPutEnum? callPut_;
        public CallPutEnum? CallPut_
        {
            get { return this.callPut_; }
            set
            {
                if (this.callPut_ != value)
                {
                    this.callPut_ = value;
                    this.NotifyPropertyChanged("CallPut_");
                }
            }
        }
        #endregion
        
        #region BaseCoupon_
        private string baseCoupon_;
        public string BaseCoupon_
        {
            get { return this.baseCoupon_; }
            set
            {
                if (this.baseCoupon_ != value)
                {
                    this.baseCoupon_ = value;
                    this.NotifyPropertyChanged("BaseCoupon_");
                }
            }
        }
        #endregion
        
        #region Strike_
        private string strike_;
        public string Strike_
        {
            get { return this.strike_; }
            set
            {
                if (this.strike_ != value)
                {
                    this.strike_ = value;
                    this.NotifyPropertyChanged("Strike_");
                }
            }
        }
        #endregion
        
        //#region StrikeValue_
        //private double strikeValue_;
        //public double StrikeValue_
        //{
        //    get { return this.strikeValue_; }
        //    set
        //    {
        //        if (this.strikeValue_ != value)
        //        {
        //            this.strikeValue_ = value;
        //            this.NotifyPropertyChanged("StrikeValue_");
        //        }
        //    }
        //}
        //#endregion
        
        #region PartiRate_
        private string partiRate_;
        public string PartiRate_
        {
            get { return this.partiRate_; }
            set
            {
                if (this.partiRate_ != value)
                {
                    this.partiRate_ = value;
                    this.NotifyPropertyChanged("PartiRate_");
                }
            }
        }
        #endregion
        
        // return calculation을 위한 것
        #region Excel_underlyingCalcIDViewModel_
        private Excel_underlyingCalcIDViewModel excel_underlyingCalcIDViewModel_;
        public Excel_underlyingCalcIDViewModel Excel_underlyingCalcIDViewModel_
        {
            get { return this.excel_underlyingCalcIDViewModel_; }
            set
            {
                if (this.excel_underlyingCalcIDViewModel_ != value)
                {
                    this.excel_underlyingCalcIDViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingCalcIDViewModel_");
                }
            }
        }
        #endregion

        public override void DefaultSetting(Excel_multiAssetCompositeOptionViewModel e_mcovm)
        {
            this.callPut_ = CallPutEnum.Call;
            this.partiRate_ = "100.0";
            this.strike_ = "100.0";
            this.baseCoupon_ = "0.0";
            //this.strikeValue_ = Convert.ToDouble(this.strike_) * this.baseUnderlyingValue_;
            this.excel_underlyingCalcIDViewModel_ = new Excel_maximumUnderlyingCalcIDViewModel();

        }

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_multiAsset_compositeOption_subtype");
                xmlWriter.WriteElementString("excel_type" , "excel_multiAsset_vanillaCallPut");
                xmlWriter.WriteStartElement("excel_multiAsset_vanillaCallPut");
                    
                    xmlWriter.WriteElementString("exerciseDate", this.exerciseDate_.ToString(StringFormat.XmlDateFormat_));
                    xmlWriter.WriteElementString("payoffDate", this.payoffDate_.ToString(StringFormat.XmlDateFormat_));
                    //xmlWriter.WriteElementString("baseUnderlyingValue", this.baseUnderlyingValue_.ToString());
                    xmlWriter.WriteElementString("callPut", this.callPut_.ToString());
                    xmlWriter.WriteElementString("baseCoupon" , (Convert.ToDouble(this.baseCoupon_) / 100.0).ToString() );
                    xmlWriter.WriteElementString("strike" , (Convert.ToDouble(this.strike_) / 100.0).ToString() );
                    //xmlWriter.WriteElementString("strikeValue", this.strikeValue_.ToString());
                    xmlWriter.WriteElementString("partiRate", (Convert.ToDouble(this.partiRate_) / 100.0).ToString());

                    this.excel_underlyingCalcIDViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_multiAsset_compositeOption_subtype serial_Excel_multiAsset_compositeOption_subtype = serial_Class as FpmlSerializedCSharp.Excel_multiAsset_compositeOption_subtype;
            FpmlSerializedCSharp.Excel_multiAsset_vanillaCallPut serial_Excel_multiAsset_vanillaCallPut = serial_Excel_multiAsset_compositeOption_subtype.Excel_multiAsset_vanillaCallPut_;

            this.exerciseDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiAsset_vanillaCallPut.ExerciseDate_.ValueStr);
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiAsset_vanillaCallPut.PayoffDate_.ValueStr);

            //this.baseUnderlyingValue_ = serial_Excel_multiAsset_vanillaCallPut.BaseUnderlyingValue_.DoubleValue();
            this.callPut_ = Enum.Parse(typeof(CallPutEnum), serial_Excel_multiAsset_vanillaCallPut.CallPut_.ValueStr) as CallPutEnum?;
            this.baseCoupon_ = ( serial_Excel_multiAsset_vanillaCallPut.BaseCoupon_.DoubleValue() * 100.0).ToString();
            this.strike_ = ( serial_Excel_multiAsset_vanillaCallPut.Strike_.DoubleValue() * 100.0).ToString();
            //this.strikeValue_ = serial_Excel_multiAsset_vanillaCallPut.StrikeValue_.DoubleValue();
            this.partiRate_ = ( serial_Excel_multiAsset_vanillaCallPut.PartiRate_.DoubleValue() * 100.0).ToString();
            //this.underlyingCalcType_ = serial_Excel_multiAsset_vanillaCallPut.UnderlyingCalcType_.ValueStr;

            FpmlSerializedCSharp.Excel_underlyingCalcID serial_returnUnderlyingCalcID = serial_Excel_multiAsset_vanillaCallPut.Excel_underlyingCalcID_;
            string returnUnderlyingCalcIDtype = serial_returnUnderlyingCalcID.Excel_type_.ValueStr;
            this.excel_underlyingCalcIDViewModel_ = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(returnUnderlyingCalcIDtype);
            this.excel_underlyingCalcIDViewModel_.setFromSerial(serial_returnUnderlyingCalcID);
        }

        public override Excel_multiAsset_compositeOption_subtypeViewModel Clone()
        {
            Excel_multiAsset_vanillaCallPutViewModel clone = new Excel_multiAsset_vanillaCallPutViewModel();

            clone.Excel_underlyingCalcInfoViewModel_ = this.excel_underlyingCalcInfoViewModel_;

            clone.BaseCoupon_ = this.baseCoupon_;

            clone.Excel_underlyingCalcIDViewModel_ = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(this.Excel_underlyingCalcIDViewModel_.Excel_type_);
            clone.Excel_underlyingCalcIDViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

            clone.PartiRate_ = this.partiRate_;
            clone.Description_ = this.description_;
            clone.CallPut_ = this.callPut_;
            clone.ExerciseDate_ = this.exerciseDate_;
            clone.PayoffDate_ = this.payoffDate_;
            clone.Strike_ = this.strike_;
            //clone.StrikeValue_ = this.strikeValue_;

            this.descriptionUpdate();

            clone.Description_ = this.description_;

            return clone;
        }

        public override void descriptionUpdate()
        {
            if (this.callPut_ == CallPutEnum.Call)
            {
                this.Type_ = "Multi Vanilla Call";
            }
            else if (this.callPut_ == CallPutEnum.Put)
            {
                this.Type_ = "Multi Vanilla Put";
            }
            else
            {
                this.Type_ = "unknown";
            }

            this.description_ = "multiVanilla " + this.strike_ + " " + this.callPut_;
        }

        public override Control view()
        {
            System.Windows.Controls.Control v = new Excel_multiAsset_vanillaCallPutView();

            v.DataContext = this;

            return v;
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel,
                                  EVENT_INFO_Table_DAO dao)
        {
            dao.EVENT_TYPE_ = "multiAssetcompositeOptionSubTypeTest";
            dao.EVENT_NAME_ = "multi_vanillaCallPut";
        }

        public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;

            this.excel_underlyingCalcIDViewModel_.setUnderlying(this.excel_underlyingCalcInfoViewModel_);

        }

        public override Excel_multiAssetCompositeOptionLoaderView loaderView(Excel_multiAssetCompositeOptionViewModel e_mcovm)
        {
            Excel_multiAssetCompositeOptionLoaderView subTypeLoaderView = new Excel_multiAssetCompositeOptionLoaderView();

            subTypeLoaderView.InterfaceViewModel_ = e_mcovm;

            subTypeLoaderView.initialize(this);

            this.excel_underlyingCalcInfoViewModel_ = e_mcovm.Excel_underlyingCalcInfoViewModel_;

            subTypeLoaderView.selectedOptionGrid_.Children.Add(this.view());

            return subTypeLoaderView;
        }

        public override void setInterfaceViewModel(Excel_multiAssetCompositeOptionViewModel e_mcovm)
        {
            this.exerciseDate_ = e_mcovm.Excel_issueInfoViewModel_.MaturityDate_;
            this.payoffDate_ = e_mcovm.PayoffDate_;

            this.excel_underlyingCalcIDViewModel_.EventDate_ = this.exerciseDate_;
            //this.DefaultSetting(e_mcovm);

            
        }


    }
    
}

