using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_upInOutCallViewModel : Excel_compositeOption_subtypeViewModel
    {
        public enum InOutEnum
        {
            In,
            Out
        };

        public Excel_upInOutCallViewModel() 
        {
            this.excel_Type_ = "excel_upInOutCall";
            this.inOut_ = InOutEnum.Out;
            this.partiRate_ = "100";
            
        }

        #region InOut_
        private InOutEnum? inOut_;
        public InOutEnum? InOut_
        {
            get { return this.inOut_; }
            set
            {
                if (this.inOut_ != value)
                {
                    this.inOut_ = value;
                    this.NotifyPropertyChanged("InOut_");
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

        #region Barrier_
        private string barrier_;
        public string Barrier_
        {
            get { return this.barrier_; }
            set
            {
                if (this.barrier_ != value)
                {
                    this.barrier_ = value;
                    this.NotifyPropertyChanged("Barrier_");
                }
            }
        }
        #endregion

        #region BarrierValue_
        private double barrierValue_;
        public double BarrierValue_
        {
            get { return this.barrierValue_; }
            set
            {
                if (this.barrierValue_ != value)
                {
                    this.barrierValue_ = value;
                    this.NotifyPropertyChanged("BarrierValue_");
                }
            }
        }
        #endregion

        #region RebateCoupon_
        private string rebateCoupon_;
        public string RebateCoupon_
        {
            get { return this.rebateCoupon_; }
            set
            {
                if (this.rebateCoupon_ != value)
                {
                    this.rebateCoupon_ = value;
                    this.NotifyPropertyChanged("RebateCoupon_");
                }
            }
        }
        #endregion

        #region RebateCouponValue_
        private string rebateCouponValue_;
        public string RebateCouponValue_
        {
            get { return this.rebateCouponValue_; }
            set
            {
                if (this.rebateCouponValue_ != value)
                {
                    this.rebateCouponValue_ = value;
                    this.NotifyPropertyChanged("RebateCouponValue_");
                }
            }
        }
        #endregion

        #region ObservationStartDate_
        private DateTime observationStartDate_;
        public DateTime ObservationStartDate_
        {
            get { return this.observationStartDate_; }
            set
            {
                if (this.observationStartDate_ != value)
                {
                    this.observationStartDate_ = value;
                    this.NotifyPropertyChanged("ObservationStartDate_");
                }
            }
        }
        #endregion

        #region ObservationEndDate_
        private DateTime observationEndDate_;
        public DateTime ObservationEndDate_
        {
            get { return this.observationEndDate_; }
            set
            {
                if (this.observationEndDate_ != value)
                {
                    this.observationEndDate_ = value;
                    this.NotifyPropertyChanged("ObservationEndDate_");
                }
            }
        }
        #endregion

        public override void DefaultSetting(Excel_compositeOptionViewModel e_covm)
        {
            this.inOut_ = InOutEnum.Out;
            this.baseCoupon_ = "0.0";
            this.strike_ = "100.0";

            this.baseUnderlyingValue_ = Convert.ToDouble(e_covm.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_[0].BasePrice_);

            this.strikeValue_ = Convert.ToDouble(this.strike_) * this.baseUnderlyingValue_ / 100.0;
            this.partiRate_ = "100.0";
            this.barrier_ = "120.0";

            this.barrierValue_ = Convert.ToDouble(this.barrier_) * this.baseUnderlyingValue_ / 100.0;
            this.rebateCoupon_ = "0.0";
            this.rebateCouponValue_ = "0.0";

            this.observationStartDate_ = e_covm.Excel_issueInfoViewModel_.EffectiveDate_;
            this.observationEndDate_ = e_covm.Excel_issueInfoViewModel_.MaturityDate_;

        }

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_compositeOption_subtype");
                xmlWriter.WriteElementString("excel_Type", "excel_upInOutCall");
                xmlWriter.WriteStartElement("excel_upInOutCall");

                    xmlWriter.WriteElementString("exerciseDate", this.exerciseDate_.ToString(StringFormat.XmlDateFormat_));
                    xmlWriter.WriteElementString("payoffDate", this.payoffDate_.ToString(StringFormat.XmlDateFormat_));
                    xmlWriter.WriteElementString("baseUnderlyingValue", this.baseUnderlyingValue_.ToString());
                    xmlWriter.WriteElementString("underlyingCode", this.underlyingCode_);
                    xmlWriter.WriteElementString("inOut", this.inOut_.ToString() );
                    xmlWriter.WriteElementString("baseCoupon", (Convert.ToDouble(this.baseCoupon_)/100.0).ToString() );
                    xmlWriter.WriteElementString("strike", (Convert.ToDouble(this.strike_)/100.0).ToString() );
                    xmlWriter.WriteElementString("strikeValue", this.strikeValue_.ToString());
                    xmlWriter.WriteElementString("partiRate", (Convert.ToDouble(this.partiRate_)/100.0).ToString() );
                    xmlWriter.WriteElementString("barrier", (Convert.ToDouble(this.barrier_)/100.0).ToString() );
                    xmlWriter.WriteElementString("barrierValue", this.barrierValue_.ToString());
                    xmlWriter.WriteElementString("rebateCoupon", (Convert.ToDouble(this.rebateCoupon_) / 100.0).ToString() );
                    xmlWriter.WriteElementString("rebateCouponValue", this.rebateCouponValue_);

                    xmlWriter.WriteElementString("observationStartDate", this.observationStartDate_.ToString(StringFormat.XmlDateFormat_));
                    xmlWriter.WriteElementString("observationEndDate", this.observationEndDate_.ToString(StringFormat.XmlDateFormat_));

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
            FpmlSerializedCSharp.Excel_upInOutCall serial_Excel_upInOutCall = serial_Excel_compositeOption_subtype.Excel_upInOutCall_;

            this.exerciseDate_ = StringConverter.xmlDateToDateTime(serial_Excel_upInOutCall.ExerciseDate_.ValueStr);
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_upInOutCall.PayoffDate_.ValueStr);
            this.inOut_ = Enum.Parse(typeof(InOutEnum), serial_Excel_upInOutCall.InOut_.ValueStr) as InOutEnum?;
            this.baseUnderlyingValue_ = serial_Excel_upInOutCall.BaseUnderlyingValue_.DoubleValue();
            this.underlyingCode_ = serial_Excel_upInOutCall.UnderlyingCode_.ValueStr;
            this.baseCoupon_ = ( serial_Excel_upInOutCall.BaseCoupon_.DoubleValue() * 100.0).ToString();
            this.strike_ = ( serial_Excel_upInOutCall.Strike_.DoubleValue() * 100.0).ToString();
            this.strikeValue_ = serial_Excel_upInOutCall.StrikeValue_.DoubleValue();
            this.partiRate_ = ( serial_Excel_upInOutCall.PartiRate_.DoubleValue() * 100.0).ToString();
            this.barrier_ = ( serial_Excel_upInOutCall.Barrier_.DoubleValue() * 100.0).ToString();
            this.barrierValue_ = serial_Excel_upInOutCall.BarrierValue_.DoubleValue();
            this.rebateCoupon_ = (serial_Excel_upInOutCall.RebateCoupon_.DoubleValue() * 100.0).ToString();
            this.rebateCouponValue_ = serial_Excel_upInOutCall.RebateCouponValue_.ValueStr;
            this.observationStartDate_ = StringConverter.xmlDateToDateTime(serial_Excel_upInOutCall.ObservationStartDate_.ValueStr);
            this.observationEndDate_ = StringConverter.xmlDateToDateTime(serial_Excel_upInOutCall.ObservationEndDate_.ValueStr);

            this.descriptionUpdate();
        }

        public override Excel_compositeOption_subtypeViewModel Clone()
        {
            Excel_upInOutCallViewModel clone = new Excel_upInOutCallViewModel();

            clone.ExerciseDate_ = this.exerciseDate_;
            clone.PayoffDate_ = this.payoffDate_;
            clone.InOut_ = this.inOut_;
            clone.BaseUnderlyingValue_ = this.baseUnderlyingValue_;
            clone.UnderlyingCode_ = this.underlyingCode_;
            clone.partiRate_ = this.partiRate_;
            clone.BaseCoupon_ = this.baseCoupon_;
            clone.Strike_ = this.strike_;
            clone.StrikeValue_ = this.strikeValue_;
            clone.Barrier_ = this.barrier_;
            clone.BarrierValue_ = this.BarrierValue_;
            clone.RebateCoupon_ = this.rebateCoupon_;
            clone.RebateCouponValue_ = this.rebateCouponValue_;
            clone.ObservationStartDate_ = this.observationStartDate_;
            clone.ObservationEndDate_ = this.observationEndDate_;

            this.descriptionUpdate();

            clone.Description_ = this.description_;

            return clone;
        }

        public override void descriptionUpdate()
        {
            if (this.inOut_ == InOutEnum.Out)
            {
                this.Type_ = "Up Out Call";
            }
            else if (this.inOut_ == InOutEnum.In)
            {
                this.Type_ = "Up In Call";
            }
            else 
            {
                this.Type_ = "unknown";
            }

            this.description_ = "Barrier " + this.barrier_ + " Call" + this.strike_ + " " + this.InOut_;
        }

        public override Control view()
        {
            System.Windows.Controls.Control v = new Excel_upInOutCallView();

            v.DataContext = this;

            return v;
            
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel,
                                          EVENT_INFO_Table_DAO dao)
        {
            dao.EVENT_TYPE_ = "compositeOptionSubTypeTest";
            dao.EVENT_NAME_ = "upInOutCall";
        }

        public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;
            //this.
        }

        public override Excel_compositeOptionLoaderView loaderView(Excel_compositeOptionViewModel e_covm)
        {
            Excel_compositeOptionLoaderView subTypeLoaderView = new Excel_compositeOptionLoaderView();

            subTypeLoaderView.initialize(this);
            
            subTypeLoaderView.InterfaceViewModel_ = e_covm;

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

            this.observationStartDate_ = e_covm.Excel_issueInfoViewModel_.EffectiveDate_;
            this.observationEndDate_ = e_covm.Excel_issueInfoViewModel_.MaturityDate_;

            this.underlyingCode_ = e_covm.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_[0].KrCode_;
            //this.DefaultSetting(e_covm);
        }
    }
    
}

