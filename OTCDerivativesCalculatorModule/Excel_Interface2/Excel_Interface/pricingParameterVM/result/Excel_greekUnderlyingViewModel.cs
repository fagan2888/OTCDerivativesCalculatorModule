using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_greekUnderlyingViewModel : IXmlData
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
        
        public Excel_greekUnderlyingViewModel() { }

        #region UnderlyingName_
        private string underlyingName_;
        public string UnderlyingName_
        {
            get { return this.underlyingName_; }
            set
            {
                if (this.underlyingName_ != value)
                {
                    this.underlyingName_ = value;
                    this.NotifyPropertyChanged("UnderlyingName_");
                }
            }
        }
        #endregion

        #region UnderlyingValue_
        private string underlyingValue_;
        public string UnderlyingValue_
        {
            get { return this.underlyingValue_; }
            set
            {
                if (this.underlyingValue_ != value)
                {
                    this.underlyingValue_ = value;
                    this.NotifyPropertyChanged("UnderlyingValue_");
                }
            }
        }
        #endregion

        #region BasePrice_
        private string basePrice_;
        public string BasePrice_
        {
            get { return this.basePrice_; }
            set
            {
                if (this.basePrice_ != value)
                {
                    this.basePrice_ = value;
                    this.NotifyPropertyChanged("BasePrice_");
                }
            }
        }
        #endregion

        #region Pertubation_h_
        private string pertubation_h_;
        public string Pertubation_h_
        {
            get { return this.pertubation_h_; }
            set
            {
                if (this.pertubation_h_ != value)
                {
                    this.pertubation_h_ = value;
                    this.NotifyPropertyChanged("Pertubation_h_");
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

        #region Delta_
        private string delta_;
        public string Delta_
        {
            get { return this.delta_; }
            set
            {
                if (this.delta_ != value)
                {
                    this.delta_ = value;
                    this.NotifyPropertyChanged("Delta_");
                }
            }
        }
        #endregion

        #region Gamma_
        private string gamma_;
        public string Gamma_
        {
            get { return this.gamma_; }
            set
            {
                if (this.gamma_ != value)
                {
                    this.gamma_ = value;
                    this.NotifyPropertyChanged("Gamma_");
                }
            }
        }
        #endregion

        #region Vega_
        private string vega_;
        public string Vega_
        {
            get { return this.vega_; }
            set
            {
                if (this.vega_ != value)
                {
                    this.vega_ = value;
                    this.NotifyPropertyChanged("Vega_");
                }
            }
        }
        #endregion
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_greekUnderlying");
                xmlWriter.WriteElementString("underlyingName", this.underlyingName_);
                xmlWriter.WriteElementString("underlyingValue", this.underlyingValue_);
                xmlWriter.WriteElementString("basePrice", this.basePrice_);
                xmlWriter.WriteElementString("volatility", this.volatility_);
                xmlWriter.WriteElementString("pertubation_h", this.pertubation_h_);
                xmlWriter.WriteElementString("delta", this.delta_);
                xmlWriter.WriteElementString("gamma", this.gamma_);
                xmlWriter.WriteElementString("vega", this.vega_);
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_greekUnderlying serial_Excel_greekUnderlying = serial_Class as FpmlSerializedCSharp.Excel_greekUnderlying;

            this.underlyingName_ = serial_Excel_greekUnderlying.UnderlyingName_.ValueStr;
            this.underlyingValue_ = serial_Excel_greekUnderlying.UnderlyingValue_.ValueStr;
            this.basePrice_ = serial_Excel_greekUnderlying.BasePrice_.ValueStr;
            this.volatility_ = serial_Excel_greekUnderlying.Volatility_.ValueStr;
            this.pertubation_h_ = serial_Excel_greekUnderlying.Pertubation_h_.ValueStr;
            this.delta_ = serial_Excel_greekUnderlying.Delta_.ValueStr;
            this.gamma_ = serial_Excel_greekUnderlying.Gamma_.ValueStr;
            this.vega_ = serial_Excel_greekUnderlying.Vega_.ValueStr;
            
        }

        public string vba_description()
        {
            string str = "";

            str += "underlyingName=" + this.underlyingName_ + ";";
            str += "underlyingValue=" + this.underlyingValue_+ ";";
            str += "basePrice=" + this.basePrice_+ ";";
            str += "volatility=" + this.volatility_+ ";";
            str += "pertubation_h=" + this.pertubation_h_ + ";";
            str += "delta=" + this.delta_ + ";";
            str += "gamma=" + this.gamma_ + ";";
            str += "vega=" + this.vega_ + ";";

            return str;
        }


        public string vba_description_greekPositionCalc(string notionalStr)
        {
            //   face_amt * delta * adj_stock_price as delta_Amt,"
            //   face_amt * 0.5 * gamma * ( adj_stock_price * 0.01 ) * (adj_stock_price * 0.01 ) as gamma_Amt,"
            //   face_amt * ( vega / 100 ) as vega_Amt,"

            double notional = Convert.ToDouble(notionalStr);

            double underValue = Convert.ToDouble(this.underlyingValue_);
            double deltaPosition = notional * underValue * Convert.ToDouble(this.delta_) ;

            double pert_h = Convert.ToDouble(this.pertubation_h_);
            double gammaPosition = notional * 0.5 * Convert.ToDouble(this.gamma_) * pert_h * pert_h;
                                            //* (underValue * 0.01) * (underValue * 0.01);

            double vegaPosition = notional * Convert.ToDouble(this.vega_) ;

            string str = "";

            str += "deltaPos=" + deltaPosition + ";";
            str += "gammaPos=" + gammaPosition + ";";
            str += "vegaPos=" + vegaPosition + ";";

            return str;
        }

        //public string vba_description_greekNCR_RiskCalc(string notionalStr)
        //{
        //    //   face_amt * delta * adj_stock_price as delta_Amt,"
        //    //   face_amt * 0.5 * gamma * ( adj_stock_price * 0.01 ) * (adj_stock_price * 0.01 ) as gamma_Amt,"
        //    //   face_amt * ( vega / 100 ) as vega_Amt,"

        //    double notional = Convert.ToDouble(notionalStr);

        //    double underValue = Convert.ToDouble(this.underlyingValue_);
        //    double deltaPosition = notional * underValue * Convert.ToDouble(this.delta_);

        //    double gammaPosition = notional * 0.5 * Convert.ToDouble(this.delta_)
        //                                    * (underValue * 0.01) * (underValue * 0.01);

        //    double vegaPosition = notional * Convert.ToDouble(this.vega_);

        //    string str = "";

        //    str += "deltaNCR_Risk=" + deltaPosition + ";";
        //    str += "gammaNCR_Pos=" + gammaPosition + ";";
        //    str += "vegaPos=" + vegaPosition + ";";

        //    return str;
        //}
    }
    
}

