using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_vanillaCallPutViewModel : Excel_compositeOption_subtypeViewModel
    {
        public enum CallPutEnum
        { 
            Call,
            Put
        };

        public Excel_vanillaCallPutViewModel() 
        {
            this.excel_Type_ = "excel_vanillaCallPut";
            //this.view_ = new Excel_vanillaCallPutView();
            //this.view_.DataContext = this;
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

        #region StrikeValue_
        private double strikeValue_;
        public double StrikeValue_
        {
            get { return this.strikeValue_; }
            set
            {
                if (this.strikeValue_ != value)
                {
                    this.strikeValue_ = value;
                    this.NotifyPropertyChanged("StrikeValue_");
                }
            }
        }
        #endregion

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

        public override void DefaultSetting(Excel_compositeOptionViewModel e_covm)
        {
            this.callPut_ = CallPutEnum.Call;
            this.partiRate_ = "100.0";
            this.strike_ = "100.0";
            this.baseCoupon_ = "0.0";
            //this.strikeValue_ = Convert.ToDouble(this.strike_) * this.baseUnderlyingValue_;
            this.baseUnderlyingValue_ = Convert.ToDouble(e_covm.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_[0].BasePrice_); 
            //double basePrice =
            this.strikeValue_ = Convert.ToDouble(this.strike_) * this.baseUnderlyingValue_ / 100.0;
        }

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_compositeOption_subtype");
                xmlWriter.WriteElementString("excel_type" , "excel_vanillaCallPut");
                xmlWriter.WriteStartElement("excel_vanillaCallPut");
                
                xmlWriter.WriteElementString("exerciseDate", this.exerciseDate_.ToString(StringFormat.XmlDateFormat_));
                xmlWriter.WriteElementString("payoffDate", this.payoffDate_.ToString(StringFormat.XmlDateFormat_));
                xmlWriter.WriteElementString("underlyingCode", this.underlyingCode_);
                xmlWriter.WriteElementString("baseUnderlyingValue", this.baseUnderlyingValue_.ToString());
                
                xmlWriter.WriteElementString("callPut", this.callPut_.ToString());

                xmlWriter.WriteElementString("baseCoupon", (Convert.ToDouble(this.baseCoupon_)/100.0).ToString() );
                xmlWriter.WriteElementString("strike", (Convert.ToDouble(this.strike_) / 100.0).ToString() );
                xmlWriter.WriteElementString("strikeValue", this.strikeValue_.ToString());
                xmlWriter.WriteElementString("partiRate", (Convert.ToDouble(this.partiRate_) / 100.0).ToString());
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_compositeOption_subtype serial_Excel_compositeOption_subtype = serial_Class as FpmlSerializedCSharp.Excel_compositeOption_subtype;
            FpmlSerializedCSharp.Excel_vanillaCallPut serial_Excel_vanillaCallPut = serial_Excel_compositeOption_subtype.Excel_vanillaCallPut_;

            this.exerciseDate_ = StringConverter.xmlDateToDateTime(serial_Excel_vanillaCallPut.ExerciseDate_.ValueStr);
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_vanillaCallPut.PayoffDate_.ValueStr);
            this.baseUnderlyingValue_ = serial_Excel_vanillaCallPut.BaseUnderlyingValue_.DoubleValue();
            this.underlyingCode_ = serial_Excel_vanillaCallPut.UnderlyingCode_.ValueStr;
            //Enum.Parse(typeof(CallPutEnum), this.callPut_);
            this.callPut_ = Enum.Parse(typeof(CallPutEnum), serial_Excel_vanillaCallPut.CallPut_.ValueStr) as CallPutEnum?;
            this.baseCoupon_ = ( serial_Excel_vanillaCallPut.BaseCoupon_.DoubleValue() * 100.0).ToString() ;
            this.strike_ = ( serial_Excel_vanillaCallPut.Strike_.DoubleValue() * 100.0 ).ToString() ;
            this.strikeValue_ = serial_Excel_vanillaCallPut.StrikeValue_.DoubleValue();
            this.partiRate_ = ( serial_Excel_vanillaCallPut.PartiRate_.DoubleValue() * 100.0 ) .ToString() ;

            this.descriptionUpdate();
        }

        public override Excel_compositeOption_subtypeViewModel Clone()
        {
            Excel_vanillaCallPutViewModel clone = new Excel_vanillaCallPutViewModel();

            clone.BaseCoupon_ = this.baseCoupon_;
            clone.BaseUnderlyingValue_ = this.baseUnderlyingValue_;
            clone.UnderlyingCode_ = this.underlyingCode_;
            clone.PartiRate_ = this.partiRate_;
            clone.Description_ = this.description_;
            clone.CallPut_ = this.callPut_;
            clone.ExerciseDate_ = this.exerciseDate_;
            clone.PayoffDate_= this.payoffDate_;
            clone.Strike_ = this.strike_;
            clone.StrikeValue_ = this.strikeValue_;

            this.descriptionUpdate();

            clone.Description_ = this.description_;

            return clone;
        }

        public override void descriptionUpdate()
        {
            if (this.callPut_  == CallPutEnum.Call)
            {
                this.Type_ = "Vanilla Call";
            }
            else if (this.callPut_ == CallPutEnum.Put)
            {
                this.Type_ = "Vanilla Put";
            }
            else
            {
                this.Type_ = "unknown";
            }

            //this.name_ = 
            this.description_ = "Vanilla " + this.strike_ + " " + this.callPut_ ;
        }

        public override Control view()
        {
            System.Windows.Controls.Control v = new Excel_vanillaCallPutView();

            v.DataContext = this;

            return v;
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel,
                                          EVENT_INFO_Table_DAO dao)
        {
            dao.EVENT_TYPE_ = "compositeOptionSubTypeTest";
            dao.EVENT_NAME_ = "vanillaCallPut";
        }

        public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;

            try
            {
                this.baseUnderlyingValue_ = Convert.ToDouble(excel_under.Excel_underlyingInfoViewModel_[0].BasePrice_);
            }
            catch (Exception e)
            {
                OutputLogViewModel.addResult(e.Message);
            }

        }

        public override Excel_compositeOptionLoaderView loaderView(Excel_compositeOptionViewModel e_covm)
        {
            Excel_compositeOptionLoaderView subTypeLoaderView = new Excel_compositeOptionLoaderView();

            subTypeLoaderView.InterfaceViewModel_ = e_covm;

            subTypeLoaderView.initialize(this);

            try 
            { 
                this.BaseUnderlyingValue_ = Convert.ToDouble(this.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_[0].BasePrice_); 
            }
            catch (Exception) { }

            //subTypeLoaderView. = this.Excel_underlyingCalcInfoViewModel_;

            subTypeLoaderView.selectedOptionGrid_.Children.Add(this.view());

            return subTypeLoaderView;
        }

        public override void setInterfaceViewModel(Excel_compositeOptionViewModel e_covm)
        {
            this.exerciseDate_ = e_covm.Excel_issueInfoViewModel_.MaturityDate_;
            this.payoffDate_ = e_covm.PayoffDate_;
            this.underlyingCode_ = e_covm.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_[0].KrCode_;
            //this.DefaultSetting(e_covm);

        }


    }
    
}

