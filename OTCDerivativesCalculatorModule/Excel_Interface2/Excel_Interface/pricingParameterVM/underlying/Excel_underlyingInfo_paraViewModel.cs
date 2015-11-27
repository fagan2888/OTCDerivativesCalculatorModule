using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_underlyingInfo_paraViewModel : IXmlData , INotifyPropertyChanged
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
        
        public Excel_underlyingInfo_paraViewModel() 
        { 
            
        }
        
        #region Excel_type_
        private string excel_type_;
        public string Excel_type_
        {
            get { return this.excel_type_; }
            set
            {
                if (this.excel_type_ != value)
                {
                    this.excel_type_ = value;
                    this.NotifyPropertyChanged("Excel_type_");
                }
            }
        }
        #endregion
        
        #region KrCode_
        private string krCode_;
        public string KrCode_
        {
            get { return this.krCode_; }
            set
            {
                if (this.krCode_ != value)
                {
                    this.krCode_ = value;
                    this.NotifyPropertyChanged("KrCode_");
                }
            }
        }
        #endregion
        
        #region UnderNameTrans_
        private NameTrans underNameTrans_;
        public NameTrans UnderNameTrans_
        {
            get { return this.underNameTrans_; }
            set
            {
                if (this.underNameTrans_ != value)
                {
                    this.underNameTrans_ = value;
                    this.NotifyPropertyChanged("UnderNameTrans_");
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

        #region Sub_type_
        private string sub_type_;
        public string Sub_type_
        {
            get { return this.sub_type_; }
            set
            {
                if (this.sub_type_ != value)
                {
                    this.sub_type_ = value;
                    this.NotifyPropertyChanged("Sub_type_");
                }
            }
        }
        #endregion

        #region Tenor_
        private string tenor_;
        public string Tenor_
        {
            get { return this.tenor_; }
            set
            {
                if (this.tenor_ != value)
                {
                    this.tenor_ = value;
                    this.NotifyPropertyChanged("Tenor_");
                }
            }
        }
        #endregion

        #region LinkedCurve_
        private string linkedCurve_;
        public string LinkedCurve_
        {
            get { return this.linkedCurve_; }
            set
            {
                if (this.linkedCurve_ != value)
                {
                    this.linkedCurve_ = value;
                    this.NotifyPropertyChanged("LinkedCurve_");
                }
            }
        }
        #endregion
        
        #region Excel_underlyingModel_paraViewModel_
        private Excel_underlyingModel_paraViewModel excel_underlyingModel_paraViewModel_;
        public Excel_underlyingModel_paraViewModel Excel_underlyingModel_paraViewModel_
        {
            get { return this.excel_underlyingModel_paraViewModel_; }
            set
            {
                if (this.excel_underlyingModel_paraViewModel_ != value)
                {
                    this.excel_underlyingModel_paraViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingModel_paraViewModel_");
                }
            }
        }
        #endregion


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

        #region Description_
        public string Description_
        {
            get 
            { 
                return this.excel_underlyingModel_paraViewModel_.Description_; 
            }
            set
            {
                if (this.excel_underlyingModel_paraViewModel_.Description_ != value)
                {
                    this.excel_underlyingModel_paraViewModel_.Description_ = value;
                    this.NotifyPropertyChanged("Description_");
                }
            }
        }
        #endregion

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_underlyingInfo_para");
                xmlWriter.WriteElementString("excel_type" , this.excel_type_);
                xmlWriter.WriteElementString("krCode" , this.krCode_);
                xmlWriter.WriteElementString("underName" , this.underNameTrans_.Value_);
                xmlWriter.WriteElementString("basePrice", this.BasePrice_);    
                xmlWriter.WriteElementString("sub_type", this.sub_type_);
                xmlWriter.WriteElementString("tenor", this.tenor_);
                xmlWriter.WriteElementString("linkedCurve", this.linkedCurve_);
                    
                if (excel_underlyingModel_paraViewModel_ == null)
                {
                    throw new Exception("model is empty : " + this.KrCode_);
                }
                else
                {
                    excel_underlyingModel_paraViewModel_.buildXml(xmlWriter);
                }
                    
                xmlWriter.WriteElementString("value" , this.CurrentValue_);
                //xmlWriter.WriteElementString("description" , this.Description_);
                    
            xmlWriter.WriteEndElement();
        }

        public void buildPricingXml(XmlWriter xmlWriter)
        {
            //this.makeVMFromExcel_interface();

            //this.underlying_paraViewModel_.buildXml(xmlWriter);
        }

        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingInfo_para serial_Excel_underlyingInfo_para = serial_Class as FpmlSerializedCSharp.Excel_underlyingInfo_para;

            this.excel_type_ = serial_Excel_underlyingInfo_para.Excel_type_.ValueStr;
            this.krCode_ = serial_Excel_underlyingInfo_para.KrCode_.ValueStr;
            this.underNameTrans_ = new NameTrans(serial_Excel_underlyingInfo_para.UnderName_.ValueStr);
            
            this.basePrice_= serial_Excel_underlyingInfo_para.BasePrice_.ValueStr;
            this.sub_type_ = serial_Excel_underlyingInfo_para.Sub_type_.ValueStr;
            this.tenor_ = serial_Excel_underlyingInfo_para.Tenor_.ValueStr;
            this.linkedCurve_ = serial_Excel_underlyingInfo_para.LinkedCurve_.ValueStr;

            FpmlSerializedCSharp.Excel_underlyingModel_para serial_excel_underlyingModel_para = serial_Excel_underlyingInfo_para.Excel_underlyingModel_para_;
            string excel_underlyingModel_paratype = serial_excel_underlyingModel_para.Excel_type_.ValueStr;
            this.excel_underlyingModel_paraViewModel_ = Excel_underlyingModel_paraViewModel.CreateExcel_underlyingModel_para(excel_underlyingModel_paratype);
            this.excel_underlyingModel_paraViewModel_.setFromSerial(serial_excel_underlyingModel_para);

            this.CurrentValue_ = serial_Excel_underlyingInfo_para.Value_.ValueStr;

            //this.value_ = serial_Excel_underlyingInfo_para.Value_.ValueStr;

            //this.description_ = serial_Excel_underlyingInfo_para.Description_.ValueStr;
            
     
        }

        public void loadMarketData(DateTime referenceDate)
        {


            //this.excel_underlyingModel_paraViewModel_.loadMarketData(referenceDate);
        }

        public void buildParaSetting(Excel_underlyingInfoViewModel e_uivm)
        {
            this.Excel_type_ = e_uivm.Excel_type_;
            this.KrCode_ = e_uivm.KrCode_;
            this.UnderNameTrans_ = e_uivm.NameTrans_;
            this.BasePrice_ = e_uivm.BasePrice_;
            this.Tenor_ = e_uivm.Tenor_;
            this.Sub_type_ = e_uivm.Sub_type_;
            this.LinkedCurve_ = e_uivm.LinkedCurveCode_;
        }

        public void buildParaSetting(Excel_underlyingInfoViewModel e_uivm, ParameterSettingManager paraSettingManager)
        {
            this.Excel_type_ = e_uivm.Excel_type_;
            this.KrCode_ = e_uivm.KrCode_;
            this.UnderNameTrans_ = e_uivm.NameTrans_;
            this.BasePrice_ = e_uivm.BasePrice_;
            this.Tenor_ = e_uivm.Tenor_;
            this.Sub_type_ = e_uivm.Sub_type_;
            this.LinkedCurve_ = e_uivm.LinkedCurveCode_;

            //this.CurrentValue_ = ? // model에서 setting 을 통해 set됨

            this.excel_underlyingModel_paraViewModel_ =
                paraSettingManager.UnderlyingParaSetting_.underModel(e_uivm);


        }

        public string vba_desciption()
        {
            StringBuilder sb = new StringBuilder();


            //if (!(this.Excel_type_ == null || this.Excel_type_ == "")) str += "type=" + this.Excel_type_ + ";";
            //if (!(this.KrCode_ == null || this.KrCode_ == "")) str += "code=" + this.KrCode_ + ";";
            //if (!(this.UnderNameTrans_.Value_ == null || this.UnderNameTrans_.Value_ == "")) str += "name=" + this.UnderNameTrans_.Value_ + ";";
            //if (!(this.BasePrice_ == null || this.BasePrice_ == "")) str += "basePrice=" + this.BasePrice_ + ";";
            //if (!(this.Sub_type_ == null || this.Sub_type_ == "")) str += "subType=" + this.Sub_type_ + ";";
            //if (!(this.Tenor_ == null || this.Tenor_ == "")) str += "tenor=" + this.Tenor_ + ";";
            //if (!(this.LinkedCurve_ == null || this.LinkedCurve_ == "")) str += "linkedCurve=" + this.LinkedCurve_ + ";";

            sb.Append("type=" + this.Excel_type_ + ";");
            sb.Append("code=" + this.KrCode_ + ";");
            sb.Append("name=" + this.UnderNameTrans_.Value_ + ";");
            sb.Append("basePrice=" + this.BasePrice_ + ";");
            sb.Append("subType=" + this.Sub_type_ + ";");
            sb.Append("tenor=" + this.Tenor_ + ";");
            sb.Append("linkedCurve=" + this.LinkedCurve_ + ";");

            sb.Append(this.excel_underlyingModel_paraViewModel_.vba_description());

            return sb.ToString();
        }
    }
    
}

